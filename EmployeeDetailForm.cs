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
    public partial class EmployeeDetailForm : Form


    {
        public string EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FirstNameKana { get; set; }
        public string LastNameKana { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string DepartmentName { get; set; }
        public string PositionName { get; set; }
        public string HireDate { get; set; }
        public string Status { get; set; }



        public EmployeeDetailForm()
        {
            InitializeComponent();
        }


        private void EmployeeDetailForm_Load(object sender, EventArgs e)
        {
            // InitializeComponent();


            //DataGritViewで選択した情報をフォームに表示する
            txt_Employeeid.Text = EmployeeID;
            txt_Lastname.Text = LastName;
            txt_FirstName.Text = FirstName;
            txt_LastnameKana.Text = LastNameKana;
            txt_Namekana.Text = FirstNameKana;
            txt_email.Text = Email;
            txt_phonenumber.Text = PhoneNumber;
            date_hiredate.Text = HireDate;
            cmb_Department.Text = DepartmentName;
            cmb_position.Text = PositionName;
            txt_status.Text = Status;
        }

        //メイン画面に戻る
        private void btn_back_Click(object sender, EventArgs e)
        {
            {
                //終了前の確認
                DialogResult result = MessageBox.Show("メイン画面に戻りますか？", "確認",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                //選択肢
                if (result == DialogResult.Yes)
                {
                    //はい
                    this.Close();

                }

                else if (result == DialogResult.No)
                {
                    //いいえ
                    Console.WriteLine("キャンセルしました。");
                }

            }
        }

        //社員情報を更新する
        private void btn_update_Click(object sender, EventArgs e)
        {
            //取得した情報を社員情報編集フォームに渡す
            EmployeeEditForm employeeEditForm = new EmployeeEditForm();

            employeeEditForm.EmployeeID = txt_Employeeid.Text;
            employeeEditForm.FirstName = txt_FirstName.Text;
            employeeEditForm.LastName = txt_Lastname.Text;
            employeeEditForm.FirstNameKana = txt_Namekana.Text;
            employeeEditForm.LastNameKana = txt_LastnameKana.Text;
            employeeEditForm.Email = txt_email.Text;
            employeeEditForm.PhoneNumber = txt_phonenumber.Text;
            employeeEditForm.DepartmentName = cmb_Department.Text;
            employeeEditForm.PositionName = cmb_position.Text;
            employeeEditForm.HireDate = date_hiredate.Text;
            employeeEditForm.Status = txt_status.Text;


            //社員情報編集フォームを開く
            employeeEditForm.ShowDialog();

            

        }

        //社員情報を削除する
        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(txt_Lastname.Text + txt_FirstName.Text + "さんを削除して宜しいでしょうか？", "確認",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question);

            //選択肢
            if (result == DialogResult.Yes)
            {
                //はい

                //DBを更新する


                //更新完了
                MessageBox.Show("削除しました。", "確認");
                this.Close();
            }

            else if (result == DialogResult.No)
            {
                //いいえ
                Console.WriteLine("削除をキャンセルしました。");
            }
        }
        //社員情報を削除する
        private void btn_Delete_Click_1(object sender, EventArgs e)
        {
            //削除前の確認
            DialogResult result = MessageBox.Show("XXさんを削除して宜しいでしょうか？", "確認",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            //選択肢
            if (result == DialogResult.Yes)
            {
                //はい
                //DB更新
                MessageBox.Show("削除しました。メイン画面に戻ります。", "確認");

                this.Close();
            }

            else if (result == DialogResult.No)
            {
                //いいえ
                Console.WriteLine("キャンセルしました。");
            }
        }
    }
    
}



