using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using Log4Emrs;
namespace WinStopwatch
{
    public partial class Form1 : Form
    {
        private Stopwatch watch = new Stopwatch();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddControl_Click(object sender, EventArgs e)
        {
            Decimal nNum = nuNum.Value;
            if (nNum <= 0)
            {
                MessageBox.Show("请输入要加载的控件个正整数个数!");
                return;
            }
            pnlContent.Controls.Clear();
            if (rbButton.Checked)
            {
                watch.Reset();
                watch.Start();
                for (int i = 0; i < nNum; i++)
                {
                    Button btn = new Button();
                    pnlContent.Controls.Add(btn);
                }
                watch.Stop();
                lblResult.Text = watch.Elapsed.ToString() + "s";
            }
            else if (rbRadioButton.Checked)
            {
                watch.Reset();
                watch.Start();
                for (int i = 0; i < nNum; i++)
                {
                    RadioButton radio = new RadioButton();
                    pnlContent.Controls.Add(radio);
                }
                watch.Stop();
                lblResult.Text = watch.Elapsed.ToString() + "s";
            }
            else if (rbCheckBox.Checked)
            {
                watch.Reset();
                watch.Start();
                for (int i = 0; i < nNum; i++)
                {
                    CheckBox cb = new CheckBox();
                    pnlContent.Controls.Add(cb);
                }
                watch.Stop();
                lblResult.Text = watch.Elapsed.ToString() + "s";
            }
            else if (rbTextBox.Checked)
            {
                watch.Reset();
                watch.Start();
                for (int i = 0; i < nNum; i++)
                {
                    TextBox txt = new TextBox();
                    pnlContent.Controls.Add(txt);
                }
                watch.Stop();
                lblResult.Text = watch.Elapsed.ToString() + "s";
            }
            MessageBox.Show("耗时：" + watch.Elapsed.ToString() + "s");
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            Decimal nNum = nuNum.Value;
            if (nNum <= 0)
            {
                MessageBox.Show("请输入要加载的控件个正整数个数!");
                return;
            }
            pnlContent.Controls.Clear();
            if (rbButton.Checked)
            {
                Log4Emr.Restart("Button");
                Log4Emr.LogInfo("创建Button并添加到Panel-begin");
                for (int i = 0; i < nNum; i++)
                {
                    Button btn = new Button();
                    pnlContent.Controls.Add(btn);
                }
                Log4Emr.LogInfo("创建Button并添加到Panel-end");
                Log4Emr.Stop();
            }
            else if (rbRadioButton.Checked)
            {
                Log4Emr.Restart("RadioButton");
                Log4Emr.LogInfo("创建RadioButton并添加到Panel-begin");
                for (int i = 0; i < nNum; i++)
                {
                    RadioButton rb = new RadioButton();
                    pnlContent.Controls.Add(rb);
                }
                Log4Emr.LogInfo("创建RadioButton并添加到Panel-end");
                Log4Emr.Stop();
            }
            else if (rbCheckBox.Checked)
            {
                Log4Emr.Restart("CheckBox");
                Log4Emr.LogInfo("创建CheckBox并添加到Panel-begin");
                for (int i = 0; i < nNum; i++)
                {
                    CheckBox cb = new CheckBox();
                    pnlContent.Controls.Add(cb);
                }
                Log4Emr.LogInfo("创建CheckBox并添加到Panel-end");
                Log4Emr.Stop();
            }
            else if (rbTextBox.Checked)
            {
                Log4Emr.Restart("TextBox");
                Log4Emr.LogInfo("创建TextBox并添加到Panel-begin");
                for (int i = 0; i < nNum; i++)
                {
                    TextBox txt = new TextBox();
                    pnlContent.Controls.Add(txt);
                }
                Log4Emr.LogInfo("创建TextBox并添加到Panel-end");
                Log4Emr.Stop();
            }
        }
    }
}
