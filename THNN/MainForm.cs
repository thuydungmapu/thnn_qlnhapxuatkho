using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THNN
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            lblHotennv.Text = "NV. " + Lopketnoi.hotennv;
        }

        private void NhapKho_Click(object sender, EventArgs e)
        {
            TQphieunhap fr=new TQphieunhap();
            fr.ShowDialog();
        }

        private void Xuatkho_Click(object sender, EventArgs e)
        {
            TQXuatkho fr = new TQXuatkho();
            fr.ShowDialog();
        }
        private void Hanghoa_Click(object sender, EventArgs e)
        {
            HangHoa fr = new HangHoa();
            fr.ShowDialog();
        }

        private void NCC_Click(object sender, EventArgs e)
        {
            NhaCungCap fr = new NhaCungCap();
            fr.ShowDialog();
        }

        private void Khachhang_Click(object sender, EventArgs e)
        {
            KhachHang fr = new KhachHang();
            fr.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult chon = MessageBox.Show("Thoát chương trình (Yes/No)?", "Xác  nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);//Hỏi  xác  nhận 
            if (chon == DialogResult.Yes)
            {
                this.Close();
            }
        }

        
    }
}
