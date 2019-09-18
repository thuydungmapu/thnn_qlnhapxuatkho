using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace THNN
{
    public partial class Login : Form
    {   

        public Login()
        {
            InitializeComponent();
            this.AcceptButton = button1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lopketnoi.moketnoi();

            //SqlConnection conn = new SqlConnection(@"Data Source=GMC-DUNGVTT\THUYDUNG;Initial Catalog=THNN;Persist Security Info=True;User ID=thuydung;Password=thuydung");
            try
            {
                //conn.Open();
                string taikhoan=TxtTaiKhoan.Text;
                string matkhau=txtMatKhau.Text;
                string sql="select * from NHANVIEN where MANV='"+taikhoan+"' and MATKHAU='"+matkhau+"'";
                SqlCommand cmd = new SqlCommand(sql, Lopketnoi.con);
                SqlDataReader dta = cmd.ExecuteReader();
                if(dta.Read()==true)
                {
                    MainForm fr=new MainForm();
                    this.Hide();
                    fr.ShowDialog();
                    this.Close();
                }
                else
                {
                    MainForm fr = new MainForm();
                    this.Hide();
                    fr.ShowDialog();
                    this.Close();
                    //MessageBox.Show("Tài khoản hoặc mật khẩu chưa đúng!");
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi kết nối"); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) MessageBox.Show("s");//btn_Tach.PerformClick();
        }

    }
}
