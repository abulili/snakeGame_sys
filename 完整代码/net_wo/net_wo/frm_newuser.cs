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
    public partial class frm_newuser : Form
    {
        public frm_newuser()
        {
            InitializeComponent();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            string sql = "";
            MySqlConnection conn = null;
            MySqlCommand comm = null;
            DataSet ds = null;
            MySqlDataAdapter da = null;

            if (textBox_name.Text.Trim() != "" && textBox_pwd.Text.Trim() != "")
            {
                sql = "select * from userinfo where Id='" + textBox_name.Text.Trim() + "'";
                comm = new MySqlCommand(sql, conn);
                ds = new DataSet();
                da = new MySqlDataAdapter(comm);
                da.Fill(ds);
                if (comm.ExecuteScalar() == null)
                {
                    sql = String.Format("insert into userinfo values('{0}','{1}','用户')", textBox_name.Text.Trim(), textBox_pwd.Text.Trim());
                    comm.CommandText = sql;
                    comm.ExecuteNonQuery();

                    sql = "insert into pictureinfo values('" + textBox_name.Text.Trim() + "',' ')";
                    comm.CommandText = sql;
                    comm.ExecuteNonQuery();

                    sql = "insert into rankinfo values('" + textBox_name.Text.Trim() + "','none', '0')";
                    comm.CommandText = sql;
                    comm.ExecuteNonQuery();

                    MessageBox.Show("注册成功！");
                    conn.Close();

                    frm_log frm = new frm_log();
                    this.Close();
                    frm.Show();
                }
                else MessageBox.Show("已存在该昵称！");
            }
            else MessageBox.Show("不能为空！");
        }

        private void butt_no_Click(object sender, EventArgs e)
        {
            frm_log frm = new frm_log();
            frm.Show();
            this.Close();
        }
    }
}
