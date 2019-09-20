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
            lblHotennv.Text = "NV. " + Lopketnoi.hotennv;
        }

        private void NhapKho_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tHNNDataSetCTPN_pn.CTPHIEUNHAP' table. You can move, or remove it, as needed.
            this.cTPHIEUNHAPTableAdapter.Fill(this.tHNNDataSetCTPN_pn.CTPHIEUNHAP);
            // TODO: This line of code loads data into the 'tHNNDataSetHH_PN.HANGHOA' table. You can move, or remove it, as needed.
            this.hANGHOATableAdapter.Fill(this.tHNNDataSetHH_PN.HANGHOA);
            // TODO: This line of code loads data into the 'tHNNDataSetPhieuNhap.PHIEUNHAP' table. You can move, or remove it, as needed.
            this.pHIEUNHAPTableAdapter.Fill(this.tHNNDataSetPhieuNhap.PHIEUNHAP);
            // TODO: This line of code loads data into the 'tHNNDataSetNCC.NHACUNGCAP' table. You can move, or remove it, as needed.
            this.nHACUNGCAPTableAdapter.Fill(this.tHNNDataSetNCC.NHACUNGCAP);
            // TODO: This line of code loads data into the 'tHNNDataSetNVPNK.NHANVIEN' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter.Fill(this.tHNNDataSetNVPNK.NHANVIEN);
            txtngaypn.Text = DateTime.Now.ToShortDateString();
            DateTime t = System.DateTime.Now;
            txtmpn.Text = "PN" + t.Year.ToString().Substring(2, 2) + t.Month.ToString() + t.Day.ToString() + t.Hour.ToString() + t.Minute.ToString() + t.Second.ToString();

            //for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            //{
               // if(dataGridView1.Rows[i].Cells[0].Value.ToString()!="")
               // {
                  //  dataGridView1.Rows[i].Cells[0].Value= ;
               // }
           // }

        }


        private void btnThemNCC_Click(object sender, EventArgs e)
        {
            NhaCungCap fr = new NhaCungCap();
            fr.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                pHIEUNHAPTableAdapter.Insert(txtmpn.Text.ToString().Trim(), txtMaNCC.Text.ToString().Trim(), Lopketnoi.manv, DateTime.Parse(txtngaypn.Text.ToString().Trim()), rtbghichu.Text);
                MessageBox.Show("Thêm Phiếu nhập thành công");
                this.Close();
            }
            catch (System.Exception ex) { MessageBox.Show("Lỗi thêm phiếu nhâp"); }
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
