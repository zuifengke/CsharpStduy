using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CshorpStudy.Drawing
{
    public partial class 画图基础 : Form
    {
        public 画图基础()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics gph = e.Graphics;
            Rectangle rectangle = new Rectangle(20, 20, 200, 100);
            Pen pen=new Pen(Color.Red);
            gph.DrawRectangle(pen, rectangle);
            gph.FillRectangle(Brushes.Blue, rectangle);
        }
    }
}
