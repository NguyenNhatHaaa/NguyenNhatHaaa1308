using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH_XuanHa.GUII
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SanPham t1 = new SanPham();
            t1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomerGUi t2 = new CustomerGUi();
            t2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HoaDon hd = new HoaDon();
            hd.ShowDialog();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
