using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace net_wo
{
    public partial class frm_log : Form
    {
        public static frm_log frmlogin;
        public frm_log()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //取消
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void butt_log_Click(object sender, EventArgs e)
        {
            string connStr = "server=localhost;port=3306;database=snakeGame;user=root;password=Root@123";
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();

            string sql = "select State from userinfo where Id='" + text_name.Text.Trim() + "' and Pwd='" + text_pwd.Text.Trim() + "'";
            //MessageBox.Show(sql);
            MySqlCommand comm = new MySqlCommand(sql, conn);

            if (text_name.Text.Trim() != "" && text_pwd.Text.Trim() != "")
            {
                string role = (string)comm.ExecuteScalar();
                if (role != null)
                {
                    this.Hide();//隐藏登录窗口
                    frmlogin = this;//静态全局变量
                    frm_main frm = new frm_main(text_name.Text.Trim(), role, text_pwd.Text.Trim());
                    frm.Show();                    //MessageBox.Show(role);
                    conn.Close();//及时关闭
                }
                else MessageBox.Show("用户名或密码错误!");
            }
            else MessageBox.Show("用户名或密码不能为空！");
            conn.Close();
        }


        private void butt_no_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void text_name_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                text_pwd.Focus();
            }
        }

        private void text_pwd_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_pwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                butt_log.Focus();
            }
        }

        private void butt_new_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_newuser frm = new frm_newuser();
            frm.Show();
        }
    }
}
