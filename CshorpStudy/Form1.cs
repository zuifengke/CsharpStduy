using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Web.Security;
namespace CshorpStudy.Drawing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        bool isDrag = false;
        Rectangle theRectangle = new Rectangle
            (new Point(0, 0), new Size(0, 0));
        Point startPoint;

        private void Form1_MouseDown(object sender,
            System.Windows.Forms.MouseEventArgs e)
        {

        }

        private void Form1_MouseMove(object sender,
            System.Windows.Forms.MouseEventArgs e)
        {

           
        }

        private void Form1_MouseUp(object sender,
            System.Windows.Forms.MouseEventArgs e)
        {

          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AppDomain currentDomain = AppDomain.CurrentDomain;

            currentDomain.UnhandledException += new UnhandledExceptionEventHandler(AppDomain_CurrentDomain_UnhandledException);
            throw new Exception("this is Exception");
        }

      
      

        private void button2_Click(object sender, EventArgs e)
        {
            this.button1_Click(sender, e);
            this.button1.PerformClick();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataSet ds= MySqlHelper.Query("insert into ");
            
        }
        static void AppDomain_CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs args)
        {
            Exception e = (Exception)args.ExceptionObject;

            MessageBox.Show(e.Message);
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1");
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {
            MessageBox.Show("1");
        }
    }
}
