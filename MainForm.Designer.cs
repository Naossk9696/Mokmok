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
            EmployeeID = new DataGridViewTextBoxColumn();
            FullName = new DataGridViewTextBoxColumn();
            FullNameKana = new DataGridViewTextBoxColumn();
            Position = new DataGridViewTextBoxColumn();
            Department = new DataGridViewTextBoxColumn();
            button4 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(1147, 590);
            button1.Name = "button1";
            button1.Size = new Size(165, 38);
            button1.TabIndex = 1;
            button1.Text = "終了";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1125, 116);
            button2.Name = "button2";
            button2.Size = new Size(165, 41);
            button2.TabIndex = 2;
            button2.Text = "新規登録";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(301, 116);
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
            label2.Location = new Point(1239, 29);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 22;
            label2.Text = "Ver.1.0";
            label2.Click += label2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { EmployeeID, FullName, FullNameKana, Position, Department });
            dataGridView1.Location = new Point(23, 194);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1289, 366);
            dataGridView1.TabIndex = 23;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // EmployeeID
            // 
            EmployeeID.HeaderText = "社員番号";
            EmployeeID.MinimumWidth = 6;
            EmployeeID.Name = "EmployeeID";
            EmployeeID.Width = 125;
            // 
            // FullName
            // 
            FullName.HeaderText = "名前";
            FullName.MinimumWidth = 6;
            FullName.Name = "FullName";
            FullName.Width = 125;
            // 
            // FullNameKana
            // 
            FullNameKana.HeaderText = "名前カナ";
            FullNameKana.MinimumWidth = 6;
            FullNameKana.Name = "FullNameKana";
            FullNameKana.Width = 125;
            // 
            // Position
            // 
            Position.HeaderText = "役職";
            Position.MinimumWidth = 6;
            Position.Name = "Position";
            Position.Width = 125;
            // 
            // Department
            // 
            Department.HeaderText = "部門";
            Department.MinimumWidth = 6;
            Department.Name = "Department";
            Department.Width = 125;
            // 
            // button4
            // 
            button4.Location = new Point(506, 116);
            button4.Name = "button4";
            button4.Size = new Size(165, 41);
            button4.TabIndex = 24;
            button4.Text = "検索条件リセット";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(23, 116);
            button5.Name = "button5";
            button5.Size = new Size(165, 41);
            button5.TabIndex = 25;
            button5.Text = "詳細検索";
            button5.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1324, 640);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "MainForm";
            Text = "社員情報管理システムメインフォーム";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private DataGridViewTextBoxColumn EmployeeID;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn FullNameKana;
        private DataGridViewTextBoxColumn Position;
        private DataGridViewTextBoxColumn Department;
        private Button button4;
        private Button button5;
    }
}
