using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
namespace CshorpStudy.Drawing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] month = new string[12] { "一月", "二月", "三月", "四月", "五月", "六月", "七月", "八月", "九月", "十月", "十一月", "十二月" };
            float[] d = new float[12] { 20.5f, 60, 10.8f, 15.6f, 30, 70.9f, 50.3f, 30.7f, 70, 50.4f, 30.8f, 20 };
            //画图初始化
            Bitmap bmap = new Bitmap(500, 500);
            Graphics gph = Graphics.FromImage(bmap);
            gph.Clear(Color.White);

            PointF cpt = new PointF(40, 420);//中心点
            PointF[] xpt = new PointF[3] { new PointF(cpt.Y + 15, cpt.Y), new PointF(cpt.Y, cpt.Y - 8), new PointF(cpt.Y, cpt.Y + 8) };//x轴三角形
            PointF[] ypt = new PointF[3] { new PointF(cpt.X, cpt.X - 15), new PointF(cpt.X - 8, cpt.X), new PointF(cpt.X + 8, cpt.X) };//y轴三角形
            gph.DrawString("某工厂某产品月生产量图表", new Font("宋体", 14), Brushes.Black, new PointF(cpt.X + 60, cpt.X));//图表标题
            //画x轴
            gph.DrawLine(Pens.Black, cpt.X, cpt.Y, cpt.Y, cpt.Y);
            gph.DrawPolygon(Pens.Black, xpt);
            gph.FillPolygon(new SolidBrush(Color.Black), xpt);
            gph.DrawString("月份", new Font("宋体", 12), Brushes.Black, new PointF(cpt.Y + 10, cpt.Y + 10));
            //画y轴
            gph.DrawLine(Pens.Black, cpt.X, cpt.Y, cpt.X, cpt.X);
            gph.DrawPolygon(Pens.Black, ypt);
            gph.FillPolygon(new SolidBrush(Color.Black), ypt);
            gph.DrawString("单位(万)", new Font("宋体", 12), Brushes.Black, new PointF(0, 7));
            for (int i = 1; i <= 12; i++)
            {
                //画y轴刻度
                if (i < 11)
                {
                    gph.DrawString((i * 10).ToString(), new Font("宋体", 11), Brushes.Black, new PointF(cpt.X - 30, cpt.Y - i * 30 - 6));
                    gph.DrawLine(Pens.Black, cpt.X - 3, cpt.Y - i * 30, cpt.X, cpt.Y - i * 30);
                }

                //画x轴项目
                gph.DrawString(month[i - 1].Substring(0, 1), new Font("宋体", 11), Brushes.Black, new PointF(cpt.X + i * 30 - 5, cpt.Y + 5));
                gph.DrawString(month[i - 1].Substring(1, 1), new Font("宋体", 11), Brushes.Black, new PointF(cpt.X + i * 30 - 5, cpt.Y + 20));
                if (month[i - 1].Length > 2) gph.DrawString(month[i - 1].Substring(2, 1), new Font("宋体", 11), Brushes.Black, new PointF(cpt.X + i * 30 - 5, cpt.Y + 35));
                //画点
                gph.DrawEllipse(Pens.Black, cpt.X + i * 30 - 1.5f, cpt.Y - d[i - 1] * 3 - 1.5f, 3, 3);
                gph.FillEllipse(new SolidBrush(Color.Black), cpt.X + i * 30 - 1.5f, cpt.Y - d[i - 1] * 3 - 1.5f, 3, 3);
                //画数值
                gph.DrawString(d[i - 1].ToString(), new Font("宋体", 11), Brushes.Black, new PointF(cpt.X + i * 30, cpt.Y - d[i - 1] * 3));
                //画折线
                if (i > 1) gph.DrawLine(Pens.Red, cpt.X + (i - 1) * 30, cpt.Y - d[i - 2] * 3, cpt.X + i * 30, cpt.Y - d[i - 1] * 3);
            }
            //保存输出图片
            //bmap.Save(Response.OutputStream, ImageFormat.Gif);
            pictureBox1.Image = bmap;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            画图基础 frm = new 画图基础();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            画图基础2 frm = new 画图基础2();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            画图基础3 frm = new 画图基础3();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            图片像素颜色变化 frm = new 图片像素颜色变化();
            frm.Show();
        }
    }
}
