
namespace net_wo
{
    partial class frm_adduser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_adduser));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_pwd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.butt_no = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名称";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(231, 29);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(100, 25);
            this.textBox_name.TabIndex = 1;
            // 
            // textBox_pwd
            // 
            this.textBox_pwd.Location = new System.Drawing.Point(231, 93);
            this.textBox_pwd.Name = "textBox_pwd";
            this.textBox_pwd.ReadOnly = true;
            this.textBox_pwd.Size = new System.Drawing.Size(100, 25);
            this.textBox_pwd.TabIndex = 3;
            this.textBox_pwd.Text = "   12345";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "密    码";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "用户身份";
            // 
            // button_add
            // 
            this.button_add.AutoSize = true;
            this.button_add.BackColor = System.Drawing.Color.Thistle;
            this.button_add.Location = new System.Drawing.Point(203, 302);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 25);
            this.button_add.TabIndex = 6;
            this.button_add.Text = "添加";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // butt_no
            // 
            this.butt_no.AutoSize = true;
            this.butt_no.BackColor = System.Drawing.Color.Thistle;
            this.butt_no.Location = new System.Drawing.Point(477, 302);
            this.butt_no.Name = "butt_no";
            this.butt_no.Size = new System.Drawing.Size(75, 25);
            this.butt_no.TabIndex = 7;
            this.butt_no.Text = "取消";
            this.butt_no.UseVisualStyleBackColor = false;
            this.butt_no.Click += new System.EventHandler(this.butt_no_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "管理员",
            "用户"});
            this.comboBox1.Location = new System.Drawing.Point(231, 157);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 23);
            this.comboBox1.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.textBox_name);
            this.groupBox1.Controls.Add(this.textBox_pwd);
            this.groupBox1.Location = new System.Drawing.Point(139, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(481, 276);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // frm_adduser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butt_no);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_adduser";
            this.Text = "添加用户";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_pwd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button butt_no;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}