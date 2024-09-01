using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace 社員情報管理システム
{
    public partial class EmployeeAddForm : Form
    {
        private int employeeID;
        public EmployeeAddForm(int newEmployeeID)
        {
            InitializeComponent();
            employeeID = newEmployeeID;
        }

        //mainフォームに戻る
        private void btn_back_Click(object sender, EventArgs e)
        {
            //終了前の確認
            DialogResult result = MessageBox.Show("メイン画面に戻りますか？", "確認",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            //選択肢
            if (result == DialogResult.Yes)
            {
                //はい

                //テキストボックス内にデータが入っていた場合の再確認
                this.Close();
            }

            else if (result == DialogResult.No)
            {
                //いいえ
                Console.WriteLine("キャンセルしました。");
            }
        }

        //入力したデータを登録する
        private void btn_addinfo_Click(object sender, EventArgs e)
        {
            //登録前の確認ポップアップを表示
            DialogResult result = MessageBox.Show("xxさんを登録して宜しいですか？", "確認",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            //選択肢
            if (result == DialogResult.Yes)
            {
                //はい

                //入力項目必須欄が空白の場合確認する

                this.Close();
            }

            else if (result == DialogResult.No)
            {
                //いいえ
                Console.WriteLine("キャンセルしました。");
            }
        }

        //新規登録フォームを表示
        private void EmployeeAddForm_Load(object sender, EventArgs e)
        {

            // txt_EmployeeID に設定
            txt_EmployeeID.Text = employeeID.ToString("D6");
        }

        //txt_EmployeeID.Text = EmployeeID;
        //txt_LastName.Text = LastName;
        //txt_FirstName.Text = FirstName;
        //txt_LastnameKana.Text = LastNameKana;
        //txt_FirstnameKana.Text = FirstNameKana;
        //txt_email.Text = Email;
        //txt_phonenumber.Text = PhoneNumber;
        //date_hiredate.Text = HireDate;
        //cmb_Department.SelectedValue = DepartmentName;
        //cmb_Position.Text = PositionName;
        //cmb_status.Text = Status;

    }

}