namespace PD2020S_Examl_A108222027
{
    partial class SaleRec
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaleRec));
            this.btnall = new System.Windows.Forms.Button();
            this.lblchoicedate = new System.Windows.Forms.Label();
            this.datetimepick = new System.Windows.Forms.DateTimePicker();
            this.lbldetail = new System.Windows.Forms.Label();
            this.lbltranaction = new System.Windows.Forms.Label();
            this.dgvdetail = new System.Windows.Forms.DataGridView();
            this.dgvtransaction = new System.Windows.Forms.DataGridView();
            this.tbxcashier = new PD2020S_Examl_A108222027.CustomTextBox();
            this.tbxdate = new PD2020S_Examl_A108222027.CustomTextBox();
            this.tbxsum = new PD2020S_Examl_A108222027.CustomTextBox();
            this.tbxhang = new PD2020S_Examl_A108222027.CustomTextBox();
            this.pbxpackage = new System.Windows.Forms.PictureBox();
            this.pbxmoney = new System.Windows.Forms.PictureBox();
            this.pbxdate = new System.Windows.Forms.PictureBox();
            this.pbxcashier = new System.Windows.Forms.PictureBox();
            this.btnfind = new System.Windows.Forms.Button();
            this.cbxhangout = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtransaction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxpackage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxmoney)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxcashier)).BeginInit();
            this.SuspendLayout();
            // 
            // btnall
            // 
            this.btnall.Location = new System.Drawing.Point(361, 16);
            this.btnall.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnall.Name = "btnall";
            this.btnall.Size = new System.Drawing.Size(156, 38);
            this.btnall.TabIndex = 45;
            this.btnall.Text = "查詢全部訂單";
            this.btnall.UseVisualStyleBackColor = true;
            this.btnall.Click += new System.EventHandler(this.btnall_Click);
            // 
            // lblchoicedate
            // 
            this.lblchoicedate.AutoSize = true;
            this.lblchoicedate.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblchoicedate.Location = new System.Drawing.Point(589, 31);
            this.lblchoicedate.Name = "lblchoicedate";
            this.lblchoicedate.Size = new System.Drawing.Size(97, 25);
            this.lblchoicedate.TabIndex = 43;
            this.lblchoicedate.Text = "查詢日期:";
            // 
            // datetimepick
            // 
            this.datetimepick.CalendarMonthBackground = System.Drawing.Color.White;
            this.datetimepick.CustomFormat = "";
            this.datetimepick.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetimepick.Location = new System.Drawing.Point(715, 31);
            this.datetimepick.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datetimepick.Name = "datetimepick";
            this.datetimepick.Size = new System.Drawing.Size(129, 25);
            this.datetimepick.TabIndex = 42;
            // 
            // lbldetail
            // 
            this.lbldetail.AutoSize = true;
            this.lbldetail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldetail.Location = new System.Drawing.Point(47, 350);
            this.lbldetail.Name = "lbldetail";
            this.lbldetail.Size = new System.Drawing.Size(95, 23);
            this.lbldetail.TabIndex = 38;
            this.lbldetail.Text = "交易詳情:";
            this.lbldetail.Visible = false;
            // 
            // lbltranaction
            // 
            this.lbltranaction.AutoSize = true;
            this.lbltranaction.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltranaction.Location = new System.Drawing.Point(56, 28);
            this.lbltranaction.Name = "lbltranaction";
            this.lbltranaction.Size = new System.Drawing.Size(95, 23);
            this.lbltranaction.TabIndex = 31;
            this.lbltranaction.Text = "交易記錄:";
            // 
            // dgvdetail
            // 
            this.dgvdetail.AllowUserToAddRows = false;
            this.dgvdetail.AllowUserToDeleteRows = false;
            this.dgvdetail.AllowUserToResizeColumns = false;
            this.dgvdetail.AllowUserToResizeRows = false;
            this.dgvdetail.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvdetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdetail.Location = new System.Drawing.Point(27, 379);
            this.dgvdetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvdetail.Name = "dgvdetail";
            this.dgvdetail.ReadOnly = true;
            this.dgvdetail.RowTemplate.Height = 27;
            this.dgvdetail.Size = new System.Drawing.Size(947, 302);
            this.dgvdetail.TabIndex = 30;
            this.dgvdetail.Visible = false;
            // 
            // dgvtransaction
            // 
            this.dgvtransaction.AllowUserToAddRows = false;
            this.dgvtransaction.AllowUserToDeleteRows = false;
            this.dgvtransaction.AllowUserToResizeColumns = false;
            this.dgvtransaction.AllowUserToResizeRows = false;
            this.dgvtransaction.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvtransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtransaction.Location = new System.Drawing.Point(29, 61);
            this.dgvtransaction.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvtransaction.Name = "dgvtransaction";
            this.dgvtransaction.ReadOnly = true;
            this.dgvtransaction.RowTemplate.Height = 27;
            this.dgvtransaction.Size = new System.Drawing.Size(488, 288);
            this.dgvtransaction.TabIndex = 29;
            this.dgvtransaction.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.expand);
            // 
            // tbxcashier
            // 
            this.tbxcashier.BackColor = System.Drawing.SystemColors.Control;
            this.tbxcashier.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxcashier.BottmBorderFocusColor = System.Drawing.Color.Blue;
            this.tbxcashier.BottomBorderColor = System.Drawing.Color.Black;
            this.tbxcashier.BottomFocusOn = "";
            this.tbxcashier.BottomUnFocus = "";
            this.tbxcashier.FocusTextColor = System.Drawing.Color.Gray;
            this.tbxcashier.ForeColor = System.Drawing.Color.Gray;
            this.tbxcashier.Location = new System.Drawing.Point(708, 88);
            this.tbxcashier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxcashier.Name = "tbxcashier";
            this.tbxcashier.ReadOnly = true;
            this.tbxcashier.Size = new System.Drawing.Size(136, 32);
            this.tbxcashier.TabIndex = 47;
            this.tbxcashier.UnfocusTextColor = System.Drawing.Color.Gray;
            // 
            // tbxdate
            // 
            this.tbxdate.BackColor = System.Drawing.SystemColors.Control;
            this.tbxdate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxdate.BottmBorderFocusColor = System.Drawing.Color.Blue;
            this.tbxdate.BottomBorderColor = System.Drawing.Color.Black;
            this.tbxdate.BottomFocusOn = "";
            this.tbxdate.BottomUnFocus = "";
            this.tbxdate.FocusTextColor = System.Drawing.Color.Gray;
            this.tbxdate.ForeColor = System.Drawing.Color.Gray;
            this.tbxdate.Location = new System.Drawing.Point(708, 166);
            this.tbxdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxdate.Name = "tbxdate";
            this.tbxdate.ReadOnly = true;
            this.tbxdate.Size = new System.Drawing.Size(257, 32);
            this.tbxdate.TabIndex = 47;
            this.tbxdate.UnfocusTextColor = System.Drawing.Color.Gray;
            // 
            // tbxsum
            // 
            this.tbxsum.BackColor = System.Drawing.SystemColors.Control;
            this.tbxsum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxsum.BottmBorderFocusColor = System.Drawing.Color.Blue;
            this.tbxsum.BottomBorderColor = System.Drawing.Color.Black;
            this.tbxsum.BottomFocusOn = "";
            this.tbxsum.BottomUnFocus = "";
            this.tbxsum.FocusTextColor = System.Drawing.Color.Gray;
            this.tbxsum.ForeColor = System.Drawing.Color.Gray;
            this.tbxsum.Location = new System.Drawing.Point(708, 250);
            this.tbxsum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxsum.Name = "tbxsum";
            this.tbxsum.ReadOnly = true;
            this.tbxsum.Size = new System.Drawing.Size(100, 32);
            this.tbxsum.TabIndex = 47;
            this.tbxsum.UnfocusTextColor = System.Drawing.Color.Gray;
            // 
            // tbxhang
            // 
            this.tbxhang.BackColor = System.Drawing.SystemColors.Control;
            this.tbxhang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxhang.BottmBorderFocusColor = System.Drawing.Color.Blue;
            this.tbxhang.BottomBorderColor = System.Drawing.Color.Black;
            this.tbxhang.BottomFocusOn = "";
            this.tbxhang.BottomUnFocus = "";
            this.tbxhang.FocusTextColor = System.Drawing.Color.Gray;
            this.tbxhang.ForeColor = System.Drawing.Color.Gray;
            this.tbxhang.Location = new System.Drawing.Point(708, 315);
            this.tbxhang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxhang.Name = "tbxhang";
            this.tbxhang.ReadOnly = true;
            this.tbxhang.Size = new System.Drawing.Size(100, 32);
            this.tbxhang.TabIndex = 47;
            this.tbxhang.UnfocusTextColor = System.Drawing.Color.Gray;
            // 
            // pbxpackage
            // 
            this.pbxpackage.Image = ((System.Drawing.Image)(resources.GetObject("pbxpackage.Image")));
            this.pbxpackage.Location = new System.Drawing.Point(605, 302);
            this.pbxpackage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbxpackage.Name = "pbxpackage";
            this.pbxpackage.Size = new System.Drawing.Size(65, 45);
            this.pbxpackage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxpackage.TabIndex = 46;
            this.pbxpackage.TabStop = false;
            // 
            // pbxmoney
            // 
            this.pbxmoney.Image = ((System.Drawing.Image)(resources.GetObject("pbxmoney.Image")));
            this.pbxmoney.Location = new System.Drawing.Point(605, 238);
            this.pbxmoney.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbxmoney.Name = "pbxmoney";
            this.pbxmoney.Size = new System.Drawing.Size(65, 45);
            this.pbxmoney.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxmoney.TabIndex = 46;
            this.pbxmoney.TabStop = false;
            // 
            // pbxdate
            // 
            this.pbxdate.Image = ((System.Drawing.Image)(resources.GetObject("pbxdate.Image")));
            this.pbxdate.Location = new System.Drawing.Point(605, 154);
            this.pbxdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbxdate.Name = "pbxdate";
            this.pbxdate.Size = new System.Drawing.Size(65, 45);
            this.pbxdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxdate.TabIndex = 46;
            this.pbxdate.TabStop = false;
            // 
            // pbxcashier
            // 
            this.pbxcashier.Image = ((System.Drawing.Image)(resources.GetObject("pbxcashier.Image")));
            this.pbxcashier.Location = new System.Drawing.Point(605, 76);
            this.pbxcashier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbxcashier.Name = "pbxcashier";
            this.pbxcashier.Size = new System.Drawing.Size(65, 45);
            this.pbxcashier.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxcashier.TabIndex = 46;
            this.pbxcashier.TabStop = false;
            // 
            // btnfind
            // 
            this.btnfind.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnfind.BackgroundImage")));
            this.btnfind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnfind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnfind.FlatAppearance.BorderSize = 0;
            this.btnfind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfind.Location = new System.Drawing.Point(865, 18);
            this.btnfind.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnfind.Name = "btnfind";
            this.btnfind.Size = new System.Drawing.Size(68, 48);
            this.btnfind.TabIndex = 44;
            this.btnfind.UseVisualStyleBackColor = true;
            this.btnfind.Click += new System.EventHandler(this.btnfind_Click);
            // 
            // cbxhangout
            // 
            this.cbxhangout.AutoSize = true;
            this.cbxhangout.Location = new System.Drawing.Point(524, 38);
            this.cbxhangout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxhangout.Name = "cbxhangout";
            this.cbxhangout.Size = new System.Drawing.Size(59, 19);
            this.cbxhangout.TabIndex = 48;
            this.cbxhangout.Text = "外帶";
            this.cbxhangout.UseVisualStyleBackColor = true;
            this.cbxhangout.CheckedChanged += new System.EventHandler(this.cbxhangout_CheckedChanged);
            // 
            // SaleRec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbxhangout);
            this.Controls.Add(this.tbxhang);
            this.Controls.Add(this.tbxsum);
            this.Controls.Add(this.tbxdate);
            this.Controls.Add(this.tbxcashier);
            this.Controls.Add(this.pbxpackage);
            this.Controls.Add(this.pbxmoney);
            this.Controls.Add(this.pbxdate);
            this.Controls.Add(this.pbxcashier);
            this.Controls.Add(this.btnall);
            this.Controls.Add(this.btnfind);
            this.Controls.Add(this.lblchoicedate);
            this.Controls.Add(this.datetimepick);
            this.Controls.Add(this.lbldetail);
            this.Controls.Add(this.lbltranaction);
            this.Controls.Add(this.dgvdetail);
            this.Controls.Add(this.dgvtransaction);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SaleRec";
            this.Size = new System.Drawing.Size(1005, 689);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtransaction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxpackage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxmoney)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxcashier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnall;
        private System.Windows.Forms.Button btnfind;
        private System.Windows.Forms.Label lblchoicedate;
        private System.Windows.Forms.DateTimePicker datetimepick;
        private System.Windows.Forms.Label lbldetail;
        private System.Windows.Forms.Label lbltranaction;
        private System.Windows.Forms.DataGridView dgvdetail;
        private System.Windows.Forms.DataGridView dgvtransaction;
        private System.Windows.Forms.PictureBox pbxcashier;
        private System.Windows.Forms.PictureBox pbxdate;
        private System.Windows.Forms.PictureBox pbxmoney;
        private System.Windows.Forms.PictureBox pbxpackage;
        private CustomTextBox tbxcashier;
        private CustomTextBox tbxdate;
        private CustomTextBox tbxsum;
        private CustomTextBox tbxhang;
        private System.Windows.Forms.CheckBox cbxhangout;
    }
}
