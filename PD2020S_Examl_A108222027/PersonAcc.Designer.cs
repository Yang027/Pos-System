namespace PD2020S_Examl_A108222027
{
    partial class PersonAcc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonAcc));
            this.pnltop = new System.Windows.Forms.Panel();
            this.lbltitle = new System.Windows.Forms.Label();
            this.pbxlogo = new System.Windows.Forms.PictureBox();
            this.btnclose = new System.Windows.Forms.Button();
            this.pnlleft = new System.Windows.Forms.Panel();
            this.pnlrec = new System.Windows.Forms.Panel();
            this.pnlaccount = new System.Windows.Forms.Panel();
            this.lbltime = new System.Windows.Forms.Label();
            this.btnsalerec = new System.Windows.Forms.Button();
            this.btnproductmanagement = new System.Windows.Forms.Button();
            this.tmrtime = new System.Windows.Forms.Timer(this.components);
            this.btnminizm = new System.Windows.Forms.Button();
            this.pnltop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxlogo)).BeginInit();
            this.pnlleft.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnltop
            // 
            this.pnltop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.pnltop.Controls.Add(this.btnminizm);
            this.pnltop.Controls.Add(this.lbltitle);
            this.pnltop.Controls.Add(this.pbxlogo);
            this.pnltop.Controls.Add(this.btnclose);
            this.pnltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnltop.Location = new System.Drawing.Point(0, 0);
            this.pnltop.Name = "pnltop";
            this.pnltop.Size = new System.Drawing.Size(926, 45);
            this.pnltop.TabIndex = 2;
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.Color.White;
            this.lbltitle.Location = new System.Drawing.Point(54, 22);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(187, 23);
            this.lbltitle.TabIndex = 67;
            this.lbltitle.Text = "AccountMaintence";
            // 
            // pbxlogo
            // 
            this.pbxlogo.BackColor = System.Drawing.Color.Transparent;
            this.pbxlogo.Image = ((System.Drawing.Image)(resources.GetObject("pbxlogo.Image")));
            this.pbxlogo.Location = new System.Drawing.Point(0, 3);
            this.pbxlogo.Name = "pbxlogo";
            this.pbxlogo.Size = new System.Drawing.Size(57, 42);
            this.pbxlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxlogo.TabIndex = 0;
            this.pbxlogo.TabStop = false;
            // 
            // btnclose
            // 
            this.btnclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclose.FlatAppearance.BorderSize = 0;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.White;
            this.btnclose.Location = new System.Drawing.Point(879, 0);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(47, 42);
            this.btnclose.TabIndex = 66;
            this.btnclose.Text = "x";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // pnlleft
            // 
            this.pnlleft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.pnlleft.Controls.Add(this.pnlrec);
            this.pnlleft.Controls.Add(this.pnlaccount);
            this.pnlleft.Controls.Add(this.lbltime);
            this.pnlleft.Controls.Add(this.btnsalerec);
            this.pnlleft.Controls.Add(this.btnproductmanagement);
            this.pnlleft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlleft.Location = new System.Drawing.Point(0, 45);
            this.pnlleft.Name = "pnlleft";
            this.pnlleft.Size = new System.Drawing.Size(178, 498);
            this.pnlleft.TabIndex = 3;
            // 
            // pnlrec
            // 
            this.pnlrec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlrec.Location = new System.Drawing.Point(0, 248);
            this.pnlrec.Name = "pnlrec";
            this.pnlrec.Size = new System.Drawing.Size(17, 79);
            this.pnlrec.TabIndex = 65;
            this.pnlrec.Visible = false;
            // 
            // pnlaccount
            // 
            this.pnlaccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlaccount.Location = new System.Drawing.Point(0, 101);
            this.pnlaccount.Name = "pnlaccount";
            this.pnlaccount.Size = new System.Drawing.Size(17, 79);
            this.pnlaccount.TabIndex = 65;
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltime.ForeColor = System.Drawing.Color.White;
            this.lbltime.Location = new System.Drawing.Point(41, 22);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(70, 23);
            this.lbltime.TabIndex = 64;
            this.lbltime.Text = "label1";
            // 
            // btnsalerec
            // 
            this.btnsalerec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsalerec.FlatAppearance.BorderSize = 0;
            this.btnsalerec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalerec.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalerec.ForeColor = System.Drawing.Color.White;
            this.btnsalerec.Image = ((System.Drawing.Image)(resources.GetObject("btnsalerec.Image")));
            this.btnsalerec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsalerec.Location = new System.Drawing.Point(6, 248);
            this.btnsalerec.Name = "btnsalerec";
            this.btnsalerec.Size = new System.Drawing.Size(177, 79);
            this.btnsalerec.TabIndex = 1;
            this.btnsalerec.Text = "             銷售記錄";
            this.btnsalerec.UseVisualStyleBackColor = true;
            this.btnsalerec.Click += new System.EventHandler(this.btnsalerec_Click);
            // 
            // btnproductmanagement
            // 
            this.btnproductmanagement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnproductmanagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnproductmanagement.FlatAppearance.BorderSize = 0;
            this.btnproductmanagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnproductmanagement.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnproductmanagement.ForeColor = System.Drawing.Color.White;
            this.btnproductmanagement.Image = ((System.Drawing.Image)(resources.GetObject("btnproductmanagement.Image")));
            this.btnproductmanagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnproductmanagement.Location = new System.Drawing.Point(3, 101);
            this.btnproductmanagement.Name = "btnproductmanagement";
            this.btnproductmanagement.Size = new System.Drawing.Size(177, 79);
            this.btnproductmanagement.TabIndex = 1;
            this.btnproductmanagement.Text = "             賬號管理";
            this.btnproductmanagement.UseVisualStyleBackColor = true;
            this.btnproductmanagement.Click += new System.EventHandler(this.btnproductmanagement_Click);
            // 
            // tmrtime
            // 
            this.tmrtime.Tick += new System.EventHandler(this.tmrtime_Tick);
            // 
            // btnminizm
            // 
            this.btnminizm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnminizm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnminizm.FlatAppearance.BorderSize = 0;
            this.btnminizm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnminizm.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnminizm.ForeColor = System.Drawing.Color.White;
            this.btnminizm.Location = new System.Drawing.Point(833, 3);
            this.btnminizm.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnminizm.Name = "btnminizm";
            this.btnminizm.Size = new System.Drawing.Size(47, 42);
            this.btnminizm.TabIndex = 69;
            this.btnminizm.Text = "一";
            this.btnminizm.UseVisualStyleBackColor = false;
            this.btnminizm.Click += new System.EventHandler(this.btnminizm_Click);
            // 
            // PersonAcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 543);
            this.Controls.Add(this.pnlleft);
            this.Controls.Add(this.pnltop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PersonAcc";
            this.Text = "PersonAcc";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moving);
            this.pnltop.ResumeLayout(false);
            this.pnltop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxlogo)).EndInit();
            this.pnlleft.ResumeLayout(false);
            this.pnlleft.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnltop;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Panel pnlleft;
        private System.Windows.Forms.PictureBox pbxlogo;
        private System.Windows.Forms.Panel pnlrec;
        private System.Windows.Forms.Panel pnlaccount;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Button btnsalerec;
        private System.Windows.Forms.Button btnproductmanagement;
        private System.Windows.Forms.Timer tmrtime;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Button btnminizm;
    }
}