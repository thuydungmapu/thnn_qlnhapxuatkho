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
    public partial class NhaCungCap : Form
    {
        public NhaCungCap()
        {
            InitializeComponent();
            lblHotennv.Text = "NV. " + Lopketnoi.hotennv;
        }

        private void NhaCungCap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tHNNDataSetNCC_NCC.NHACUNGCAP' table. You can move, or remove it, as needed.
            this.nHACUNGCAPTableAdapter.Fill(this.tHNNDataSetNCC_NCC.NHACUNGCAP);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (btnThem.Text == "THÊM")
            {
                txtmancc.Enabled = true;
                txttenncc.Enabled = true;
                txtmst.Enabled = true;
                txtsdt.Enabled = true;
                rtxdiachi.Enabled = true;
                txtemail.Enabled = true;
                txtstk.Enabled = true;

                btnThem.Text = "LƯU";
                btnsua.Enabled = false;
                btnxoa.Enabled = false;

                txtmancc.Text = "";
                txttenncc.Text = "";
                txtmst.Text = "";
                txtsdt.Text = "";
                rtxdiachi.Text = "";
                txtemail.Text = "";
                txtstk.Text = "";
            }

            else
            {
                try
                {
                    nHACUNGCAPTableAdapter.Insert(txtmancc.Text.ToString().Trim(), txttenncc.Text.ToString(), txtsdt.Text.ToString().Trim(), txtemail.Text.ToString().Trim(), txtstk.Text.ToString().Trim(), txtmst.Text.ToString().Trim(), rtxdiachi.Text.ToString());
                    this.nHACUNGCAPTableAdapter.Fill(this.tHNNDataSetNCC_NCC.NHACUNGCAP);
                    txtmancc.Enabled = false;
                    txttenncc.Enabled = false;
                    txtmst.Enabled = false;
                    txtsdt.Enabled = false;
                    rtxdiachi.Enabled = false;
                    txtemail.Enabled = false;
                    txtstk.Enabled = false;

                    btnThem.Text = "THÊM";
                    btnsua.Enabled = true;
                    btnxoa.Enabled = true;
                    MessageBox.Show("Thêm nhà cung cấp thành công");
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Lỗi thêm NCC " + ex.Message);
                }
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Đã xóa nhà cung cấp " + txtmancc.Text);
                nHACUNGCAPTableAdapter.Delete(txtmancc.Text.ToString().Trim());
                this.nHACUNGCAPTableAdapter.Fill(this.tHNNDataSetNCC_NCC.NHACUNGCAP);
                
            }
            catch (System.Exception) { }
            
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (btnsua.Text == "SỬA")
            {
                txttenncc.Enabled = true;
                txtmst.Enabled = true;
                txtsdt.Enabled = true;
                rtxdiachi.Enabled = true;
                txtemail.Enabled = true;
                txtstk.Enabled = true;

                btnsua.Text = "LƯU";
                btnThem.Enabled = false;
                btnxoa.Enabled = false;
            }

            else
            {
                try
                {
                    nHACUNGCAPTableAdapter.Update(txttenncc.Text.ToString(),txtsdt.Text.ToString(),txtemail.Text.ToString(),txtstk.Text.ToString(),txtmst.Text.ToString(),rtxdiachi.Text.ToString(),txtmancc.Text.ToString().Trim(),txtmancc.Text.ToString().Trim());
                    this.nHACUNGCAPTableAdapter.Fill(this.tHNNDataSetNCC_NCC.NHACUNGCAP);
                   
                    txttenncc.Enabled = false;
                    txtmst.Enabled = false;
                    txtsdt.Enabled = false;
                    rtxdiachi.Enabled = false;
                    txtemail.Enabled = false;
                    txtstk.Enabled = false;

                    btnsua.Text = "SỬA";
                    btnThem.Enabled = true;
                    btnxoa.Enabled = true;
                    MessageBox.Show("Sửa nhà cung cấp thành công");
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Lỗi sửa NCC " + ex.Message);
                }
            }
        }
    }
}
