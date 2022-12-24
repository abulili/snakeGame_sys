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
    public partial class frm_adduser : Form
    {
        string sql = "";
        MySqlConnection conn = null;
        MySqlCommand comm = null;
        DataSet ds = null;
        MySqlDataAdapter da = null;
        public frm_adduser()
        {
            InitializeComponent();

            string connstr = "server=localhost;port=3306;database=snakeGame;user=root;password=Root@123";
            conn = new MySqlConnection(connstr);
            conn.Open();

            comboBox1.SelectedIndex = 1;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (textBox_name.Text.Trim() != "" && textBox_pwd.Text.Trim() != "")
            {
                sql = "select * from userinfo where Id='" + textBox_name.Text.Trim() + "'";
                comm = new MySqlCommand(sql, conn);
                ds = new DataSet();
                da = new MySqlDataAdapter(comm);
                da.Fill(ds);
                if (comm.ExecuteScalar() == null)
                {
                    string users = comboBox1.Text.Trim();
                    sql = String.Format("insert into userinfo values('{0}','12345','{1}')", textBox_name.Text.Trim(), users);
                    comm.CommandText = sql;
                    comm.ExecuteNonQuery();

                    sql = "insert into pictureinfo values('" + textBox_name.Text.Trim() + "',' ')";
                    comm.CommandText = sql;
                    comm.ExecuteNonQuery();

                    sql = "insert into rankinfo values('" + textBox_name.Text.Trim() + "','none', '0')";
                    comm.CommandText = sql;
                    comm.ExecuteNonQuery();

                    MessageBox.Show("添加信息成功！");
                }
                else MessageBox.Show("已存在该用户");
            }
            else MessageBox.Show("不能为空！");
        }

        private void butt_no_Click(object sender, EventArgs e)
        {
            conn.Close();
            this.Close();
        }
    }
}
