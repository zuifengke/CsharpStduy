using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CshorpStudy.WinForm
{
    public partial class RibbonControl : UserControl
    {
        public RibbonControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.ribbonStrip1.Minimized = !this.ribbonStrip1.Minimized;
        }
    }
}
