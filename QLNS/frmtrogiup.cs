using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLNS
{
    public partial class frmtrogiup : Form
    {
        public frmtrogiup()
        {
            InitializeComponent();
            label2.Text = "Phần mềm 'Quản lý nhân sự Tiền lương ' được viết bằng ngôn ngữ C# và hệ quản trị cơ sở dữ liệu SQL SERVER với các tính năng cơ bản nhất và có thể nâng cấp theo yêu cầu của người sử dụng. Đây là nội dung khá rộng, đòi hỏi kiến thức quản lý thực tế nhiều nên phần mềm không tránh khỏi còn nhiều thiếu sót, rất mong nhận được sự góp ý để phần mềm ngày càng được hoàn thiện hơn! \n" +
                "Em cũng xin được chân thành cảm ơn sự hỗ trợ, hướng dẫn của Thầy cùng các bạn cùng lớp Khoa Công nghệ Thông tin trường ĐH Hải Phòng trong thời gian qua.";
            label3.Text = "Địa chỉ liên hệ: Phạm Đặng Hồng Giang - Lớp CNTTK19 - ĐH Hải Phòng.\n" +
                "email giangdshp0001@gmail.com";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
