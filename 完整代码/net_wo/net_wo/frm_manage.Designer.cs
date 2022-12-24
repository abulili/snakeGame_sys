
namespace net_wo
{
    partial class frm_manage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_manage));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.用户名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.用户密码 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.用户身份 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.text_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_state = new System.Windows.Forms.ComboBox();
            this.but_rePwd = new System.Windows.Forms.Button();
            this.butt_del = new System.Windows.Forms.Button();
            this.butto_ok = new System.Windows.Forms.Button();
            this.but_bad = new System.Windows.Forms.Button();
            this.text_reasion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.用户名称,
            this.用户密码,
            this.用户身份});
            this.dataGridView1.Location = new System.Drawing.Point(52, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(700, 252);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDown);
            // 
            // 用户名称
            // 
            this.用户名称.DataPropertyName = "Id";
            this.用户名称.HeaderText = "用户名称";
            this.用户名称.MinimumWidth = 6;
            this.用户名称.Name = "用户名称";
            // 
            // 用户密码
            // 
            this.用户密码.DataPropertyName = "Pwd";
            this.用户密码.HeaderText = "用户密码";
            this.用户密码.MinimumWidth = 6;
            this.用户密码.Name = "用户密码";
            // 
            // 用户身份
            // 
            this.用户身份.DataPropertyName = "State";
            this.用户身份.HeaderText = "用户身份";
            this.用户身份.MinimumWidth = 6;
            this.用户身份.Name = "用户身份";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(109, 28);
            // 
            // 删除
            // 
            this.删除.Name = "删除";
            this.删除.Size = new System.Drawing.Size(108, 24);
            this.删除.Text = "删除";
            this.删除.Click += new System.EventHandler(this.删除_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "用户名称";
            // 
            // text_name
            // 
            this.text_name.Location = new System.Drawing.Point(125, 308);
            this.text_name.Name = "text_name";
            this.text_name.ReadOnly = true;
            this.text_name.Size = new System.Drawing.Size(100, 25);
            this.text_name.TabIndex = 3;
            this.text_name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "用户密码";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(579, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "用户身份";
            // 
            // comboBox_state
            // 
            this.comboBox_state.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_state.FormattingEnabled = true;
            this.comboBox_state.Items.AddRange(new object[] {
            "用户",
            "管理员"});
            this.comboBox_state.Location = new System.Drawing.Point(652, 308);
            this.comboBox_state.Name = "comboBox_state";
            this.comboBox_state.Size = new System.Drawing.Size(100, 23);
            this.comboBox_state.TabIndex = 18;
            // 
            // but_rePwd
            // 
            this.but_rePwd.BackColor = System.Drawing.Color.Thistle;
            this.but_rePwd.Location = new System.Drawing.Point(392, 306);
            this.but_rePwd.Name = "but_rePwd";
            this.but_rePwd.Size = new System.Drawing.Size(100, 25);
            this.but_rePwd.TabIndex = 19;
            this.but_rePwd.Text = "重置密码";
            this.but_rePwd.UseVisualStyleBackColor = false;
            this.but_rePwd.Click += new System.EventHandler(this.but_rePwd_Click);
            // 
            // butt_del
            // 
            this.butt_del.BackColor = System.Drawing.Color.Thistle;
            this.butt_del.Location = new System.Drawing.Point(533, 374);
            this.butt_del.Name = "butt_del";
            this.butt_del.Size = new System.Drawing.Size(75, 23);
            this.butt_del.TabIndex = 20;
            this.butt_del.Text = "删除";
            this.butt_del.UseVisualStyleBackColor = false;
            this.butt_del.Click += new System.EventHandler(this.butt_del_Click);
            // 
            // butto_ok
            // 
            this.butto_ok.BackColor = System.Drawing.Color.Thistle;
            this.butto_ok.Location = new System.Drawing.Point(677, 374);
            this.butto_ok.Name = "butto_ok";
            this.butto_ok.Size = new System.Drawing.Size(75, 23);
            this.butto_ok.TabIndex = 21;
            this.butto_ok.Text = "确认修改";
            this.butto_ok.UseVisualStyleBackColor = false;
            this.butto_ok.Click += new System.EventHandler(this.butto_ok_Click);
            // 
            // but_bad
            // 
            this.but_bad.BackColor = System.Drawing.Color.Thistle;
            this.but_bad.Location = new System.Drawing.Point(322, 374);
            this.but_bad.Name = "but_bad";
            this.but_bad.Size = new System.Drawing.Size(98, 23);
            this.but_bad.TabIndex = 22;
            this.but_bad.Text = "加入黑名单";
            this.but_bad.UseVisualStyleBackColor = false;
            this.but_bad.Click += new System.EventHandler(this.but_bad_Click);
            // 
            // text_reasion
            // 
            this.text_reasion.Location = new System.Drawing.Point(55, 361);
            this.text_reasion.Multiline = true;
            this.text_reasion.Name = "text_reasion";
            this.text_reasion.Size = new System.Drawing.Size(247, 66);
            this.text_reasion.TabIndex = 23;
            this.text_reasion.Text = "不超过50字";
            this.text_reasion.TextChanged += new System.EventHandler(this.text_reasion_TextChanged);
            // 
            // frm_manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.text_reasion);
            this.Controls.Add(this.but_bad);
            this.Controls.Add(this.butto_ok);
            this.Controls.Add(this.butt_del);
            this.Controls.Add(this.but_rePwd);
            this.Controls.Add(this.comboBox_state);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_manage";
            this.Text = "用户管理";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 删除;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_state;
        private System.Windows.Forms.Button but_rePwd;
        private System.Windows.Forms.Button butt_del;
        private System.Windows.Forms.Button butto_ok;
        private System.Windows.Forms.DataGridViewTextBoxColumn 用户名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 用户密码;
        private System.Windows.Forms.DataGridViewTextBoxColumn 用户身份;
        private System.Windows.Forms.Button but_bad;
        private System.Windows.Forms.TextBox text_reasion;
    }
}