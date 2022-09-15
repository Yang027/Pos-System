namespace PD2020S_Examl_A108222027
{
    partial class ability
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
            this.lblhangout = new System.Windows.Forms.Label();
            this.lbldetail = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.lbltranaction = new System.Windows.Forms.Label();
            this.dgvdetail = new System.Windows.Forms.DataGridView();
            this.dgvtransaction = new System.Windows.Forms.DataGridView();
            this.tbxsum = new PD2020S_Examl_A108222027.CustomTextBox();
            this.tbxdate = new PD2020S_Examl_A108222027.CustomTextBox();
            this.tbxhang = new PD2020S_Examl_A108222027.CustomTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtransaction)).BeginInit();
            this.SuspendLayout();
            // 
            // lblhangout
            // 
            this.lblhangout.AutoSize = true;
            this.lblhangout.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhangout.ForeColor = System.Drawing.Color.White;
            this.lblhangout.Location = new System.Drawing.Point(515, 40);
            this.lblhangout.Name = "lblhangout";
            this.lblhangout.Size = new System.Drawing.Size(58, 23);
            this.lblhangout.TabIndex = 48;
            this.lblhangout.Text = "外帶:";
            // 
            // lbldetail
            // 
            this.lbldetail.AutoSize = true;
            this.lbldetail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldetail.ForeColor = System.Drawing.Color.White;
            this.lbldetail.Location = new System.Drawing.Point(6, 287);
            this.lbldetail.Name = "lbldetail";
            this.lbldetail.Size = new System.Drawing.Size(100, 23);
            this.lbldetail.TabIndex = 46;
            this.lbldetail.Text = "交易詳情:";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.ForeColor = System.Drawing.Color.White;
            this.lbltotal.Location = new System.Drawing.Point(475, 91);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(100, 23);
            this.lbltotal.TabIndex = 45;
            this.lbltotal.Text = "消費金額:";
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.ForeColor = System.Drawing.Color.White;
            this.lbldate.Location = new System.Drawing.Point(433, 176);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(58, 23);
            this.lbldate.TabIndex = 44;
            this.lbldate.Text = "日期:";
            // 
            // lbltranaction
            // 
            this.lbltranaction.AutoSize = true;
            this.lbltranaction.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltranaction.ForeColor = System.Drawing.Color.White;
            this.lbltranaction.Location = new System.Drawing.Point(3, 3);
            this.lbltranaction.Name = "lbltranaction";
            this.lbltranaction.Size = new System.Drawing.Size(100, 23);
            this.lbltranaction.TabIndex = 41;
            this.lbltranaction.Text = "交易記錄:";
            // 
            // dgvdetail
            // 
            this.dgvdetail.AllowUserToAddRows = false;
            this.dgvdetail.AllowUserToDeleteRows = false;
            this.dgvdetail.AllowUserToResizeColumns = false;
            this.dgvdetail.AllowUserToResizeRows = false;
            this.dgvdetail.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvdetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdetail.Location = new System.Drawing.Point(3, 314);
            this.dgvdetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvdetail.Name = "dgvdetail";
            this.dgvdetail.ReadOnly = true;
            this.dgvdetail.RowTemplate.Height = 27;
            this.dgvdetail.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvdetail.Size = new System.Drawing.Size(744, 185);
            this.dgvdetail.TabIndex = 40;
            // 
            // dgvtransaction
            // 
            this.dgvtransaction.AllowUserToAddRows = false;
            this.dgvtransaction.AllowUserToDeleteRows = false;
            this.dgvtransaction.AllowUserToResizeColumns = false;
            this.dgvtransaction.AllowUserToResizeRows = false;
            this.dgvtransaction.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvtransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtransaction.Location = new System.Drawing.Point(3, 30);
            this.dgvtransaction.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvtransaction.Name = "dgvtransaction";
            this.dgvtransaction.ReadOnly = true;
            this.dgvtransaction.RowTemplate.Height = 27;
            this.dgvtransaction.Size = new System.Drawing.Size(428, 254);
            this.dgvtransaction.TabIndex = 39;
            this.dgvtransaction.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.select);
            // 
            // tbxsum
            // 
            this.tbxsum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbxsum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxsum.BottmBorderFocusColor = System.Drawing.Color.Blue;
            this.tbxsum.BottomBorderColor = System.Drawing.Color.Black;
            this.tbxsum.BottomFocusOn = "";
            this.tbxsum.BottomUnFocus = "";
            this.tbxsum.FocusTextColor = System.Drawing.Color.Gray;
            this.tbxsum.Font = new System.Drawing.Font("PMingLiU", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbxsum.ForeColor = System.Drawing.Color.White;
            this.tbxsum.Location = new System.Drawing.Point(607, 91);
            this.tbxsum.Name = "tbxsum";
            this.tbxsum.ReadOnly = true;
            this.tbxsum.Size = new System.Drawing.Size(100, 33);
            this.tbxsum.TabIndex = 50;
            this.tbxsum.UnfocusTextColor = System.Drawing.Color.Gray;
            // 
            // tbxdate
            // 
            this.tbxdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbxdate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxdate.BottmBorderFocusColor = System.Drawing.Color.Blue;
            this.tbxdate.BottomBorderColor = System.Drawing.Color.Black;
            this.tbxdate.BottomFocusOn = "";
            this.tbxdate.BottomUnFocus = "";
            this.tbxdate.FocusTextColor = System.Drawing.Color.Gray;
            this.tbxdate.Font = new System.Drawing.Font("PMingLiU", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbxdate.ForeColor = System.Drawing.Color.White;
            this.tbxdate.Location = new System.Drawing.Point(507, 176);
            this.tbxdate.Name = "tbxdate";
            this.tbxdate.ReadOnly = true;
            this.tbxdate.Size = new System.Drawing.Size(240, 33);
            this.tbxdate.TabIndex = 51;
            this.tbxdate.UnfocusTextColor = System.Drawing.Color.Gray;
            // 
            // tbxhang
            // 
            this.tbxhang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbxhang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxhang.BottmBorderFocusColor = System.Drawing.Color.Blue;
            this.tbxhang.BottomBorderColor = System.Drawing.Color.Black;
            this.tbxhang.BottomFocusOn = "";
            this.tbxhang.BottomUnFocus = "";
            this.tbxhang.FocusTextColor = System.Drawing.Color.Gray;
            this.tbxhang.Font = new System.Drawing.Font("PMingLiU", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbxhang.ForeColor = System.Drawing.Color.White;
            this.tbxhang.Location = new System.Drawing.Point(607, 40);
            this.tbxhang.Name = "tbxhang";
            this.tbxhang.ReadOnly = true;
            this.tbxhang.Size = new System.Drawing.Size(100, 25);
            this.tbxhang.TabIndex = 52;
            this.tbxhang.UnfocusTextColor = System.Drawing.Color.White;
            // 
            // ability
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.tbxhang);
            this.Controls.Add(this.tbxdate);
            this.Controls.Add(this.tbxsum);
            this.Controls.Add(this.lblhangout);
            this.Controls.Add(this.lbldetail);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.lbltranaction);
            this.Controls.Add(this.dgvdetail);
            this.Controls.Add(this.dgvtransaction);
            this.Name = "ability";
            this.Size = new System.Drawing.Size(757, 501);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtransaction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblhangout;
        private System.Windows.Forms.Label lbldetail;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Label lbltranaction;
        private System.Windows.Forms.DataGridView dgvdetail;
        private System.Windows.Forms.DataGridView dgvtransaction;
        private CustomTextBox tbxsum;
        private CustomTextBox tbxdate;
        private CustomTextBox tbxhang;
    }
}
