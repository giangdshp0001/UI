using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace QLNS
{

    public partial class frmdangnhap : Form
    {
        public static string QuyenDoiMatKhau;
        public static string QuyenQLCongDoan;
        public static string QuyenQLTaiChinh;
        public static string QuyenQuanLiNhanSu;
        public static string QuyenQuanTriHeThong;
        public static string QuyenTraCuu;

        Clsdatabase cls = new Clsdatabase();
        //  private SqlConnection Con = null;
      //  private Frm_Main mainWindow;
       // public Form2()
      //  {
           
      //  }
        public frmdangnhap()
        {
            InitializeComponent();
           
        }




        private void frmdangnhap_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
          
           
        }


        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            ((Button)sender).BackgroundImage = Properties.Resources._133;
            ((Button)sender).ForeColor = Color.Red;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackgroundImage = Properties.Resources.xanh;
            ((Button)sender).ForeColor = SystemColors.WindowText;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_MouseMove_1(object sender, MouseEventArgs e)
        {
            ((Button)sender).BackgroundImage = Properties.Resources._133;
            ((Button)sender).ForeColor = Color.Red;
        }

        private void button3_MouseLeave_1(object sender, EventArgs e)
        {
            ((Button)sender).BackgroundImage = Properties.Resources.xanh;
            ((Button)sender).ForeColor = SystemColors.WindowText;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection myConn;
            SqlCommand myCmd;
            string strSelect;
            myConn = new SqlConnection("Data Source=DESKTOP-UT28GA1;Initial Catalog=QLNS;Persist Security Info=True;User ID=sa;Password=123456789");
            myConn.Open();
            strSelect = "select U.Username,U.Quyen,Q.QuyenDoiMatKhau,Q.QuyenQLCongDoan,Q.QuyenQLTaiChinh,Q.QuyenQuanLiNhanSu,Q.QuyenQuanTriHeThong,Q.QuyenTraCuu from tbuser U left join tbquyen Q on U.Quyen = Q.UserRight where upper(U.Username) = '" +  textBox1.Text.ToUpper() + "' and Pass='" + textBox2.Text + "'";
            myCmd = new SqlCommand(strSelect, myConn);
            SqlDataReader reader = myCmd.ExecuteReader();
            int tongquyen = 0;
            string myquyenduocphan = "";
            if (reader.HasRows)
            {
                this.Hide();
                reader.Read();
                string ten = reader.GetString(reader.GetOrdinal("Username"));
                string quyen = reader.GetString(reader.GetOrdinal("Quyen"));
                // for (int x = 1; x < 6; x++)
                //  {
                QuyenDoiMatKhau = reader.GetString(reader.GetOrdinal("QuyenDoiMatKhau")).ToString();
                if (QuyenDoiMatKhau.ToString().Trim() == "1")
                {
                    tongquyen = tongquyen + 1;
                    myquyenduocphan = myquyenduocphan.ToString() + "DoiMatKhau," + " ";
                }
                QuyenQLCongDoan = reader.GetString(reader.GetOrdinal("QuyenQLCongDoan")).ToString();
                if (QuyenQLCongDoan.ToString().Trim() == "1")
                {
                    tongquyen = tongquyen + 1;
                    myquyenduocphan = myquyenduocphan.ToString() + "QLCongDoan," + " ";
                }
                QuyenQLTaiChinh = reader.GetString(reader.GetOrdinal("QuyenQLTaiChinh")).ToString();
                if (QuyenQLTaiChinh.ToString().Trim() == "1")
                {
                    tongquyen = tongquyen + 1;
                    myquyenduocphan = myquyenduocphan.ToString() + "QLTaiChinh," + " ";
                }
                QuyenQuanLiNhanSu = reader.GetString(reader.GetOrdinal("QuyenQuanLiNhanSu")).ToString();
                if (QuyenQuanLiNhanSu.ToString().Trim() == "1")
                {
                    tongquyen = tongquyen + 1;
                    myquyenduocphan = myquyenduocphan.ToString() + "QuanLiNhanSu," + " ";
                }
                QuyenQuanTriHeThong = reader.GetString(reader.GetOrdinal("QuyenQuanTriHeThong")).ToString();
                if (QuyenQuanTriHeThong.ToString().Trim() == "1")
                {
                    tongquyen = tongquyen + 1;
                    myquyenduocphan = myquyenduocphan.ToString() + "QuanTriHeThong," + " ";
                }
                QuyenTraCuu = reader.GetString(reader.GetOrdinal("QuyenTraCuu")).ToString();
                if (QuyenTraCuu.ToString().Trim() == "1")
                {
                    tongquyen = tongquyen + 1;
                    myquyenduocphan = myquyenduocphan.ToString() + "QuyenTraCuu," + " ";
                }
                // }

                if (quyen.ToString().Length > 0)
                {
                    Global.testquyen = quyen.Trim().ToString();
                    Global.gUserName = ten.ToUpper();
                    if (Global.testquyen == "User")
                        MessageBox.Show("Đăng nhập thành công!\nXin chào " + ten.ToUpper() + ". Bạn đang đang nhập với quyền User, chỉ tra cứu thông tin. \n Hãy liên hệ Admin để được phân quyền.", "");
                    else
                        MessageBox.Show("Đăng nhập thành công!\nXin chào " + ten.ToUpper() + ". Bạn đang đang nhập với quyền " + quyen.Trim().ToString().ToUpper() + ".", "");// Tong so quyen: <" + tongquyen + "> bao gồm: " + myquyenduocphan, "Thông báo");
                   
                   
                }
       

                myCmd.Dispose();
                reader.Close();
                reader.Dispose();
                myConn.Close();
                this.Close();

                Frm_Main frm = new Frm_Main();

                frm.ShowDialog();
               
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại hoặc không có quyền truy cập!", "Thông báo !");

            }
        }
    }
       
              
}
