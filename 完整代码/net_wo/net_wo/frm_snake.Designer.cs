namespace net_wo
{
    partial class frm_snake
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_snake));
            this.timer_game = new System.Windows.Forms.Timer(this.components);
            this.timer_gameover = new System.Windows.Forms.Timer(this.components);
            this.帮助 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.pai_ming = new System.Windows.Forms.TabPage();
            this.dataGridView_paiMing = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.history = new System.Windows.Forms.TabPage();
            this.dataGridView_history = new System.Windows.Forms.DataGridView();
            this.btn_sheetView = new System.Windows.Forms.Button();
            this.btn_chartView = new System.Windows.Forms.Button();
            this.user = new System.Windows.Forms.Label();
            this.count_times = new System.Windows.Forms.Label();
            this.highscore = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.main_page = new System.Windows.Forms.TabControl();
            this.game_page = new System.Windows.Forms.TabPage();
            this.gameover = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox6 = new AForge.Controls.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.labelScore = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.guanJun = new System.Windows.Forms.PictureBox();
            this.yaJun = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_paiMing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_history)).BeginInit();
            this.main_page.SuspendLayout();
            this.game_page.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guanJun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yaJun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // timer_game
            // 
            this.timer_game.Enabled = true;
            this.timer_game.Interval = 250;
            this.timer_game.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // timer_gameover
            // 
            this.timer_gameover.Tick += new System.EventHandler(this.timer_gameover_Tick);
            // 
            // 帮助
            // 
            this.帮助.Location = new System.Drawing.Point(0, 0);
            this.帮助.Name = "帮助";
            this.帮助.Size = new System.Drawing.Size(200, 100);
            this.帮助.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 0;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(0, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 0;
            // 
            // pai_ming
            // 
            this.pai_ming.Location = new System.Drawing.Point(0, 0);
            this.pai_ming.Name = "pai_ming";
            this.pai_ming.Size = new System.Drawing.Size(200, 100);
            this.pai_ming.TabIndex = 0;
            // 
            // dataGridView_paiMing
            // 
            this.dataGridView_paiMing.ColumnHeadersHeight = 29;
            this.dataGridView_paiMing.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_paiMing.Name = "dataGridView_paiMing";
            this.dataGridView_paiMing.RowHeadersWidth = 51;
            this.dataGridView_paiMing.Size = new System.Drawing.Size(240, 150);
            this.dataGridView_paiMing.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(523, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(529, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(529, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // history
            // 
            this.history.Location = new System.Drawing.Point(0, 0);
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(200, 100);
            this.history.TabIndex = 0;
            // 
            // dataGridView_history
            // 
            this.dataGridView_history.ColumnHeadersHeight = 29;
            this.dataGridView_history.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_history.Name = "dataGridView_history";
            this.dataGridView_history.RowHeadersWidth = 51;
            this.dataGridView_history.Size = new System.Drawing.Size(240, 150);
            this.dataGridView_history.TabIndex = 0;
            // 
            // btn_sheetView
            // 
            this.btn_sheetView.Location = new System.Drawing.Point(0, 0);
            this.btn_sheetView.Name = "btn_sheetView";
            this.btn_sheetView.Size = new System.Drawing.Size(75, 23);
            this.btn_sheetView.TabIndex = 0;
            // 
            // btn_chartView
            // 
            this.btn_chartView.Location = new System.Drawing.Point(0, 0);
            this.btn_chartView.Name = "btn_chartView";
            this.btn_chartView.Size = new System.Drawing.Size(75, 23);
            this.btn_chartView.TabIndex = 0;
            // 
            // user
            // 
            this.user.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.user.ForeColor = System.Drawing.Color.Black;
            this.user.Location = new System.Drawing.Point(484, 54);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(110, 23);
            this.user.TabIndex = 3;
            this.user.Text = "昵称：";
            this.user.Click += new System.EventHandler(this.user_Click);
            // 
            // count_times
            // 
            this.count_times.AutoSize = true;
            this.count_times.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.count_times.ForeColor = System.Drawing.Color.Black;
            this.count_times.Location = new System.Drawing.Point(484, 132);
            this.count_times.Name = "count_times";
            this.count_times.Size = new System.Drawing.Size(109, 20);
            this.count_times.TabIndex = 4;
            this.count_times.Text = "游戏次数：";
            this.count_times.Click += new System.EventHandler(this.count_times_Click);
            // 
            // highscore
            // 
            this.highscore.AutoSize = true;
            this.highscore.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.highscore.ForeColor = System.Drawing.Color.Black;
            this.highscore.Location = new System.Drawing.Point(484, 90);
            this.highscore.Name = "highscore";
            this.highscore.Size = new System.Drawing.Size(89, 20);
            this.highscore.TabIndex = 5;
            this.highscore.Text = "最高分：";
            this.highscore.Click += new System.EventHandler(this.highscore_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("隶书", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4.ForeColor = System.Drawing.Color.Red;
            this.button4.Location = new System.Drawing.Point(488, 322);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(116, 37);
            this.button4.TabIndex = 7;
            this.button4.Text = "删除";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // main_page
            // 
            this.main_page.Controls.Add(this.game_page);
            this.main_page.Font = new System.Drawing.Font("隶书", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.main_page.Location = new System.Drawing.Point(-5, 0);
            this.main_page.Name = "main_page";
            this.main_page.SelectedIndex = 0;
            this.main_page.Size = new System.Drawing.Size(609, 421);
            this.main_page.TabIndex = 6;
            this.main_page.SelectedIndexChanged += new System.EventHandler(this.main_page_SelectedIndexChanged);
            // 
            // game_page
            // 
            this.game_page.Controls.Add(this.gameover);
            this.game_page.Controls.Add(this.pictureBox1);
            this.game_page.Controls.Add(this.groupBox1);
            this.game_page.Location = new System.Drawing.Point(4, 37);
            this.game_page.Name = "game_page";
            this.game_page.Padding = new System.Windows.Forms.Padding(3);
            this.game_page.Size = new System.Drawing.Size(601, 380);
            this.game_page.TabIndex = 0;
            this.game_page.Text = "游戏界面";
            this.game_page.UseVisualStyleBackColor = true;
            this.game_page.Click += new System.EventHandler(this.game_page_Click);
            // 
            // gameover
            // 
            this.gameover.BackColor = System.Drawing.Color.Transparent;
            this.gameover.ForeColor = System.Drawing.Color.Red;
            this.gameover.Location = new System.Drawing.Point(34, 116);
            this.gameover.Name = "gameover";
            this.gameover.Size = new System.Drawing.Size(353, 36);
            this.gameover.TabIndex = 5;
            this.gameover.Click += new System.EventHandler(this.gameover_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::net_wo.Properties.Resources.PFaXZ8m8dt;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(413, 388);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LavenderBlush;
            this.groupBox1.Controls.Add(this.pictureBox6);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.labelScore);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(410, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 388);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox6.Image = global::net_wo.Properties.Resources.蛇;
            this.pictureBox6.Location = new System.Drawing.Point(140, 29);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(44, 44);
            this.pictureBox6.TabIndex = 7;
            this.pictureBox6.TabStop = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Location = new System.Drawing.Point(45, 302);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 36);
            this.button3.TabIndex = 6;
            this.button3.Text = "退出";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Location = new System.Drawing.Point(42, 67);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(0, 20);
            this.labelScore.TabIndex = 3;
            this.labelScore.Click += new System.EventHandler(this.labelScore_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(45, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "开始";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(46, 241);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 36);
            this.button2.TabIndex = 2;
            this.button2.Text = "暂停";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 50);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 50);
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(0, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(100, 50);
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            // 
            // guanJun
            // 
            this.guanJun.Location = new System.Drawing.Point(0, 0);
            this.guanJun.Name = "guanJun";
            this.guanJun.Size = new System.Drawing.Size(100, 50);
            this.guanJun.TabIndex = 0;
            this.guanJun.TabStop = false;
            // 
            // yaJun
            // 
            this.yaJun.Location = new System.Drawing.Point(0, 0);
            this.yaJun.Name = "yaJun";
            this.yaJun.Size = new System.Drawing.Size(100, 50);
            this.yaJun.TabIndex = 0;
            this.yaJun.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // frm_snake
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(605, 421);
            this.Controls.Add(this.main_page);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frm_snake";
            this.Text = "贪吃蛇";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_paiMing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_history)).EndInit();
            this.main_page.ResumeLayout(false);
            this.game_page.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guanJun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yaJun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer_game;
        private System.Windows.Forms.Timer timer_gameover;
        private System.Windows.Forms.TabPage 帮助;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TabPage pai_ming;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_paiMing;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox yaJun;
        private System.Windows.Forms.PictureBox guanJun;
        private System.Windows.Forms.TabPage history;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label highscore;
        private System.Windows.Forms.Label count_times;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.Button btn_chartView;
        private System.Windows.Forms.Button btn_sheetView;
        private System.Windows.Forms.DataGridView dataGridView_history;
        private System.Windows.Forms.TabControl main_page;
        private System.Windows.Forms.TabPage game_page;
        private System.Windows.Forms.Label gameover;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private AForge.Controls.PictureBox pictureBox6;
    }
}

