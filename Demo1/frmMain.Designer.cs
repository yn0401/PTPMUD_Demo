namespace Demo1
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.dgv_sp = new System.Windows.Forms.DataGridView();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.lbl_search = new DevExpress.XtraEditors.LabelControl();
            this.lbl_Id = new DevExpress.XtraEditors.LabelControl();
            this.lbl_Name = new DevExpress.XtraEditors.LabelControl();
            this.lbl_Brand = new DevExpress.XtraEditors.LabelControl();
            this.lbl_Price = new DevExpress.XtraEditors.LabelControl();
            this.lbl_Status = new DevExpress.XtraEditors.LabelControl();
            this.lbl_Date = new DevExpress.XtraEditors.LabelControl();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Brand = new System.Windows.Forms.TextBox();
            this.dpx_Date = new System.Windows.Forms.DateTimePicker();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.cbx_status = new System.Windows.Forms.ComboBox();
            this.p_control = new DevExpress.XtraEditors.PanelControl();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_user = new DevExpress.XtraEditors.LabelControl();
            this.lbl_home = new DevExpress.XtraEditors.LabelControl();
            this.lbl_title = new DevExpress.XtraEditors.LabelControl();
            this.btn1_add = new System.Windows.Forms.Button();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_up = new System.Windows.Forms.Button();
            this.htmlTemplate1 = new DevExpress.Utils.Html.HtmlTemplate();
            this.htmlTemplate2 = new DevExpress.Utils.Html.HtmlTemplate();
            this.radialMenu1 = new DevExpress.XtraBars.Ribbon.RadialMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_control)).BeginInit();
            this.p_control.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radialMenu1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 741);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Size = new System.Drawing.Size(1341, 20);
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "ribbonPage3";
            // 
            // dgv_sp
            // 
            this.dgv_sp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sp.Location = new System.Drawing.Point(293, 339);
            this.dgv_sp.Name = "dgv_sp";
            this.dgv_sp.RowHeadersWidth = 51;
            this.dgv_sp.RowTemplate.Height = 24;
            this.dgv_sp.Size = new System.Drawing.Size(621, 204);
            this.dgv_sp.TabIndex = 2;
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(12, 72);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(251, 23);
            this.txt_Search.TabIndex = 3;
            // 
            // lbl_search
            // 
            this.lbl_search.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.lbl_search.Appearance.Options.UseFont = true;
            this.lbl_search.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.lbl_search.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("lbl_search.ImageOptions.Image")));
            this.lbl_search.Location = new System.Drawing.Point(12, 30);
            this.lbl_search.Name = "lbl_search";
            this.lbl_search.Size = new System.Drawing.Size(92, 36);
            this.lbl_search.TabIndex = 4;
            this.lbl_search.Text = "Tìm kiếm";
            // 
            // lbl_Id
            // 
            this.lbl_Id.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.lbl_Id.Appearance.Options.UseFont = true;
            this.lbl_Id.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.lbl_Id.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("lbl_Id.ImageOptions.SvgImage")));
            this.lbl_Id.Location = new System.Drawing.Point(300, 99);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(39, 24);
            this.lbl_Id.TabIndex = 5;
            this.lbl_Id.Text = "Id";
            // 
            // lbl_Name
            // 
            this.lbl_Name.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.lbl_Name.Appearance.Options.UseFont = true;
            this.lbl_Name.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.lbl_Name.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("lbl_Name.ImageOptions.SvgImage")));
            this.lbl_Name.Location = new System.Drawing.Point(300, 176);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(61, 24);
            this.lbl_Name.TabIndex = 6;
            this.lbl_Name.Text = "Name";
            // 
            // lbl_Brand
            // 
            this.lbl_Brand.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.lbl_Brand.Appearance.Options.UseFont = true;
            this.lbl_Brand.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.lbl_Brand.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("lbl_Brand.ImageOptions.SvgImage")));
            this.lbl_Brand.Location = new System.Drawing.Point(620, 93);
            this.lbl_Brand.Name = "lbl_Brand";
            this.lbl_Brand.Size = new System.Drawing.Size(84, 44);
            this.lbl_Brand.TabIndex = 7;
            this.lbl_Brand.Text = "Brand";
            // 
            // lbl_Price
            // 
            this.lbl_Price.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.lbl_Price.Appearance.Options.UseFont = true;
            this.lbl_Price.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.lbl_Price.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("lbl_Price.ImageOptions.Image")));
            this.lbl_Price.Location = new System.Drawing.Point(620, 170);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(70, 36);
            this.lbl_Price.TabIndex = 9;
            this.lbl_Price.Text = "Price";
            // 
            // lbl_Status
            // 
            this.lbl_Status.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.lbl_Status.Appearance.Options.UseFont = true;
            this.lbl_Status.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.lbl_Status.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("lbl_Status.ImageOptions.Image")));
            this.lbl_Status.Location = new System.Drawing.Point(300, 242);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(81, 36);
            this.lbl_Status.TabIndex = 10;
            this.lbl_Status.Text = "Status";
            // 
            // lbl_Date
            // 
            this.lbl_Date.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.lbl_Date.Appearance.Options.UseFont = true;
            this.lbl_Date.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.lbl_Date.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("lbl_Date.ImageOptions.Image")));
            this.lbl_Date.Location = new System.Drawing.Point(620, 245);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(69, 36);
            this.lbl_Date.TabIndex = 11;
            this.lbl_Date.Text = "Date";
            // 
            // txt_Id
            // 
            this.txt_Id.Location = new System.Drawing.Point(300, 137);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(275, 23);
            this.txt_Id.TabIndex = 12;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(300, 212);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(275, 23);
            this.txt_Name.TabIndex = 13;
            // 
            // txt_Brand
            // 
            this.txt_Brand.Location = new System.Drawing.Point(621, 137);
            this.txt_Brand.Name = "txt_Brand";
            this.txt_Brand.Size = new System.Drawing.Size(275, 23);
            this.txt_Brand.TabIndex = 14;
            // 
            // dpx_Date
            // 
            this.dpx_Date.CustomFormat = "dd/MM/yyyy";
            this.dpx_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpx_Date.Location = new System.Drawing.Point(621, 285);
            this.dpx_Date.Name = "dpx_Date";
            this.dpx_Date.Size = new System.Drawing.Size(275, 23);
            this.dpx_Date.TabIndex = 17;
            // 
            // txt_Price
            // 
            this.txt_Price.Location = new System.Drawing.Point(621, 212);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(275, 23);
            this.txt_Price.TabIndex = 18;
            // 
            // cbx_status
            // 
            this.cbx_status.FormattingEnabled = true;
            this.cbx_status.Location = new System.Drawing.Point(300, 284);
            this.cbx_status.Name = "cbx_status";
            this.cbx_status.Size = new System.Drawing.Size(275, 24);
            this.cbx_status.TabIndex = 25;
            this.cbx_status.SelectedIndexChanged += new System.EventHandler(this.cbx_status_SelectedIndexChanged);
            // 
            // p_control
            // 
            this.p_control.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.p_control.Appearance.Options.UseBackColor = true;
            this.p_control.Controls.Add(this.statusStrip1);
            this.p_control.Controls.Add(this.label1);
            this.p_control.Controls.Add(this.lbl_user);
            this.p_control.Controls.Add(this.lbl_home);
            this.p_control.Controls.Add(this.txt_Search);
            this.p_control.Controls.Add(this.lbl_search);
            this.p_control.Dock = System.Windows.Forms.DockStyle.Left;
            this.p_control.Location = new System.Drawing.Point(0, 0);
            this.p_control.Name = "p_control";
            this.p_control.Size = new System.Drawing.Size(287, 741);
            this.p_control.TabIndex = 26;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(2, 717);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(283, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(94, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 7;
            // 
            // lbl_user
            // 
            this.lbl_user.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.Appearance.Options.UseFont = true;
            this.lbl_user.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.lbl_user.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("lbl_user.ImageOptions.Image")));
            this.lbl_user.Location = new System.Drawing.Point(12, 186);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(67, 36);
            this.lbl_user.TabIndex = 6;
            this.lbl_user.Text = "User";
            // 
            // lbl_home
            // 
            this.lbl_home.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_home.Appearance.Options.UseFont = true;
            this.lbl_home.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.lbl_home.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("lbl_home.ImageOptions.Image")));
            this.lbl_home.Location = new System.Drawing.Point(12, 121);
            this.lbl_home.Name = "lbl_home";
            this.lbl_home.Size = new System.Drawing.Size(74, 36);
            this.lbl_home.TabIndex = 5;
            this.lbl_home.Text = "Home";
            // 
            // lbl_title
            // 
            this.lbl_title.Appearance.Font = new System.Drawing.Font("Script MT Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Appearance.Options.UseFont = true;
            this.lbl_title.Location = new System.Drawing.Point(470, 41);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(251, 33);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Perfume Managerment";
            // 
            // btn1_add
            // 
            this.btn1_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn1_add.FlatAppearance.BorderSize = 2;
            this.btn1_add.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1_add.ForeColor = System.Drawing.Color.Black;
            this.btn1_add.Location = new System.Drawing.Point(931, 356);
            this.btn1_add.Name = "btn1_add";
            this.btn1_add.Size = new System.Drawing.Size(85, 40);
            this.btn1_add.TabIndex = 27;
            this.btn1_add.Text = "Add";
            this.btn1_add.UseVisualStyleBackColor = false;
            this.btn1_add.Click += new System.EventHandler(this.btn1_add_Click);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Xóa";
            this.barButtonItem2.Id = 8;
            this.barButtonItem2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem2.ImageOptions.SvgImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // btn_del
            // 
            this.btn_del.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_del.FlatAppearance.BorderSize = 2;
            this.btn_del.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_del.ForeColor = System.Drawing.Color.Black;
            this.btn_del.Location = new System.Drawing.Point(931, 485);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(85, 40);
            this.btn_del.TabIndex = 28;
            this.btn_del.Text = "Delete";
            this.btn_del.UseVisualStyleBackColor = false;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_up
            // 
            this.btn_up.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_up.FlatAppearance.BorderSize = 2;
            this.btn_up.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_up.ForeColor = System.Drawing.Color.Black;
            this.btn_up.Location = new System.Drawing.Point(931, 422);
            this.btn_up.Name = "btn_up";
            this.btn_up.Size = new System.Drawing.Size(85, 40);
            this.btn_up.TabIndex = 29;
            this.btn_up.Text = "Update";
            this.btn_up.UseVisualStyleBackColor = false;
            this.btn_up.Click += new System.EventHandler(this.btn_up_Click);
            // 
            // htmlTemplate1
            // 
            this.htmlTemplate1.Name = "htmlTemplate1";
            // 
            // htmlTemplate2
            // 
            this.htmlTemplate2.Name = "htmlTemplate2";
            // 
            // radialMenu1
            // 
            this.radialMenu1.Name = "radialMenu1";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 761);
            this.Controls.Add(this.btn_up);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.btn1_add);
            this.Controls.Add(this.p_control);
            this.Controls.Add(this.cbx_status);
            this.Controls.Add(this.txt_Price);
            this.Controls.Add(this.dpx_Date);
            this.Controls.Add(this.txt_Brand);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.lbl_Date);
            this.Controls.Add(this.lbl_Status);
            this.Controls.Add(this.lbl_Price);
            this.Controls.Add(this.lbl_Brand);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_Id);
            this.Controls.Add(this.dgv_sp);
            this.Controls.Add(this.ribbonStatusBar);
            this.Name = "frmMain";
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_control)).EndInit();
            this.p_control.ResumeLayout(false);
            this.p_control.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radialMenu1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private System.Windows.Forms.DataGridView dgv_sp;
        private System.Windows.Forms.TextBox txt_Search;
        private DevExpress.XtraEditors.LabelControl lbl_search;
        private DevExpress.XtraEditors.LabelControl lbl_Id;
        private DevExpress.XtraEditors.LabelControl lbl_Name;
        private DevExpress.XtraEditors.LabelControl lbl_Brand;
        private DevExpress.XtraEditors.LabelControl lbl_Price;
        private DevExpress.XtraEditors.LabelControl lbl_Status;
        private DevExpress.XtraEditors.LabelControl lbl_Date;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_Brand;
        private System.Windows.Forms.DateTimePicker dpx_Date;
        private System.Windows.Forms.TextBox txt_Price;
        private System.Windows.Forms.ComboBox cbx_status;
        private DevExpress.XtraEditors.PanelControl p_control;
        private DevExpress.XtraEditors.LabelControl lbl_title;
        private DevExpress.XtraEditors.LabelControl lbl_user;
        private DevExpress.XtraEditors.LabelControl lbl_home;
        private System.Windows.Forms.Button btn1_add;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_up;
        private System.Windows.Forms.Label label1;
        private DevExpress.Utils.Html.HtmlTemplate htmlTemplate1;
        private DevExpress.Utils.Html.HtmlTemplate htmlTemplate2;
        private DevExpress.XtraBars.Ribbon.RadialMenu radialMenu1;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}