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
    public partial class frm_help : Form
    {
        MySqlDataAdapter da = null;//最好初始化
        DataSet ds = null;
        MySqlConnection conn = null;
        MySqlCommand comm = null;
        string sql = "", Username = "", role = "";
        public frm_help(String user)
        {
            InitializeComponent();
            Username = user;
        }

        private void button_no_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox_sub_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_wanna_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void butt_sub_Click(object sender, EventArgs e)
        {
            string connStr = "server=localhost;port=3306;database=snakeGame;user=root;password=Root@123";
            conn = new MySqlConnection(connStr);
            conn.Open();
            if (textBox_sub.Text.Trim() != "")
            {
                if(textBox_sub.Text.Trim().Length > 100)
                {
                    MessageBox.Show("超出字数！");
                }
                else
                {
                    sql = String.Format("insert into questioninfo values('{0}','{1}')", Username, textBox_sub.Text.Trim());
                    comm = new MySqlCommand(sql, conn);
                    ds = new DataSet();
                    da = new MySqlDataAdapter(comm);
                    da.Fill(ds);
                    MessageBox.Show("提交成功！");
                }
                textBox_sub.Text = "";
            }
            else
            {
                MessageBox.Show("消息不能为空！");   
            }
            conn.Close();
        }
    }
}
