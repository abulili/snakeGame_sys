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
    public partial class frm_rank : Form
    {
        MySqlDataAdapter da = null;
        DataSet ds = null;
        MySqlConnection conn = null;
        MySqlCommand comm = null;
        string sql = "";
        public frm_rank()
        {
            InitializeComponent();
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            string connStr = "server=localhost;port=3306;database=snakeGame;user=root;password=Root@123";
            conn = new MySqlConnection(connStr);
            conn.Open();

            //sql = "SELECT (@Rankk:=@Rankk+1) Rankk,Id,Score FROM rankinfo, (SELECT @Rankk:=0) as Rankk ORDER BY Score";
           // sql = "SELECT @Rankk:=0; SELECT (@Rankk:=@Rankk+1) Rankk, Id, Score FROM rankinfo ORDER BY Score";
            sql = "select *from rankinfo ORDER BY Score desc";
            //MessageBox.Show(sql);
            comm = new MySqlCommand(sql, conn);

            ds = new DataSet();
            da = new MySqlDataAdapter(comm);
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            //遍历
            string sett = "", namee = "";
            for(int i = 0; i < dataGridView1.Rows.Count - 1; ++i)//空对象（多一行
            {
                sett = (i + 1).ToString();
                string temp = dataGridView1.Rows[i].Cells["排名"].Value.ToString();
                //MessageBox.Show(temp);
                if (sett == temp) continue;

                dataGridView1.Rows[i].Cells["排名"].Value = sett;
                namee = dataGridView1.Rows[i].Cells["用户名称"].Value.ToString();
                sql = "update rankinfo set Rankk='" + sett + "' where Id='" + namee + "'";
                //MessageBox.Show(sql);
                comm.CommandText = sql;
                comm.ExecuteNonQuery();
            }
            //conn.Close(); 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
        {
            
        }

        private void button_no_Click(object sender, EventArgs e)
        {
            conn.Close();
            this.Close();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text.Trim() != "" && textBox1.Text.Trim() != "")
            {
                string temp = comboBox1.Text.Trim();
                if (temp == "用户名称")
                {
                    sql = "select *from rankinfo where Id='" + textBox1.Text.Trim() + "'";
                }
                else if(temp == "分数")
                {
                    sql = "select *from rankinfo where Score='" + textBox1.Text.Trim() + "'";
                }
                else if(temp == "排名")
                {
                    sql = "select *from rankinfo where Rankk='" + textBox1.Text.Trim() + "'";
                }
                comm.CommandText = sql;
                comm.ExecuteNonQuery();

                ds.Clear();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("填写完全部信息后方可搜索");
            }
        }
    }
}
