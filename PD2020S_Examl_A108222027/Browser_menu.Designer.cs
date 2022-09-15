namespace PD2020S_Examl_A108222027
{
    partial class Browser_menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Browser_menu));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tbc = new System.Windows.Forms.TabControl();
            this.opdmenu = new System.Windows.Forms.OpenFileDialog();
            this.pbxadv = new System.Windows.Forms.PictureBox();
            this.pbxlogo = new System.Windows.Forms.PictureBox();
            this.cbxtimeoffer = new System.Windows.Forms.ComboBox();
            this.lbltime = new System.Windows.Forms.Label();
            this.tbc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxadv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxlogo)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(744, 666);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(744, 666);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tbc
            // 
            this.tbc.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.tbc.Controls.Add(this.tabPage1);
            this.tbc.Controls.Add(this.tabPage2);
            this.tbc.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbc.Location = new System.Drawing.Point(5, 215);
            this.tbc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbc.Name = "tbc";
            this.tbc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbc.SelectedIndex = 0;
            this.tbc.Size = new System.Drawing.Size(752, 700);
            this.tbc.TabIndex = 3;
            // 
            // opdmenu
            // 
            this.opdmenu.FileName = "openFileDialog1";
            // 
            // pbxadv
            // 
            this.pbxadv.Image = ((System.Drawing.Image)(resources.GetObject("pbxadv.Image")));
            this.pbxadv.Location = new System.Drawing.Point(170, -5);
            this.pbxadv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbxadv.Name = "pbxadv";
            this.pbxadv.Size = new System.Drawing.Size(503, 215);
            this.pbxadv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxadv.TabIndex = 4;
            this.pbxadv.TabStop = false;
            // 
            // pbxlogo
            // 
            this.pbxlogo.BackColor = System.Drawing.Color.Transparent;
            this.pbxlogo.Image = ((System.Drawing.Image)(resources.GetObject("pbxlogo.Image")));
            this.pbxlogo.Location = new System.Drawing.Point(4, 3);
            this.pbxlogo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbxlogo.Name = "pbxlogo";
            this.pbxlogo.Size = new System.Drawing.Size(164, 125);
            this.pbxlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxlogo.TabIndex = 5;
            this.pbxlogo.TabStop = false;
            // 
            // cbxtimeoffer
            // 
            this.cbxtimeoffer.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbxtimeoffer.FormattingEnabled = true;
            this.cbxtimeoffer.Items.AddRange(new object[] {
            "一般時段",
            "早餐"});
            this.cbxtimeoffer.Location = new System.Drawing.Point(5, 169);
            this.cbxtimeoffer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxtimeoffer.Name = "cbxtimeoffer";
            this.cbxtimeoffer.Size = new System.Drawing.Size(157, 33);
            this.cbxtimeoffer.TabIndex = 6;
            this.cbxtimeoffer.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbltime.Location = new System.Drawing.Point(4, 134);
            this.lbltime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(115, 30);
            this.lbltime.TabIndex = 7;
            this.lbltime.Text = "時段查詢:";
            // 
            // Browser_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 753);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.cbxtimeoffer);
            this.Controls.Add(this.pbxlogo);
            this.Controls.Add(this.pbxadv);
            this.Controls.Add(this.tbc);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Browser_menu";
            this.Text = "Browser_menu";
            this.tbc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxadv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxlogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tbc;
        private System.Windows.Forms.OpenFileDialog opdmenu;
        private System.Windows.Forms.PictureBox pbxadv;
        private System.Windows.Forms.PictureBox pbxlogo;
        private System.Windows.Forms.ComboBox cbxtimeoffer;
        private System.Windows.Forms.Label lbltime;
    }
}