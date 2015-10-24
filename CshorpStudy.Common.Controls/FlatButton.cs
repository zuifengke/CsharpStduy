using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CshorpStudy.Common.Controls
{
    public class FlatButton : Control
    {
        private Size m_imageSize = Size.Empty;
        private Point m_imagePos = Point.Empty;
        private Size m_textSize = Size.Empty;
        private Point m_textPos = Point.Empty;

        private bool m_bMouseOver = false;
        private bool m_bMouseDown = false;

        public FlatButton()
        {
            base.SetStyle(ControlStyles.ResizeRedraw, true);
            base.SetStyle(ControlStyles.UserPaint, true);
            base.SetStyle(ControlStyles.AllPaintingInWmPaint, true);

            base.SetStyle(ControlStyles.Selectable, true);
            
            //StandardClick设置为false,这里改为自定义触发单击事件
            base.SetStyle(ControlStyles.StandardClick, false);

            base.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            base.SetBounds(0, 0, 80, 22);
        }
        /// <summary>
        /// 获取或设置按钮文本
        /// </summary>
        [Category("Data")]
        [Description("获取或设置按钮文本")]
        public override string Text
        {
            get { return base.Text; }
            set
            {
                base.Text = value;
                this.CalcImageAndTextBounds();
                base.Invalidate();
            }
        }

        private string m_szTipText = null;
        /// <summary>
        /// 获取或设置工具提示文本
        /// </summary>
        [Category("Data")]
        [Description("获取或设置工具提示文本")]
        public string ToolTipText
        {
            get { return this.m_szTipText; }
            set { this.m_szTipText = value; }
        }

        private bool m_bImageAboveText = false;
        /// <summary>
        /// 获取或设置按钮图标是否显示在文本上方
        /// </summary>
        [Category("Appearance")]
        [Description("获取或设置按钮图标是否显示在文本上方")]
        [DefaultValue(false)]
        public bool ImageAboveText
        {
            get { return this.m_bImageAboveText; }
            set
            {
                this.m_bImageAboveText = value;
                this.CalcImageAndTextBounds();
                base.Invalidate();
            }
        }

        private bool m_bContentCenter = true;
        /// <summary>
        /// 获取或设置按钮显示内容是否居中
        /// </summary>
        [Category("Appearance")]
        [Description("获取或设置按钮显示内容是否居中")]
        [DefaultValue(true)]
        public bool ContentCenter
        {
            get { return this.m_bContentCenter; }
            set
            {
                this.m_bContentCenter = value;
                this.CalcImageAndTextBounds();
                base.Invalidate();
            }
        }

        private Image m_image = null;
        /// <summary>
        /// 获取或设置按钮显示的图像
        /// </summary>
        [Category("Appearance")]
        [Description("获取或设置按钮显示的图像")]
        [DefaultValue(null)]
        public Image Image
        {
            get { return this.m_image; }
            set
            {
                this.m_image = value;
                this.CalcImageAndTextBounds();
                base.Invalidate();
            }
        }

        private ToolTip m_ToolTip = null;
        /// <summary>
        /// 显示工具提示文本
        /// </summary>
        private void ShowToolTip()
        {
            if (this.m_szTipText == null || this.m_szTipText.Trim() == "")
                return;
            if (this.m_ToolTip == null)
                this.m_ToolTip = new ToolTip();
            this.m_ToolTip.SetToolTip(this, this.m_szTipText);
        }

        /// <summary>
        /// 隐藏工具提示文本
        /// </summary>
        private void HideToolTip()
        {
            if (this.m_ToolTip == null)
                return;
            this.m_ToolTip.RemoveAll();
            this.m_ToolTip.Dispose();
            this.m_ToolTip = null;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (this.m_image != null)
                {
                    this.m_image.Dispose();
                    this.m_image = null;
                }
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// 触发一次单击事件
        /// </summary>
        public void PerformClick()
        {
            if (this.Enabled && this.Visible)
                this.OnClick(EventArgs.Empty);
        }

        private void CalcImageAndTextBounds()
        {
            this.m_textPos = Point.Empty;
            this.m_textSize = Size.Empty;
            this.m_imagePos = Point.Empty;
            this.m_imageSize = Size.Empty;

            //文本大小
            if (!string.IsNullOrEmpty(this.Text))
            {
                Graphics g = this.CreateGraphics();
                SizeF textSize = g.MeasureString(this.Text, this.Font);
                g.Dispose();
                this.m_textSize = new Size((int)textSize.Width + 1, (int)textSize.Height + 1);
            }

            //图标大小
            if (this.m_image != null)
            {
                this.m_imageSize = new Size(this.m_image.Width, this.m_image.Height);
            }

            //调整图标和文本位置
            Rectangle contentRect = Rectangle.Empty;
            if (this.m_bImageAboveText)
            {
                contentRect.Height = this.m_textSize.Height + this.m_imageSize.Height;
                if (this.m_image != null)
                    contentRect.Height += 1;
                contentRect.Width = Math.Max(this.m_textSize.Width, this.m_imageSize.Width);
            }
            else
            {
                contentRect.Width = this.m_textSize.Width + this.m_imageSize.Width;
                if (this.m_image != null)
                    contentRect.Width += 1;
                contentRect.Height = Math.Max(this.m_textSize.Height, this.m_imageSize.Height);
            }
            contentRect.Y = (this.Height - contentRect.Height) / 2;
            if (this.m_bContentCenter)
                contentRect.X = (this.Width - contentRect.Width) / 2;

            if (!this.m_bImageAboveText)
            {
                this.m_imagePos = new Point(contentRect.X, contentRect.Y);
                this.m_textPos = new Point(contentRect.X + this.m_imageSize.Width, contentRect.Y);
                if (this.m_image != null) this.m_textPos.X += 1;
            }
            else
            {
                this.m_imagePos = new Point(contentRect.X, contentRect.Y);
                this.m_imagePos.X += (contentRect.Width - this.m_imageSize.Width) / 2;
                this.m_textPos = new Point(contentRect.X, this.m_imagePos.Y + this.m_imageSize.Height);
                if (this.m_image != null) this.m_textPos.Y += 1;
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button != MouseButtons.Left)
                return;
            if (!this.m_bMouseDown)
            {
                this.m_bMouseDown = true;
                base.Invalidate();
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            if (e.Button != MouseButtons.Left)
                return;
            if (this.m_bMouseDown)
            {
                this.m_bMouseDown = false;
                base.Invalidate();
                base.OnClick(EventArgs.Empty); //MouseUp时触发单击事件
            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            bool bMouseOver = this.ClientRectangle.Contains(new Point(e.X, e.Y));
            if (bMouseOver != this.m_bMouseOver)
            {
                this.m_bMouseDown = bMouseOver; //设置该变量,从而决定是否触发OnMouseUp中OnClick
                this.m_bMouseOver = bMouseOver;
                base.Invalidate();
            }
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            if (!this.m_bMouseOver)
            {
                this.m_bMouseOver = true;
                base.Invalidate();
            }
            this.ShowToolTip();
            base.OnMouseEnter(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            if (this.m_bMouseOver)
            {
                this.m_bMouseOver = false;
                base.Invalidate();
            }
            this.HideToolTip();
            base.OnMouseLeave(e);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            this.DrawImage(e.Graphics);
            this.DrawText(e.Graphics);
            this.DrawBorder(e.Graphics);
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            this.CalcImageAndTextBounds();
        }

        private void DrawImage(Graphics g)
        {
            if (this.m_image == null)
                return;
            Point[] destPoints = new Point[3];
            destPoints[0].X = (this.m_bMouseOver && this.m_bMouseDown) ? this.m_imagePos.X + 1 : this.m_imagePos.X;
            destPoints[0].Y = (this.m_bMouseOver && this.m_bMouseDown) ? this.m_imagePos.Y + 1 : this.m_imagePos.Y;
            destPoints[1].X = destPoints[0].X + this.m_imageSize.Width;
            destPoints[1].Y = destPoints[0].Y;
            destPoints[2].X = destPoints[0].X;
            destPoints[2].Y = destPoints[1].Y + this.m_imageSize.Height;

            // 转换单色图像
            // white -> BackColor
            // black -> ForeColor
            ColorMap[] colorMap = new ColorMap[2];
            colorMap[0] = new ColorMap();
            colorMap[0].OldColor = Color.White;
            colorMap[0].NewColor = this.BackColor;
            colorMap[1] = new ColorMap();
            colorMap[1].OldColor = Color.Black;
            colorMap[1].NewColor = this.ForeColor;
            ImageAttributes imageAttr = new ImageAttributes();
            imageAttr.SetRemapTable(colorMap);

            g.DrawImage(this.m_image, destPoints, new Rectangle(Point.Empty, this.m_imageSize), GraphicsUnit.Pixel, imageAttr);
            imageAttr.Dispose();
        }

        private void DrawText(Graphics g)
        {
            if (base.Text == string.Empty || base.Text.Trim() == "")
                return;
            Rectangle rect = new Rectangle(this.m_textPos, this.m_textSize);
            rect.X += (this.m_bMouseOver && this.m_bMouseDown) ? 1 : 0;
            rect.Y += (this.m_bMouseOver && this.m_bMouseDown) ? 1 : 0 + 1;

            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;
            stringFormat.FormatFlags = StringFormatFlags.NoWrap;
            SolidBrush brush = new SolidBrush(base.ForeColor);
            g.DrawString(base.Text, base.Font, brush, rect, stringFormat);
            brush.Dispose();
            stringFormat.Dispose();
        }

        private void DrawBorder(Graphics g)
        {
            if (this.m_bMouseDown)
            {
                ControlPaint.DrawBorder3D(g, this.ClientRectangle, Border3DStyle.SunkenInner);
                return;
            }
            if (this.m_bMouseOver || this.DesignMode)
            {
                ControlPaint.DrawBorder3D(g, this.ClientRectangle, Border3DStyle.RaisedOuter);
            }
        }
    }
}
