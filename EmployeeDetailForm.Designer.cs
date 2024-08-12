﻿using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace 社員情報管理システム
{
    partial class EmployeeDetailForm
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            comboBox1 = new ComboBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            button2 = new Button();
            textBox9 = new TextBox();
            button1 = new Button();
            //SuspendLayout();
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
            // textBox1
            // 
            textBox1.Location = new Point(151, 89);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(154, 27);
            textBox1.TabIndex = 12;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(151, 136);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(154, 27);
            textBox2.TabIndex = 13;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(151, 180);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(432, 27);
            textBox3.TabIndex = 14;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(151, 224);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(432, 27);
            textBox4.TabIndex = 15;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(428, 85);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(155, 27);
            textBox5.TabIndex = 16;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(428, 140);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(155, 27);
            textBox6.TabIndex = 17;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(151, 273);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 18;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(151, 323);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(151, 27);
            textBox7.TabIndex = 19;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(151, 419);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(151, 27);
            textBox8.TabIndex = 20;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(151, 372);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 21;
            // 
            // button2
            // 
            button2.Location = new Point(559, 500);
            button2.Name = "button2";
            button2.Size = new Size(166, 54);
            button2.TabIndex = 23;
            button2.Text = "メインに戻る";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(151, 45);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(154, 27);
            textBox9.TabIndex = 25;
            // 
            // button1
            // 
            button1.Location = new Point(273, 500);
            button1.Name = "button1";
            button1.Size = new Size(166, 54);
            button1.TabIndex = 26;
            button1.Text = "更新する";
            button1.UseVisualStyleBackColor = true;
            // 
            // EmployeeDetailForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(737, 566);
            Controls.Add(button1);
            Controls.Add(textBox9);
            Controls.Add(button2);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(comboBox1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
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
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private ComboBox comboBox1;
        private TextBox textBox7;
        private TextBox textBox8;
        private DateTimePicker dateTimePicker1;
        private Button button2;
        private TextBox textBox9;
        private Button button1;
    }
}
