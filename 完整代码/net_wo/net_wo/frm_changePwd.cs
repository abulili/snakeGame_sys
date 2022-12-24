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
    public partial class frm_changePwd : Form
    {
        MySqlDataAdapter da = null;//最好初始化
        DataSet ds = null;
        MySqlConnection conn = null;
        MySqlCommand comm = null;
        string sql = "";
        public frm_changePwd(String role)
        {
            InitializeComponent();
            text_user.Text = role;

            string connStr = "server=localhost;port=3306;database=snakeGame;user=root;password=Root@123";
            conn = new MySqlConnection(connStr);
            conn.Open();

            sql = "select Id from userinfo";
            comm = new MySqlCommand(sql, conn);
            ds = new DataSet();
            da = new MySqlDataAdapter(comm);
            da.Fill(ds);
        }

        private void butt_ok_Click(object sender, EventArgs e)
        {
            if(text_user.Text.Trim() != "" && text_pa.Text.Trim() != "" && text_pa_new.Text.Trim() != "" && text_pa_ok.Text.Trim() != "")
            {
                sql = "select Pwd from userinfo where Id='" + text_user.Text + "'";
                comm = new MySqlCommand(sql, conn);
                ds = new DataSet();
                da = new MySqlDataAdapter(comm);
                da.Fill(ds);
                string passwd = (string)comm.ExecuteScalar();


                if (passwd != text_pa.Text.Trim())
                {
                    MessageBox.Show("请输入正确密码！");
                }
                else
                {
                    if (text_pa_ok.Text.Trim() == text_pa_new.Text.Trim())
                    {
                        sql = "update userinfo set Pwd='" + text_pa_new.Text.Trim() + "' where Id='" + text_user.Text + "'";
                        comm.CommandText = sql;
                        comm.ExecuteNonQuery();

                        MessageBox.Show("密码修改成功！");
                    }
                    else MessageBox.Show("密码必须一致！");
                }
            }
            else MessageBox.Show("所有信息不能为空！");
        }

        private void butt_no_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
