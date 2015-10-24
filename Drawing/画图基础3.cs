using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CshorpStudy.Drawing
{
    public partial class 画图基础3 : Form
    {
        public 画图基础3()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics gph = e.Graphics;

            gph.SmoothingMode = SmoothingMode.HighQuality;
            //设置图片质量,指定是否将平滑处理（消除锯齿）应用于直线、曲线和已填充区域的边缘
            gph.Clear(Color.Red);
            //清除整个绘图面并以指定背景色填充
            gph.DrawRectangle(Pens.Blue, 10, 10, 100, 100);
            gph.FillRectangle(Brushes.Blue, 120, 10, 100, 100);
            //绘制矩形
            gph.DrawEllipse(Pens.Blue, 10, 120, 100, 100);
            gph.FillEllipse(Brushes.Blue, 120, 120, 100, 100);
            //绘制椭圆
            gph.DrawPie(Pens.Blue, 10, 230, 100, 100, 0, 270);
            //绘制圆弧
            gph.FillPie(Brushes.Blue, 120, 230, 100, 100, 0, 270);
            //绘制饼图
            Point[] line = { new Point(10, 340), new Point(60, 30), new Point(110, 30), new Point(160, 340) };
            gph.DrawCurve(Pens.Blue, line);
            //绘制曲线
            gph.DrawBezier(Pens.Blue, new Point(10, 340), new Point(60, 30), new Point(110, 30), new Point(160, 340));
            //绘制贝塞尔曲线
            Point[] line2 = { new Point(10, 340), new Point(340, 100), new Point(190, 340), new Point(10, 340) };
            gph.DrawPolygon(Pens.Blue, line2);
            //gph.FillPolygon(Pens.Blue, line2);
            //绘制图片
            gph.DrawLine(Pens.Black, 10, 480, 300, 480);
            //---------------------------------------------------------------
            gph.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            //设置字符串质量
            gph.Clear(Color.Red);
            //清除整个绘图面并以指定背景色填充
            gph.DrawString("无换行显示:绘制文本换行显示的字符串,应该使用文本外部边界的长方行", new Font("宋体", 16), Brushes.Blue, 10, 10);
            //绘制文本字符串string, Font, Brush, float, float(字符串,字体,x,y坐标)
            RectangleF rect = new RectangleF(10, 110, 300, 200);
            string str = "绘制文本换行显示的字符串,应该使用文本外部边界的长方行";
            gph.DrawString(str, new Font("宋体", 16), Brushes.Blue, rect);
        }
    }
}
