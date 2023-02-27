﻿using DevExpress.XtraPivotGrid;
using System.Windows.Forms;

namespace WinPivot_CustomFunctions {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();     
            // This line of code is generated by Data Source Configuration Wizard
            salesPersonTableAdapter1.Fill(nwindDataSet1.SalesPerson);
            pivotGridControl1.BestFit();
            pivotGridControl1.OptionsView.ShowColumnTotals = false;
            pivotGridControl1.OptionsView.ShowRowTotals = false;
            pivotGridControl1.OptionsView.ShowRowGrandTotals = false;
            pivotGridControl1.OptionsData.DataProcessingEngine = PivotDataProcessingEngine.Optimized;
            PivotGridField pivotGridField1 = new PivotGridField() {
                Area = PivotArea.DataArea,
                AreaIndex = 0,
                Caption = "First Product Sold",
                FieldName = "FirstProductSold"
            };
            pivotGridControl1.Fields.Add(pivotGridField1);
            pivotGridField1.DataBinding = new ExpressionDataBinding() { 
                Expression = "FirstValue([ProductName])" };
            pivotGridField1.Options.ShowUnboundExpressionMenu = true;
            pivotGridField1.Options.ShowGrandTotal = false; 
        }      
    }
}
