namespace PD2020S_Examl_A108222027
{
    partial class empolyeesystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(empolyeesystem));
            this.pnltop = new System.Windows.Forms.Panel();
            this.lbltime = new System.Windows.Forms.Label();
            this.lbltitle = new System.Windows.Forms.Label();
            this.pbxlogo = new System.Windows.Forms.PictureBox();
            this.btnclose = new System.Windows.Forms.Button();
            this.tmrtime = new System.Windows.Forms.Timer(this.components);
            this.pnltop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxlogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnltop
            // 
            this.pnltop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.pnltop.Controls.Add(this.lbltime);
            this.pnltop.Controls.Add(this.lbltitle);
            this.pnltop.Controls.Add(this.pbxlogo);
            this.pnltop.Controls.Add(this.btnclose);
            this.pnltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnltop.Location = new System.Drawing.Point(0, 0);
            this.pnltop.Name = "pnltop";
            this.pnltop.Size = new System.Drawing.Size(938, 45);
            this.pnltop.TabIndex = 5;
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltime.ForeColor = System.Drawing.Color.White;
            this.lbltime.Location = new System.Drawing.Point(345, 21);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(70, 23);
            this.lbltime.TabIndex = 64;
            this.lbltime.Text = "label1";
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.Color.White;
            this.lbltitle.Location = new System.Drawing.Point(54, 22);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(229, 23);
            this.lbltitle.TabIndex = 67;
            this.lbltitle.Text = "EmployeeManagement";
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
            this.btnclose.Location = new System.Drawing.Point(896, 3);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(42, 45);
            this.btnclose.TabIndex = 66;
            this.btnclose.Text = "X";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // tmrtime
            // 
            this.tmrtime.Tick += new System.EventHandler(this.tmrtime_Tick);
            // 
            // empolyeesystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(938, 764);
            this.Controls.Add(this.pnltop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "empolyeesystem";
            this.Text = "empolyeesystem";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.save);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moving);
            this.pnltop.ResumeLayout(false);
            this.pnltop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxlogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnltop;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.PictureBox pbxlogo;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Timer tmrtime;
    }
}