namespace PD2020S_Examl_A108222027
{
    partial class frmAccountManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccountManagement));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnModify = new System.Windows.Forms.Button();
            this.lblname = new System.Windows.Forms.Label();
            this.tbxname = new System.Windows.Forms.TextBox();
            this.lblps = new System.Windows.Forms.Label();
            this.lblaccount = new System.Windows.Forms.Label();
            this.lbltip = new System.Windows.Forms.Label();
            this.lbllevel = new System.Windows.Forms.Label();
            this.cbxlevel = new System.Windows.Forms.ComboBox();
            this.lbxAccountlist = new System.Windows.Forms.ListBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btninsert = new System.Windows.Forms.Button();
            this.tbxpss = new System.Windows.Forms.TextBox();
            this.tbxacc = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btndtmodif = new System.Windows.Forms.Button();
            this.lbldtname = new System.Windows.Forms.Label();
            this.tbxdtname = new System.Windows.Forms.TextBox();
            this.lbldtpass = new System.Windows.Forms.Label();
            this.lbldtacc = new System.Windows.Forms.Label();
            this.lbldttip = new System.Windows.Forms.Label();
            this.lbldtpower = new System.Windows.Forms.Label();
            this.cbxdtpower = new System.Windows.Forms.ComboBox();
            this.btndtdel = new System.Windows.Forms.Button();
            this.btndtupdate = new System.Windows.Forms.Button();
            this.btndtinsert = new System.Windows.Forms.Button();
            this.tbxdtpass = new System.Windows.Forms.TextBox();
            this.tbxdtacc = new System.Windows.Forms.TextBox();
            this.dgvaccount = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnexit = new System.Windows.Forms.Button();
            this.lbltishi = new System.Windows.Forms.Label();
            this.pbxlogo = new System.Windows.Forms.PictureBox();
            this.pbxp = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvaccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxlogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxp)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabControl1.Location = new System.Drawing.Point(111, 84);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(570, 364);
            this.tabControl1.TabIndex = 57;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.load);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnModify);
            this.tabPage1.Controls.Add(this.lblname);
            this.tabPage1.Controls.Add(this.tbxname);
            this.tabPage1.Controls.Add(this.lblps);
            this.tabPage1.Controls.Add(this.lblaccount);
            this.tabPage1.Controls.Add(this.lbltip);
            this.tabPage1.Controls.Add(this.lbllevel);
            this.tabPage1.Controls.Add(this.cbxlevel);
            this.tabPage1.Controls.Add(this.lbxAccountlist);
            this.tabPage1.Controls.Add(this.btndelete);
            this.tabPage1.Controls.Add(this.btnUpdate);
            this.tabPage1.Controls.Add(this.btninsert);
            this.tabPage1.Controls.Add(this.tbxpss);
            this.tabPage1.Controls.Add(this.tbxacc);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(562, 335);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "員工管理";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnModify
            // 
            this.btnModify.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnModify.Location = new System.Drawing.Point(400, 221);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(90, 40);
            this.btnModify.TabIndex = 58;
            this.btnModify.Text = "更改資料";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click_1);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblname.Location = new System.Drawing.Point(262, 135);
            this.lblname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(41, 20);
            this.lblname.TabIndex = 67;
            this.lblname.Text = "姓名";
            // 
            // tbxname
            // 
            this.tbxname.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbxname.Location = new System.Drawing.Point(325, 129);
            this.tbxname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxname.Name = "tbxname";
            this.tbxname.Size = new System.Drawing.Size(114, 28);
            this.tbxname.TabIndex = 54;
            // 
            // lblps
            // 
            this.lblps.AutoSize = true;
            this.lblps.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblps.Location = new System.Drawing.Point(262, 180);
            this.lblps.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblps.Name = "lblps";
            this.lblps.Size = new System.Drawing.Size(41, 20);
            this.lblps.TabIndex = 63;
            this.lblps.Text = "密碼";
            // 
            // lblaccount
            // 
            this.lblaccount.AutoSize = true;
            this.lblaccount.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblaccount.Location = new System.Drawing.Point(262, 90);
            this.lblaccount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblaccount.Name = "lblaccount";
            this.lblaccount.Size = new System.Drawing.Size(41, 20);
            this.lblaccount.TabIndex = 64;
            this.lblaccount.Text = "賬號";
            // 
            // lbltip
            // 
            this.lbltip.AutoSize = true;
            this.lbltip.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbltip.Location = new System.Drawing.Point(258, 3);
            this.lbltip.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltip.Name = "lbltip";
            this.lbltip.Size = new System.Drawing.Size(89, 20);
            this.lbltip.TabIndex = 65;
            this.lbltip.Text = "添加賬號：";
            // 
            // lbllevel
            // 
            this.lbllevel.AutoSize = true;
            this.lbllevel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbllevel.Location = new System.Drawing.Point(262, 48);
            this.lbllevel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbllevel.Name = "lbllevel";
            this.lbllevel.Size = new System.Drawing.Size(41, 20);
            this.lbllevel.TabIndex = 66;
            this.lbllevel.Text = "職位";
            // 
            // cbxlevel
            // 
            this.cbxlevel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbxlevel.FormattingEnabled = true;
            this.cbxlevel.Items.AddRange(new object[] {
            "Admin",
            "Owner",
            "Worker",
            "Guest"});
            this.cbxlevel.Location = new System.Drawing.Point(325, 41);
            this.cbxlevel.Name = "cbxlevel";
            this.cbxlevel.Size = new System.Drawing.Size(114, 28);
            this.cbxlevel.TabIndex = 61;
            // 
            // lbxAccountlist
            // 
            this.lbxAccountlist.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbxAccountlist.FormattingEnabled = true;
            this.lbxAccountlist.ItemHeight = 16;
            this.lbxAccountlist.Location = new System.Drawing.Point(6, 3);
            this.lbxAccountlist.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbxAccountlist.Name = "lbxAccountlist";
            this.lbxAccountlist.Size = new System.Drawing.Size(247, 244);
            this.lbxAccountlist.TabIndex = 59;
            this.lbxAccountlist.SelectedValueChanged += new System.EventHandler(this.itemchange);
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btndelete.Location = new System.Drawing.Point(401, 276);
            this.btndelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(88, 39);
            this.btndelete.TabIndex = 62;
            this.btndelete.Text = "刪除";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnUpdate.Location = new System.Drawing.Point(263, 274);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(88, 39);
            this.btnUpdate.TabIndex = 60;
            this.btnUpdate.Text = "更新資料";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btninsert
            // 
            this.btninsert.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btninsert.Location = new System.Drawing.Point(263, 222);
            this.btninsert.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(88, 39);
            this.btninsert.TabIndex = 56;
            this.btninsert.Text = "加入員工";
            this.btninsert.UseVisualStyleBackColor = true;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click_1);
            // 
            // tbxpss
            // 
            this.tbxpss.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbxpss.Location = new System.Drawing.Point(325, 171);
            this.tbxpss.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxpss.Name = "tbxpss";
            this.tbxpss.Size = new System.Drawing.Size(114, 28);
            this.tbxpss.TabIndex = 55;
            // 
            // tbxacc
            // 
            this.tbxacc.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbxacc.Location = new System.Drawing.Point(325, 83);
            this.tbxacc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxacc.Name = "tbxacc";
            this.tbxacc.Size = new System.Drawing.Size(114, 28);
            this.tbxacc.TabIndex = 53;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btndtmodif);
            this.tabPage2.Controls.Add(this.lbldtname);
            this.tabPage2.Controls.Add(this.tbxdtname);
            this.tabPage2.Controls.Add(this.lbldtpass);
            this.tabPage2.Controls.Add(this.lbldtacc);
            this.tabPage2.Controls.Add(this.lbldttip);
            this.tabPage2.Controls.Add(this.lbldtpower);
            this.tabPage2.Controls.Add(this.cbxdtpower);
            this.tabPage2.Controls.Add(this.btndtdel);
            this.tabPage2.Controls.Add(this.btndtupdate);
            this.tabPage2.Controls.Add(this.btndtinsert);
            this.tabPage2.Controls.Add(this.tbxdtpass);
            this.tabPage2.Controls.Add(this.tbxdtacc);
            this.tabPage2.Controls.Add(this.dgvaccount);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(562, 335);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "員工管理(表單)";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btndtmodif
            // 
            this.btndtmodif.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btndtmodif.Location = new System.Drawing.Point(473, 222);
            this.btndtmodif.Name = "btndtmodif";
            this.btndtmodif.Size = new System.Drawing.Size(83, 41);
            this.btndtmodif.TabIndex = 72;
            this.btndtmodif.Text = "更改資料";
            this.btndtmodif.UseVisualStyleBackColor = true;
            this.btndtmodif.Click += new System.EventHandler(this.btndtmodif_Click);
            // 
            // lbldtname
            // 
            this.lbldtname.AutoSize = true;
            this.lbldtname.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbldtname.Location = new System.Drawing.Point(360, 146);
            this.lbldtname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldtname.Name = "lbldtname";
            this.lbldtname.Size = new System.Drawing.Size(41, 20);
            this.lbldtname.TabIndex = 80;
            this.lbldtname.Text = "姓名";
            // 
            // tbxdtname
            // 
            this.tbxdtname.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbxdtname.Location = new System.Drawing.Point(423, 138);
            this.tbxdtname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxdtname.Name = "tbxdtname";
            this.tbxdtname.Size = new System.Drawing.Size(114, 28);
            this.tbxdtname.TabIndex = 69;
            // 
            // lbldtpass
            // 
            this.lbldtpass.AutoSize = true;
            this.lbldtpass.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbldtpass.Location = new System.Drawing.Point(360, 189);
            this.lbldtpass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldtpass.Name = "lbldtpass";
            this.lbldtpass.Size = new System.Drawing.Size(41, 20);
            this.lbldtpass.TabIndex = 76;
            this.lbldtpass.Text = "密碼";
            // 
            // lbldtacc
            // 
            this.lbldtacc.AutoSize = true;
            this.lbldtacc.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbldtacc.Location = new System.Drawing.Point(360, 100);
            this.lbldtacc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldtacc.Name = "lbldtacc";
            this.lbldtacc.Size = new System.Drawing.Size(41, 20);
            this.lbldtacc.TabIndex = 77;
            this.lbldtacc.Text = "賬號";
            // 
            // lbldttip
            // 
            this.lbldttip.AutoSize = true;
            this.lbldttip.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbldttip.Location = new System.Drawing.Point(356, 12);
            this.lbldttip.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldttip.Name = "lbldttip";
            this.lbldttip.Size = new System.Drawing.Size(89, 20);
            this.lbldttip.TabIndex = 78;
            this.lbldttip.Text = "添加賬號：";
            // 
            // lbldtpower
            // 
            this.lbldtpower.AutoSize = true;
            this.lbldtpower.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbldtpower.Location = new System.Drawing.Point(360, 57);
            this.lbldtpower.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldtpower.Name = "lbldtpower";
            this.lbldtpower.Size = new System.Drawing.Size(41, 20);
            this.lbldtpower.TabIndex = 79;
            this.lbldtpower.Text = "職位";
            // 
            // cbxdtpower
            // 
            this.cbxdtpower.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbxdtpower.FormattingEnabled = true;
            this.cbxdtpower.Items.AddRange(new object[] {
            "Admin",
            "Owner",
            "Worker",
            "Guest"});
            this.cbxdtpower.Location = new System.Drawing.Point(423, 50);
            this.cbxdtpower.Name = "cbxdtpower";
            this.cbxdtpower.Size = new System.Drawing.Size(114, 28);
            this.cbxdtpower.TabIndex = 74;
            // 
            // btndtdel
            // 
            this.btndtdel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btndtdel.Location = new System.Drawing.Point(473, 282);
            this.btndtdel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btndtdel.Name = "btndtdel";
            this.btndtdel.Size = new System.Drawing.Size(86, 41);
            this.btndtdel.TabIndex = 75;
            this.btndtdel.Text = "刪除";
            this.btndtdel.UseVisualStyleBackColor = true;
            this.btndtdel.Click += new System.EventHandler(this.btndtdel_Click);
            // 
            // btndtupdate
            // 
            this.btndtupdate.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btndtupdate.Location = new System.Drawing.Point(364, 282);
            this.btndtupdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btndtupdate.Name = "btndtupdate";
            this.btndtupdate.Size = new System.Drawing.Size(83, 41);
            this.btndtupdate.TabIndex = 73;
            this.btndtupdate.Text = "更新資料";
            this.btndtupdate.UseVisualStyleBackColor = true;
            this.btndtupdate.Click += new System.EventHandler(this.btndtupdate_Click);
            // 
            // btndtinsert
            // 
            this.btndtinsert.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btndtinsert.Location = new System.Drawing.Point(364, 222);
            this.btndtinsert.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btndtinsert.Name = "btndtinsert";
            this.btndtinsert.Size = new System.Drawing.Size(83, 41);
            this.btndtinsert.TabIndex = 71;
            this.btndtinsert.Text = "添加員工";
            this.btndtinsert.UseVisualStyleBackColor = true;
            this.btndtinsert.Click += new System.EventHandler(this.btndtinsert_Click);
            // 
            // tbxdtpass
            // 
            this.tbxdtpass.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbxdtpass.Location = new System.Drawing.Point(423, 180);
            this.tbxdtpass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxdtpass.Name = "tbxdtpass";
            this.tbxdtpass.Size = new System.Drawing.Size(114, 28);
            this.tbxdtpass.TabIndex = 70;
            // 
            // tbxdtacc
            // 
            this.tbxdtacc.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbxdtacc.Location = new System.Drawing.Point(423, 92);
            this.tbxdtacc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxdtacc.Name = "tbxdtacc";
            this.tbxdtacc.Size = new System.Drawing.Size(114, 28);
            this.tbxdtacc.TabIndex = 68;
            // 
            // dgvaccount
            // 
            this.dgvaccount.AllowUserToAddRows = false;
            this.dgvaccount.AllowUserToDeleteRows = false;
            this.dgvaccount.AllowUserToResizeColumns = false;
            this.dgvaccount.AllowUserToResizeRows = false;
            this.dgvaccount.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvaccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvaccount.Location = new System.Drawing.Point(6, 6);
            this.dgvaccount.Name = "dgvaccount";
            this.dgvaccount.RowTemplate.Height = 24;
            this.dgvaccount.Size = new System.Drawing.Size(341, 317);
            this.dgvaccount.TabIndex = 0;
            this.dgvaccount.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.select);
            // 
            // tabPage3
            // 
            this.tabPage3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage3.Size = new System.Drawing.Size(562, 335);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "員工調查";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnexit.Location = new System.Drawing.Point(591, -2);
            this.btnexit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(84, 42);
            this.btnexit.TabIndex = 57;
            this.btnexit.Text = "回到選單";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // lbltishi
            // 
            this.lbltishi.AutoSize = true;
            this.lbltishi.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbltishi.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbltishi.Location = new System.Drawing.Point(116, 451);
            this.lbltishi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltishi.Name = "lbltishi";
            this.lbltishi.Size = new System.Drawing.Size(228, 20);
            this.lbltishi.TabIndex = 64;
            this.lbltishi.Text = "Tip:請先更改資料在更新資料！";
            // 
            // pbxlogo
            // 
            this.pbxlogo.BackColor = System.Drawing.Color.Transparent;
            this.pbxlogo.Image = global::PD2020S_Examl_A108222027.Properties.Resources.logo4;
            this.pbxlogo.Location = new System.Drawing.Point(-6, -2);
            this.pbxlogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbxlogo.Name = "pbxlogo";
            this.pbxlogo.Size = new System.Drawing.Size(117, 548);
            this.pbxlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxlogo.TabIndex = 63;
            this.pbxlogo.TabStop = false;
            // 
            // pbxp
            // 
            this.pbxp.Image = ((System.Drawing.Image)(resources.GetObject("pbxp.Image")));
            this.pbxp.Location = new System.Drawing.Point(111, -2);
            this.pbxp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbxp.Name = "pbxp";
            this.pbxp.Size = new System.Drawing.Size(139, 86);
            this.pbxp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxp.TabIndex = 65;
            this.pbxp.TabStop = false;
            // 
            // frmAccountManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 542);
            this.Controls.Add(this.pbxp);
            this.Controls.Add(this.lbltishi);
            this.Controls.Add(this.pbxlogo);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnexit);
            this.Name = "frmAccountManagement";
            this.Text = "AccountManagement";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvaccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxlogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.TextBox tbxname;
        private System.Windows.Forms.Label lblps;
        private System.Windows.Forms.Label lblaccount;
        private System.Windows.Forms.Label lbltip;
        private System.Windows.Forms.Label lbllevel;
        private System.Windows.Forms.ComboBox cbxlevel;
        private System.Windows.Forms.ListBox lbxAccountlist;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.TextBox tbxpss;
        private System.Windows.Forms.TextBox tbxacc;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btndtmodif;
        private System.Windows.Forms.Label lbldtname;
        private System.Windows.Forms.TextBox tbxdtname;
        private System.Windows.Forms.Label lbldtpass;
        private System.Windows.Forms.Label lbldtacc;
        private System.Windows.Forms.Label lbldttip;
        private System.Windows.Forms.Label lbldtpower;
        private System.Windows.Forms.ComboBox cbxdtpower;
        private System.Windows.Forms.Button btndtdel;
        private System.Windows.Forms.Button btndtupdate;
        private System.Windows.Forms.Button btndtinsert;
        private System.Windows.Forms.TextBox tbxdtpass;
        private System.Windows.Forms.TextBox tbxdtacc;
        private System.Windows.Forms.DataGridView dgvaccount;
        private System.Windows.Forms.PictureBox pbxlogo;
        private System.Windows.Forms.Label lbltishi;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.PictureBox pbxp;
    }
}