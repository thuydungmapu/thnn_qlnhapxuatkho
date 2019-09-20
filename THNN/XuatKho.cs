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
    public partial class XuatKho : Form
    {
        public XuatKho()
        {
            InitializeComponent();
            lblHotennv.Text = "NV. " + Lopketnoi.hotennv;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            KhachHang fr = new KhachHang();
            fr.ShowDialog();
        }

        private void XuatKho_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tHNNDataSetPhieuxuat_PX.PHIEUXUAT' table. You can move, or remove it, as needed.
            this.pHIEUXUATTableAdapter.Fill(this.tHNNDataSetPhieuxuat_PX.PHIEUXUAT);
            // TODO: This line of code loads data into the 'tHNNDataSetNV_PX.NHANVIEN' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter.Fill(this.tHNNDataSetNV_PX.NHANVIEN);
            // TODO: This line of code loads data into the 'tHNNDataSetKH_PX.KHACHHANG' table. You can move, or remove it, as needed.
            this.kHACHHANGTableAdapter.Fill(this.tHNNDataSetKH_PX.KHACHHANG);

            txtngaypx.Text = DateTime.Now.ToShortDateString();
            DateTime t = System.DateTime.Now;
            txtmapx.Text = "PX" + t.Year.ToString().Substring(2, 2) + t.Month.ToString() + t.Day.ToString() + t.Hour.ToString() + t.Minute.ToString() + t.Second.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                pHIEUXUATTableAdapter.Insert(txtmapx.Text.ToString().Trim(), txtmakh.Text.ToString().Trim(), Lopketnoi.manv, DateTime.Parse(txtngaypx.Text.ToString()), txtghichu.Text.ToString());
                this.pHIEUXUATTableAdapter.Fill(this.tHNNDataSetPhieuxuat_PX.PHIEUXUAT);
                MessageBox.Show("Thêm phiếu xuất thành công");
                this.Close();
            }
            catch (System.Exception) { }
        }

        
    }
}
