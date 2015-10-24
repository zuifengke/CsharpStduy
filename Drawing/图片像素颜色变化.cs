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
    public partial class 图片像素颜色变化 : Form
    {
        public 图片像素颜色变化()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap myBitmap = this.pictureBox1.Image as Bitmap;
            int picWidth = myBitmap.Width;
            int picHeight = myBitmap.Height;
            for (int i = 0; i < picWidth; i++)
            {
                for (int j = 0; j < picHeight; j++)
                {
                    Color pix = myBitmap.GetPixel(i, j);
                    if (pix.A == 255&&pix.B==255&&pix.G<=255)
                        myBitmap.SetPixel(i, j, Color.Red);
                }
            }
            this.pictureBox1.Image = myBitmap;
        }
    }
}
