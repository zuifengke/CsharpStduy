using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CshorpStudy.Drawing
{
    public partial class 画图基础2 : Form
    {
        public 画图基础2()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics gph = e.Graphics;
            Pen mypen = new Pen(Color.Red, 2);
            //创建自定义钢笔,color,float,参数为颜色和宽度
            mypen.DashStyle = DashStyle.Custom;
            //自定义钢笔样式
            gph.DrawLine(mypen, 10, 10, 300, 10);
            //绘制直线
            mypen.DashStyle = DashStyle.Dash;
            gph.DrawLine(mypen, 10, 30, 300, 30);
            //(Pen, int, int, int, int)pen Pen 起点x坐标,起点y坐标,终点x坐标,终点y坐标
            mypen.DashStyle = DashStyle.DashDot;
            gph.DrawLine(mypen, 10, 50, 300, 50);
            mypen.DashStyle = DashStyle.DashDotDot;
            gph.DrawLine(mypen, 10, 70, 300, 70);
            mypen.DashStyle = DashStyle.Dot;
            gph.DrawLine(mypen, 10, 90, 300, 90);
            mypen.DashStyle = DashStyle.Solid;
            gph.DrawLine(mypen, 10, 110, 300, 110);
            mypen.DashCap = DashCap.Round;
            mypen.DashStyle   = DashStyle.Dash;
            mypen.EndCap = LineCap.Round;
            gph.DrawLine(mypen, 10, 130, 300, 130);
        }
    }
}
