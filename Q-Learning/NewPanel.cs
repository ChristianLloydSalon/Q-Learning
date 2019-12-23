using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Q_Learning
{
    class NewPanel : Panel
    {
        private ToolTip toolTip = new ToolTip();
        private int    _BorderThickness;
        private Color  _BorderColor;
        private string _Text;
        private Label textLabel;

        public NewPanel()
        {
            // default values
            _Text            = this.Name;
            _BorderColor     = Color.Black;
            _BorderThickness = 5;

            textLabel = new Label();
            toolTip.IsBalloon = true;
            this.Cursor = Cursors.Hand;
        }

        // NewPanel Events
        private event EventHandler BorderColorChanged;        // event to handle border color changes
        private event EventHandler BorderThicknessChanged;    // event to handle border thickness changes

        // Summary: 
        //      Gets or sets the line border color
        //
        // Returns: 
        //      the border color
        public Color BorderColor
        {
            get
            {
                return _BorderColor;
            }

            set
            {
                _BorderColor = value;
                OnBorderColorChanged();
            }
        }

        protected virtual void OnBorderColorChanged()
        {
            if (BorderColorChanged != null)
                BorderColorChanged(this, EventArgs.Empty);

            
            BorderColorPaint();
        }

        // Summary: 
        //      Gets or sets the border thickness
        //
        // Returns: 
        //      thickness of the border
        public int BorderThickness
        {
            get
            {
                return _BorderThickness;
            }
            set
            {
                _BorderThickness = value;
                OnBorderThicknessChanged();
            }
        }

        protected virtual void OnBorderThicknessChanged()
        {
            if (BorderThicknessChanged != null)
                BorderThicknessChanged(this, EventArgs.Empty);

            BorderColorPaint();
        }

        // Summary: 
        //      Gets or sets the panel text
        //
        // Returns: 
        //      panel text
        public string PanelLabel
        {
            get
            {
                return _Text;
            }

            set
            {
                _Text = value;
                TextChange();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            BorderColorPaint();
            TextChange();
        }

        protected override void OnFontChanged(EventArgs e)
        {
            BorderColorPaint();
            TextChange();
        }

        protected override void OnTextChanged(EventArgs e)
        {
            BorderColorPaint();
            TextChange();
        }

        private void BorderColorPaint()
        {
            Pen pen = new Pen(_BorderColor);

            Graphics g = this.CreateGraphics();
            //g.Clear(this.BackColor);

            int thickness = 1;
            for (int i = 0; i < _BorderThickness; i++)
            {
                g.DrawRectangle(pen, new Rectangle(i, i, this.Width - thickness, this.Height - thickness));
                thickness += 2;
            }

            pen.Dispose();
        }

        private void TextChange()
        {
            Graphics g = this.CreateGraphics();
            g.DrawString(_Text, new Font("Century Gothic", 7, FontStyle.Bold), Brushes.Red, 10, 10);
        }

        protected override void OnMouseHover(EventArgs e)
        {
            toolTip.SetToolTip(this, "Q-VALUE: " + _Text);
        }
    }
}
