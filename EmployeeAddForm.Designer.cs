namespace 社員情報管理システム
{
    partial class EmployeeAddForm
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
            btn_back = new Button();
            btn_addinfo = new Button();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txt_LastName = new TextBox();
            txt_FirstName = new TextBox();
            label12 = new Label();
            label13 = new Label();
            txt_LastnameKana = new TextBox();
            txt_FirstnameKana = new TextBox();
            txt_email = new TextBox();
            txt_phonenumber = new TextBox();
            cmb_Department = new ComboBox();
            cmb_Position = new ComboBox();
            date_hiredate = new DateTimePicker();
            cmb_status = new ComboBox();
            txt_EmployeeID = new TextBox();
            SuspendLayout();
            // 
            // btn_back
            // 
            btn_back.Location = new Point(501, 553);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(144, 55);
            btn_back.TabIndex = 0;
            btn_back.Text = "メインに戻る";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // btn_addinfo
            // 
            btn_addinfo.Location = new Point(220, 553);
            btn_addinfo.Name = "btn_addinfo";
            btn_addinfo.Size = new Size(203, 55);
            btn_addinfo.TabIndex = 1;
            btn_addinfo.Text = "登録する";
            btn_addinfo.UseVisualStyleBackColor = true;
            btn_addinfo.Click += btn_addinfo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 75);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 3;
            label1.Text = "社員番号";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 124);
            label3.Name = "label3";
            label3.Size = new Size(24, 20);
            label3.TabIndex = 5;
            label3.Text = "姓";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 173);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 6;
            label2.Text = "姓（かな）";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 229);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 8;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 275);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 9;
            label6.Text = "電話番号";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(30, 416);
            label7.Name = "label7";
            label7.Size = new Size(54, 20);
            label7.TabIndex = 10;
            label7.Text = "雇用日";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(30, 322);
            label8.Name = "label8";
            label8.Size = new Size(39, 20);
            label8.TabIndex = 11;
            label8.Text = "部門";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(30, 372);
            label9.Name = "label9";
            label9.Size = new Size(39, 20);
            label9.TabIndex = 12;
            label9.Text = "役職";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(30, 462);
            label10.Name = "label10";
            label10.Size = new Size(69, 20);
            label10.TabIndex = 13;
            label10.Text = "在職状況";
            // 
            // txt_LastName
            // 
            txt_LastName.Location = new Point(164, 121);
            txt_LastName.Name = "txt_LastName";
            txt_LastName.Size = new Size(152, 27);
            txt_LastName.TabIndex = 16;
            // 
            // txt_FirstName
            // 
            txt_FirstName.Location = new Point(448, 124);
            txt_FirstName.Name = "txt_FirstName";
            txt_FirstName.Size = new Size(152, 27);
            txt_FirstName.TabIndex = 17;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(342, 128);
            label12.Name = "label12";
            label12.Size = new Size(39, 20);
            label12.TabIndex = 18;
            label12.Text = "名前";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(342, 173);
            label13.Name = "label13";
            label13.Size = new Size(94, 20);
            label13.TabIndex = 19;
            label13.Text = "名前（かな）";
            // 
            // txt_LastnameKana
            // 
            txt_LastnameKana.Location = new Point(164, 170);
            txt_LastnameKana.Name = "txt_LastnameKana";
            txt_LastnameKana.Size = new Size(152, 27);
            txt_LastnameKana.TabIndex = 20;
            // 
            // txt_FirstnameKana
            // 
            txt_FirstnameKana.Location = new Point(448, 173);
            txt_FirstnameKana.Name = "txt_FirstnameKana";
            txt_FirstnameKana.Size = new Size(152, 27);
            txt_FirstnameKana.TabIndex = 21;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(164, 222);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(436, 27);
            txt_email.TabIndex = 22;
            // 
            // txt_phonenumber
            // 
            txt_phonenumber.Location = new Point(164, 275);
            txt_phonenumber.Name = "txt_phonenumber";
            txt_phonenumber.Size = new Size(436, 27);
            txt_phonenumber.TabIndex = 23;
            // 
            // cmb_Department
            // 
            cmb_Department.FormattingEnabled = true;
            cmb_Department.Location = new Point(164, 319);
            cmb_Department.Name = "cmb_Department";
            cmb_Department.Size = new Size(160, 28);
            cmb_Department.TabIndex = 24;
            // 
            // cmb_Position
            // 
            cmb_Position.FormattingEnabled = true;
            cmb_Position.Location = new Point(164, 364);
            cmb_Position.Name = "cmb_Position";
            cmb_Position.Size = new Size(160, 28);
            cmb_Position.TabIndex = 25;
            // 
            // date_hiredate
            // 
            date_hiredate.Location = new Point(161, 416);
            date_hiredate.Name = "date_hiredate";
            date_hiredate.Size = new Size(212, 27);
            date_hiredate.TabIndex = 26;
            // 
            // cmb_status
            // 
            cmb_status.FormattingEnabled = true;
            cmb_status.Location = new Point(161, 462);
            cmb_status.Name = "cmb_status";
            cmb_status.Size = new Size(160, 28);
            cmb_status.TabIndex = 27;
            // 
            // txt_EmployeeID
            // 
            txt_EmployeeID.Location = new Point(164, 75);
            txt_EmployeeID.Name = "txt_EmployeeID";
            txt_EmployeeID.Size = new Size(152, 27);
            txt_EmployeeID.TabIndex = 28;
            // 
            // EmployeeAddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(671, 622);
            Controls.Add(txt_EmployeeID);
            Controls.Add(cmb_status);
            Controls.Add(date_hiredate);
            Controls.Add(cmb_Position);
            Controls.Add(cmb_Department);
            Controls.Add(txt_phonenumber);
            Controls.Add(txt_email);
            Controls.Add(txt_FirstnameKana);
            Controls.Add(txt_LastnameKana);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(txt_FirstName);
            Controls.Add(txt_LastName);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(btn_addinfo);
            Controls.Add(btn_back);
            Name = "EmployeeAddForm";
            Text = "社員情報新規登録フォーム";
            Load += EmployeeAddForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_back;
        private Button btn_addinfo;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txt_LastName;
        private TextBox txt_FirstName;
        private Label label12;
        private Label label13;
        private TextBox txt_LastnameKana;
        private TextBox txt_FirstnameKana;
        private TextBox txt_email;
        private TextBox txt_phonenumber;
        private ComboBox cmb_Department;
        private ComboBox cmb_Position;
        private DateTimePicker date_hiredate;
        private ComboBox cmb_status;
        private TextBox txt_EmployeeID;
    }
}