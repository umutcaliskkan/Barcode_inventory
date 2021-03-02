
namespace BarkodluEnvanterKayit
{
    partial class yazici
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(yazici));
            DevExpress.DataAccess.Sql.SelectQuery selectQuery3 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column13 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression13 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table3 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column14 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression14 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column15 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression15 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column16 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression16 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column17 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression17 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column18 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression18 = new DevExpress.DataAccess.Sql.ColumnExpression();
            this.btn_FormYenile = new DevExpress.XtraEditors.SimpleButton();
            this.btn_TabloYenile = new DevExpress.XtraEditors.SimpleButton();
            this.txt_Yaziciid = new DevExpress.XtraEditors.TextEdit();
            this.Btn_YaziciVeriCek = new DevExpress.XtraEditors.SimpleButton();
            this.btn_YaziciVeriGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btn_YaziciExcell = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_YaziciVeriSil = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_YaziciKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.txt_YaziciBarkod = new DevExpress.XtraEditors.TextEdit();
            this.txt_YaziciKullanici = new DevExpress.XtraEditors.TextEdit();
            this.txt_YaziciDepartman = new DevExpress.XtraEditors.TextEdit();
            this.txt_YaziciModel = new DevExpress.XtraEditors.TextEdit();
            this.txt_YaziciMarka = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridC_Yazici = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.colyaziciid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colyazicimarka = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colyazicimodel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colyazicidepartman = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colyazicikullanici = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colyazicibarkod = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Yaziciid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_YaziciBarkod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_YaziciKullanici.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_YaziciDepartman.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_YaziciModel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_YaziciMarka.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridC_Yazici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_FormYenile
            // 
            this.btn_FormYenile.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_FormYenile.ImageOptions.SvgImage")));
            this.btn_FormYenile.Location = new System.Drawing.Point(524, 46);
            this.btn_FormYenile.Name = "btn_FormYenile";
            this.btn_FormYenile.Size = new System.Drawing.Size(327, 46);
            this.btn_FormYenile.TabIndex = 68;
            this.btn_FormYenile.Text = "FORMU YENİLE";
            this.btn_FormYenile.Click += new System.EventHandler(this.btn_FormYenile_Click);
            // 
            // btn_TabloYenile
            // 
            this.btn_TabloYenile.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_TabloYenile.ImageOptions.SvgImage")));
            this.btn_TabloYenile.Location = new System.Drawing.Point(927, 46);
            this.btn_TabloYenile.Name = "btn_TabloYenile";
            this.btn_TabloYenile.Size = new System.Drawing.Size(327, 46);
            this.btn_TabloYenile.TabIndex = 67;
            this.btn_TabloYenile.Text = "TABLOYU YENİLE";
            this.btn_TabloYenile.Click += new System.EventHandler(this.btn_TabloYenile_Click);
            // 
            // txt_Yaziciid
            // 
            this.txt_Yaziciid.EditValue = "ID";
            this.txt_Yaziciid.Location = new System.Drawing.Point(638, 425);
            this.txt_Yaziciid.Name = "txt_Yaziciid";
            this.txt_Yaziciid.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Yaziciid.Properties.Appearance.Options.UseFont = true;
            this.txt_Yaziciid.Size = new System.Drawing.Size(137, 26);
            this.txt_Yaziciid.TabIndex = 66;
            // 
            // Btn_YaziciVeriCek
            // 
            this.Btn_YaziciVeriCek.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Btn_EkranVeriCek.ImageOptions.SvgImage")));
            this.Btn_YaziciVeriCek.Location = new System.Drawing.Point(807, 409);
            this.Btn_YaziciVeriCek.Name = "Btn_YaziciVeriCek";
            this.Btn_YaziciVeriCek.Size = new System.Drawing.Size(141, 46);
            this.Btn_YaziciVeriCek.TabIndex = 65;
            this.Btn_YaziciVeriCek.Text = "VERİ ÇEK";
            this.Btn_YaziciVeriCek.Click += new System.EventHandler(this.Btn_YaziciVeriCek_Click);
            // 
            // btn_YaziciVeriGuncelle
            // 
            this.btn_YaziciVeriGuncelle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_EkranVeriGuncelle.ImageOptions.SvgImage")));
            this.btn_YaziciVeriGuncelle.Location = new System.Drawing.Point(807, 461);
            this.btn_YaziciVeriGuncelle.Name = "btn_YaziciVeriGuncelle";
            this.btn_YaziciVeriGuncelle.Size = new System.Drawing.Size(141, 46);
            this.btn_YaziciVeriGuncelle.TabIndex = 64;
            this.btn_YaziciVeriGuncelle.Text = "VERİ GÜNCELLE";
            this.btn_YaziciVeriGuncelle.Click += new System.EventHandler(this.btn_YaziciVeriGuncelle_Click);
            // 
            // btn_YaziciExcell
            // 
            this.btn_YaziciExcell.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_EkranExcell.ImageOptions.SvgImage")));
            this.btn_YaziciExcell.Location = new System.Drawing.Point(1007, 461);
            this.btn_YaziciExcell.Name = "btn_YaziciExcell";
            this.btn_YaziciExcell.Size = new System.Drawing.Size(141, 46);
            this.btn_YaziciExcell.TabIndex = 63;
            this.btn_YaziciExcell.Text = "EXCELL AKTAR";
            this.btn_YaziciExcell.Click += new System.EventHandler(this.btn_YaziciExcell_Click);
            // 
            // Btn_YaziciVeriSil
            // 
            this.Btn_YaziciVeriSil.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Btn_EkranVeriSil.ImageOptions.SvgImage")));
            this.Btn_YaziciVeriSil.Location = new System.Drawing.Point(1007, 405);
            this.Btn_YaziciVeriSil.Name = "Btn_YaziciVeriSil";
            this.Btn_YaziciVeriSil.Size = new System.Drawing.Size(141, 46);
            this.Btn_YaziciVeriSil.TabIndex = 62;
            this.Btn_YaziciVeriSil.Text = "VERİ SİL";
            this.Btn_YaziciVeriSil.Click += new System.EventHandler(this.Btn_YaziciVeriSil_Click);
            // 
            // Btn_YaziciKaydet
            // 
            this.Btn_YaziciKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_EkranKaydet.ImageOptions.Image")));
            this.Btn_YaziciKaydet.Location = new System.Drawing.Point(257, 322);
            this.Btn_YaziciKaydet.Name = "Btn_YaziciKaydet";
            this.Btn_YaziciKaydet.Size = new System.Drawing.Size(167, 44);
            this.Btn_YaziciKaydet.TabIndex = 61;
            this.Btn_YaziciKaydet.Text = "KAYDET";
            this.Btn_YaziciKaydet.Click += new System.EventHandler(this.Btn_EkranKaydet_Click);
            // 
            // txt_YaziciBarkod
            // 
            this.txt_YaziciBarkod.Location = new System.Drawing.Point(257, 266);
            this.txt_YaziciBarkod.Name = "txt_YaziciBarkod";
            this.txt_YaziciBarkod.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_YaziciBarkod.Properties.Appearance.Options.UseFont = true;
            this.txt_YaziciBarkod.Size = new System.Drawing.Size(167, 26);
            this.txt_YaziciBarkod.TabIndex = 60;
            // 
            // txt_YaziciKullanici
            // 
            this.txt_YaziciKullanici.Location = new System.Drawing.Point(257, 223);
            this.txt_YaziciKullanici.Name = "txt_YaziciKullanici";
            this.txt_YaziciKullanici.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_YaziciKullanici.Properties.Appearance.Options.UseFont = true;
            this.txt_YaziciKullanici.Size = new System.Drawing.Size(167, 26);
            this.txt_YaziciKullanici.TabIndex = 59;
            // 
            // txt_YaziciDepartman
            // 
            this.txt_YaziciDepartman.Location = new System.Drawing.Point(257, 178);
            this.txt_YaziciDepartman.Name = "txt_YaziciDepartman";
            this.txt_YaziciDepartman.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_YaziciDepartman.Properties.Appearance.Options.UseFont = true;
            this.txt_YaziciDepartman.Size = new System.Drawing.Size(167, 26);
            this.txt_YaziciDepartman.TabIndex = 58;
            // 
            // txt_YaziciModel
            // 
            this.txt_YaziciModel.Location = new System.Drawing.Point(257, 136);
            this.txt_YaziciModel.Name = "txt_YaziciModel";
            this.txt_YaziciModel.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_YaziciModel.Properties.Appearance.Options.UseFont = true;
            this.txt_YaziciModel.Size = new System.Drawing.Size(167, 26);
            this.txt_YaziciModel.TabIndex = 57;
            // 
            // txt_YaziciMarka
            // 
            this.txt_YaziciMarka.Location = new System.Drawing.Point(257, 95);
            this.txt_YaziciMarka.Name = "txt_YaziciMarka";
            this.txt_YaziciMarka.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_YaziciMarka.Properties.Appearance.Options.UseFont = true;
            this.txt_YaziciMarka.Size = new System.Drawing.Size(167, 26);
            this.txt_YaziciMarka.TabIndex = 56;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(97, 272);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(140, 20);
            this.labelControl8.TabIndex = 55;
            this.labelControl8.Text = "YAZICI BARKOD NO :";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(97, 229);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(126, 20);
            this.labelControl7.TabIndex = 54;
            this.labelControl7.Text = "YAZICI KULLANICI :";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(97, 184);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(143, 20);
            this.labelControl6.TabIndex = 53;
            this.labelControl6.Text = "YAZICI DEPARTMAN :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(97, 142);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(105, 20);
            this.labelControl2.TabIndex = 52;
            this.labelControl2.Text = "YAZICI MODEL :\r\n";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(97, 98);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(106, 20);
            this.labelControl1.TabIndex = 51;
            this.labelControl1.Text = "YAZICI MARKA :";
            // 
            // gridC_Yazici
            // 
            this.gridC_Yazici.DataMember = "tblyazici";
            this.gridC_Yazici.DataSource = this.sqlDataSource1;
            this.gridC_Yazici.Location = new System.Drawing.Point(524, 98);
            this.gridC_Yazici.MainView = this.gridView1;
            this.gridC_Yazici.Name = "gridC_Yazici";
            this.gridC_Yazici.Size = new System.Drawing.Size(730, 301);
            this.gridC_Yazici.TabIndex = 69;
            this.gridC_Yazici.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colyaziciid,
            this.colyazicimarka,
            this.colyazicimodel,
            this.colyazicidepartman,
            this.colyazicikullanici,
            this.colyazicibarkod});
            this.gridView1.GridControl = this.gridC_Yazici;
            this.gridView1.Name = "gridView1";
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "localhost_BarkodEnvanterDB_Connection";
            this.sqlDataSource1.Name = "sqlDataSource1";
            columnExpression13.ColumnName = "yaziciid";
            table3.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"185\" />";
            table3.Name = "tblyazici";
            columnExpression13.Table = table3;
            column13.Expression = columnExpression13;
            columnExpression14.ColumnName = "yazicimarka";
            columnExpression14.Table = table3;
            column14.Expression = columnExpression14;
            columnExpression15.ColumnName = "yazicimodel";
            columnExpression15.Table = table3;
            column15.Expression = columnExpression15;
            columnExpression16.ColumnName = "yazicidepartman";
            columnExpression16.Table = table3;
            column16.Expression = columnExpression16;
            columnExpression17.ColumnName = "yazicikullanici";
            columnExpression17.Table = table3;
            column17.Expression = columnExpression17;
            columnExpression18.ColumnName = "yazicibarkod";
            columnExpression18.Table = table3;
            column18.Expression = columnExpression18;
            selectQuery3.Columns.Add(column13);
            selectQuery3.Columns.Add(column14);
            selectQuery3.Columns.Add(column15);
            selectQuery3.Columns.Add(column16);
            selectQuery3.Columns.Add(column17);
            selectQuery3.Columns.Add(column18);
            selectQuery3.Name = "tblyazici";
            selectQuery3.Tables.Add(table3);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery3});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // colyaziciid
            // 
            this.colyaziciid.FieldName = "yaziciid";
            this.colyaziciid.MinWidth = 25;
            this.colyaziciid.Name = "colyaziciid";
            this.colyaziciid.Visible = true;
            this.colyaziciid.VisibleIndex = 0;
            this.colyaziciid.Width = 94;
            // 
            // colyazicimarka
            // 
            this.colyazicimarka.FieldName = "yazicimarka";
            this.colyazicimarka.MinWidth = 25;
            this.colyazicimarka.Name = "colyazicimarka";
            this.colyazicimarka.Visible = true;
            this.colyazicimarka.VisibleIndex = 1;
            this.colyazicimarka.Width = 94;
            // 
            // colyazicimodel
            // 
            this.colyazicimodel.FieldName = "yazicimodel";
            this.colyazicimodel.MinWidth = 25;
            this.colyazicimodel.Name = "colyazicimodel";
            this.colyazicimodel.Visible = true;
            this.colyazicimodel.VisibleIndex = 2;
            this.colyazicimodel.Width = 94;
            // 
            // colyazicidepartman
            // 
            this.colyazicidepartman.FieldName = "yazicidepartman";
            this.colyazicidepartman.MinWidth = 25;
            this.colyazicidepartman.Name = "colyazicidepartman";
            this.colyazicidepartman.Visible = true;
            this.colyazicidepartman.VisibleIndex = 3;
            this.colyazicidepartman.Width = 94;
            // 
            // colyazicikullanici
            // 
            this.colyazicikullanici.FieldName = "yazicikullanici";
            this.colyazicikullanici.MinWidth = 25;
            this.colyazicikullanici.Name = "colyazicikullanici";
            this.colyazicikullanici.Visible = true;
            this.colyazicikullanici.VisibleIndex = 4;
            this.colyazicikullanici.Width = 94;
            // 
            // colyazicibarkod
            // 
            this.colyazicibarkod.FieldName = "yazicibarkod";
            this.colyazicibarkod.MinWidth = 25;
            this.colyazicibarkod.Name = "colyazicibarkod";
            this.colyazicibarkod.Visible = true;
            this.colyazicibarkod.VisibleIndex = 5;
            this.colyazicibarkod.Width = 94;
            // 
            // yazici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 552);
            this.ControlBox = false;
            this.Controls.Add(this.gridC_Yazici);
            this.Controls.Add(this.btn_FormYenile);
            this.Controls.Add(this.btn_TabloYenile);
            this.Controls.Add(this.txt_Yaziciid);
            this.Controls.Add(this.Btn_YaziciVeriCek);
            this.Controls.Add(this.btn_YaziciVeriGuncelle);
            this.Controls.Add(this.btn_YaziciExcell);
            this.Controls.Add(this.Btn_YaziciVeriSil);
            this.Controls.Add(this.Btn_YaziciKaydet);
            this.Controls.Add(this.txt_YaziciBarkod);
            this.Controls.Add(this.txt_YaziciKullanici);
            this.Controls.Add(this.txt_YaziciDepartman);
            this.Controls.Add(this.txt_YaziciModel);
            this.Controls.Add(this.txt_YaziciMarka);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "yazici";
            this.Text = "YAZICI KAYIT FORMU";
            ((System.ComponentModel.ISupportInitialize)(this.txt_Yaziciid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_YaziciBarkod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_YaziciKullanici.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_YaziciDepartman.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_YaziciModel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_YaziciMarka.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridC_Yazici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btn_FormYenile;
        private DevExpress.XtraEditors.SimpleButton btn_TabloYenile;
        private DevExpress.XtraEditors.TextEdit txt_Yaziciid;
        private DevExpress.XtraEditors.SimpleButton Btn_YaziciVeriCek;
        private DevExpress.XtraEditors.SimpleButton btn_YaziciVeriGuncelle;
        private DevExpress.XtraEditors.SimpleButton btn_YaziciExcell;
        private DevExpress.XtraEditors.SimpleButton Btn_YaziciVeriSil;
        private DevExpress.XtraEditors.SimpleButton Btn_YaziciKaydet;
        private DevExpress.XtraEditors.TextEdit txt_YaziciBarkod;
        private DevExpress.XtraEditors.TextEdit txt_YaziciKullanici;
        private DevExpress.XtraEditors.TextEdit txt_YaziciDepartman;
        private DevExpress.XtraEditors.TextEdit txt_YaziciModel;
        private DevExpress.XtraEditors.TextEdit txt_YaziciMarka;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridC_Yazici;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colyaziciid;
        private DevExpress.XtraGrid.Columns.GridColumn colyazicimarka;
        private DevExpress.XtraGrid.Columns.GridColumn colyazicimodel;
        private DevExpress.XtraGrid.Columns.GridColumn colyazicidepartman;
        private DevExpress.XtraGrid.Columns.GridColumn colyazicikullanici;
        private DevExpress.XtraGrid.Columns.GridColumn colyazicibarkod;
    }
}