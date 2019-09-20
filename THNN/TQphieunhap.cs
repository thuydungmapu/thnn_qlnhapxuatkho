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
    public partial class TQphieunhap : Form
    {
        public TQphieunhap()
        {
            InitializeComponent();
        }

        

        private void TQphieunhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tHNNDataSetPN_TQPN.PHIEUNHAP' table. You can move, or remove it, as needed.
            this.pHIEUNHAPTableAdapter.Fill(this.tHNNDataSetPN_TQPN.PHIEUNHAP);
            try{
                this.cTPHIEUNHAPTableAdapter.Fill(this.tHNNDataSetCTPN_TQPN.CTPHIEUNHAP, txtsopn.Text.ToString().Trim());
            }
            catch (System.Exception) { }
        }

      
        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NhapKho fr = new NhapKho();
            fr.ShowDialog();
            this.pHIEUNHAPTableAdapter.Fill(this.tHNNDataSetPN_TQPN.PHIEUNHAP);
            try
            {
                this.cTPHIEUNHAPTableAdapter.Fill(this.tHNNDataSetCTPN_TQPN.CTPHIEUNHAP, txtsopn.Text.ToString().Trim());
            }
            catch (System.Exception) { }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                cTPHIEUNHAPTableAdapter.Delete(txtsopn.Text.ToString().Trim());
                pHIEUNHAPTableAdapter.Delete(txtsopn.Text.ToString().Trim());
                MessageBox.Show("Đã xóa phiếu nhập");

                this.pHIEUNHAPTableAdapter.Fill(this.tHNNDataSetPN_TQPN.PHIEUNHAP);
                try
                {
                    this.cTPHIEUNHAPTableAdapter.Fill(this.tHNNDataSetCTPN_TQPN.CTPHIEUNHAP, txtsopn.Text.ToString().Trim());
                }
                catch (System.Exception) { }

            }
            catch (System.Exception) { }
            
            

        }
    }
}
