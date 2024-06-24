using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSHARP_DETHITHU
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void giớiThiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chương trình tiện ích", "Thông tin", MessageBoxButtons.OK);
        }

        private void gToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Giaiphuongtrinhbac2 giaiphuongtrinhbac2 = new Giaiphuongtrinhbac2();
            giaiphuongtrinhbac2.ShowDialog();
        }

        private void địnhDạngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dinhdang dinhdang = new Dinhdang();
            dinhdang.ShowDialog();
        }

        private void thoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void đăngKýMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dangkymonhoc dangkymonhoc = new Dangkymonhoc();
            dangkymonhoc.ShowDialog();  
        }
    }
}
