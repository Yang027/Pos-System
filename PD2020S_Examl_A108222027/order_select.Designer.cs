namespace PD2020S_Examl_A108222027
{
    partial class order_select
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(order_select));
            this.pbxbreakfast = new System.Windows.Forms.PictureBox();
            this.pbxnormal = new System.Windows.Forms.PictureBox();
            this.btnon = new System.Windows.Forms.Button();
            this.btnoff = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxbreakfast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxnormal)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxbreakfast
            // 
            this.pbxbreakfast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxbreakfast.Image = ((System.Drawing.Image)(resources.GetObject("pbxbreakfast.Image")));
            this.pbxbreakfast.Location = new System.Drawing.Point(37, 105);
            this.pbxbreakfast.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbxbreakfast.Name = "pbxbreakfast";
            this.pbxbreakfast.Size = new System.Drawing.Size(332, 276);
            this.pbxbreakfast.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxbreakfast.TabIndex = 1;
            this.pbxbreakfast.TabStop = false;
            this.pbxbreakfast.Click += new System.EventHandler(this.pbxbreakfast_Click);
            // 
            // pbxnormal
            // 
            this.pbxnormal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxnormal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxnormal.Image = global::PD2020S_Examl_A108222027.Properties.Resources.oderbk;
            this.pbxnormal.Location = new System.Drawing.Point(519, 105);
            this.pbxnormal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbxnormal.Name = "pbxnormal";
            this.pbxnormal.Size = new System.Drawing.Size(332, 276);
            this.pbxnormal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxnormal.TabIndex = 0;
            this.pbxnormal.TabStop = false;
            this.pbxnormal.Click += new System.EventHandler(this.pbxnormal_Click);
            // 
            // btnon
            // 
            this.btnon.BackColor = System.Drawing.Color.Transparent;
            this.btnon.Enabled = false;
            this.btnon.FlatAppearance.BorderSize = 0;
            this.btnon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnon.Image = ((System.Drawing.Image)(resources.GetObject("btnon.Image")));
            this.btnon.Location = new System.Drawing.Point(704, 12);
            this.btnon.Name = "btnon";
            this.btnon.Size = new System.Drawing.Size(95, 56);
            this.btnon.TabIndex = 71;
            this.btnon.UseVisualStyleBackColor = false;
            this.btnon.Click += new System.EventHandler(this.btnon_Click);
            // 
            // btnoff
            // 
            this.btnoff.BackColor = System.Drawing.Color.Transparent;
            this.btnoff.Enabled = false;
            this.btnoff.FlatAppearance.BorderSize = 0;
            this.btnoff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnoff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnoff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnoff.Image = ((System.Drawing.Image)(resources.GetObject("btnoff.Image")));
            this.btnoff.Location = new System.Drawing.Point(704, 12);
            this.btnoff.Name = "btnoff";
            this.btnoff.Size = new System.Drawing.Size(95, 56);
            this.btnoff.TabIndex = 70;
            this.btnoff.UseVisualStyleBackColor = false;
            this.btnoff.Visible = false;
            this.btnoff.Click += new System.EventHandler(this.btnoff_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(658, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 72;
            this.label1.Text = "Limit:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(678, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 20);
            this.label2.TabIndex = 72;
            this.label2.Text = "開";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(794, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 20);
            this.label3.TabIndex = 72;
            this.label3.Text = "關";
            // 
            // order_select
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 508);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnon);
            this.Controls.Add(this.btnoff);
            this.Controls.Add(this.pbxbreakfast);
            this.Controls.Add(this.pbxnormal);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "order_select";
            this.Text = "order_select";
            ((System.ComponentModel.ISupportInitialize)(this.pbxbreakfast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxnormal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxnormal;
        private System.Windows.Forms.PictureBox pbxbreakfast;
        private System.Windows.Forms.Button btnon;
        private System.Windows.Forms.Button btnoff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}