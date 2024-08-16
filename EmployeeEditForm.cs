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
        public EmployeeEditForm()
        {

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

        private void btn_delete_Click(object sender, EventArgs e)
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
