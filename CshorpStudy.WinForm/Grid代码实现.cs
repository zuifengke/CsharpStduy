using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CshorpStudy.WinForm
{
    public partial class Grid代码实现 : Form
    {
        public Grid代码实现()
        {
            InitializeComponent();
        }
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            this.dataGridView1.Rows.Add();
        }
    }
}
