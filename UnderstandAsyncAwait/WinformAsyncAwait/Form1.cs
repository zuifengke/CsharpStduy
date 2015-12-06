using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformAsyncAwait
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTaskResult_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Beige;
            this.btnTaskResult.BackColor = Color.BlueViolet;

            var operationA=new LongTimeOperationA().GetValue();
            var operationB=new LongTimeOperationB().GetValue();

            var valueA = operationA.Result;
            Text = valueA;
          
        }

        private async void btnAsyncAwait_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Aquamarine;
            this.btnAsyncAwait.BackColor = Color.Blue;

            var operationA = new LongTimeOperationA().GetValue();
            var operationB = new LongTimeOperationB().GetValue();

            var valueA =await operationA;
            Text = valueA;
           
        }
    }
}
