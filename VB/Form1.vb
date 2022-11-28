Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms
Imports DevExpress.XtraCharts

Namespace ImageLegendItems

    Public Partial Class Form1
        Inherits Form

        Private photos As Dictionary(Of String, Image) = New Dictionary(Of String, Image)()

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            employeesTableAdapter.Fill(nwindDataSet.Employees)
            InitializePhotos()
        End Sub

        Private Sub InitializePhotos()
            For Each row As DataRow In nwindDataSet.Employees.Rows
                Dim lastName As String = row.ItemArray(1).ToString()
                If Not photos.ContainsKey(lastName) Then
                    Using stream As MemoryStream = New MemoryStream(CType(row.ItemArray(14), Byte()))
                        Using sourceImage As Image = Image.FromStream(stream)
                            Dim image As Bitmap = New Bitmap(74, 79)
                            Using graphics As Graphics = Graphics.FromImage(image)
                                graphics.DrawImage(sourceImage, New Rectangle(New Point(5, 5), New Size(75, 75)))
                            End Using

                            photos.Add(lastName, image)
                        End Using
                    End Using
                End If
            Next
        End Sub

        Private Sub chartControl1_CustomDrawSeries(ByVal sender As Object, ByVal e As CustomDrawSeriesEventArgs)
            e.LegendMarkerImage = photos(e.Series.Name)
        End Sub
    End Class
End Namespace
