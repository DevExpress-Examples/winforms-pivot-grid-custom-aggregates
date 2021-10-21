Namespace WinPivot_CustomFunctions
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
			Me.nwindDataSet1 = New WinPivot_CustomFunctions.nwindDataSet()
			Me.fieldCategoryName1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldCountry1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldExtendedPrice1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldProductName1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldSalesPerson1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.salesPersonTableAdapter1 = New WinPivot_CustomFunctions.nwindDataSetTableAdapters.SalesPersonTableAdapter()
			CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' pivotGridControl1
			' 
			Me.pivotGridControl1.DataMember = "SalesPerson"
			Me.pivotGridControl1.DataSource = Me.nwindDataSet1
			Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() { Me.fieldCategoryName1, Me.fieldCountry1, Me.fieldExtendedPrice1, Me.fieldProductName1, Me.fieldSalesPerson1})
			Me.pivotGridControl1.Location = New System.Drawing.Point(0, 0)
			Me.pivotGridControl1.Name = "pivotGridControl1"
			Me.pivotGridControl1.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.LegacyOptimized
			Me.pivotGridControl1.Size = New System.Drawing.Size(784, 561)
			Me.pivotGridControl1.TabIndex = 0
			' 
			' nwindDataSet1
			' 
			Me.nwindDataSet1.DataSetName = "nwindDataSet"
			Me.nwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' fieldCategoryName1
			' 
			Me.fieldCategoryName1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
			Me.fieldCategoryName1.AreaIndex = 0
			Me.fieldCategoryName1.FieldName = "CategoryName"
			Me.fieldCategoryName1.Name = "fieldCategoryName1"
			' 
			' fieldCountry1
			' 
			Me.fieldCountry1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldCountry1.AreaIndex = 0
			Me.fieldCountry1.FieldName = "Country"
			Me.fieldCountry1.Name = "fieldCountry1"
			' 
			' fieldExtendedPrice1
			' 
			Me.fieldExtendedPrice1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldExtendedPrice1.AreaIndex = 0
			Me.fieldExtendedPrice1.FieldName = "Extended Price"
			Me.fieldExtendedPrice1.Name = "fieldExtendedPrice1"
			' 
			' fieldProductName1
			' 
			Me.fieldProductName1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldProductName1.AreaIndex = 1
			Me.fieldProductName1.FieldName = "ProductName"
			Me.fieldProductName1.Name = "fieldProductName1"
			Me.fieldProductName1.Visible = False
			' 
			' fieldSalesPerson1
			' 
			Me.fieldSalesPerson1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldSalesPerson1.AreaIndex = 1
			Me.fieldSalesPerson1.FieldName = "Sales Person"
			Me.fieldSalesPerson1.Name = "fieldSalesPerson1"
			' 
			' salesPersonTableAdapter1
			' 
			Me.salesPersonTableAdapter1.ClearBeforeFill = True
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(784, 561)
			Me.Controls.Add(Me.pivotGridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
		Private nwindDataSet1 As nwindDataSet
		Private salesPersonTableAdapter1 As nwindDataSetTableAdapters.SalesPersonTableAdapter
		Private fieldCategoryName1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldCountry1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldExtendedPrice1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldProductName1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldSalesPerson1 As DevExpress.XtraPivotGrid.PivotGridField
	End Class
End Namespace

