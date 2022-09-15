namespace PD2020S_Examl_A108222027
{
    partial class Normaltime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Normaltime));
            this.lbltip = new System.Windows.Forms.Label();
            this.btnorder = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.cbxchange = new System.Windows.Forms.ComboBox();
            this.flpanel = new System.Windows.Forms.FlowLayoutPanel();
            this.tmrchange = new System.Windows.Forms.Timer(this.components);
            this.lbldate = new System.Windows.Forms.Label();
            this.tbxdate = new System.Windows.Forms.TextBox();
            this.tbxcashier = new System.Windows.Forms.TextBox();
            this.lblcrashier = new System.Windows.Forms.Label();
            this.pbxlogo = new System.Windows.Forms.PictureBox();
            this.sfdsavebil = new System.Windows.Forms.SaveFileDialog();
            this.pbxadv = new System.Windows.Forms.PictureBox();
            this.btnexit = new System.Windows.Forms.Button();
            this.cbxhangout = new System.Windows.Forms.CheckBox();
            this.cbxdiscount = new System.Windows.Forms.CheckBox();
            this.lbxshoppingcar1 = new System.Windows.Forms.ListBox();
            this.lblrefresh = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnsave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxlogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxadv)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltip
            // 
            this.lbltip.AutoSize = true;
            this.lbltip.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbltip.Location = new System.Drawing.Point(11, 280);
            this.lbltip.Name = "lbltip";
            this.lbltip.Size = new System.Drawing.Size(105, 25);
            this.lbltip.TabIndex = 24;
            this.lbltip.Text = "單點/套餐:";
            // 
            // btnorder
            // 
            this.btnorder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnorder.BackgroundImage")));
            this.btnorder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnorder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnorder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnorder.FlatAppearance.BorderSize = 0;
            this.btnorder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnorder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnorder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnorder.Font = new System.Drawing.Font("PMingLiU", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnorder.ForeColor = System.Drawing.Color.Transparent;
            this.btnorder.Location = new System.Drawing.Point(1331, 897);
            this.btnorder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnorder.Name = "btnorder";
            this.btnorder.Size = new System.Drawing.Size(90, 61);
            this.btnorder.TabIndex = 23;
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
            this.btndel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btndel.FlatAppearance.BorderSize = 0;
            this.btndel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btndel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btndel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndel.ForeColor = System.Drawing.Color.Transparent;
            this.btndel.Location = new System.Drawing.Point(1107, 897);
            this.btndel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(90, 61);
            this.btndel.TabIndex = 22;
            this.toolTip1.SetToolTip(this.btndel, "刪除商品");
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // cbxchange
            // 
            this.cbxchange.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbxchange.FormattingEnabled = true;
            this.cbxchange.Items.AddRange(new object[] {
            "單點",
            "套餐"});
            this.cbxchange.Location = new System.Drawing.Point(131, 278);
            this.cbxchange.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxchange.Name = "cbxchange";
            this.cbxchange.Size = new System.Drawing.Size(177, 33);
            this.cbxchange.TabIndex = 21;
            this.cbxchange.SelectedIndexChanged += new System.EventHandler(this.cbxchange_SelectedIndexChanged);
            // 
            // flpanel
            // 
            this.flpanel.AutoScroll = true;
            this.flpanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flpanel.Location = new System.Drawing.Point(12, 318);
            this.flpanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flpanel.Name = "flpanel";
            this.flpanel.Size = new System.Drawing.Size(975, 640);
            this.flpanel.TabIndex = 16;
            // 
            // tmrchange
            // 
            this.tmrchange.Interval = 1000;
            this.tmrchange.Tick += new System.EventHandler(this.tmrchange_Tick);
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbldate.Location = new System.Drawing.Point(55, 242);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(57, 25);
            this.lbldate.TabIndex = 29;
            this.lbldate.Text = "日期:";
            // 
            // tbxdate
            // 
            this.tbxdate.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbxdate.Location = new System.Drawing.Point(131, 231);
            this.tbxdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxdate.Name = "tbxdate";
            this.tbxdate.ReadOnly = true;
            this.tbxdate.Size = new System.Drawing.Size(209, 34);
            this.tbxdate.TabIndex = 28;
            // 
            // tbxcashier
            // 
            this.tbxcashier.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbxcashier.Location = new System.Drawing.Point(131, 182);
            this.tbxcashier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxcashier.Name = "tbxcashier";
            this.tbxcashier.ReadOnly = true;
            this.tbxcashier.Size = new System.Drawing.Size(177, 34);
            this.tbxcashier.TabIndex = 27;
            // 
            // lblcrashier
            // 
            this.lblcrashier.AutoSize = true;
            this.lblcrashier.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblcrashier.Location = new System.Drawing.Point(35, 194);
            this.lblcrashier.Name = "lblcrashier";
            this.lblcrashier.Size = new System.Drawing.Size(77, 25);
            this.lblcrashier.TabIndex = 26;
            this.lblcrashier.Text = "結賬員:";
            // 
            // pbxlogo
            // 
            this.pbxlogo.Image = ((System.Drawing.Image)(resources.GetObject("pbxlogo.Image")));
            this.pbxlogo.Location = new System.Drawing.Point(-43, -18);
            this.pbxlogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbxlogo.Name = "pbxlogo";
            this.pbxlogo.Size = new System.Drawing.Size(284, 231);
            this.pbxlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxlogo.TabIndex = 20;
            this.pbxlogo.TabStop = false;
            // 
            // pbxadv
            // 
            this.pbxadv.Image = ((System.Drawing.Image)(resources.GetObject("pbxadv.Image")));
            this.pbxadv.Location = new System.Drawing.Point(380, 1);
            this.pbxadv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbxadv.Name = "pbxadv";
            this.pbxadv.Size = new System.Drawing.Size(1043, 311);
            this.pbxadv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxadv.TabIndex = 30;
            this.pbxadv.TabStop = false;
            // 
            // btnexit
            // 
            this.btnexit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnexit.BackgroundImage")));
            this.btnexit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnexit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnexit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnexit.FlatAppearance.BorderSize = 0;
            this.btnexit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnexit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexit.ForeColor = System.Drawing.Color.Transparent;
            this.btnexit.Location = new System.Drawing.Point(993, 897);
            this.btnexit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(90, 61);
            this.btnexit.TabIndex = 33;
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
            this.cbxhangout.TabIndex = 34;
            this.cbxhangout.Text = "外帶";
            this.cbxhangout.UseVisualStyleBackColor = true;
            this.cbxhangout.CheckedChanged += new System.EventHandler(this.cbxhangout_CheckedChanged);
            // 
            // cbxdiscount
            // 
            this.cbxdiscount.AutoSize = true;
            this.cbxdiscount.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbxdiscount.Location = new System.Drawing.Point(248, 49);
            this.cbxdiscount.Margin = new System.Windows.Forms.Padding(4);
            this.cbxdiscount.Name = "cbxdiscount";
            this.cbxdiscount.Size = new System.Drawing.Size(94, 29);
            this.cbxdiscount.TabIndex = 35;
            this.cbxdiscount.Text = "甜心卡";
            this.cbxdiscount.UseVisualStyleBackColor = true;
            this.cbxdiscount.CheckedChanged += new System.EventHandler(this.cbxdiscount_CheckedChanged);
            // 
            // lbxshoppingcar1
            // 
            this.lbxshoppingcar1.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbxshoppingcar1.FormattingEnabled = true;
            this.lbxshoppingcar1.ItemHeight = 25;
            this.lbxshoppingcar1.Location = new System.Drawing.Point(993, 339);
            this.lbxshoppingcar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbxshoppingcar1.Name = "lbxshoppingcar1";
            this.lbxshoppingcar1.Size = new System.Drawing.Size(428, 554);
            this.lbxshoppingcar1.TabIndex = 0;
            // 
            // lblrefresh
            // 
            this.lblrefresh.AutoSize = true;
            this.lblrefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblrefresh.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblrefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblrefresh.Location = new System.Drawing.Point(1332, 314);
            this.lblrefresh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblrefresh.Name = "lblrefresh";
            this.lblrefresh.Size = new System.Drawing.Size(89, 20);
            this.lblrefresh.TabIndex = 37;
            this.lblrefresh.Text = "重新選擇";
            this.lblrefresh.Click += new System.EventHandler(this.lblrefresh_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsave.BackgroundImage")));
            this.btnsave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsave.Location = new System.Drawing.Point(1219, 897);
            this.btnsave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(90, 61);
            this.btnsave.TabIndex = 111;
            this.toolTip1.SetToolTip(this.btnsave, "保存交易");
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // Normaltime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1424, 961);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.lblrefresh);
            this.Controls.Add(this.lbxshoppingcar1);
            this.Controls.Add(this.cbxdiscount);
            this.Controls.Add(this.cbxhangout);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.pbxadv);
            this.Controls.Add(this.lbltip);
            this.Controls.Add(this.btnorder);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.cbxchange);
            this.Controls.Add(this.flpanel);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.tbxdate);
            this.Controls.Add(this.tbxcashier);
            this.Controls.Add(this.lblcrashier);
            this.Controls.Add(this.pbxlogo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Normaltime";
            this.Text = "Normaltime";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.save);
            ((System.ComponentModel.ISupportInitialize)(this.pbxlogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxadv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltip;
        private System.Windows.Forms.Button btnorder;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.ComboBox cbxchange;
        private System.Windows.Forms.FlowLayoutPanel flpanel;
        private System.Windows.Forms.Timer tmrchange;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.TextBox tbxdate;
        private System.Windows.Forms.TextBox tbxcashier;
        private System.Windows.Forms.Label lblcrashier;
        private System.Windows.Forms.PictureBox pbxlogo;
        private System.Windows.Forms.SaveFileDialog sfdsavebil;
        private System.Windows.Forms.PictureBox pbxadv;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.CheckBox cbxhangout;
        private System.Windows.Forms.CheckBox cbxdiscount;
        private System.Windows.Forms.ListBox lbxshoppingcar1;
        private System.Windows.Forms.Label lblrefresh;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnsave;
    }
}