namespace PD2020S_Examl_A108222027
{
    partial class Analyze
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
            this.components = new System.ComponentModel.Container();
            this.lbldatetip = new System.Windows.Forms.Label();
            this.gbxselect2 = new System.Windows.Forms.GroupBox();
            this.rbxmoney = new System.Windows.Forms.RadioButton();
            this.rbxnumber = new System.Windows.Forms.RadioButton();
            this.gbxselect = new System.Windows.Forms.GroupBox();
            this.rbtdate = new System.Windows.Forms.RadioButton();
            this.rbnproduct = new System.Windows.Forms.RadioButton();
            this.rbtpie = new System.Windows.Forms.RadioButton();
            this.rbtbar = new System.Windows.Forms.RadioButton();
            this.rbtLine = new System.Windows.Forms.RadioButton();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblFrom = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.gbxselect2.SuspendLayout();
            this.gbxselect.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbldatetip
            // 
            this.lbldatetip.AutoSize = true;
            this.lbldatetip.Font = new System.Drawing.Font("微軟正黑體 Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbldatetip.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbldatetip.Location = new System.Drawing.Point(704, 340);
            this.lbldatetip.Name = "lbldatetip";
            this.lbldatetip.Size = new System.Drawing.Size(129, 19);
            this.lbldatetip.TabIndex = 33;
            this.lbldatetip.Text = "選擇日期進行查詢";
            // 
            // gbxselect2
            // 
            this.gbxselect2.Controls.Add(this.rbxmoney);
            this.gbxselect2.Controls.Add(this.rbxnumber);
            this.gbxselect2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbxselect2.Location = new System.Drawing.Point(708, 567);
            this.gbxselect2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxselect2.Name = "gbxselect2";
            this.gbxselect2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxselect2.Size = new System.Drawing.Size(200, 111);
            this.gbxselect2.TabIndex = 30;
            this.gbxselect2.TabStop = false;
            this.gbxselect2.Text = "選項";
            // 
            // rbxmoney
            // 
            this.rbxmoney.AutoSize = true;
            this.rbxmoney.Checked = true;
            this.rbxmoney.Location = new System.Drawing.Point(27, 30);
            this.rbxmoney.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbxmoney.Name = "rbxmoney";
            this.rbxmoney.Size = new System.Drawing.Size(93, 29);
            this.rbxmoney.TabIndex = 15;
            this.rbxmoney.TabStop = true;
            this.rbxmoney.Text = "營業額";
            this.rbxmoney.UseVisualStyleBackColor = true;
            this.rbxmoney.CheckedChanged += new System.EventHandler(this.sdf);
            // 
            // rbxnumber
            // 
            this.rbxnumber.AutoSize = true;
            this.rbxnumber.Location = new System.Drawing.Point(27, 76);
            this.rbxnumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbxnumber.Name = "rbxnumber";
            this.rbxnumber.Size = new System.Drawing.Size(73, 29);
            this.rbxnumber.TabIndex = 17;
            this.rbxnumber.Text = "數量";
            this.rbxnumber.UseVisualStyleBackColor = true;
            this.rbxnumber.CheckedChanged += new System.EventHandler(this.sdf);
            // 
            // gbxselect
            // 
            this.gbxselect.Controls.Add(this.rbtdate);
            this.gbxselect.Controls.Add(this.rbnproduct);
            this.gbxselect.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbxselect.Location = new System.Drawing.Point(708, 216);
            this.gbxselect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxselect.Name = "gbxselect";
            this.gbxselect.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxselect.Size = new System.Drawing.Size(200, 112);
            this.gbxselect.TabIndex = 29;
            this.gbxselect.TabStop = false;
            this.gbxselect.Text = "選項";
            // 
            // rbtdate
            // 
            this.rbtdate.AutoSize = true;
            this.rbtdate.Checked = true;
            this.rbtdate.Location = new System.Drawing.Point(27, 30);
            this.rbtdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtdate.Name = "rbtdate";
            this.rbtdate.Size = new System.Drawing.Size(73, 29);
            this.rbtdate.TabIndex = 18;
            this.rbtdate.TabStop = true;
            this.rbtdate.Text = "日期";
            this.rbtdate.UseVisualStyleBackColor = true;
            this.rbtdate.CheckedChanged += new System.EventHandler(this.date);
            // 
            // rbnproduct
            // 
            this.rbnproduct.AutoSize = true;
            this.rbnproduct.Location = new System.Drawing.Point(27, 78);
            this.rbnproduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbnproduct.Name = "rbnproduct";
            this.rbnproduct.Size = new System.Drawing.Size(73, 29);
            this.rbnproduct.TabIndex = 19;
            this.rbnproduct.Text = "產品";
            this.rbnproduct.UseVisualStyleBackColor = true;
            this.rbnproduct.CheckedChanged += new System.EventHandler(this.date);
            // 
            // rbtpie
            // 
            this.rbtpie.AutoSize = true;
            this.rbtpie.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbtpie.Location = new System.Drawing.Point(735, 154);
            this.rbtpie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtpie.Name = "rbtpie";
            this.rbtpie.Size = new System.Drawing.Size(116, 29);
            this.rbtpie.TabIndex = 28;
            this.rbtpie.Text = "Pie Chart";
            this.rbtpie.UseVisualStyleBackColor = true;
            this.rbtpie.CheckedChanged += new System.EventHandler(this.change);
            // 
            // rbtbar
            // 
            this.rbtbar.AutoSize = true;
            this.rbtbar.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbtbar.Location = new System.Drawing.Point(735, 94);
            this.rbtbar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtbar.Name = "rbtbar";
            this.rbtbar.Size = new System.Drawing.Size(118, 29);
            this.rbtbar.TabIndex = 26;
            this.rbtbar.Text = "Bar Chart";
            this.rbtbar.UseVisualStyleBackColor = true;
            this.rbtbar.CheckedChanged += new System.EventHandler(this.change);
            // 
            // rbtLine
            // 
            this.rbtLine.AutoSize = true;
            this.rbtLine.Checked = true;
            this.rbtLine.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbtLine.Location = new System.Drawing.Point(735, 34);
            this.rbtLine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtLine.Name = "rbtLine";
            this.rbtLine.Size = new System.Drawing.Size(126, 29);
            this.rbtLine.TabIndex = 27;
            this.rbtLine.TabStop = true;
            this.rbtLine.Text = "Line Chart";
            this.rbtLine.UseVisualStyleBackColor = true;
            this.rbtLine.CheckedChanged += new System.EventHandler(this.change);
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.zedGraphControl1.Location = new System.Drawing.Point(0, 0);
            this.zedGraphControl1.Margin = new System.Windows.Forms.Padding(8);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(480, 701);
            this.zedGraphControl1.TabIndex = 25;
            this.zedGraphControl1.UseExtendedPrintDialog = true;
            this.zedGraphControl1.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblFrom);
            this.groupBox1.Controls.Add(this.dtpFrom);
            this.groupBox1.Controls.Add(this.dtpTo);
            this.groupBox1.Controls.Add(this.lblTo);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(708, 405);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 140);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "日期選擇";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblFrom.Location = new System.Drawing.Point(10, 23);
            this.lblFrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(61, 19);
            this.lblFrom.TabIndex = 5;
            this.lblFrom.Text = "From：";
            // 
            // dtpFrom
            // 
            this.dtpFrom.CustomFormat = "yyyy年MM月dd日";
            this.dtpFrom.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(13, 42);
            this.dtpFrom.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(180, 27);
            this.dtpFrom.TabIndex = 2;
            this.dtpFrom.Value = new System.DateTime(2020, 6, 24, 0, 0, 0, 0);
            this.dtpFrom.ValueChanged += new System.EventHandler(this.dtpFrom_ValueChanged);
            // 
            // dtpTo
            // 
            this.dtpTo.CustomFormat = "yyyy年MM月dd日";
            this.dtpTo.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(13, 96);
            this.dtpTo.Margin = new System.Windows.Forms.Padding(4);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(180, 27);
            this.dtpTo.TabIndex = 3;
            this.dtpTo.ValueChanged += new System.EventHandler(this.dtpTo_ValueChanged);
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTo.Location = new System.Drawing.Point(10, 73);
            this.lblTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(41, 19);
            this.lblTo.TabIndex = 4;
            this.lblTo.Text = "To：";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy年MM月";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(721, 362);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(140, 25);
            this.dateTimePicker1.TabIndex = 35;
            this.dateTimePicker1.Visible = false;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged_1);
            // 
            // Analyze
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbldatetip);
            this.Controls.Add(this.gbxselect2);
            this.Controls.Add(this.gbxselect);
            this.Controls.Add(this.rbtpie);
            this.Controls.Add(this.rbtbar);
            this.Controls.Add(this.rbtLine);
            this.Controls.Add(this.zedGraphControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Analyze";
            this.Size = new System.Drawing.Size(1025, 701);
            this.gbxselect2.ResumeLayout(false);
            this.gbxselect2.PerformLayout();
            this.gbxselect.ResumeLayout(false);
            this.gbxselect.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldatetip;
        private System.Windows.Forms.GroupBox gbxselect2;
        private System.Windows.Forms.RadioButton rbxmoney;
        private System.Windows.Forms.RadioButton rbxnumber;
        private System.Windows.Forms.GroupBox gbxselect;
        private System.Windows.Forms.RadioButton rbtdate;
        private System.Windows.Forms.RadioButton rbnproduct;
        private System.Windows.Forms.RadioButton rbtpie;
        private System.Windows.Forms.RadioButton rbtbar;
        private System.Windows.Forms.RadioButton rbtLine;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}
