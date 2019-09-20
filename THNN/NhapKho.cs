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
    public partial class NhapKho : Form
    {
        public NhapKho()
        {
            InitializeComponent();
        }

        private void NhapKho_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tHNNDataSetHangHoa.HANGHOA' table. You can move, or remove it, as needed.
            this.hANGHOATableAdapter.Fill(this.tHNNDataSetHangHoa.HANGHOA);
            // TODO: This line of code loads data into the 'tHNNDataSetCTPN.CTPHIEUNHAP' table. You can move, or remove it, as needed.
            this.cTPHIEUNHAPTableAdapter.Fill(this.tHNNDataSetCTPN.CTPHIEUNHAP);
            // TODO: This line of code loads data into the 'tHNNDataSetpn.PHIEUNHAP' table. You can move, or remove it, as needed.
            this.pHIEUNHAPTableAdapter.Fill(this.tHNNDataSetpn.PHIEUNHAP);
            // TODO: This line of code loads data into the 'tHNNDataSetNCC.NHACUNGCAP' table. You can move, or remove it, as needed.
            this.nHACUNGCAPTableAdapter.Fill(this.tHNNDataSetNCC.NHACUNGCAP);
            // TODO: This line of code loads data into the 'tHNNDataSetNVPNK.NHANVIEN' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter.Fill(this.tHNNDataSetNVPNK.NHANVIEN);
            
            txtngaypx.Text = DateTime.Now.ToShortDateString();
            DateTime t = System.DateTime.Now;
            txtmapx.Text = "PX" + t.Year.ToString().Substring(2, 2) + t.Month.ToString() + t.Day.ToString() + t.Hour.ToString() + t.Minute.ToString() + t.Second.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                pHIEUNHAPTableAdapter.Insert(txtmapx.Text.ToString().Trim(), txtMaNCC.Text.ToString().Trim(),lbMNV.Text.ToString().Trim(),DateTime.Parse(txtngaypx.Text.ToString().Trim()), richTxtghichu.Text.ToString());
                MessageBox.Show("Thêm phiếu nhập thành công");
            }
            catch (System.Exception ex) { MessageBox.Show("Có lỗi thêm phiếu nhập. " + ex.Message); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
