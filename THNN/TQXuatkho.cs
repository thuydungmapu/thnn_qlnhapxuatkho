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
    public partial class TQXuatkho : Form
    {
        public TQXuatkho()
        {
            InitializeComponent();
        }

        private void TQXuatkho_Load(object sender, EventArgs e)
        {
            this.pHIEUXUATTableAdapter.Fill(this.tHNNDataSetPX_TQPX.PHIEUXUAT);
            try
            {
                this.cTPHIEUXUATTableAdapter.Fill(this.tHNNDataSetCTPX_TQPX.CTPHIEUXUAT,txtpx.Text.ToString().Trim());
            }
            catch (System.Exception) { }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XuatKho fr = new XuatKho();
            fr.ShowDialog();
            this.pHIEUXUATTableAdapter.Fill(this.tHNNDataSetPX_TQPX.PHIEUXUAT);
            try
            {
                this.cTPHIEUXUATTableAdapter.Fill(this.tHNNDataSetCTPX_TQPX.CTPHIEUXUAT, txtpx.Text.ToString().Trim());
            }
            catch (System.Exception) { }

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                cTPHIEUXUATTableAdapter.Delete(txtpx.Text.ToString().Trim());
                pHIEUXUATTableAdapter.Delete(txtpx.Text.ToString().Trim());
                this.pHIEUXUATTableAdapter.Fill(this.tHNNDataSetPX_TQPX.PHIEUXUAT);
                try
                {
                    this.cTPHIEUXUATTableAdapter.Fill(this.tHNNDataSetCTPX_TQPX.CTPHIEUXUAT, txtpx.Text.ToString().Trim());
                }
                catch (System.Exception) { }
                MessageBox.Show("xóa phiêu xuất thành công");
            }
            catch (System.Exception) { }
        }

        
    }
}
