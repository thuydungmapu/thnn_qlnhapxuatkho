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
            // TODO: This line of code loads data into the 'tHNNDataSetNCC.NHACUNGCAP' table. You can move, or remove it, as needed.
            this.nHACUNGCAPTableAdapter.Fill(this.tHNNDataSetNCC.NHACUNGCAP);
            // TODO: This line of code loads data into the 'tHNNDataSetNVPNK.NHANVIEN' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter.Fill(this.tHNNDataSetNVPNK.NHANVIEN);
            

        }
    }
}
