Namespace ImageLegendItems

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

'#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim xyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
            Dim sideBySideBarSeriesLabel1 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
            Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
            Me.nwindDataSet = New ImageLegendItems.nwindDataSet()
            Me.employeesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.employeesTableAdapter = New ImageLegendItems.nwindDataSetTableAdapters.EmployeesTableAdapter()
            CType((Me.chartControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((sideBySideBarSeriesLabel1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.nwindDataSet), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.employeesBindingSource), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' chartControl1
            ' 
            Me.chartControl1.DataAdapter = Me.employeesTableAdapter
            Me.chartControl1.DataSource = Me.employeesBindingSource
            xyDiagram1.AxisX.Range.ScrollingRange.SideMarginsEnabled = True
            xyDiagram1.AxisX.Range.SideMarginsEnabled = True
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.Range.ScrollingRange.SideMarginsEnabled = True
            xyDiagram1.AxisY.Range.SideMarginsEnabled = True
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            Me.chartControl1.Diagram = xyDiagram1
            Me.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartControl1.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center
            Me.chartControl1.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.TopOutside
            Me.chartControl1.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight
            Me.chartControl1.Location = New System.Drawing.Point(0, 0)
            Me.chartControl1.Name = "chartControl1"
            Me.chartControl1.SeriesDataMember = "LastName"
            Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
            Me.chartControl1.SeriesTemplate.ArgumentDataMember = "LastName"
            Me.chartControl1.SeriesTemplate.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
            sideBySideBarSeriesLabel1.LineVisible = True
            Me.chartControl1.SeriesTemplate.Label = sideBySideBarSeriesLabel1
            Me.chartControl1.SeriesTemplate.ValueDataMembersSerializable = "EmployeeID"
            Me.chartControl1.Size = New System.Drawing.Size(946, 474)
            Me.chartControl1.TabIndex = 0
            AddHandler Me.chartControl1.CustomDrawSeries, New DevExpress.XtraCharts.CustomDrawSeriesEventHandler(AddressOf Me.chartControl1_CustomDrawSeries)
            ' 
            ' nwindDataSet
            ' 
            Me.nwindDataSet.DataSetName = "nwindDataSet"
            Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' employeesBindingSource
            ' 
            Me.employeesBindingSource.DataMember = "Employees"
            Me.employeesBindingSource.DataSource = Me.nwindDataSet
            ' 
            ' employeesTableAdapter
            ' 
            Me.employeesTableAdapter.ClearBeforeFill = True
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(946, 474)
            Me.Controls.Add(Me.chartControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.Form1_Load)
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((sideBySideBarSeriesLabel1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chartControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.nwindDataSet), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.employeesBindingSource), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

'#End Region
        Private chartControl1 As DevExpress.XtraCharts.ChartControl

        Private employeesTableAdapter As ImageLegendItems.nwindDataSetTableAdapters.EmployeesTableAdapter

        Private nwindDataSet As ImageLegendItems.nwindDataSet

        Private employeesBindingSource As System.Windows.Forms.BindingSource
    End Class
End Namespace
