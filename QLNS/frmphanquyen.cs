using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLNS
{
    public partial class frmphanquyen : Form
    {
        Clsdatabase cls = new Clsdatabase();
        public static SqlConnection Con;
        public frmphanquyen()
        {
            InitializeComponent();
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmphanquyen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.TblTTNVCoBan' table. You can move, or remove it, as needed.
            //this.tblTTNVCoBanTableAdapter.Fill(this.dataSet1.TblTTNVCoBan);
            Con = new SqlConnection();
            Con.ConnectionString = @"Data Source=DESKTOP-UT28GA1;Initial Catalog=QLNS;Persist Security Info=True;User ID=sa;Password=123456789";
            // dateTimePicker1.CustomFormat = " MM / dd / yyyy ";
            // dateTimePicker3.CustomFormat = " MM / dd / yyyy ";
            // dateTimePicker4.CustomFormat = " MM / dd / yyyy ";
            // cls.loadcombobox(comboBox4, "select MaLuong from TblBangLuongCTy", 0);

            //  frmcoban.FillCombo("SELECT MaBoPhan FROM TblBoPhan", comboBox2, "MaBoPhan", "MaBoPhan");
            // comboBox2.SelectedIndex = -1;

            cls.loaddatagridview2(GridPhanQuyen, "select U.Username,U.Quyen,Q.QuyenDoiMatKhau,Q.QuyenQLCongDoan, Q.QuyenQLTaiChinh, Q.QuyenQuanLiNhanSu,Q.QuyenQuanTriHeThong from tbuser U left join tbquyen Q on U.Quyen = Q.UserRight");

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btOK_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result=MessageBox.Show("Bạn có chắc chắn phân quyền cho user " + txtUser.Text + " không?", "PHÂN QUYỀN",buttons,MessageBoxIcon.Question);

           // MessageBox.Show(result.ToString(), "");

            if (result.ToString() == "Yes")
            {
                string update = "";
                if (rbQuanTriVien.Checked == true)
                {
                    update = "update tbuser set Quyen='QuanTriVien' where UserName='" + txtUser.Text + "'";
                }
                else if (rbNVTaiChinh.Checked == true)
                {
                    update = "update tbuser set Quyen='NVTaiChinh' where UserName='" + txtUser.Text + "'";
                }
                else if (rbNVPhongNhanSu.Checked == true)
                {
                    update = "update tbuser set Quyen='NVPhongNhanSu' where UserName='" + txtUser.Text + "'";
                }
                else if (rbNVCongDoan.Checked == true)
                {
                    update = "update tbuser set Quyen='NVCongDoan' where UserName='" + txtUser.Text + "'";
                }
                else 
                {
                    update = "update tbuser set Quyen='User' where UserName='" + txtUser.Text + "'";
                }
              //  MessageBox.Show(update, "");
                cls.thucthiketnoi(update);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            // Application.Exit();
        }

        private void GridPhanQuyen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void GridPhanQuyen_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUser.Text = GridPhanQuyen.Rows[e.RowIndex].Cells["Username"].Value.ToString();

            //Store1 = txtUser.Text;
            //Store2= GridPhanQuyen.Rows[e.RowIndex].Cells["Quyen"].Value.ToString();
            //Store3 = GridPhanQuyen.Rows[e.RowIndex].Cells["QuyenDoiMatKhau"].Value.ToString();
            //Store4 = GridPhanQuyen.Rows[e.RowIndex].Cells["QuyenDoiMatKhau"].Value.ToString();
            //Store5 = GridPhanQuyen.Rows[e.RowIndex].Cells["QuyenDoiMatKhau"].Value.ToString();
            //Store6 = GridPhanQuyen.Rows[e.RowIndex].Cells["QuyenDoiMatKhau"].Value.ToString();
            //Store7 = GridPhanQuyen.Rows[e.RowIndex].Cells["QuyenDoiMatKhau"].Value.ToString();

            //cbQuanTriVien.Checked= 
            //  txtUser.Text = GridPhanQuyen.Rows[e.RowIndex].Cells[0].Value.ToString();
            //   cbQuanTriVien.Checked= GridPhanQuyen.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void rbQuanTriVien_CheckedChanged(object sender, EventArgs e)
        {

            for (int i = 0; i < GridPhanQuyen.Rows.Count - 1; i++)
            {

                if (txtUser.Text.ToString() == GridPhanQuyen.Rows[i].Cells[0].Value.ToString())
                {

                    //  MessageBox.Show(GridPhanQuyen.Rows[i].Cells[0].Value.ToString(), "");
                    GridPhanQuyen.Rows[i].Cells["Quyen"].Value = "QuanTriVien";
                    GridPhanQuyen.Rows[i].Cells["QuyenDoiMatKhau"].Value = 1; // Convert.ToInt32(cbQuanTriVien.Checked);
                    GridPhanQuyen.Rows[i].Cells["QuyenQLCongDoan"].Value = 1;
                    GridPhanQuyen.Rows[i].Cells["QuyenQLTaiChinh"].Value = 1;
                    GridPhanQuyen.Rows[i].Cells["QuyenQuanLiNhanSu"].Value = 1;
                    GridPhanQuyen.Rows[i].Cells["QuyenQuanTriHeThong"].Value = 1;
                    break;
                }

            }
        }

        private void rbNVPhongNhanSu_CheckedChanged(object sender, EventArgs e)
        {
            GridPhanQuyen.CancelEdit();
            GridPhanQuyen.RefreshEdit();
            for (int i = 0; i < GridPhanQuyen.Rows.Count - 1; i++)
            {

                if (txtUser.Text.ToString() == GridPhanQuyen.Rows[i].Cells[0].Value.ToString())
                {

                    //  MessageBox.Show(GridPhanQuyen.Rows[i].Cells[0].Value.ToString(), "");
                    GridPhanQuyen.Rows[i].Cells["Quyen"].Value = "NVPhongNhanSu";
                    GridPhanQuyen.Rows[i].Cells["QuyenDoiMatKhau"].Value = 1; // Convert.ToInt32(cbQuanTriVien.Checked);
                    GridPhanQuyen.Rows[i].Cells["QuyenQLCongDoan"].Value = 0;
                    GridPhanQuyen.Rows[i].Cells["QuyenQLTaiChinh"].Value = 0;
                    GridPhanQuyen.Rows[i].Cells["QuyenQuanLiNhanSu"].Value = 1;
                    GridPhanQuyen.Rows[i].Cells["QuyenQuanTriHeThong"].Value = 0;
                    break;
                }

            }
        }

        private void rbNVTaiChinh_CheckedChanged(object sender, EventArgs e)
        {
            GridPhanQuyen.CancelEdit();
            GridPhanQuyen.RefreshEdit();
            for (int i = 0; i < GridPhanQuyen.Rows.Count - 1; i++)
            {

                if (txtUser.Text.ToString() == GridPhanQuyen.Rows[i].Cells[0].Value.ToString())
                {

                    //  MessageBox.Show(GridPhanQuyen.Rows[i].Cells[0].Value.ToString(), "");
                    GridPhanQuyen.Rows[i].Cells["Quyen"].Value = "NVTaiChinh";
                    GridPhanQuyen.Rows[i].Cells["QuyenDoiMatKhau"].Value = 1; // Convert.ToInt32(cbQuanTriVien.Checked);
                    GridPhanQuyen.Rows[i].Cells["QuyenQLCongDoan"].Value = 0;
                    GridPhanQuyen.Rows[i].Cells["QuyenQLTaiChinh"].Value = 1;
                    GridPhanQuyen.Rows[i].Cells["QuyenQuanLiNhanSu"].Value = 0;
                    GridPhanQuyen.Rows[i].Cells["QuyenQuanTriHeThong"].Value = 0;
                    break;
                }


            }
        }
        private void rbNVCongDoan_CheckedChanged(object sender, EventArgs e)
        {
            GridPhanQuyen.CancelEdit();
            GridPhanQuyen.RefreshEdit();
            for (int i = 0; i < GridPhanQuyen.Rows.Count - 1; i++)
            {

                if (txtUser.Text.ToString() == GridPhanQuyen.Rows[i].Cells[0].Value.ToString())
                {

                    //  MessageBox.Show(GridPhanQuyen.Rows[i].Cells[0].Value.ToString(), "");
                    GridPhanQuyen.Rows[i].Cells["Quyen"].Value = "NVCongDoan";
                    GridPhanQuyen.Rows[i].Cells["QuyenDoiMatKhau"].Value = 1; // Convert.ToInt32(cbQuanTriVien.Checked);
                    GridPhanQuyen.Rows[i].Cells["QuyenQLCongDoan"].Value = 1;
                    GridPhanQuyen.Rows[i].Cells["QuyenQLTaiChinh"].Value = 0;
                    GridPhanQuyen.Rows[i].Cells["QuyenQuanLiNhanSu"].Value = 0;
                    GridPhanQuyen.Rows[i].Cells["QuyenQuanTriHeThong"].Value = 0;
                    break;
                }

            }
        }
        private void rbUser_CheckedChanged(object sender, EventArgs e)
        {
            GridPhanQuyen.CancelEdit();
            GridPhanQuyen.RefreshEdit();
            for (int i = 0; i < GridPhanQuyen.Rows.Count - 1; i++)
            {

                if (txtUser.Text.ToString() == GridPhanQuyen.Rows[i].Cells[0].Value.ToString())
                {

                    //  MessageBox.Show(GridPhanQuyen.Rows[i].Cells[0].Value.ToString(), "");
                    GridPhanQuyen.Rows[i].Cells["Quyen"].Value = "User";
                    GridPhanQuyen.Rows[i].Cells["QuyenDoiMatKhau"].Value = 1; // Convert.ToInt32(cbQuanTriVien.Checked);
                    GridPhanQuyen.Rows[i].Cells["QuyenQLCongDoan"].Value = 0;
                    GridPhanQuyen.Rows[i].Cells["QuyenQLTaiChinh"].Value = 0;
                    GridPhanQuyen.Rows[i].Cells["QuyenQuanLiNhanSu"].Value = 0;
                    GridPhanQuyen.Rows[i].Cells["QuyenQuanTriHeThong"].Value = 0;
                    break;
                }

            }
        }
    }
}
        
