namespace 社員情報管理システム
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            groupBox1 = new GroupBox();
            employeeid = new DataGridViewTextBoxColumn();
            firstname = new DataGridViewTextBoxColumn();
            firstnameKana = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            phonenumber = new DataGridViewTextBoxColumn();
            Department = new DataGridViewTextBoxColumn();
            Position = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(1095, 692);
            button1.Name = "button1";
            button1.Size = new Size(165, 38);
            button1.TabIndex = 1;
            button1.Text = "終了";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(64, 200);
            button2.Name = "button2";
            button2.Size = new Size(165, 41);
            button2.TabIndex = 2;
            button2.Text = "新規登録";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(679, 31);
            button3.Name = "button3";
            button3.Size = new Size(165, 41);
            button3.TabIndex = 20;
            button3.Text = "詳細検索";
            button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label1.Location = new Point(50, 29);
            label1.Name = "label1";
            label1.Size = new Size(271, 38);
            label1.TabIndex = 21;
            label1.Text = "社員情報管理システム";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1178, 29);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 22;
            label2.Text = "Ver.1.0";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { employeeid, firstname, firstnameKana, email, phonenumber, Department, Position, status });
            dataGridView1.Location = new Point(28, 301);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1232, 366);
            dataGridView1.TabIndex = 23;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // button4
            // 
            button4.Location = new Point(679, 114);
            button4.Name = "button4";
            button4.Size = new Size(165, 41);
            button4.TabIndex = 24;
            button4.Text = "検索条件リセット";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(64, 117);
            button5.Name = "button5";
            button5.Size = new Size(165, 41);
            button5.TabIndex = 25;
            button5.Text = "社員詳細表示";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(9, 31);
            button6.Name = "button6";
            button6.Size = new Size(117, 31);
            button6.TabIndex = 27;
            button6.Text = "検索条件追加";
            button6.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(9, 80);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(167, 28);
            comboBox1.TabIndex = 28;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(9, 114);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(167, 28);
            comboBox2.TabIndex = 29;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(198, 80);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(431, 28);
            comboBox3.TabIndex = 30;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(198, 114);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(431, 28);
            comboBox4.TabIndex = 31;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox4);
            groupBox1.Controls.Add(comboBox3);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Location = new Point(283, 86);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(878, 209);
            groupBox1.TabIndex = 32;
            groupBox1.TabStop = false;
            groupBox1.Text = "検索条件";
            // 
            // employeeid
            // 
            employeeid.HeaderText = "社員番号";
            employeeid.MinimumWidth = 6;
            employeeid.Name = "employeeid";
            employeeid.Width = 125;
            // 
            // firstname
            // 
            firstname.HeaderText = "名前";
            firstname.MinimumWidth = 6;
            firstname.Name = "firstname";
            firstname.Width = 150;
            // 
            // firstnameKana
            // 
            firstnameKana.HeaderText = "名前カナ";
            firstnameKana.MinimumWidth = 6;
            firstnameKana.Name = "firstnameKana";
            firstnameKana.Width = 150;
            // 
            // email
            // 
            email.HeaderText = "メールアドレス";
            email.MinimumWidth = 6;
            email.Name = "email";
            email.Width = 200;
            // 
            // phonenumber
            // 
            phonenumber.HeaderText = "電話番号";
            phonenumber.MinimumWidth = 6;
            phonenumber.Name = "phonenumber";
            phonenumber.Width = 170;
            // 
            // Department
            // 
            Department.HeaderText = "部門";
            Department.MinimumWidth = 6;
            Department.Name = "Department";
            Department.Width = 125;
            // 
            // Position
            // 
            Position.HeaderText = "役職";
            Position.MinimumWidth = 6;
            Position.Name = "Position";
            Position.Width = 125;
            // 
            // status
            // 
            status.HeaderText = "在籍状況";
            status.MinimumWidth = 6;
            status.Name = "status";
            status.Width = 125;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1272, 742);
            Controls.Add(groupBox1);
            Controls.Add(button5);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "MainForm";
            Text = "社員情報管理システムメインフォーム";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Label label2;
        private DataGridView dataGridView1;
        private Button button4;
        private Button button5;
        private Button button6;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private GroupBox groupBox1;
        private DataGridViewTextBoxColumn employeeid;
        private DataGridViewTextBoxColumn firstname;
        private DataGridViewTextBoxColumn firstnameKana;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn phonenumber;
        private DataGridViewTextBoxColumn Department;
        private DataGridViewTextBoxColumn Position;
        private DataGridViewTextBoxColumn status;
    }
}
