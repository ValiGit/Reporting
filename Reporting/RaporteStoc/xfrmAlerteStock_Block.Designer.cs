namespace Reporting.RaporteStoc
{
    partial class xfrmAlerteStock_Block
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfrmAlerteStock_Block));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.viewAlerteStocType1BlockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mRPDataSet_view_AlerteStockType1_Block = new Reporting.MRPDataSet_view_AlerteStockType1_Block();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDGestiune = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDenumireGestiune = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodProdus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescriere = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDSubCategorie = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDenumireSubcategorie = new DevExpress.XtraGrid.Columns.GridColumn();
            this.view_AlerteStocType1_BlockTableAdapter = new Reporting.MRPDataSet_view_AlerteStockType1_BlockTableAdapters.view_AlerteStocType1_BlockTableAdapter();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barButtonItemDeblocheazaProdus = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnVeziListaPRINT = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdaugaInListaPRINT = new DevExpress.XtraEditors.SimpleButton();
            this.lookUpEditGestiunePrint = new DevExpress.XtraEditors.LookUpEdit();
            this.txtCantitatePrint = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewAlerteStocType1BlockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mRPDataSet_view_AlerteStockType1_Block)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditGestiunePrint.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantitatePrint.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.viewAlerteStocType1BlockBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(918, 501);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // viewAlerteStocType1BlockBindingSource
            // 
            this.viewAlerteStocType1BlockBindingSource.DataMember = "view_AlerteStocType1_Block";
            this.viewAlerteStocType1BlockBindingSource.DataSource = this.mRPDataSet_view_AlerteStockType1_Block;
            // 
            // mRPDataSet_view_AlerteStockType1_Block
            // 
            this.mRPDataSet_view_AlerteStockType1_Block.DataSetName = "MRPDataSet_view_AlerteStockType1_Block";
            this.mRPDataSet_view_AlerteStockType1_Block.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDGestiune,
            this.colDenumireGestiune,
            this.colCodProdus,
            this.colDescriere,
            this.colIDSubCategorie,
            this.colDenumireSubcategorie});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ShowViewCaption = true;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colDenumireGestiune, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colDescriere, DevExpress.Data.ColumnSortOrder.Descending)});
            this.gridView1.ViewCaption = "DEBLOCARE PRODUSE pentru alerte stock";
            this.gridView1.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gridView1_PopupMenuShowing);
            // 
            // colIDGestiune
            // 
            this.colIDGestiune.AppearanceCell.ForeColor = System.Drawing.Color.Red;
            this.colIDGestiune.AppearanceCell.Options.UseForeColor = true;
            this.colIDGestiune.FieldName = "IDGestiune";
            this.colIDGestiune.Name = "colIDGestiune";
            this.colIDGestiune.Visible = true;
            this.colIDGestiune.VisibleIndex = 0;
            this.colIDGestiune.Width = 134;
            // 
            // colDenumireGestiune
            // 
            this.colDenumireGestiune.AppearanceCell.ForeColor = System.Drawing.Color.Red;
            this.colDenumireGestiune.AppearanceCell.Options.UseForeColor = true;
            this.colDenumireGestiune.FieldName = "DenumireGestiune";
            this.colDenumireGestiune.Name = "colDenumireGestiune";
            this.colDenumireGestiune.Visible = true;
            this.colDenumireGestiune.VisibleIndex = 1;
            this.colDenumireGestiune.Width = 291;
            // 
            // colCodProdus
            // 
            this.colCodProdus.AppearanceCell.ForeColor = System.Drawing.Color.Red;
            this.colCodProdus.AppearanceCell.Options.UseForeColor = true;
            this.colCodProdus.FieldName = "CodProdus";
            this.colCodProdus.Name = "colCodProdus";
            this.colCodProdus.Visible = true;
            this.colCodProdus.VisibleIndex = 1;
            this.colCodProdus.Width = 138;
            // 
            // colDescriere
            // 
            this.colDescriere.AppearanceCell.ForeColor = System.Drawing.Color.Red;
            this.colDescriere.AppearanceCell.Options.UseForeColor = true;
            this.colDescriere.FieldName = "Descriere";
            this.colDescriere.Name = "colDescriere";
            this.colDescriere.Visible = true;
            this.colDescriere.VisibleIndex = 2;
            this.colDescriere.Width = 630;
            // 
            // colIDSubCategorie
            // 
            this.colIDSubCategorie.AppearanceCell.ForeColor = System.Drawing.Color.Red;
            this.colIDSubCategorie.AppearanceCell.Options.UseForeColor = true;
            this.colIDSubCategorie.FieldName = "IDSubCategorie";
            this.colIDSubCategorie.Name = "colIDSubCategorie";
            this.colIDSubCategorie.Width = 348;
            // 
            // colDenumireSubcategorie
            // 
            this.colDenumireSubcategorie.AppearanceCell.ForeColor = System.Drawing.Color.Red;
            this.colDenumireSubcategorie.AppearanceCell.Options.UseForeColor = true;
            this.colDenumireSubcategorie.FieldName = "DenumireSubcategorie";
            this.colDenumireSubcategorie.Name = "colDenumireSubcategorie";
            this.colDenumireSubcategorie.Visible = true;
            this.colDenumireSubcategorie.VisibleIndex = 3;
            this.colDenumireSubcategorie.Width = 439;
            // 
            // view_AlerteStocType1_BlockTableAdapter
            // 
            this.view_AlerteStocType1_BlockTableAdapter.ClearBeforeFill = true;
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItemDeblocheazaProdus, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // barButtonItemDeblocheazaProdus
            // 
            this.barButtonItemDeblocheazaProdus.Caption = "Deblocheaza produs";
            this.barButtonItemDeblocheazaProdus.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItemDeblocheazaProdus.Glyph")));
            this.barButtonItemDeblocheazaProdus.Id = 0;
            this.barButtonItemDeblocheazaProdus.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItemDeblocheazaProdus.LargeGlyph")));
            this.barButtonItemDeblocheazaProdus.Name = "barButtonItemDeblocheazaProdus";
            this.barButtonItemDeblocheazaProdus.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemDeblocheazaProdus_ItemClick);
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItemDeblocheazaProdus});
            this.barManager1.MaxItemId = 1;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(942, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 525);
            this.barDockControlBottom.Size = new System.Drawing.Size(942, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 525);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(942, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 525);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnVeziListaPRINT);
            this.layoutControl1.Controls.Add(this.btnAdaugaInListaPRINT);
            this.layoutControl1.Controls.Add(this.lookUpEditGestiunePrint);
            this.layoutControl1.Controls.Add(this.txtCantitatePrint);
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
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
            this.layoutControl1.Size = new System.Drawing.Size(942, 525);
            this.layoutControl1.TabIndex = 5;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnVeziListaPRINT
            // 
            this.btnVeziListaPRINT.Image = ((System.Drawing.Image)(resources.GetObject("btnVeziListaPRINT.Image")));
            this.btnVeziListaPRINT.Location = new System.Drawing.Point(766, 479);
            this.btnVeziListaPRINT.Name = "btnVeziListaPRINT";
            this.btnVeziListaPRINT.Size = new System.Drawing.Size(152, 22);
            this.btnVeziListaPRINT.StyleController = this.layoutControl1;
            this.btnVeziListaPRINT.TabIndex = 7;
            this.btnVeziListaPRINT.Text = "Vizualizare lista PRINT";
            // 
            // btnAdaugaInListaPRINT
            // 
            this.btnAdaugaInListaPRINT.Image = ((System.Drawing.Image)(resources.GetObject("btnAdaugaInListaPRINT.Image")));
            this.btnAdaugaInListaPRINT.Location = new System.Drawing.Point(591, 479);
            this.btnAdaugaInListaPRINT.Name = "btnAdaugaInListaPRINT";
            this.btnAdaugaInListaPRINT.Size = new System.Drawing.Size(171, 22);
            this.btnAdaugaInListaPRINT.StyleController = this.layoutControl1;
            this.btnAdaugaInListaPRINT.TabIndex = 6;
            this.btnAdaugaInListaPRINT.Text = "Adauga in lista PRINT";
            this.btnAdaugaInListaPRINT.Click += new System.EventHandler(this.btnAdaugaInListaPRINT_Click);
            // 
            // lookUpEditGestiunePrint
            // 
            this.lookUpEditGestiunePrint.Location = new System.Drawing.Point(303, 479);
            this.lookUpEditGestiunePrint.MenuManager = this.barManager1;
            this.lookUpEditGestiunePrint.Name = "lookUpEditGestiunePrint";
            this.lookUpEditGestiunePrint.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditGestiunePrint.Size = new System.Drawing.Size(284, 20);
            this.lookUpEditGestiunePrint.StyleController = this.layoutControl1;
            this.lookUpEditGestiunePrint.TabIndex = 5;
            // 
            // txtCantitatePrint
            // 
            this.txtCantitatePrint.Location = new System.Drawing.Point(96, 479);
            this.txtCantitatePrint.MenuManager = this.barManager1;
            this.txtCantitatePrint.Name = "txtCantitatePrint";
            this.txtCantitatePrint.Properties.Mask.BeepOnError = true;
            this.txtCantitatePrint.Properties.Mask.EditMask = "f2";
            this.txtCantitatePrint.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtCantitatePrint.Size = new System.Drawing.Size(131, 20);
            this.txtCantitatePrint.StyleController = this.layoutControl1;
            this.txtCantitatePrint.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.CustomizationFormText = "Root";
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Location = new System.Drawing.Point(0, 0);
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(942, 525);
            this.Root.Text = "Root";
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(922, 505);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CaptionImage = ((System.Drawing.Image)(resources.GetObject("layoutControlGroup1.CaptionImage")));
            this.layoutControlGroup1.CustomizationFormText = "Adaugare produs in lista de printare rapida:";
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 430);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(922, 75);
            this.layoutControlGroup1.Text = "Adaugare produs in lista de printare rapida:";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtCantitatePrint;
            this.layoutControlItem2.CustomizationFormText = "Cantitate";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(207, 26);
            this.layoutControlItem2.Text = "Cantitate";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(69, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.lookUpEditGestiunePrint;
            this.layoutControlItem3.CustomizationFormText = "Din gestiunea:";
            this.layoutControlItem3.Location = new System.Drawing.Point(207, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(360, 26);
            this.layoutControlItem3.Text = "Din gestiunea:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(69, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnAdaugaInListaPRINT;
            this.layoutControlItem4.CustomizationFormText = "layoutControlItem4";
            this.layoutControlItem4.Location = new System.Drawing.Point(567, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(175, 26);
            this.layoutControlItem4.Text = "layoutControlItem4";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnVeziListaPRINT;
            this.layoutControlItem5.CustomizationFormText = "layoutControlItem5";
            this.layoutControlItem5.Location = new System.Drawing.Point(742, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(156, 26);
            this.layoutControlItem5.Text = "layoutControlItem5";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // xfrmAlerteStock_Block
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 525);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "xfrmAlerteStock_Block";
            this.Text = "Blocare / deblocare produse pentru alerte de stoc";
            this.Load += new System.EventHandler(this.xfrmAlerteStock_Block_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewAlerteStocType1BlockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mRPDataSet_view_AlerteStockType1_Block)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditGestiunePrint.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantitatePrint.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private MRPDataSet_view_AlerteStockType1_Block mRPDataSet_view_AlerteStockType1_Block;
        private System.Windows.Forms.BindingSource viewAlerteStocType1BlockBindingSource;
        private MRPDataSet_view_AlerteStockType1_BlockTableAdapters.view_AlerteStocType1_BlockTableAdapter view_AlerteStocType1_BlockTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colIDGestiune;
        private DevExpress.XtraGrid.Columns.GridColumn colDenumireGestiune;
        private DevExpress.XtraGrid.Columns.GridColumn colCodProdus;
        private DevExpress.XtraGrid.Columns.GridColumn colDescriere;
        private DevExpress.XtraGrid.Columns.GridColumn colIDSubCategorie;
        private DevExpress.XtraGrid.Columns.GridColumn colDenumireSubcategorie;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemDeblocheazaProdus;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton btnAdaugaInListaPRINT;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditGestiunePrint;
        private DevExpress.XtraEditors.TextEdit txtCantitatePrint;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.SimpleButton btnVeziListaPRINT;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    }
}