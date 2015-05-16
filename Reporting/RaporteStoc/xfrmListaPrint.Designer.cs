namespace Reporting.RaporteStoc
{
    partial class xfrmListaPrint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmListaPrint));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.alerteStocType1PrintRapidBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mRPDataSet_AlerteStocType1_PrintRapid = new Reporting.MRPDataSet_AlerteStocType1_PrintRapid();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodProdus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescriere = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdGestiuneFrom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdGestiuneTo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDenumireGestiuneFrom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDenumireGestiuneTo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantitate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.alerteStocType1_PrintRapidTableAdapter = new Reporting.MRPDataSet_AlerteStocType1_PrintRapidTableAdapters.AlerteStocType1_PrintRapidTableAdapter();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnExportExcel = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.btnSterge = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alerteStocType1PrintRapidBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mRPDataSet_AlerteStocType1_PrintRapid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.alerteStocType1PrintRapidBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 54);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1056, 536);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // alerteStocType1PrintRapidBindingSource
            // 
            this.alerteStocType1PrintRapidBindingSource.DataMember = "AlerteStocType1_PrintRapid";
            this.alerteStocType1PrintRapidBindingSource.DataSource = this.mRPDataSet_AlerteStocType1_PrintRapid;
            // 
            // mRPDataSet_AlerteStocType1_PrintRapid
            // 
            this.mRPDataSet_AlerteStocType1_PrintRapid.DataSetName = "MRPDataSet_AlerteStocType1_PrintRapid";
            this.mRPDataSet_AlerteStocType1_PrintRapid.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colCodProdus,
            this.colDescriere,
            this.colIdGestiuneFrom,
            this.colIdGestiuneTo,
            this.colDenumireGestiuneFrom,
            this.colDenumireGestiuneTo,
            this.colCantitate});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colIdGestiuneTo, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // colCodProdus
            // 
            this.colCodProdus.FieldName = "CodProdus";
            this.colCodProdus.Name = "colCodProdus";
            this.colCodProdus.Visible = true;
            this.colCodProdus.VisibleIndex = 0;
            this.colCodProdus.Width = 158;
            // 
            // colDescriere
            // 
            this.colDescriere.FieldName = "Descriere";
            this.colDescriere.Name = "colDescriere";
            this.colDescriere.Visible = true;
            this.colDescriere.VisibleIndex = 1;
            this.colDescriere.Width = 374;
            // 
            // colIdGestiuneFrom
            // 
            this.colIdGestiuneFrom.FieldName = "IdGestiuneFrom";
            this.colIdGestiuneFrom.Name = "colIdGestiuneFrom";
            this.colIdGestiuneFrom.Width = 219;
            // 
            // colIdGestiuneTo
            // 
            this.colIdGestiuneTo.FieldName = "IdGestiuneTo";
            this.colIdGestiuneTo.Name = "colIdGestiuneTo";
            this.colIdGestiuneTo.Width = 219;
            // 
            // colDenumireGestiuneFrom
            // 
            this.colDenumireGestiuneFrom.Caption = "Din GESTIUNEA:";
            this.colDenumireGestiuneFrom.FieldName = "DenumireGestiuneFrom";
            this.colDenumireGestiuneFrom.Name = "colDenumireGestiuneFrom";
            this.colDenumireGestiuneFrom.Visible = true;
            this.colDenumireGestiuneFrom.VisibleIndex = 2;
            this.colDenumireGestiuneFrom.Width = 219;
            // 
            // colDenumireGestiuneTo
            // 
            this.colDenumireGestiuneTo.Caption = "In GESTIUNEA:";
            this.colDenumireGestiuneTo.FieldName = "DenumireGestiuneTo";
            this.colDenumireGestiuneTo.Name = "colDenumireGestiuneTo";
            this.colDenumireGestiuneTo.Visible = true;
            this.colDenumireGestiuneTo.VisibleIndex = 4;
            this.colDenumireGestiuneTo.Width = 219;
            // 
            // colCantitate
            // 
            this.colCantitate.DisplayFormat.FormatString = "f0";
            this.colCantitate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCantitate.FieldName = "Cantitate";
            this.colCantitate.Name = "colCantitate";
            this.colCantitate.Visible = true;
            this.colCantitate.VisibleIndex = 3;
            this.colCantitate.Width = 224;
            // 
            // alerteStocType1_PrintRapidTableAdapter
            // 
            this.alerteStocType1_PrintRapidTableAdapter.ClearBeforeFill = true;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnSterge);
            this.layoutControl1.Controls.Add(this.btnExportExcel);
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1444, 3, 250, 350);
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
            this.layoutControl1.Size = new System.Drawing.Size(1080, 602);
            this.layoutControl1.TabIndex = 1;
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
            this.emptySpaceItem1,
            this.layoutControlItem3});
            this.Root.Location = new System.Drawing.Point(0, 0);
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1080, 602);
            this.Root.Text = "Root";
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 42);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1060, 540);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExportExcel.Image")));
            this.btnExportExcel.Location = new System.Drawing.Point(921, 12);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(147, 38);
            this.btnExportExcel.StyleController = this.layoutControl1;
            this.btnExportExcel.TabIndex = 0;
            this.btnExportExcel.Text = "Export EXCEL";
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnExportExcel;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(909, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(151, 42);
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(744, 42);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // btnSterge
            // 
            this.btnSterge.Image = ((System.Drawing.Image)(resources.GetObject("btnSterge.Image")));
            this.btnSterge.Location = new System.Drawing.Point(756, 12);
            this.btnSterge.Name = "btnSterge";
            this.btnSterge.Size = new System.Drawing.Size(161, 38);
            this.btnSterge.StyleController = this.layoutControl1;
            this.btnSterge.TabIndex = 3;
            this.btnSterge.Text = "Sterge lista";
            this.btnSterge.Click += new System.EventHandler(this.btnSterge_Click);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnSterge;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(744, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(165, 42);
            this.layoutControlItem3.Text = "layoutControlItem3";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // xfrmListaPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 602);
            this.Controls.Add(this.layoutControl1);
            this.Name = "xfrmListaPrint";
            this.Text = "Lista produse alese pentru transfer intre gestiuni (in baza alertelor stoc)";
            this.Load += new System.EventHandler(this.xfrmListaPrint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alerteStocType1PrintRapidBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mRPDataSet_AlerteStocType1_PrintRapid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private MRPDataSet_AlerteStocType1_PrintRapid mRPDataSet_AlerteStocType1_PrintRapid;
        private System.Windows.Forms.BindingSource alerteStocType1PrintRapidBindingSource;
        private MRPDataSet_AlerteStocType1_PrintRapidTableAdapters.AlerteStocType1_PrintRapidTableAdapter alerteStocType1_PrintRapidTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colCodProdus;
        private DevExpress.XtraGrid.Columns.GridColumn colDescriere;
        private DevExpress.XtraGrid.Columns.GridColumn colIdGestiuneFrom;
        private DevExpress.XtraGrid.Columns.GridColumn colIdGestiuneTo;
        private DevExpress.XtraGrid.Columns.GridColumn colDenumireGestiuneFrom;
        private DevExpress.XtraGrid.Columns.GridColumn colDenumireGestiuneTo;
        private DevExpress.XtraGrid.Columns.GridColumn colCantitate;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton btnExportExcel;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.SimpleButton btnSterge;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}