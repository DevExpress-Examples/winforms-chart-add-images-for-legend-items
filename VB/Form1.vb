Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms
Imports DevExpress.Drawing
Imports DevExpress.XtraCharts

Namespace ImageLegendItems

    Public Partial Class Form1
        Inherits Form

        Private photos As Dictionary(Of String, DXImage) = New Dictionary(Of String, DXImage)()

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
                        Using sourceImage As DXImage = DXImage.FromStream(stream)
                            Dim image As DXBitmap = New DXBitmap(74, 79)
                            Using graphics As DXGraphics = DXGraphics.FromImage(image)
                                graphics.DrawImage(sourceImage, New Rectangle(New Point(5, 5), New Size(75, 75)))
                            End Using

                            photos.Add(lastName, image)
                        End Using
                    End Using
                End If
            Next
        End Sub

        Private Sub chartControl1_CustomDrawSeries(ByVal sender As Object, ByVal e As CustomDrawSeriesEventArgs)
            e.DXLegendMarkerImage = photos(e.Series.Name)
        End Sub
    End Class
End Namespace
