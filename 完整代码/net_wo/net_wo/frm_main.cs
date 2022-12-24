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
    public partial class frm_main : Form
    {
        String UserName = "", Role = "", PassWord = "";
        bool logout = false;

        private void 注销_Click(object sender, EventArgs e)
        {
            frm_log.frmlogin.Show();
            logout = true;
            this.Close();
        }

        private void frm_main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!logout)
            {
                frm_log.frmlogin.Close();
            }
        }

        private void 修改密码_Click(object sender, EventArgs e)
        {
            frm_changePwd frm = new frm_changePwd(UserName);
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
        }

        private void 个人信息_Click(object sender, EventArgs e)
        {
            frm_user frm = new frm_user(UserName);
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
        }

        private void 用户管理_Click(object sender, EventArgs e)
        {
            frm_manage frm = new frm_manage(UserName);
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
        }

        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_help frm = new frm_help(UserName);
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
        }

        private void 排行榜ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_rank frm = new frm_rank();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
        }

        private void 添加用户_Click(object sender, EventArgs e)
        {
            frm_adduser frm = new frm_adduser();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
        }

        private void 用户反馈_Click(object sender, EventArgs e)
        {
           
            frm_info frm = new frm_info();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
        }

        private void 开始游戏_Click(object sender, EventArgs e)
        {
            frm_snake frm = new frm_snake(UserName);
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
        }

        public frm_main(string username, string role, string password)
        {
            InitializeComponent();
            UserName = username;
            Role = role;
            PassWord = password;

            if(role == "管理员")
            {
                用户管理.Visible = true;
                用户反馈.Visible = true;
                添加用户.Visible = true;
                开始游戏.Visible = false;
                帮助.Visible = false;
            }
        }
    }
}
