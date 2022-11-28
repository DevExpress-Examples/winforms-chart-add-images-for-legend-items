using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DevExpress.Drawing;
using DevExpress.XtraCharts;

namespace ImageLegendItems {

    public partial class Form1 : Form {
        Dictionary<string, DXImage> photos = new Dictionary<string, DXImage>();

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            this.employeesTableAdapter.Fill(this.nwindDataSet.Employees);

            InitializePhotos();
        }

        void InitializePhotos() {
            foreach (DataRow row in nwindDataSet.Employees.Rows) {
                string lastName = row.ItemArray[1].ToString();
                if (!photos.ContainsKey(lastName)) {
                    using (MemoryStream stream = new MemoryStream((byte[])row.ItemArray[14])) {
                        using (DXImage sourceImage = DXImage.FromStream(stream)) {
                            DXBitmap image = new DXBitmap(74, 79);
                            using (DXGraphics graphics = DXGraphics.FromImage(image))
                                graphics.DrawImage(sourceImage, 
                                    new Rectangle(new Point(5, 5), new Size(75, 75)));
                            photos.Add(lastName, image);
                        }
                    }
                }
            }
        }

        private void chartControl1_CustomDrawSeries(object sender, CustomDrawSeriesEventArgs e) {
            e.DXLegendMarkerImage = photos[e.Series.Name];
        }
    }
}
