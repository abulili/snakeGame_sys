
namespace net_wo
{
    partial class frm_help
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_help));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_wanna = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_no = new System.Windows.Forms.Button();
            this.butt_sub = new System.Windows.Forms.Button();
            this.textBox_sub = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LavenderBlush;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(103, 34);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(547, 46);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "若发现程序出现问题，请告诉我，并对应用进行重启\r\n";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_wanna
            // 
            this.button_wanna.BackColor = System.Drawing.Color.Thistle;
            this.button_wanna.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_wanna.Location = new System.Drawing.Point(308, 104);
            this.button_wanna.Name = "button_wanna";
            this.button_wanna.Size = new System.Drawing.Size(128, 41);
            this.button_wanna.TabIndex = 1;
            this.button_wanna.Text = "提交问题";
            this.button_wanna.UseVisualStyleBackColor = false;
            this.button_wanna.Click += new System.EventHandler(this.button_wanna_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_no);
            this.groupBox1.Controls.Add(this.butt_sub);
            this.groupBox1.Controls.Add(this.textBox_sub);
            this.groupBox1.Location = new System.Drawing.Point(103, 203);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(569, 195);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "问题描述(100字内)";
            this.groupBox1.Visible = false;
            // 
            // button_no
            // 
            this.button_no.BackColor = System.Drawing.Color.Thistle;
            this.button_no.Location = new System.Drawing.Point(472, 120);
            this.button_no.Name = "button_no";
            this.button_no.Size = new System.Drawing.Size(75, 23);
            this.button_no.TabIndex = 2;
            this.button_no.Text = "取消";
            this.button_no.UseVisualStyleBackColor = false;
            this.button_no.Click += new System.EventHandler(this.button_no_Click);
            // 
            // butt_sub
            // 
            this.butt_sub.BackColor = System.Drawing.Color.Thistle;
            this.butt_sub.Location = new System.Drawing.Point(472, 57);
            this.butt_sub.Name = "butt_sub";
            this.butt_sub.Size = new System.Drawing.Size(75, 23);
            this.butt_sub.TabIndex = 1;
            this.butt_sub.Text = "提交";
            this.butt_sub.UseVisualStyleBackColor = false;
            this.butt_sub.Click += new System.EventHandler(this.butt_sub_Click);
            // 
            // textBox_sub
            // 
            this.textBox_sub.Location = new System.Drawing.Point(6, 24);
            this.textBox_sub.Multiline = true;
            this.textBox_sub.Name = "textBox_sub";
            this.textBox_sub.Size = new System.Drawing.Size(455, 153);
            this.textBox_sub.TabIndex = 0;
            this.textBox_sub.TextChanged += new System.EventHandler(this.textBox_sub_TextChanged);
            // 
            // frm_help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_wanna);
            this.Controls.Add(this.textBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_help";
            this.Text = "帮助";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_wanna;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button butt_sub;
        private System.Windows.Forms.TextBox textBox_sub;
        private System.Windows.Forms.Button button_no;
    }
}