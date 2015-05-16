namespace Reporting.RaporteStoc
{
    partial class xfrmEvolutieStocPerProdusGestiune
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue1 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule2 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue2 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView1 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView2 = new DevExpress.XtraCharts.LineSeriesView();
            this.colD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.stocRetroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mRPDataSet_Stoc_StocRetro = new Reporting.MRPDataSet_Stoc_StocRetro();
            this.fieldCodProdus = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldIdGestiune = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldData = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldC = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldD = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldSF = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldSI = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldDenumireGestiune = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldDescriere = new DevExpress.XtraPivotGrid.PivotGridField();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCodProdus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdGestiune = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colData = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDenumireGestiune = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescriere = new DevExpress.XtraGrid.Columns.GridColumn();
            this.stocRetroTableAdapter = new Reporting.MRPDataSet_Stoc_StocRetroTableAdapters.StocRetroTableAdapter();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem1 = new DevExpress.XtraLayout.SplitterItem();
            this.splitterItem2 = new DevExpress.XtraLayout.SplitterItem();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocRetroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mRPDataSet_Stoc_StocRetro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // colD
            // 
            this.colD.AppearanceCell.BackColor = System.Drawing.Color.SeaShell;
            this.colD.AppearanceCell.Options.UseBackColor = true;
            this.colD.DisplayFormat.FormatString = "f";
            this.colD.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colD.FieldName = "D";
            this.colD.Name = "colD";
            this.colD.Visible = true;
            this.colD.VisibleIndex = 4;
            this.colD.Width = 167;
            // 
            // colC
            // 
            this.colC.AppearanceCell.BackColor = System.Drawing.Color.SeaShell;
            this.colC.AppearanceCell.Options.UseBackColor = true;
            this.colC.DisplayFormat.FormatString = "f";
            this.colC.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colC.FieldName = "C";
            this.colC.Name = "colC";
            this.colC.Visible = true;
            this.colC.VisibleIndex = 5;
            this.colC.Width = 142;
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.DataSource = this.stocRetroBindingSource;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldCodProdus,
            this.fieldIdGestiune,
            this.fieldData,
            this.fieldC,
            this.fieldD,
            this.fieldSF,
            this.fieldSI,
            this.fieldDenumireGestiune,
            this.fieldDescriere});
            this.pivotGridControl1.Location = new System.Drawing.Point(366, 12);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.Size = new System.Drawing.Size(797, 505);
            this.pivotGridControl1.TabIndex = 1;
            // 
            // stocRetroBindingSource
            // 
            this.stocRetroBindingSource.DataMember = "StocRetro";
            this.stocRetroBindingSource.DataSource = this.mRPDataSet_Stoc_StocRetro;
            // 
            // mRPDataSet_Stoc_StocRetro
            // 
            this.mRPDataSet_Stoc_StocRetro.DataSetName = "MRPDataSet_Stoc_StocRetro";
            this.mRPDataSet_Stoc_StocRetro.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fieldCodProdus
            // 
            this.fieldCodProdus.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldCodProdus.AreaIndex = 1;
            this.fieldCodProdus.FieldName = "CodProdus";
            this.fieldCodProdus.Name = "fieldCodProdus";
            // 
            // fieldIdGestiune
            // 
            this.fieldIdGestiune.AreaIndex = 0;
            this.fieldIdGestiune.FieldName = "IdGestiune";
            this.fieldIdGestiune.Name = "fieldIdGestiune";
            // 
            // fieldData
            // 
            this.fieldData.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldData.AreaIndex = 0;
            this.fieldData.FieldName = "Data";
            this.fieldData.Name = "fieldData";
            this.fieldData.Width = 78;
            // 
            // fieldC
            // 
            this.fieldC.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldC.AreaIndex = 1;
            this.fieldC.FieldName = "C";
            this.fieldC.Name = "fieldC";
            this.fieldC.Visible = false;
            // 
            // fieldD
            // 
            this.fieldD.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldD.AreaIndex = 1;
            this.fieldD.FieldName = "D";
            this.fieldD.Name = "fieldD";
            this.fieldD.Visible = false;
            // 
            // fieldSF
            // 
            this.fieldSF.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldSF.AreaIndex = 0;
            this.fieldSF.CellFormat.FormatString = "f";
            this.fieldSF.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldSF.FieldName = "SF";
            this.fieldSF.Name = "fieldSF";
            this.fieldSF.ValueFormat.FormatString = "f";
            this.fieldSF.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // fieldSI
            // 
            this.fieldSI.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldSI.AreaIndex = 1;
            this.fieldSI.FieldName = "SI";
            this.fieldSI.Name = "fieldSI";
            this.fieldSI.Visible = false;
            // 
            // fieldDenumireGestiune
            // 
            this.fieldDenumireGestiune.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldDenumireGestiune.AreaIndex = 0;
            this.fieldDenumireGestiune.FieldName = "DenumireGestiune";
            this.fieldDenumireGestiune.Name = "fieldDenumireGestiune";
            this.fieldDenumireGestiune.Width = 119;
            // 
            // fieldDescriere
            // 
            this.fieldDescriere.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldDescriere.AreaIndex = 2;
            this.fieldDescriere.FieldName = "Descriere";
            this.fieldDescriere.Name = "fieldDescriere";
            this.fieldDescriere.Width = 298;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.stocRetroBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(345, 743);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCodProdus,
            this.colIdGestiune,
            this.colData,
            this.colSI,
            this.colSF,
            this.colD,
            this.colC,
            this.colDenumireGestiune,
            this.colDescriere});
            gridFormatRule1.Column = this.colD;
            gridFormatRule1.ColumnApplyTo = this.colD;
            gridFormatRule1.Name = "FormatDebitZero";
            formatConditionRuleValue1.Appearance.ForeColor = System.Drawing.Color.White;
            formatConditionRuleValue1.Appearance.Options.UseForeColor = true;
            formatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            formatConditionRuleValue1.Expression = "[D] == 0";
            formatConditionRuleValue1.Value1 = "0";
            gridFormatRule1.Rule = formatConditionRuleValue1;
            gridFormatRule2.Column = this.colC;
            gridFormatRule2.ColumnApplyTo = this.colC;
            gridFormatRule2.Name = "FormatCreditZero";
            formatConditionRuleValue2.Appearance.ForeColor = System.Drawing.Color.White;
            formatConditionRuleValue2.Appearance.Options.UseForeColor = true;
            formatConditionRuleValue2.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            formatConditionRuleValue2.Expression = "[C] == 0";
            formatConditionRuleValue2.Value1 = "0";
            gridFormatRule2.Rule = formatConditionRuleValue2;
            this.gridView1.FormatRules.Add(gridFormatRule1);
            this.gridView1.FormatRules.Add(gridFormatRule2);
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colDenumireGestiune, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colCodProdus
            // 
            this.colCodProdus.FieldName = "CodProdus";
            this.colCodProdus.Name = "colCodProdus";
            this.colCodProdus.Visible = true;
            this.colCodProdus.VisibleIndex = 0;
            this.colCodProdus.Width = 162;
            // 
            // colIdGestiune
            // 
            this.colIdGestiune.FieldName = "IdGestiune";
            this.colIdGestiune.Name = "colIdGestiune";
            this.colIdGestiune.Width = 125;
            // 
            // colData
            // 
            this.colData.FieldName = "Data";
            this.colData.Name = "colData";
            this.colData.Visible = true;
            this.colData.VisibleIndex = 2;
            this.colData.Width = 311;
            // 
            // colSI
            // 
            this.colSI.AppearanceCell.BackColor = System.Drawing.Color.SeaShell;
            this.colSI.AppearanceCell.Options.UseBackColor = true;
            this.colSI.DisplayFormat.FormatString = "f";
            this.colSI.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSI.FieldName = "SI";
            this.colSI.Name = "colSI";
            this.colSI.Visible = true;
            this.colSI.VisibleIndex = 3;
            this.colSI.Width = 166;
            // 
            // colSF
            // 
            this.colSF.AppearanceCell.BackColor = System.Drawing.Color.SeaShell;
            this.colSF.AppearanceCell.Options.UseBackColor = true;
            this.colSF.DisplayFormat.FormatString = "f";
            this.colSF.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSF.FieldName = "SF";
            this.colSF.Name = "colSF";
            this.colSF.Visible = true;
            this.colSF.VisibleIndex = 6;
            this.colSF.Width = 207;
            // 
            // colDenumireGestiune
            // 
            this.colDenumireGestiune.FieldName = "DenumireGestiune";
            this.colDenumireGestiune.Name = "colDenumireGestiune";
            this.colDenumireGestiune.Visible = true;
            this.colDenumireGestiune.VisibleIndex = 1;
            // 
            // colDescriere
            // 
            this.colDescriere.FieldName = "Descriere";
            this.colDescriere.Name = "colDescriere";
            this.colDescriere.Visible = true;
            this.colDescriere.VisibleIndex = 1;
            this.colDescriere.Width = 421;
            // 
            // stocRetroTableAdapter
            // 
            this.stocRetroTableAdapter.ClearBeforeFill = true;
            // 
            // chartControl1
            // 
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl1.Diagram = xyDiagram1;
            this.chartControl1.Location = new System.Drawing.Point(366, 526);
            this.chartControl1.Name = "chartControl1";
            series1.ArgumentDataMember = "Series";
            series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime;
            series1.DataSource = this.pivotGridControl1;
            series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            series1.Name = "StocFinal";
            series1.ValueDataMembersSerializable = "Values";
            series1.View = lineSeriesView1;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControl1.SeriesTemplate.View = lineSeriesView2;
            this.chartControl1.Size = new System.Drawing.Size(797, 229);
            this.chartControl1.TabIndex = 3;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Controls.Add(this.chartControl1);
            this.layoutControl1.Controls.Add(this.pivotGridControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(328, 151, 250, 350);
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.BackColor = System.Drawing.Color.LightGray;
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseBackColor = true;
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseFont = true;
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseTextOptions = true;
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.layoutControl1.OptionsPrint.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControl1.OptionsPrint.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.layoutControl1.OptionsPrint.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1175, 767);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.CustomizationFormText = "Root";
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.splitterItem1,
            this.splitterItem2});
            this.Root.Location = new System.Drawing.Point(0, 0);
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1175, 767);
            this.Root.Text = "Root";
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(349, 747);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.pivotGridControl1;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(354, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(801, 509);
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.chartControl1;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(354, 514);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(801, 233);
            this.layoutControlItem3.Text = "layoutControlItem3";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // splitterItem1
            // 
            this.splitterItem1.AllowHotTrack = true;
            this.splitterItem1.CustomizationFormText = "splitterItem1";
            this.splitterItem1.Location = new System.Drawing.Point(349, 0);
            this.splitterItem1.Name = "splitterItem1";
            this.splitterItem1.Size = new System.Drawing.Size(5, 747);
            // 
            // splitterItem2
            // 
            this.splitterItem2.AllowHotTrack = true;
            this.splitterItem2.CustomizationFormText = "splitterItem2";
            this.splitterItem2.Location = new System.Drawing.Point(354, 509);
            this.splitterItem2.Name = "splitterItem2";
            this.splitterItem2.Size = new System.Drawing.Size(801, 5);
            // 
            // xfrmEvolutieStocPerProdusGestiune
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 767);
            this.Controls.Add(this.layoutControl1);
            this.Name = "xfrmEvolutieStocPerProdusGestiune";
            this.Text = "xfrmEvolutieStocPerProdusGestiune";
            this.Load += new System.EventHandler(this.xfrmEvolutieStocPerProdusGestiune_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocRetroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mRPDataSet_Stoc_StocRetro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private MRPDataSet_Stoc_StocRetro mRPDataSet_Stoc_StocRetro;
        private System.Windows.Forms.BindingSource stocRetroBindingSource;
        private MRPDataSet_Stoc_StocRetroTableAdapters.StocRetroTableAdapter stocRetroTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colCodProdus;
        private DevExpress.XtraGrid.Columns.GridColumn colIdGestiune;
        private DevExpress.XtraGrid.Columns.GridColumn colData;
        private DevExpress.XtraGrid.Columns.GridColumn colSI;
        private DevExpress.XtraGrid.Columns.GridColumn colSF;
        private DevExpress.XtraGrid.Columns.GridColumn colD;
        private DevExpress.XtraGrid.Columns.GridColumn colC;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCodProdus;
        private DevExpress.XtraPivotGrid.PivotGridField fieldIdGestiune;
        private DevExpress.XtraPivotGrid.PivotGridField fieldData;
        private DevExpress.XtraPivotGrid.PivotGridField fieldC;
        private DevExpress.XtraPivotGrid.PivotGridField fieldD;
        private DevExpress.XtraPivotGrid.PivotGridField fieldSF;
        private DevExpress.XtraPivotGrid.PivotGridField fieldSI;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraGrid.Columns.GridColumn colDenumireGestiune;
        private DevExpress.XtraGrid.Columns.GridColumn colDescriere;
        private DevExpress.XtraPivotGrid.PivotGridField fieldDenumireGestiune;
        private DevExpress.XtraPivotGrid.PivotGridField fieldDescriere;
        private DevExpress.XtraLayout.SplitterItem splitterItem1;
        private DevExpress.XtraLayout.SplitterItem splitterItem2;
    }
}