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
using System.IO;
using MySql.Data.MySqlClient;
using AForge.Video.DirectShow;
namespace net_wo
{
    public partial class frm_user : Form
    {
        MySqlDataAdapter da = null;//最好初始化
        DataSet ds = null;
        MySqlConnection conn = null;
        MySqlCommand comm = null;
        string sql = "", Username = "";

        string oldFileName = string.Empty;
        string imageName = string.Empty;
        string filepath = "";
        bool flag = false;
        public frm_user(string name)
        {
            InitializeComponent();
            Username = name;
            string connStr = "server=localhost;port=3306;database=snakeGame;user=root;password=Root@123";
            conn = new MySqlConnection(connStr);
            conn.Open();
            sql = "select *from rankinfo where Id='" + Username  +"'";
            comm = new MySqlCommand(sql, conn);
            ds = new DataSet();
            da = new MySqlDataAdapter(comm);
            da.Fill(ds);

            // 添加查询参数
            comm.Parameters.AddWithValue("@Id", name);
            // 创建MySqlDataReader对象
            using (MySqlDataReader reader = comm.ExecuteReader())
            {
                    // 读取结果集中的数据
                    while (reader.Read())
                    {
                        textBox1.Text = reader[0].ToString();
                        textBox2.Text = reader[2].ToString();
                        textBox3.Text = reader[1].ToString();
                        //Console.WriteLine("{0} {1} {2}", reader[0], reader[1], reader[2]);
                        break;
                    }
             }


            sql = "select Urll from pictureinfo where Id='" + name + "'";
            comm.CommandText = sql;
            filepath = (string)comm.ExecuteScalar();
            //MessageBox.Show(filepath);
            if(filepath.Trim() != "")
            {
                Image image = Image.FromFile(filepath);
                pictureBox1.Image = image;
            }
        }

        private void frm_user_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void butt_no_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        OpenFileDialog ofdImage;
        private void butt_choseJpg_Click(object sender, EventArgs e)
        {
            ofdImage = new OpenFileDialog();
            ofdImage.Title = "选择照片";
            ofdImage.Filter = "所有文件 (*.*) | *.*|JPG图片(*.jpg)|*.jpg|PNG图片(*.png)|*.png ";
            OpenFileDialog ofd = new OpenFileDialog();
            ofdImage.Multiselect = false;
            if (ofdImage.ShowDialog() == DialogResult.OK)
            {
                filepath = ofdImage.FileName;
                FileInfo fileinfo = new FileInfo(ofdImage.FileName);
                if(fileinfo.Length > 204800)
                {
                    MessageBox.Show("照片不能大于200k");
                }
                else
                {
                    pictureBox1.Image = Image.FromFile(ofdImage.FileName);
                    oldFileName = ofdImage.FileName;
                    flag = true;
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void butt_ok_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                string result = oldFileName.Replace('\\', '/');
                sql = "update pictureinfo set Urll='" + result + "' where Id='" + Username + "'";
                //MessageBox.Show(sql);
            }
            comm.CommandText = sql;
            comm.ExecuteNonQuery();

            ds.Clear();
            da.Fill(ds);
        }
    }
}
