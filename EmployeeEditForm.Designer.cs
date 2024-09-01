using System;
using System.Windows.Forms;


namespace 社員情報管理システム
{
    partial class EmployeeEditForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            btn_close = new Button();
            txt_Lastname = new TextBox();
            txt_LastNameKana = new TextBox();
            txt_email = new TextBox();
            txt_Phonenumber = new TextBox();
            txt_FirstName = new TextBox();
            txt_FirstNameKana = new TextBox();
            cmb_Department = new ComboBox();
            cmb_Position = new ComboBox();
            cmb_Status = new ComboBox();
            date_HireDate = new DateTimePicker();
            txt_EmployeeID = new TextBox();
            btn_Openupdform = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 38);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 0;
            label1.Text = "社員番号";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 82);
            label2.Name = "label2";
            label2.Size = new Size(24, 20);
            label2.TabIndex = 1;
            label2.Text = "姓";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 123);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 2;
            label3.Text = "姓（かな）";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 163);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 3;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 212);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 4;
            label5.Text = "携帯番号";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(33, 261);
            label6.Name = "label6";
            label6.Size = new Size(39, 20);
            label6.TabIndex = 5;
            label6.Text = "部門";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(33, 308);
            label7.Name = "label7";
            label7.Size = new Size(39, 20);
            label7.TabIndex = 6;
            label7.Text = "役職";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(33, 355);
            label8.Name = "label8";
            label8.Size = new Size(54, 20);
            label8.TabIndex = 7;
            label8.Text = "雇用日";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(33, 401);
            label9.Name = "label9";
            label9.Size = new Size(69, 20);
            label9.TabIndex = 8;
            label9.Text = "在職状況";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(343, 82);
            label10.Name = "label10";
            label10.Size = new Size(39, 20);
            label10.TabIndex = 9;
            label10.Text = "名前";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(343, 123);
            label11.Name = "label11";
            label11.Size = new Size(94, 20);
            label11.TabIndex = 10;
            label11.Text = "名前（かな）";
            // 
            // btn_close
            // 
            btn_close.Location = new Point(644, 411);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(122, 54);
            btn_close.TabIndex = 12;
            btn_close.Text = "閉じる";
            btn_close.UseVisualStyleBackColor = true;
            btn_close.Click += btn_close_Click;
            // 
            // txt_Lastname
            // 
            txt_Lastname.Location = new Point(129, 79);
            txt_Lastname.Name = "txt_Lastname";
            txt_Lastname.Size = new Size(177, 27);
            txt_Lastname.TabIndex = 13;
            // 
            // txt_LastNameKana
            // 
            txt_LastNameKana.Location = new Point(129, 120);
            txt_LastNameKana.Name = "txt_LastNameKana";
            txt_LastNameKana.Size = new Size(177, 27);
            txt_LastNameKana.TabIndex = 14;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(129, 163);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(514, 27);
            txt_email.TabIndex = 15;
            // 
            // txt_Phonenumber
            // 
            txt_Phonenumber.Location = new Point(129, 209);
            txt_Phonenumber.Name = "txt_Phonenumber";
            txt_Phonenumber.Size = new Size(514, 27);
            txt_Phonenumber.TabIndex = 16;
            // 
            // txt_FirstName
            // 
            txt_FirstName.Location = new Point(466, 82);
            txt_FirstName.Name = "txt_FirstName";
            txt_FirstName.Size = new Size(177, 27);
            txt_FirstName.TabIndex = 17;
            // 
            // txt_FirstNameKana
            // 
            txt_FirstNameKana.Location = new Point(466, 123);
            txt_FirstNameKana.Name = "txt_FirstNameKana";
            txt_FirstNameKana.Size = new Size(177, 27);
            txt_FirstNameKana.TabIndex = 18;
            // 
            // cmb_Department
            // 
            cmb_Department.FormattingEnabled = true;
            cmb_Department.Location = new Point(129, 258);
            cmb_Department.Name = "cmb_Department";
            cmb_Department.Size = new Size(177, 28);
            cmb_Department.TabIndex = 19;
            // 
            // cmb_Position
            // 
            cmb_Position.FormattingEnabled = true;
            cmb_Position.Location = new Point(129, 308);
            cmb_Position.Name = "cmb_Position";
            cmb_Position.Size = new Size(177, 28);
            cmb_Position.TabIndex = 20;
            // 
            // cmb_Status
            // 
            cmb_Status.FormattingEnabled = true;
            cmb_Status.Location = new Point(129, 401);
            cmb_Status.Name = "cmb_Status";
            cmb_Status.Size = new Size(177, 28);
            cmb_Status.TabIndex = 21;
            // 
            // date_HireDate
            // 
            date_HireDate.Location = new Point(129, 355);
            date_HireDate.Name = "date_HireDate";
            date_HireDate.Size = new Size(225, 27);
            date_HireDate.TabIndex = 22;
            // 
            // txt_EmployeeID
            // 
            txt_EmployeeID.Location = new Point(129, 35);
            txt_EmployeeID.Name = "txt_EmployeeID";
            txt_EmployeeID.Size = new Size(177, 27);
            txt_EmployeeID.TabIndex = 23;
            // 
            // btn_Openupdform
            // 
            btn_Openupdform.Location = new Point(644, 321);
            btn_Openupdform.Name = "btn_Openupdform";
            btn_Openupdform.Size = new Size(125, 54);
            btn_Openupdform.TabIndex = 24;
            btn_Openupdform.Text = "情報を更新する";
            btn_Openupdform.UseVisualStyleBackColor = true;
            btn_Openupdform.Click += btn_Openupdform_Click;
            // 
            // EmployeeEditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 489);
            Controls.Add(btn_Openupdform);
            Controls.Add(txt_EmployeeID);
            Controls.Add(date_HireDate);
            Controls.Add(cmb_Status);
            Controls.Add(cmb_Position);
            Controls.Add(cmb_Department);
            Controls.Add(txt_FirstNameKana);
            Controls.Add(txt_FirstName);
            Controls.Add(txt_Phonenumber);
            Controls.Add(txt_email);
            Controls.Add(txt_LastNameKana);
            Controls.Add(txt_Lastname);
            Controls.Add(btn_close);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EmployeeEditForm";
            Text = "社員情報更新フォーム";
            Load += EmployeeEditForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        public Label label1;
        public Label label2;
        public Label label3;
        public Label label4;
        public Label label5;
        public Label label6;
        public Label label7;
        public Label label8;
        public Label label9;
        public Label label10;
        public Label label11;
        public Button btn_close;
        public TextBox txt_Lastname;
        public TextBox txt_LastNameKana;
        public TextBox txt_email;
        public TextBox txt_Phonenumber;
        public TextBox txt_FirstName;
        public TextBox txt_FirstNameKana;
        public ComboBox cmb_Department;
        public ComboBox cmb_Position;
        public ComboBox cmb_Status;
        public DateTimePicker date_HireDate;
        public TextBox txt_EmployeeID;
        public Button btn_Openupdform;
    }
}