
namespace net_wo
{
    partial class frm_log
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_log));
            this.butt_no = new System.Windows.Forms.Button();
            this.butt_log = new System.Windows.Forms.Button();
            this.text_pwd = new System.Windows.Forms.TextBox();
            this.text_name = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.butt_new = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // butt_no
            // 
            this.butt_no.BackColor = System.Drawing.Color.Thistle;
            this.butt_no.Location = new System.Drawing.Point(365, 195);
            this.butt_no.Name = "butt_no";
            this.butt_no.Size = new System.Drawing.Size(75, 23);
            this.butt_no.TabIndex = 9;
            this.butt_no.Text = "取消";
            this.butt_no.UseVisualStyleBackColor = false;
            this.butt_no.Click += new System.EventHandler(this.butt_no_Click);
            // 
            // butt_log
            // 
            this.butt_log.BackColor = System.Drawing.Color.Thistle;
            this.butt_log.Font = new System.Drawing.Font("宋体", 9F);
            this.butt_log.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.butt_log.Location = new System.Drawing.Point(43, 195);
            this.butt_log.Name = "butt_log";
            this.butt_log.Size = new System.Drawing.Size(75, 23);
            this.butt_log.TabIndex = 3;
            this.butt_log.Text = "登录";
            this.butt_log.UseVisualStyleBackColor = false;
            this.butt_log.Click += new System.EventHandler(this.butt_log_Click);
            // 
            // text_pwd
            // 
            this.text_pwd.ForeColor = System.Drawing.SystemColors.WindowText;
            this.text_pwd.Location = new System.Drawing.Point(233, 116);
            this.text_pwd.Name = "text_pwd";
            this.text_pwd.Size = new System.Drawing.Size(100, 25);
            this.text_pwd.TabIndex = 2;
            this.text_pwd.TextChanged += new System.EventHandler(this.text_pwd_TextChanged);
            this.text_pwd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_pwd_KeyDown);
            // 
            // text_name
            // 
            this.text_name.BackColor = System.Drawing.Color.White;
            this.text_name.ForeColor = System.Drawing.SystemColors.WindowText;
            this.text_name.Location = new System.Drawing.Point(233, 59);
            this.text_name.Name = "text_name";
            this.text_name.Size = new System.Drawing.Size(100, 25);
            this.text_name.TabIndex = 1;
            this.text_name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_name_KeyDown_1);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LavenderBlush;
            this.groupBox1.Controls.Add(this.butt_no);
            this.groupBox1.Controls.Add(this.butt_new);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.butt_log);
            this.groupBox1.Controls.Add(this.text_pwd);
            this.groupBox1.Controls.Add(this.text_name);
            this.groupBox1.Location = new System.Drawing.Point(158, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(481, 262);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "密    码";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "用 户 名";
            // 
            // butt_new
            // 
            this.butt_new.BackColor = System.Drawing.Color.Thistle;
            this.butt_new.Location = new System.Drawing.Point(211, 195);
            this.butt_new.Name = "butt_new";
            this.butt_new.Size = new System.Drawing.Size(75, 23);
            this.butt_new.TabIndex = 11;
            this.butt_new.Text = "注册";
            this.butt_new.UseVisualStyleBackColor = false;
            this.butt_new.Click += new System.EventHandler(this.butt_new_Click);
            // 
            // frm_log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_log";
            this.Text = "登录";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butt_no;
        private System.Windows.Forms.Button butt_log;
        private System.Windows.Forms.TextBox text_pwd;
        private System.Windows.Forms.TextBox text_name;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butt_new;
    }
}

