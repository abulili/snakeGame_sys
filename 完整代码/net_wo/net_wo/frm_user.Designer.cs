
namespace net_wo
{
    partial class frm_user
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_user));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label_name = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.butt_choseJpg = new System.Windows.Forms.Button();
            this.butt_ok = new System.Windows.Forms.Button();
            this.butt_no = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(463, 80);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(69, 15);
            this.label_name.TabIndex = 1;
            this.label_name.Text = "姓    名";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(568, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 25);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(463, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "分    数";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(568, 144);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 25);
            this.textBox2.TabIndex = 4;
            // 
            // butt_choseJpg
            // 
            this.butt_choseJpg.AutoSize = true;
            this.butt_choseJpg.BackColor = System.Drawing.Color.Thistle;
            this.butt_choseJpg.Location = new System.Drawing.Point(127, 388);
            this.butt_choseJpg.Name = "butt_choseJpg";
            this.butt_choseJpg.Size = new System.Drawing.Size(101, 37);
            this.butt_choseJpg.TabIndex = 5;
            this.butt_choseJpg.Text = "选择图片";
            this.butt_choseJpg.UseVisualStyleBackColor = false;
            this.butt_choseJpg.Click += new System.EventHandler(this.butt_choseJpg_Click);
            // 
            // butt_ok
            // 
            this.butt_ok.AutoSize = true;
            this.butt_ok.BackColor = System.Drawing.Color.Thistle;
            this.butt_ok.Location = new System.Drawing.Point(438, 306);
            this.butt_ok.Name = "butt_ok";
            this.butt_ok.Size = new System.Drawing.Size(75, 25);
            this.butt_ok.TabIndex = 6;
            this.butt_ok.Text = "更新";
            this.butt_ok.UseVisualStyleBackColor = false;
            this.butt_ok.Click += new System.EventHandler(this.butt_ok_Click);
            // 
            // butt_no
            // 
            this.butt_no.AutoEllipsis = true;
            this.butt_no.BackColor = System.Drawing.Color.Thistle;
            this.butt_no.Location = new System.Drawing.Point(652, 306);
            this.butt_no.Name = "butt_no";
            this.butt_no.Size = new System.Drawing.Size(75, 23);
            this.butt_no.TabIndex = 8;
            this.butt_no.Text = "取消";
            this.butt_no.UseVisualStyleBackColor = false;
            this.butt_no.Click += new System.EventHandler(this.butt_no_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(568, 219);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 25);
            this.textBox3.TabIndex = 11;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(463, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "排 行 榜";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::net_wo.Properties.Resources.PFaXZ8m8dt;
            this.pictureBox1.Location = new System.Drawing.Point(32, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(344, 359);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frm_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.butt_no);
            this.Controls.Add(this.butt_ok);
            this.Controls.Add(this.butt_choseJpg);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_user";
            this.Text = "个人信息";
            this.Load += new System.EventHandler(this.frm_user_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button butt_choseJpg;
        private System.Windows.Forms.Button butt_ok;
        private System.Windows.Forms.Button butt_no;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
    }
}