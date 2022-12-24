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
    public partial class frm_manage : Form
    {
        MySqlDataAdapter da = null;//最好初始化
        DataSet ds = null;
        MySqlConnection conn = null;
        MySqlCommand comm = null;
        string sql = "";
        String username = "";
        public frm_manage(String name)
        {
            InitializeComponent();
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            username = name;
            string connStr = "server=localhost;port=3306;database=snakeGame;user=root;password=Root@123";
            conn = new MySqlConnection(connStr);
            conn.Open();

            sql = "select * from userinfo";
            comm = new MySqlCommand(sql, conn);

            ds = new DataSet();
            da = new MySqlDataAdapter(comm);
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void but_rePwd_Click(object sender, EventArgs e)
        {
                sql = "update userinfo set Pwd='12345' where Id = '" + text_name.Text + "'";
                comm.CommandText = sql;
                string temp = text_name.Text;
                comm.ExecuteNonQuery();
                comboBox_state.SelectedIndex = 0;
                sql = "select * from userinfo";
                MessageBox.Show(sql);
                comm.CommandText = sql;
                comm.ExecuteNonQuery();

                ds.Clear();
                da.Fill(ds);
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = ds.Tables[0];
                MessageBox.Show("重置成功！");
        }

        private void butt_del_Click(object sender, EventArgs e)
        {
            if (text_name.Text != "")
            {
                sql = "delete from userinfo where Id='" + text_name.Text + "'";
                comm.CommandText = sql;
                comm.ExecuteNonQuery();

                comboBox_state.SelectedIndex = 0;

                sql = "select * from userinfo";
                comm.CommandText = sql;
                comm.ExecuteNonQuery();

                ds.Clear();
                da.Fill(ds);
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = ds.Tables[0];
                MessageBox.Show("成功删除该用户！");
            }
            else MessageBox.Show("没有选中任何行！");
        }

        private void butto_ok_Click(object sender, EventArgs e)
        {
            sql = "update userinfo set State='"+ comboBox_state.Text + "' where Id = '" + text_name.Text + "'";
            comm.CommandText = sql;
            comm.ExecuteNonQuery();

            sql = "select * from userinfo";
            comm.CommandText = sql;
            comm.ExecuteNonQuery();

            ds.Clear();
            da.Fill(ds);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = ds.Tables[0];

            MessageBox.Show("修改成功！");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;
                text_name.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                comboBox_state.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            else MessageBox.Show("未选中任何行");
        }

        private void 删除_Click(object sender, EventArgs e)
        {
            butt_del_Click(sender, e);
        }

        private void but_bad_Click(object sender, EventArgs e)
        {
            sql = "delete from userinfo where id='" + username + "'";
            comm.CommandText = sql;
            comm.ExecuteNonQuery();

            sql = "insert into blacklist values('" + username + "','" + text_reasion.Text.Trim().ToString() + "')";
            comm.CommandText = sql;
            comm.ExecuteNonQuery();

            MessageBox.Show("加入成功，后续请重新添加此用户");
        }

        private void text_reasion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
