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
    public partial class KhachHang : Form
    {
        public KhachHang()
        {
            InitializeComponent();
            lblHotennv.Text = "NV. " + Lopketnoi.hotennv;
        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tHNNDataSetKH_KH.KHACHHANG' table. You can move, or remove it, as needed.
            this.kHACHHANGTableAdapter.Fill(this.tHNNDataSetKH_KH.KHACHHANG);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                kHACHHANGTableAdapter.Delete(txtmakh.Text.ToString().Trim());
                this.kHACHHANGTableAdapter.Fill(this.tHNNDataSetKH_KH.KHACHHANG);
                MessageBox.Show("Xóa khách hàng thành công");
            }
            catch (System.Exception ex) { MessageBox.Show("Có lỗi xóa khách hàng"); }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if(btnthem.Text=="THÊM")
            {
                txtmakh.Text = "";
                txttenkh.Text = "";
                txtmst.Text = "";
                txtdiachi.Text = "";
                txtsdt.Text = "";
                txtstk.Text = "";
                txtemail.Text = "";

                txtmakh.Enabled = true;
                txttenkh.Enabled = true;
                txtmst.Enabled = true;
                txtdiachi.Enabled = true;
                txtsdt.Enabled = true;
                txtstk.Enabled = true;
                txtemail.Enabled = true;

                btnsua.Enabled = false;
                btnxoa.Enabled = false;
                btnthem.Text = "LƯU";

            }
            else
            {
                try
                {
                    kHACHHANGTableAdapter.Insert(txtmakh.Text.ToString().Trim(), txttenkh.Text.ToString(), txtsdt.Text.ToString(), txtemail.Text.ToString(), txtstk.Text.ToString(), txtmst.Text.ToString().Trim(), txtdiachi.Text.ToString());
                    this.kHACHHANGTableAdapter.Fill(this.tHNNDataSetKH_KH.KHACHHANG);
                    MessageBox.Show("Thêm khách hàng thành công");
                    btnthem.Text = "THÊM";

                    txtmakh.Enabled = false;
                    txttenkh.Enabled = false;
                    txtmst.Enabled = false;
                    txtsdt.Enabled = false;
                    txtdiachi.Enabled = false;
                    txtstk.Enabled = false;
                    txtemail.Enabled = false;

                    btnsua.Enabled = true;
                    btnxoa.Enabled = true;
                }
                catch (System.Exception) { }
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (btnsua.Text == "SỬA")
            {

                txttenkh.Enabled = true;
                txtmst.Enabled = true;
                txtdiachi.Enabled = true;
                txtsdt.Enabled = true;
                txtstk.Enabled = true;
                txtemail.Enabled = true;

                btnthem.Enabled = false;
                btnxoa.Enabled = false;
                btnsua.Text = "LƯU";

            }
            else
            {
                try
                {
                    kHACHHANGTableAdapter.Update(txttenkh.Text.ToString(), txtsdt.Text.ToString(), txtemail.Text.ToString(), txtstk.Text.ToString(), txtmst.Text.ToString(), txtdiachi.Text.ToString(), txtmakh.Text.ToString().Trim(), txtmakh.Text.ToString().Trim());
                    this.kHACHHANGTableAdapter.Fill(this.tHNNDataSetKH_KH.KHACHHANG);
                    MessageBox.Show("Sửa khách hàng thành công");
                    btnsua.Text = "SỬA";

                    txttenkh.Enabled = false;
                    txtmst.Enabled = false;
                    txtsdt.Enabled = false;
                    txtdiachi.Enabled = false;
                    txtstk.Enabled = false;
                    txtemail.Enabled = false;

                    btnthem.Enabled = true;
                    btnxoa.Enabled = true;
                }
                catch (System.Exception) { }
            }
        }
    }
}
