using System.Data;
using System.Windows.Forms;
using 社員情報管理システム;
using System;
using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Eventing.Reader;

namespace 社員情報管理システム
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            //終了前の確認
            DialogResult result = MessageBox.Show("社員情報管理システムを終了しますか？", "確認",
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


        private void btn_add_Click(object sender, EventArgs e)
        {
            //新規登録フォームを開く
            EmployeeAddForm employeeAddForm = new EmployeeAddForm();
            employeeAddForm.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
        //システム起動時にデータを表示する
        private void MainForm_Load(object sender, EventArgs e)
        {
            {
                string connectionString = "Host=localhost; Port= 5432; Username = postgres;Password = naojd0921;Database=Kanri";

                using (var connectioin = new NpgsqlConnection(connectionString))
                {

                    connectioin.Open();
                    string query = "SELECT * FROM public.\"Employees\"";
                    using (var command = new NpgsqlCommand(query, connectioin))
                    using (var adapter = new NpgsqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();

                        adapter.Fill(dataTable);

                        //DataGritViewのカラム設定を使う=FALSE
                        dataGridView1.AutoGenerateColumns = false;

                        //カラム結合
                        // 新しいカラムを追加
                        dataTable.Columns.Add("CombinedFullName", typeof(string));
                        dataTable.Columns.Add("CombinedNameKana", typeof(string));

                        // 既存のカラムを結合して新しいカラムに値を設定
                        foreach (DataRow row in dataTable.Rows)
                        {
                            row["CombinedFullName"] = row[dataTable.Columns[1].ColumnName].ToString() + " " + row[dataTable.Columns[2].ColumnName].ToString();
                            row["CombinedNameKana"] = row[dataTable.Columns[3].ColumnName].ToString() + " " + row[dataTable.Columns[4].ColumnName].ToString();
                        }

                        //TBLデータをDataGritView1に表示
                        dataGridView1.Columns[0].DataPropertyName = dataTable.Columns[0].ColumnName;
                        dataGridView1.Columns[3].DataPropertyName = dataTable.Columns[5].ColumnName;
                        dataGridView1.Columns[4].DataPropertyName = dataTable.Columns[6].ColumnName;
                        dataGridView1.Columns[5].DataPropertyName = dataTable.Columns[8].ColumnName;
                        dataGridView1.Columns[6].DataPropertyName = dataTable.Columns[9].ColumnName;
                        dataGridView1.Columns[7].DataPropertyName = dataTable.Columns[7].ColumnName;
                        dataGridView1.Columns[8].DataPropertyName = dataTable.Columns[10].ColumnName;

                        dataGridView1.Columns[1].DataPropertyName = "CombinedFullName";
                        dataGridView1.Columns[2].DataPropertyName = "CombinedNameKana";

                        dataGridView1.DataSource = dataTable;

                    }
                }
            }

        }

        private void btn_detail_Click(object sender, EventArgs e)
        {
            EmployeeDetailForm employeeDetailForm = new EmployeeDetailForm();
            employeeDetailForm.Show();
        }
    }

}

