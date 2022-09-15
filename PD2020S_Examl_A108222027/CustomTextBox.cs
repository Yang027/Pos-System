using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PD2020S_Examl_A108222027
{
    public partial class CustomTextBox : TextBox
    {
        private Color _bottomBorderColor = Color.Black;
        private TextBox tbx;
        private Color unfocusTextColor = Color.Gray;
        private Color focusTextColor = Color.Gray;
        private Color _onFocusColor = Color.Blue;
        private string _focuson = "";
        private string _unfocus = "";
        public CustomTextBox()
        {
            InitializeComponent();
            BorderStyle = BorderStyle.None;
            AutoSize = false;

            Controls.Add(new Label { Height = 2, Dock = DockStyle.Bottom, BackColor = _bottomBorderColor });
            this.Text = _unfocus;
        }
        [Browsable(false)]
        public new BorderStyle BorderStyle
        {
            get { return base.BorderStyle; }
            set { base.BorderStyle = value; }
        }
        public Color BottomBorderColor
        {
            get { return _bottomBorderColor; }
            set
            {
                _bottomBorderColor = value;
                Controls[0].BackColor = _bottomBorderColor;
            }
        }
        public Color BottmBorderFocusColor
        {
            get { return _onFocusColor; }
            set { _onFocusColor = value; }
        }
        public Color UnfocusTextColor
        {
            get { return unfocusTextColor; }
            set { unfocusTextColor = value; }
        }
        public Color FocusTextColor
        {
            get { return focusTextColor; }
            set { focusTextColor = value; }
        }
        public string BottomFocusOn
        {
            get { return _focuson; }
            set { _focuson = value; this.Text = _focuson; }
        }
        public string BottomUnFocus
        {
            get { return _unfocus; }
            set { _unfocus = value;this.Text = _unfocus;  }
        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        private void enter(object sender, EventArgs e)
        {
            Controls[0].BackColor = _onFocusColor;          
            if (this.Text == _unfocus)
            {     
                this.Text = "";
            }
            else { this.Text = Text; }
            this.ForeColor = focusTextColor;
        }

        private void leave(object sender, EventArgs e)
        {
            Controls[0].BackColor = _bottomBorderColor;
            if (this.Text == "")
            {
                this.Text = _unfocus;               
            }
            else { this.Text = Text;  }
            this.ForeColor = unfocusTextColor;
        }
    }
}
