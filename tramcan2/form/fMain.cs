using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tramcan2.form
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void càiĐặtCổngCOMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fCOM fm = new fCOM();
            fm.ShowDialog();
            
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fKhachHang fm = new fKhachHang();
            this.Hide();
            fm.ShowDialog();
            this.Show();
        }
    }
}
