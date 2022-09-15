namespace PD2020S_Examl_A108222027
{
    partial class selfmanage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(selfmanage));
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.pbxheadselect = new System.Windows.Forms.PictureBox();
            this.pbxhead = new System.Windows.Forms.PictureBox();
            this.btnupdate = new System.Windows.Forms.Button();
            this.pbxacc = new System.Windows.Forms.PictureBox();
            this.pbxname = new System.Windows.Forms.PictureBox();
            this.pbxpass = new System.Windows.Forms.PictureBox();
            this.btnclean = new System.Windows.Forms.Button();
            this.tbxname = new PD2020S_Examl_A108222027.CustomTextBox();
            this.tbxcheckpass = new PD2020S_Examl_A108222027.CustomTextBox();
            this.tbxpass = new PD2020S_Examl_A108222027.CustomTextBox();
            this.tbxacc = new PD2020S_Examl_A108222027.CustomTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxheadselect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxhead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxacc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxpass)).BeginInit();
            this.SuspendLayout();
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // pbxheadselect
            // 
            this.pbxheadselect.BackColor = System.Drawing.Color.Transparent;
            this.pbxheadselect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxheadselect.Image = ((System.Drawing.Image)(resources.GetObject("pbxheadselect.Image")));
            this.pbxheadselect.Location = new System.Drawing.Point(622, 205);
            this.pbxheadselect.Name = "pbxheadselect";
            this.pbxheadselect.Size = new System.Drawing.Size(44, 44);
            this.pbxheadselect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxheadselect.TabIndex = 81;
            this.pbxheadselect.TabStop = false;
            this.pbxheadselect.Click += new System.EventHandler(this.pbxhead_Click);
            // 
            // pbxhead
            // 
            this.pbxhead.BackColor = System.Drawing.Color.Transparent;
            this.pbxhead.Image = ((System.Drawing.Image)(resources.GetObject("pbxhead.Image")));
            this.pbxhead.Location = new System.Drawing.Point(482, 117);
            this.pbxhead.Name = "pbxhead";
            this.pbxhead.Size = new System.Drawing.Size(141, 132);
            this.pbxhead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxhead.TabIndex = 80;
            this.pbxhead.TabStop = false;
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.Transparent;
            this.btnupdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnupdate.BackgroundImage")));
            this.btnupdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnupdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnupdate.FlatAppearance.BorderSize = 0;
            this.btnupdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnupdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnupdate.Location = new System.Drawing.Point(676, 433);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(88, 77);
            this.btnupdate.TabIndex = 19;
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // pbxacc
            // 
            this.pbxacc.BackColor = System.Drawing.Color.Transparent;
            this.pbxacc.Image = ((System.Drawing.Image)(resources.GetObject("pbxacc.Image")));
            this.pbxacc.Location = new System.Drawing.Point(131, 117);
            this.pbxacc.Name = "pbxacc";
            this.pbxacc.Size = new System.Drawing.Size(40, 36);
            this.pbxacc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxacc.TabIndex = 80;
            this.pbxacc.TabStop = false;
            // 
            // pbxname
            // 
            this.pbxname.BackColor = System.Drawing.Color.Transparent;
            this.pbxname.Image = ((System.Drawing.Image)(resources.GetObject("pbxname.Image")));
            this.pbxname.Location = new System.Drawing.Point(134, 310);
            this.pbxname.Name = "pbxname";
            this.pbxname.Size = new System.Drawing.Size(37, 35);
            this.pbxname.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxname.TabIndex = 82;
            this.pbxname.TabStop = false;
            // 
            // pbxpass
            // 
            this.pbxpass.BackColor = System.Drawing.Color.Transparent;
            this.pbxpass.Image = ((System.Drawing.Image)(resources.GetObject("pbxpass.Image")));
            this.pbxpass.Location = new System.Drawing.Point(131, 179);
            this.pbxpass.Name = "pbxpass";
            this.pbxpass.Size = new System.Drawing.Size(40, 35);
            this.pbxpass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxpass.TabIndex = 83;
            this.pbxpass.TabStop = false;
            // 
            // btnclean
            // 
            this.btnclean.BackColor = System.Drawing.Color.Transparent;
            this.btnclean.FlatAppearance.BorderSize = 0;
            this.btnclean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclean.ForeColor = System.Drawing.Color.White;
            this.btnclean.Location = new System.Drawing.Point(609, 109);
            this.btnclean.Name = "btnclean";
            this.btnclean.Size = new System.Drawing.Size(24, 24);
            this.btnclean.TabIndex = 84;
            this.btnclean.Text = "X";
            this.btnclean.UseVisualStyleBackColor = false;
            this.btnclean.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbxname
            // 
            this.tbxname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbxname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxname.BottmBorderFocusColor = System.Drawing.Color.Blue;
            this.tbxname.BottomBorderColor = System.Drawing.Color.Black;
            this.tbxname.BottomFocusOn = "";
            this.tbxname.BottomUnFocus = "Name";
            this.tbxname.FocusTextColor = System.Drawing.Color.Gray;
            this.tbxname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxname.ForeColor = System.Drawing.Color.White;
            this.tbxname.Location = new System.Drawing.Point(193, 310);
            this.tbxname.Name = "tbxname";
            this.tbxname.Size = new System.Drawing.Size(204, 35);
            this.tbxname.TabIndex = 76;
            this.tbxname.Text = "Name";
            this.tbxname.UnfocusTextColor = System.Drawing.Color.Gray;
            // 
            // tbxcheckpass
            // 
            this.tbxcheckpass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbxcheckpass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxcheckpass.BottmBorderFocusColor = System.Drawing.Color.Blue;
            this.tbxcheckpass.BottomBorderColor = System.Drawing.Color.Black;
            this.tbxcheckpass.BottomFocusOn = "";
            this.tbxcheckpass.BottomUnFocus = "CheckPassword";
            this.tbxcheckpass.FocusTextColor = System.Drawing.Color.Gray;
            this.tbxcheckpass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxcheckpass.ForeColor = System.Drawing.Color.White;
            this.tbxcheckpass.Location = new System.Drawing.Point(193, 242);
            this.tbxcheckpass.Name = "tbxcheckpass";
            this.tbxcheckpass.Size = new System.Drawing.Size(204, 35);
            this.tbxcheckpass.TabIndex = 75;
            this.tbxcheckpass.Text = "CheckPassword";
            this.tbxcheckpass.UnfocusTextColor = System.Drawing.Color.Gray;
            // 
            // tbxpass
            // 
            this.tbxpass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbxpass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxpass.BottmBorderFocusColor = System.Drawing.Color.Blue;
            this.tbxpass.BottomBorderColor = System.Drawing.Color.Black;
            this.tbxpass.BottomFocusOn = "";
            this.tbxpass.BottomUnFocus = "Password";
            this.tbxpass.FocusTextColor = System.Drawing.Color.Gray;
            this.tbxpass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxpass.ForeColor = System.Drawing.Color.White;
            this.tbxpass.Location = new System.Drawing.Point(193, 179);
            this.tbxpass.Name = "tbxpass";
            this.tbxpass.Size = new System.Drawing.Size(204, 35);
            this.tbxpass.TabIndex = 74;
            this.tbxpass.Text = "Password";
            this.tbxpass.UnfocusTextColor = System.Drawing.Color.Gray;
            // 
            // tbxacc
            // 
            this.tbxacc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbxacc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxacc.BottmBorderFocusColor = System.Drawing.Color.Blue;
            this.tbxacc.BottomBorderColor = System.Drawing.Color.Black;
            this.tbxacc.BottomFocusOn = "";
            this.tbxacc.BottomUnFocus = "Account";
            this.tbxacc.FocusTextColor = System.Drawing.Color.Gray;
            this.tbxacc.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxacc.ForeColor = System.Drawing.Color.White;
            this.tbxacc.Location = new System.Drawing.Point(193, 117);
            this.tbxacc.Name = "tbxacc";
            this.tbxacc.Size = new System.Drawing.Size(204, 28);
            this.tbxacc.TabIndex = 73;
            this.tbxacc.Text = "Account";
            this.tbxacc.UnfocusTextColor = System.Drawing.Color.Gray;
            // 
            // selfmanage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.btnclean);
            this.Controls.Add(this.pbxpass);
            this.Controls.Add(this.pbxname);
            this.Controls.Add(this.pbxheadselect);
            this.Controls.Add(this.pbxacc);
            this.Controls.Add(this.pbxhead);
            this.Controls.Add(this.tbxname);
            this.Controls.Add(this.tbxcheckpass);
            this.Controls.Add(this.tbxpass);
            this.Controls.Add(this.tbxacc);
            this.Controls.Add(this.btnupdate);
            this.Name = "selfmanage";
            this.Size = new System.Drawing.Size(751, 500);
            ((System.ComponentModel.ISupportInitialize)(this.pbxheadselect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxhead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxacc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxpass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnupdate;
        private CustomTextBox tbxname;
        private CustomTextBox tbxcheckpass;
        private CustomTextBox tbxpass;
        private CustomTextBox tbxacc;
        private System.Windows.Forms.PictureBox pbxhead;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.PictureBox pbxheadselect;
        private System.Windows.Forms.PictureBox pbxacc;
        private System.Windows.Forms.PictureBox pbxname;
        private System.Windows.Forms.PictureBox pbxpass;
        private System.Windows.Forms.Button btnclean;
    }
}
