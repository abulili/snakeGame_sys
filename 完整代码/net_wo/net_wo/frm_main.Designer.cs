
namespace net_wo
{
    partial class frm_main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.开始游戏 = new System.Windows.Forms.ToolStripMenuItem();
            this.用户管理 = new System.Windows.Forms.ToolStripMenuItem();
            this.添加用户 = new System.Windows.Forms.ToolStripMenuItem();
            this.用户反馈 = new System.Windows.Forms.ToolStripMenuItem();
            this.个人信息 = new System.Windows.Forms.ToolStripMenuItem();
            this.排行榜ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改密码 = new System.Windows.Forms.ToolStripMenuItem();
            this.注销 = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LavenderBlush;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.开始游戏,
            this.用户管理,
            this.添加用户,
            this.用户反馈,
            this.个人信息,
            this.排行榜ToolStripMenuItem,
            this.修改密码,
            this.注销,
            this.帮助});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(804, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 开始游戏
            // 
            this.开始游戏.Name = "开始游戏";
            this.开始游戏.Size = new System.Drawing.Size(83, 24);
            this.开始游戏.Text = "开始游戏";
            this.开始游戏.Click += new System.EventHandler(this.开始游戏_Click);
            // 
            // 用户管理
            // 
            this.用户管理.Name = "用户管理";
            this.用户管理.Size = new System.Drawing.Size(83, 24);
            this.用户管理.Text = "用户管理";
            this.用户管理.Visible = false;
            this.用户管理.Click += new System.EventHandler(this.用户管理_Click);
            // 
            // 添加用户
            // 
            this.添加用户.Name = "添加用户";
            this.添加用户.Size = new System.Drawing.Size(83, 24);
            this.添加用户.Text = "添加用户";
            this.添加用户.Visible = false;
            this.添加用户.Click += new System.EventHandler(this.添加用户_Click);
            // 
            // 用户反馈
            // 
            this.用户反馈.Name = "用户反馈";
            this.用户反馈.Size = new System.Drawing.Size(83, 24);
            this.用户反馈.Text = "用户反馈";
            this.用户反馈.Visible = false;
            this.用户反馈.Click += new System.EventHandler(this.用户反馈_Click);
            // 
            // 个人信息
            // 
            this.个人信息.Name = "个人信息";
            this.个人信息.Size = new System.Drawing.Size(83, 24);
            this.个人信息.Text = "个人信息";
            this.个人信息.Click += new System.EventHandler(this.个人信息_Click);
            // 
            // 排行榜ToolStripMenuItem
            // 
            this.排行榜ToolStripMenuItem.Name = "排行榜ToolStripMenuItem";
            this.排行榜ToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.排行榜ToolStripMenuItem.Text = "排行榜";
            this.排行榜ToolStripMenuItem.Click += new System.EventHandler(this.排行榜ToolStripMenuItem_Click);
            // 
            // 修改密码
            // 
            this.修改密码.Name = "修改密码";
            this.修改密码.Size = new System.Drawing.Size(83, 24);
            this.修改密码.Text = "修改密码";
            this.修改密码.Click += new System.EventHandler(this.修改密码_Click);
            // 
            // 注销
            // 
            this.注销.Name = "注销";
            this.注销.Size = new System.Drawing.Size(57, 24);
            this.注销.Text = "注销";
            this.注销.Click += new System.EventHandler(this.注销_Click);
            // 
            // 帮助
            // 
            this.帮助.Name = "帮助";
            this.帮助.Size = new System.Drawing.Size(53, 24);
            this.帮助.Text = "帮助";
            this.帮助.Click += new System.EventHandler(this.帮助ToolStripMenuItem_Click);
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(804, 491);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_main";
            this.Text = "主界面";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_main_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 用户管理;
        private System.Windows.Forms.ToolStripMenuItem 排行榜ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改密码;
        private System.Windows.Forms.ToolStripMenuItem 注销;
        private System.Windows.Forms.ToolStripMenuItem 帮助;
        private System.Windows.Forms.ToolStripMenuItem 个人信息;
        private System.Windows.Forms.ToolStripMenuItem 添加用户;
        private System.Windows.Forms.ToolStripMenuItem 用户反馈;
        private System.Windows.Forms.ToolStripMenuItem 开始游戏;
    }
}