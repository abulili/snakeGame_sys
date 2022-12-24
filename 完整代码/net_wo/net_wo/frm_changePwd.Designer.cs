
namespace net_wo
{
    partial class frm_changePwd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_changePwd));
            this.text_user = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.butt_no = new System.Windows.Forms.Button();
            this.butt_ok = new System.Windows.Forms.Button();
            this.text_pa_ok = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.text_pa_new = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.text_pa = new System.Windows.Forms.TextBox();
            this.密码 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // text_user
            // 
            this.text_user.Location = new System.Drawing.Point(391, 74);
            this.text_user.Name = "text_user";
            this.text_user.ReadOnly = true;
            this.text_user.Size = new System.Drawing.Size(100, 25);
            this.text_user.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(251, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "用户名称";
            // 
            // butt_no
            // 
            this.butt_no.BackColor = System.Drawing.Color.Thistle;
            this.butt_no.Location = new System.Drawing.Point(415, 328);
            this.butt_no.Name = "butt_no";
            this.butt_no.Size = new System.Drawing.Size(75, 23);
            this.butt_no.TabIndex = 30;
            this.butt_no.Text = "退出";
            this.butt_no.UseVisualStyleBackColor = false;
            this.butt_no.Click += new System.EventHandler(this.butt_no_Click);
            // 
            // butt_ok
            // 
            this.butt_ok.BackColor = System.Drawing.Color.Thistle;
            this.butt_ok.Location = new System.Drawing.Point(228, 329);
            this.butt_ok.Name = "butt_ok";
            this.butt_ok.Size = new System.Drawing.Size(75, 23);
            this.butt_ok.TabIndex = 29;
            this.butt_ok.Text = "确定";
            this.butt_ok.UseVisualStyleBackColor = false;
            this.butt_ok.Click += new System.EventHandler(this.butt_ok_Click);
            // 
            // text_pa_ok
            // 
            this.text_pa_ok.Location = new System.Drawing.Point(391, 266);
            this.text_pa_ok.Name = "text_pa_ok";
            this.text_pa_ok.Size = new System.Drawing.Size(100, 25);
            this.text_pa_ok.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(251, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 27;
            this.label4.Text = "密码确认";
            // 
            // text_pa_new
            // 
            this.text_pa_new.Location = new System.Drawing.Point(391, 202);
            this.text_pa_new.Name = "text_pa_new";
            this.text_pa_new.Size = new System.Drawing.Size(100, 25);
            this.text_pa_new.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(251, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 25;
            this.label3.Text = "新 密 码";
            // 
            // text_pa
            // 
            this.text_pa.Location = new System.Drawing.Point(391, 138);
            this.text_pa.Name = "text_pa";
            this.text_pa.Size = new System.Drawing.Size(100, 25);
            this.text_pa.TabIndex = 24;
            // 
            // 密码
            // 
            this.密码.AutoSize = true;
            this.密码.BackColor = System.Drawing.Color.Transparent;
            this.密码.Location = new System.Drawing.Point(251, 141);
            this.密码.Name = "密码";
            this.密码.Size = new System.Drawing.Size(69, 15);
            this.密码.TabIndex = 23;
            this.密码.Text = "密    码";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(158, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(469, 317);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            // 
            // frm_changePwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.text_user);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butt_no);
            this.Controls.Add(this.butt_ok);
            this.Controls.Add(this.text_pa_ok);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.text_pa_new);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.text_pa);
            this.Controls.Add(this.密码);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_changePwd";
            this.Text = "修改密码";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_user;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butt_no;
        private System.Windows.Forms.Button butt_ok;
        private System.Windows.Forms.TextBox text_pa_ok;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text_pa_new;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_pa;
        private System.Windows.Forms.Label 密码;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}