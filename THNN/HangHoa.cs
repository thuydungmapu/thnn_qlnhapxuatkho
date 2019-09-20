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
    public partial class HangHoa : Form
    {
        public HangHoa()
        {
            InitializeComponent();
            lblHotennv.Text = "NV. " + Lopketnoi.hotennv;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HangHoa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tHNNDataSetLHH1.LOAIHANGHOA' table. You can move, or remove it, as needed.
            this.lOAIHANGHOATableAdapter1.Fill(this.tHNNDataSetLHH1.LOAIHANGHOA);
            // TODO: This line of code loads data into the 'tHNNDataSetLHH_HH.LOAIHANGHOA' table. You can move, or remove it, as needed.
            this.lOAIHANGHOATableAdapter.Fill(this.tHNNDataSetLHH_HH.LOAIHANGHOA);
            try{
                // TODO: This line of code loads data into the 'tHNNDataSetHH_HH.HANGHOA' table. You can move, or remove it, as needed.
                this.hANGHOATableAdapter.Fill(this.tHNNDataSetHH_HH.HANGHOA, ccblhh.SelectedValue.ToString());
            }
            catch (System.Exception) { }
            

        }

        private void ccblhh_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'tHNNDataSetHH_HH.HANGHOA' table. You can move, or remove it, as needed.
                this.hANGHOATableAdapter.Fill(this.tHNNDataSetHH_HH.HANGHOA, ccblhh.SelectedValue.ToString());
            }
            catch (System.Exception) { }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                hANGHOATableAdapter.Delete(txtmahh.Text.ToString().Trim());
                this.hANGHOATableAdapter.Fill(this.tHNNDataSetHH_HH.HANGHOA, ccblhh.SelectedValue.ToString());

            }
            catch (System.Exception) { MessageBox.Show("Có lỗi xóa hàng hóa"); }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if(btnthem.Text=="THÊM")
            {
                ccblhh1.Visible = true;
                Txttenloai1.Visible = true;
                txtmaloai.Visible = false;
                txttenloai.Visible = false;

                txtmaloai.Enabled = true;
                txtmahh.Enabled = true;
                txttenhh.Enabled = true;
                txtdvt.Enabled = true;
                rtbmota.Enabled = true;

                txttenhh.Text = "";
                txtmahh.Text = "";
                txtdvt.Text = "";
                rtbmota.Text = "";

                btnsua.Enabled = false;
                btnxoa.Enabled = false;
                btnthem.Text = "LƯU";
            }
            else
            {
                try
                {
                    hANGHOATableAdapter.Insert(txtmahh.Text.ToString().Trim(), ccblhh1.SelectedValue.ToString(), txttenhh.Text.ToString(), txtdvt.Text.ToString(), rtbmota.Text.ToString());
                    this.hANGHOATableAdapter.Fill(this.tHNNDataSetHH_HH.HANGHOA, ccblhh.SelectedValue.ToString());
                    MessageBox.Show("Thêm hàng hóa thành công");

                    ccblhh1.Visible = false;
                    Txttenloai1.Visible = false;
                    txtmaloai.Visible = true;
                    txttenloai.Visible = true;

                    txtmaloai.Enabled = false;
                    txtmahh.Enabled = false;
                    txttenhh.Enabled = false;
                    txtdvt.Enabled = false;
                    rtbmota.Enabled = false;

                    btnsua.Enabled = true;
                    btnxoa.Enabled = true;
                    btnthem.Text = "THÊM";
                }
                catch (System.Exception ex) { MessageBox.Show("Có lỗi thêm hàng hóa " + ex.Message); }
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (btnsua.Text == "SỬA")
            {
                ccblhh1.Visible = true;
                Txttenloai1.Visible = true;
                txtmaloai.Visible = false;
                txttenloai.Visible = false;

                txtmaloai.Enabled = true;
                //txtmahh.Enabled = true;
                txttenhh.Enabled = true;
                txtdvt.Enabled = true;
                rtbmota.Enabled = true;

                btnthem.Enabled = false;
                btnxoa.Enabled = false;
                btnsua.Text = "LƯU";
            }
            else
            {
                try
                {
                    hANGHOATableAdapter.Update(ccblhh1.SelectedValue.ToString(), txttenhh.Text.ToString(), txtdvt.Text.ToString(), rtbmota.Text.ToString(), txtmahh.Text.ToString().Trim(), txtmahh.Text.ToString().Trim());
                    this.hANGHOATableAdapter.Fill(this.tHNNDataSetHH_HH.HANGHOA, ccblhh.SelectedValue.ToString());
                    MessageBox.Show("Sửa hàng hóa thành công");

                    ccblhh1.Visible = false;
                    Txttenloai1.Visible = false;
                    txtmaloai.Visible = true;
                    txttenloai.Visible = true;

                    txtmaloai.Enabled = false;
                    txttenhh.Enabled = false;
                    txtdvt.Enabled = false;
                    rtbmota.Enabled = false;

                    btnthem.Enabled = true;
                    btnxoa.Enabled = true;
                    btnsua.Text = "SỬA";
                }
                catch (System.Exception ex) { MessageBox.Show("Có lỗi sửa hàng hóa " + ex.Message); }
            }
        }
    }
}
