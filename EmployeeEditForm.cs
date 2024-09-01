using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 社員情報管理システム
{
    public partial class EmployeeEditForm : Form

        
    {
        //初期設定
        public string EmployeeID
        {
            get { return txt_EmployeeID.Text; }
            set { txt_EmployeeID.Text = value; }
        }

        public string FirstName
        {
            get { return txt_FirstName.Text; }
            set { txt_FirstName.Text = value; }
        }

        public string LastName
        {
            get { return txt_Lastname.Text; }
            set { txt_Lastname.Text = value; }
        }

        public string FirstNameKana
        {
            get { return txt_FirstNameKana.Text; }
            set { txt_FirstNameKana.Text = value; }
        }

        public string LastNameKana
        {
            get { return txt_LastNameKana.Text; }
            set { txt_LastNameKana.Text = value; }
        }

        public string Email
        {
            get { return txt_email.Text; }
            set { txt_email.Text = value; }
        }

        public string PhoneNumber
        {
            get { return txt_Phonenumber.Text; }
            set { txt_Phonenumber.Text = value; }
        }

        public string DepartmentName
        {
            get { return cmb_Department.Text; }
            set { cmb_Department.Text = value; }
        }

        public string PositionName
        {
            get { return cmb_Position.Text; }
            set { cmb_Position.Text = value; }
        }

        public string HireDate
        {
            get { return date_HireDate.Text; }
            set { date_HireDate.Text = value; }
        }

        public string Status
        {
            get { return cmb_Status.Text; }
            set { cmb_Status.Text = value; }
        }



        public EmployeeEditForm()
        {
            InitializeComponent();
        }
        //mainフォームに戻る
        private void btn_close_Click(object sender, EventArgs e)
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

       
        private void EmployeeEditForm_Load(object sender, EventArgs e)
        {

        }

        //社員情報を更新する
        private void btn_Openupdform_Click(object sender, EventArgs e)
        {
            //入力した情報でDBを更新する
            //更新前の確認
            {
                DialogResult result = MessageBox.Show(txt_Lastname.Text + txt_FirstName.Text + "さんを更新して宜しいでしょうか？", "確認",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                //選択肢
                if (result == DialogResult.Yes)
                {
                    //はい

                    //DBを更新する


                    //更新完了
                    MessageBox.Show("更新しました。", "確認");
                    this.Close();
                }

                else if (result == DialogResult.No)
                {
                    //いいえ
                    Console.WriteLine("更新をキャンセルしました。");
                }
            }






        }
    }
}
