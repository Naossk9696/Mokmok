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
    public partial class EmployeeDetailForm : Form
    {
        public EmployeeDetailForm()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            //メイン画面に戻る
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

        private void btn_back_Click_1(object sender, EventArgs e)
        {
            //mainフォームに戻る
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
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            //入力した情報でDBを更新する
            //更新前の確認
            {
                DialogResult result = MessageBox.Show("更新して宜しいでしょうか？", "確認",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                //選択肢
                if (result == DialogResult.Yes)
                {
                    //はい

                    //DBを更新する
                   

                    //更新完了
                    MessageBox.Show("更新しました。","確認");
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
