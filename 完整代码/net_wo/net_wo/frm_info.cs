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
    public partial class frm_info : Form
    {
        string sql = "";
        MySqlConnection conn = null;
        MySqlCommand comm = null;
        DataSet ds = null;
        MySqlDataAdapter da = null;
        public frm_info()
        {
            InitializeComponent();

            string connStr = "server=localhost;port=3306;database=snakeGame;user=root;password=Root@123";
            conn = new MySqlConnection(connStr);
            conn.Open();

            sql = "select * from questioninfo";
            comm = new MySqlCommand(sql, conn);

            ds = new DataSet();
            da = new MySqlDataAdapter(comm);
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            sql = "delete from questioninfo where Ques = '" + textBox1.Text + "'";
            comm.CommandText = sql;
            comm.ExecuteNonQuery();
            MessageBox.Show("处理成功！");

            textBox1.Text = "";
            sql = "select * from questioninfo";
            comm.CommandText = sql;
            comm.ExecuteNonQuery();

            ds.Clear();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button_no_Click(object sender, EventArgs e)
        {

            conn.Close();
            this.Close();
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            else MessageBox.Show("未选中任何行");
        }
    }
}
