using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace net_wo
{
    public partial class frm_snake : Form
    {

        string username = "";
        public frm_snake(string name)
        {
            InitializeComponent();
            username = name;
        }

        string Key_Name = "stop";
        Label[] Snake_Boby=new Label[200] ;
        Random R = new Random();
        int Snake_Boby_content_x = 0, Snake_Boby_content_y = 0;
        int score = 0;
        bool isalive = false;


        public void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int x, y;
            x = Snake_Boby[0].Left;
            y = Snake_Boby[0].Top;
            Key_Name = e.KeyCode.ToString();
            if (e.KeyCode == Keys.Right)
            {
                Snake_Boby[0].Left = x + 10;
                Snake_move(x, y);
            }
            if (e.KeyCode == Keys.Up) 
            {
                Snake_Boby[0].Top = y - 10;
                Snake_move(x, y);
            }
            if (e.KeyCode == Keys.Down)
            {
                Snake_Boby[0].Top = y + 10;
                Snake_move(x, y);
            }
            if (e.KeyCode == Keys.Left) 
            {
                Snake_Boby[0].Left = x - 10;
                Snake_move(x, y);
            }
            Eat_time();
        }
       
        
        public void Eat_time()
        {
            double x1 = 10, y1 = 10, x2 = 10, y2 = 10;
            foreach (Label lb  in this.pictureBox1.Controls)
            {
                if (lb.Tag.ToString() == "food".ToString())
                {
                    x2 = lb.Left;
                    y2 = lb.Top;
                }
                if (lb.Tag.ToString() == "0".ToString())
                {
                    x1 = lb.Left;
                    y1 = lb.Top;
                }
            }
            if (x2 == x1 && y2 == y1)
            {
                Snake_eat();
                foreach (Label lb in this.pictureBox1.Controls)
                {
                    if (lb.Tag.ToString() == "food".ToString())
                    {
                        lb.Top = R.Next(1, 18) * 20;
                        lb.Left = R.Next(1, 19) * 20;
                        lb.BackColor = Color.Black;
                    }
                }
            }
        }
        private void Snake_eat()
        {
            int i = 0;
            for (; Snake_Boby[i] != null; i++) ;
            Label Snake_Boby_content = new Label();
            Snake_Boby_content.Width = 10;
            Snake_Boby_content.Height = 10;
            Snake_Boby_content.Top = Snake_Boby_content_y;
            Snake_Boby_content.Left = Snake_Boby_content_x;
            Snake_Boby_content.BackColor = Color.White;
            Snake_Boby_content.Tag = i;
            Snake_Boby[i] = Snake_Boby_content;
           
            this.pictureBox1.Controls.Add(Snake_Boby_content);
            this.score++;
            this.labelScore.Text = "分数：" + this.score.ToString();
        }

        public void Snake_food()
        {

            Label Food = new Label();
            Food.Width = 10;
            Food.Height = 10;
            Food.Top = R.Next(1, 18) * 20;
            Food.Left = R.Next(1, 19) * 20;
            Food.Tag = "food";
            Food.BackColor = Color.Black;
            this.pictureBox1.Controls.Add(Food);
            
        }
        public void Snake_move(int x, int y)
        {
            int temp_x = 0, temp_y = 0;
            for (int i = 1; Snake_Boby[i] != null; i++)
            {
                if (i >= 3)
                {
                    temp_x = Snake_Boby_content_x;
                    temp_y = Snake_Boby_content_y;
                }
                if (i == 1)
                {
                    temp_x = Snake_Boby[i].Left;
                    temp_y = Snake_Boby[i].Top;
                    Snake_Boby[i].Left = x;
                    Snake_Boby[i].Top = y;
                }
                else
                {
                    Snake_Boby_content_x = Snake_Boby[i].Left;
                    Snake_Boby_content_y = Snake_Boby[i].Top;
                    Snake_Boby[i].Left = temp_x;
                    Snake_Boby[i].Top = temp_y;
                }
            }
        }
        
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (isalive)
            {
                int x, y;
                x = Snake_Boby[0].Left;
                y = Snake_Boby[0].Top;
                if (Key_Name == "start") 
                {
                    Snake_Boby[0].Left = x + 10;
                    Snake_move(x, y);
                }
                if (Key_Name == "Right")
                {
                    Snake_Boby[0].Left = x + 10;
                    Snake_move(x, y);
                }
                if (Key_Name == "Up")  
                {
                    Snake_Boby[0].Top = y - 10;
                    Snake_move(x, y);
                }
                if (Key_Name == "Down")
                {
                    Snake_Boby[0].Top = y + 10;
                    Snake_move(x, y);
                }
                if (Key_Name == "Left") 
                {
                    Snake_Boby[0].Left = x - 10;
                    Snake_move(x, y);
                }
                Eat_time();
                Snake_dead(x, y);
            }
            

        }

        
        public void  Snake_dead(int x,int y)
        {
            if (x<pictureBox1.Location.X||x>pictureBox1.Location.X+pictureBox1.Width-20||y<pictureBox1.Location.Y||y>pictureBox1.Location.Y+pictureBox1.Height-20)
            {
                this.button2.Enabled = false;
                gameover.Visible = true;
                gameover.Text = "游戏结束，得分："+score;
                timer_gameover.Enabled = false;
                timer_gameover.Interval = 2000;
                timer_gameover.Enabled = true;
                timer_game.Enabled = false;
                isalive = false;
                Array.Clear(Snake_Boby, 5, 5+score);
                Key_Name = "stop";
            }

        }

        private void btn_sheetView_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_chartView_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
           

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void gameover_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void 帮助_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pai_ming_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_paiMing_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void yaJun_Click(object sender, EventArgs e)
        {

        }

        private void guanJun_Click(object sender, EventArgs e)
        {

        }

        private void history_Click(object sender, EventArgs e)
        {

        }

        private void highscore_Click(object sender, EventArgs e)
        {

        }

        private void count_times_Click(object sender, EventArgs e)
        {

        }

        private void user_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_history_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void chart_history_Click(object sender, EventArgs e)
        {

        }

        private void game_page_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void labelSpeed_Click(object sender, EventArgs e)
        {

        }

        private void labelScore_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void main_page_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.button2.Enabled = false;

            this.Top = 100;
            this.Left = 300;
          
            gameover.Visible = false;
            this.BackColor = Color.White;
            for (int i = 0; i < 10; i++)
            {
                Label Snake_Boby_content = new Label();
                Snake_Boby_content.Height = 10;
                Snake_Boby_content.Width = 10;
                Snake_Boby_content.Top = 200;
                Snake_Boby_content.Left = 200 - i * 10;
                Snake_Boby_content.BackColor = Color.White;
                Snake_Boby_content.Tag = i;
                Snake_Boby[i] = Snake_Boby_content;
                this.pictureBox1.Controls.Add(Snake_Boby_content);
            }
            
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
            Snake_food();    
            timer_game.Start(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text.Equals("暂停"))
            {
                timer_game.Enabled = false;
                
                
                button2.Text = "继续";
            }else if (button2.Text.Equals("继续"))
            {
                timer_game.Enabled = true;
                button2.Text = "暂停";
                this.pictureBox1.Focus();
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void timer_gameover_Tick(object sender, EventArgs e)
        {
            gameover.Visible = false;
            gameover.Enabled = false;
            isalive = false;

            string connStr = "server=localhost;port=3306;database=snakeGame;user=root;password=Root@123";
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            string sql = "select *from rankinfo where Id='" + username + "'";
            MySqlCommand comm = new MySqlCommand(sql, conn);
            sql = "select Score from rankinfo where Id='" + username + "'";
            comm.CommandText = sql;
            string temp = (string)comm.ExecuteScalar();
            int allscore = int.Parse(temp);
           // MessageBox.Show(allscore.ToString() + "," + score.ToString());
            if (allscore < this.score)
            {
                //MessageBox.Show("?");
                sql = "update rankinfo set Score='" + score.ToString() + "' where Id='" + username + "'";
                comm.CommandText = sql;
                comm.ExecuteNonQuery();
                DataSet ds = new DataSet();
                MySqlDataAdapter da = new MySqlDataAdapter(comm);
                da.Fill(ds);
            }
            conn.Close();
            this.Close();
        }

        private void but_again_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Key_Name = "start";
            isalive = true;
            this.button1.Enabled = false;
            this.button2.Enabled = true;
            this.pictureBox1.Focus();
        }
    }
}
