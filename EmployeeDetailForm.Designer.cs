using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace 社員情報管理システム
{
    partial class EmployeeDetailForm
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
            txt_Lastname = new TextBox();
            txt_LastnameKana = new TextBox();
            txt_email = new TextBox();
            txt_phonenumber = new TextBox();
            txt_FirstName = new TextBox();
            txt_Namekana = new TextBox();
            cmb_Department = new ComboBox();
            cmb_position = new ComboBox();
            txt_status = new TextBox();
            date_hiredate = new DateTimePicker();
            btn_back = new Button();
            txt_Employeeid = new TextBox();
            btn_update = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 48);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 0;
            label1.Text = "社員番号";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 92);
            label2.Name = "label2";
            label2.Size = new Size(24, 20);
            label2.TabIndex = 1;
            label2.Text = "姓";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 143);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 2;
            label3.Text = "姓（かな）";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 187);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 3;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(48, 231);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 4;
            label5.Text = "電話番号";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(48, 281);
            label6.Name = "label6";
            label6.Size = new Size(39, 20);
            label6.TabIndex = 5;
            label6.Text = "部門";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(48, 330);
            label7.Name = "label7";
            label7.Size = new Size(39, 20);
            label7.TabIndex = 6;
            label7.Text = "役職";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(48, 379);
            label8.Name = "label8";
            label8.Size = new Size(54, 20);
            label8.TabIndex = 7;
            label8.Text = "雇用日";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(48, 426);
            label9.Name = "label9";
            label9.Size = new Size(69, 20);
            label9.TabIndex = 8;
            label9.Text = "在職状況";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(332, 92);
            label10.Name = "label10";
            label10.Size = new Size(39, 20);
            label10.TabIndex = 9;
            label10.Text = "名前";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(332, 143);
            label11.Name = "label11";
            label11.Size = new Size(94, 20);
            label11.TabIndex = 10;
            label11.Text = "名前（かな）";
            // 
            // txt_Lastname
            // 
            txt_Lastname.Location = new Point(151, 89);
            txt_Lastname.Name = "txt_Lastname";
            txt_Lastname.Size = new Size(154, 27);
            txt_Lastname.TabIndex = 12;
            // 
            // txt_LastnameKana
            // 
            txt_LastnameKana.Location = new Point(151, 136);
            txt_LastnameKana.Name = "txt_LastnameKana";
            txt_LastnameKana.Size = new Size(154, 27);
            txt_LastnameKana.TabIndex = 13;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(151, 180);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(432, 27);
            txt_email.TabIndex = 14;
            // 
            // txt_phonenumber
            // 
            txt_phonenumber.Location = new Point(151, 224);
            txt_phonenumber.Name = "txt_phonenumber";
            txt_phonenumber.Size = new Size(432, 27);
            txt_phonenumber.TabIndex = 15;
            // 
            // txt_FirstName
            // 
            txt_FirstName.Location = new Point(428, 85);
            txt_FirstName.Name = "txt_FirstName";
            txt_FirstName.Size = new Size(155, 27);
            txt_FirstName.TabIndex = 16;
            // 
            // txt_Namekana
            // 
            txt_Namekana.Location = new Point(428, 140);
            txt_Namekana.Name = "txt_Namekana";
            txt_Namekana.Size = new Size(155, 27);
            txt_Namekana.TabIndex = 17;
            // 
            // cmb_Department
            // 
            cmb_Department.FormattingEnabled = true;
            cmb_Department.Location = new Point(151, 273);
            cmb_Department.Name = "cmb_Department";
            cmb_Department.Size = new Size(151, 28);
            cmb_Department.TabIndex = 18;
            // 
            // cmb_position
            // 
            cmb_position.Location = new Point(151, 323);
            cmb_position.Name = "cmb_position";
            cmb_position.Size = new Size(151, 27);
            cmb_position.TabIndex = 19;
            // 
            // txt_status
            // 
            txt_status.Location = new Point(151, 419);
            txt_status.Name = "txt_status";
            txt_status.Size = new Size(151, 27);
            txt_status.TabIndex = 20;
            // 
            // date_hiredate
            // 
            date_hiredate.Location = new Point(151, 372);
            date_hiredate.Name = "date_hiredate";
            date_hiredate.Size = new Size(250, 27);
            date_hiredate.TabIndex = 21;
            // 
            // btn_back
            // 
            btn_back.Location = new Point(559, 500);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(166, 54);
            btn_back.TabIndex = 23;
            btn_back.Text = "メインに戻る";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // txt_Employeeid
            // 
            txt_Employeeid.Location = new Point(151, 45);
            txt_Employeeid.Name = "txt_Employeeid";
            txt_Employeeid.Size = new Size(154, 27);
            txt_Employeeid.TabIndex = 25;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(273, 500);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(166, 54);
            btn_update.TabIndex = 26;
            btn_update.Text = "更新する";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // EmployeeDetailForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(737, 566);
            Controls.Add(btn_update);
            Controls.Add(txt_Employeeid);
            Controls.Add(btn_back);
            Controls.Add(date_hiredate);
            Controls.Add(txt_status);
            Controls.Add(cmb_position);
            Controls.Add(cmb_Department);
            Controls.Add(txt_Namekana);
            Controls.Add(txt_FirstName);
            Controls.Add(txt_phonenumber);
            Controls.Add(txt_email);
            Controls.Add(txt_LastnameKana);
            Controls.Add(txt_Lastname);
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
            Name = "EmployeeDetailForm";
            Text = "社員情報詳細フォーム";
            Load += EmployeeDetailForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox txt_Lastname;
        private TextBox txt_LastnameKana;
        private TextBox txt_email;
        private TextBox txt_phonenumber;
        private TextBox txt_FirstName;
        private TextBox txt_Namekana;
        private ComboBox cmb_Department;
        private ComboBox cmb_position;
        private TextBox txt_status;
        private DateTimePicker date_hiredate;
        private Button btn_back;
        private TextBox txt_Employeeid;
        private Button btn_update;
    }

   
}
