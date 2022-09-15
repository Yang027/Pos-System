namespace PD2020S_Examl_A108222027
{
    partial class breakfast
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(breakfast));
            this.flpanel = new System.Windows.Forms.FlowLayoutPanel();
            this.lbxshoppingcar1 = new System.Windows.Forms.ListBox();
            this.cbxchange = new System.Windows.Forms.ComboBox();
            this.lbltip = new System.Windows.Forms.Label();
            this.tmrchange = new System.Windows.Forms.Timer(this.components);
            this.lblcrashier = new System.Windows.Forms.Label();
            this.tbxcashier = new System.Windows.Forms.TextBox();
            this.tbxdate = new System.Windows.Forms.TextBox();
            this.lbldate = new System.Windows.Forms.Label();
            this.sfdsavebil = new System.Windows.Forms.SaveFileDialog();
            this.pbxadvp = new System.Windows.Forms.PictureBox();
            this.btnorder = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.pbxlogo = new System.Windows.Forms.PictureBox();
            this.btnexit = new System.Windows.Forms.Button();
            this.cbxhangout = new System.Windows.Forms.CheckBox();
            this.lblrefresh = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnsave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxadvp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxlogo)).BeginInit();
            this.SuspendLayout();
            // 
            // flpanel
            // 
            this.flpanel.AutoScroll = true;
            this.flpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpanel.Location = new System.Drawing.Point(12, 310);
            this.flpanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flpanel.Name = "flpanel";
            this.flpanel.Size = new System.Drawing.Size(975, 650);
            this.flpanel.TabIndex = 0;
            // 
            // lbxshoppingcar1
            // 
            this.lbxshoppingcar1.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbxshoppingcar1.FormattingEnabled = true;
            this.lbxshoppingcar1.ItemHeight = 20;
            this.lbxshoppingcar1.Location = new System.Drawing.Point(995, 332);
            this.lbxshoppingcar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbxshoppingcar1.Name = "lbxshoppingcar1";
            this.lbxshoppingcar1.Size = new System.Drawing.Size(428, 564);
            this.lbxshoppingcar1.TabIndex = 3;
            this.lbxshoppingcar1.SelectedIndexChanged += new System.EventHandler(this.select);
            // 
            // cbxchange
            // 
            this.cbxchange.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbxchange.FormattingEnabled = true;
            this.cbxchange.Items.AddRange(new object[] {
            "單點",
            "套餐"});
            this.cbxchange.Location = new System.Drawing.Point(111, 266);
            this.cbxchange.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxchange.Name = "cbxchange";
            this.cbxchange.Size = new System.Drawing.Size(177, 28);
            this.cbxchange.TabIndex = 6;
            this.cbxchange.SelectedIndexChanged += new System.EventHandler(this.cbxchange_SelectedIndexChanged);
            // 
            // lbltip
            // 
            this.lbltip.AutoSize = true;
            this.lbltip.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbltip.Location = new System.Drawing.Point(0, 274);
            this.lbltip.Name = "lbltip";
            this.lbltip.Size = new System.Drawing.Size(94, 20);
            this.lbltip.TabIndex = 10;
            this.lbltip.Text = "單點/套餐";
            // 
            // tmrchange
            // 
            this.tmrchange.Interval = 1000;
            this.tmrchange.Tick += new System.EventHandler(this.tmrchange_Tick);
            // 
            // lblcrashier
            // 
            this.lblcrashier.AutoSize = true;
            this.lblcrashier.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblcrashier.Location = new System.Drawing.Point(16, 182);
            this.lblcrashier.Name = "lblcrashier";
            this.lblcrashier.Size = new System.Drawing.Size(74, 20);
            this.lblcrashier.TabIndex = 12;
            this.lblcrashier.Text = "結賬員:";
            // 
            // tbxcashier
            // 
            this.tbxcashier.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbxcashier.Location = new System.Drawing.Point(111, 172);
            this.tbxcashier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxcashier.Name = "tbxcashier";
            this.tbxcashier.ReadOnly = true;
            this.tbxcashier.Size = new System.Drawing.Size(177, 31);
            this.tbxcashier.TabIndex = 13;
            // 
            // tbxdate
            // 
            this.tbxdate.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbxdate.Location = new System.Drawing.Point(111, 219);
            this.tbxdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxdate.Name = "tbxdate";
            this.tbxdate.ReadOnly = true;
            this.tbxdate.Size = new System.Drawing.Size(203, 31);
            this.tbxdate.TabIndex = 14;
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbldate.Location = new System.Drawing.Point(36, 230);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(54, 20);
            this.lbldate.TabIndex = 15;
            this.lbldate.Text = "日期:";
            // 
            // pbxadvp
            // 
            this.pbxadvp.Image = global::PD2020S_Examl_A108222027.Properties.Resources.bk10;
            this.pbxadvp.Location = new System.Drawing.Point(407, 1);
            this.pbxadvp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbxadvp.Name = "pbxadvp";
            this.pbxadvp.Size = new System.Drawing.Size(1016, 304);
            this.pbxadvp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxadvp.TabIndex = 11;
            this.pbxadvp.TabStop = false;
            // 
            // btnorder
            // 
            this.btnorder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnorder.BackgroundImage")));
            this.btnorder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnorder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnorder.FlatAppearance.BorderSize = 0;
            this.btnorder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnorder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnorder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnorder.Font = new System.Drawing.Font("PMingLiU", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnorder.Location = new System.Drawing.Point(1333, 899);
            this.btnorder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnorder.Name = "btnorder";
            this.btnorder.Size = new System.Drawing.Size(90, 61);
            this.btnorder.TabIndex = 8;
            this.btnorder.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btnorder, "確認購買");
            this.btnorder.UseVisualStyleBackColor = true;
            this.btnorder.Click += new System.EventHandler(this.btnorder_Click);
            // 
            // btndel
            // 
            this.btndel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btndel.BackgroundImage")));
            this.btndel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btndel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndel.FlatAppearance.BorderSize = 0;
            this.btndel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btndel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btndel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndel.Location = new System.Drawing.Point(1105, 899);
            this.btndel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(90, 61);
            this.btndel.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btndel, "刪除商品");
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // pbxlogo
            // 
            this.pbxlogo.Image = ((System.Drawing.Image)(resources.GetObject("pbxlogo.Image")));
            this.pbxlogo.Location = new System.Drawing.Point(-43, -18);
            this.pbxlogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbxlogo.Name = "pbxlogo";
            this.pbxlogo.Size = new System.Drawing.Size(284, 231);
            this.pbxlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxlogo.TabIndex = 4;
            this.pbxlogo.TabStop = false;
            // 
            // btnexit
            // 
            this.btnexit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnexit.BackgroundImage")));
            this.btnexit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnexit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnexit.FlatAppearance.BorderSize = 0;
            this.btnexit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnexit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexit.Location = new System.Drawing.Point(993, 900);
            this.btnexit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(90, 61);
            this.btnexit.TabIndex = 34;
            this.toolTip1.SetToolTip(this.btnexit, "返回時段選擇");
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // cbxhangout
            // 
            this.cbxhangout.AutoSize = true;
            this.cbxhangout.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbxhangout.Location = new System.Drawing.Point(248, 102);
            this.cbxhangout.Margin = new System.Windows.Forms.Padding(4);
            this.cbxhangout.Name = "cbxhangout";
            this.cbxhangout.Size = new System.Drawing.Size(74, 29);
            this.cbxhangout.TabIndex = 35;
            this.cbxhangout.Text = "外帶";
            this.cbxhangout.UseVisualStyleBackColor = true;
            this.cbxhangout.CheckedChanged += new System.EventHandler(this.cbxhangout_CheckedChanged);
            // 
            // lblrefresh
            // 
            this.lblrefresh.AutoSize = true;
            this.lblrefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblrefresh.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblrefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblrefresh.Location = new System.Drawing.Point(1327, 310);
            this.lblrefresh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblrefresh.Name = "lblrefresh";
            this.lblrefresh.Size = new System.Drawing.Size(89, 20);
            this.lblrefresh.TabIndex = 36;
            this.lblrefresh.Text = "重新選擇";
            this.lblrefresh.Click += new System.EventHandler(this.lblrefresh_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsave.BackgroundImage")));
            this.btnsave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsave.Location = new System.Drawing.Point(1223, 899);
            this.btnsave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(90, 61);
            this.btnsave.TabIndex = 112;
            this.toolTip1.SetToolTip(this.btnsave, "保存交易");
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // breakfast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1424, 961);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.lblrefresh);
            this.Controls.Add(this.cbxhangout);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.tbxdate);
            this.Controls.Add(this.tbxcashier);
            this.Controls.Add(this.lblcrashier);
            this.Controls.Add(this.pbxadvp);
            this.Controls.Add(this.lbltip);
            this.Controls.Add(this.btnorder);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.cbxchange);
            this.Controls.Add(this.pbxlogo);
            this.Controls.Add(this.lbxshoppingcar1);
            this.Controls.Add(this.flpanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "breakfast";
            this.Text = "breakfast";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.save);
            ((System.ComponentModel.ISupportInitialize)(this.pbxadvp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxlogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpanel;
        private System.Windows.Forms.ListBox lbxshoppingcar1;
        private System.Windows.Forms.PictureBox pbxlogo;
        private System.Windows.Forms.ComboBox cbxchange;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button btnorder;
        private System.Windows.Forms.Label lbltip;
        private System.Windows.Forms.Timer tmrchange;
        private System.Windows.Forms.PictureBox pbxadvp;
        private System.Windows.Forms.Label lblcrashier;
        private System.Windows.Forms.TextBox tbxcashier;
        private System.Windows.Forms.TextBox tbxdate;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.SaveFileDialog sfdsavebil;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.CheckBox cbxhangout;
        private System.Windows.Forms.Label lblrefresh;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnsave;
    }
}