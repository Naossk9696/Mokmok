using System.Data;
using System.Windows.Forms;
using 社員情報管理システム;
using System;
using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Eventing.Reader;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Security;

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

            // 最大の EmployeeID を取得
            int maxEmployeeID = 0;

            if (dataGridView1.Rows.Count > 0)
            {
                var lastRow = dataGridView1.Rows[dataGridView1.Rows.Count - 1];
                if (lastRow.Cells["EmployeeID"].Value != null)
                {
                    maxEmployeeID = Convert.ToInt32(lastRow.Cells["EmployeeID"].Value);
                }
            }

            // 新しい EmployeeID を生成
            int newEmployeeID = maxEmployeeID + 1;

            // 新規登録フォームを開く
            EmployeeAddForm employeeAddForm = new EmployeeAddForm(newEmployeeID);
            employeeAddForm.ShowDialog();

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
        public void MainForm_Load(object sender, EventArgs e)
        {
            {

                //DB接続
                string connectionString = "Host=localhost; Port= 5432; Username = postgres;Password = naojd0921;Database=Kanri";

                using (var connection = new NpgsqlConnection(connectionString))
                {

                    connection.Open();

                    //string query = "SELECT * FROM public.\"Employees\"";

                    string query = @"
                    SELECT e.EmployeeID, e.FirstName, e.LastName, e.firstnamekana, e.lastnamekana, e.email, e.phonenumber, e.hiredate, d.departmentName, p.PositionName, e.status
                    FROM public.""Employees"" e
                    JOIN public.""departments"" d ON e.""Department"" = d.departmentid
                    JOIN public.""positions"" p ON e.""Position"" = p.positionid";

                    using (var command = new NpgsqlCommand(query, connection))
                    using (var adapter = new NpgsqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();

                        adapter.Fill(dataTable);

                        //DataGritViewのカラム設定を使う=FALSE
                        dataGridView1.AutoGenerateColumns = false;
                        dataGridView1.AllowUserToAddRows = false;

                        //カラム結合
                        // 新しいカラムを追加
                        dataTable.Columns.Add("CombinedFullName", typeof(string));
                        dataTable.Columns.Add("CombinedNameKana", typeof(string));


                        // 既存のカラムを結合して新しいカラムに値を設定
                        foreach (DataRow row in dataTable.Rows)
                        {
                            //row["CombinedFullName"] = row[dataTable.Columns[1].ColumnName].ToString() + " " + row[dataTable.Columns[2].ColumnName].ToString();
                            //row["CombinedNameKana"] = row[dataTable.Columns[3].ColumnName].ToString() + " " + row[dataTable.Columns[4].ColumnName].ToString();
                            row["CombinedFullName"] = row["lastName"].ToString() + " " + row["FirstName"].ToString();
                            row["CombinedNameKana"] = row["lastnamekana"].ToString() + " " + row["firstnamekana"].ToString();
                        }

                        //TBLデータをDataGritView1に表示
                        //dataGridView1.Columns[3].DataPropertyName = dataTable.Columns[5].ColumnName;
                        dataGridView1.Columns[0].DataPropertyName = "employeeid";
                        dataGridView1.Columns[1].DataPropertyName = "CombinedFullName";
                        dataGridView1.Columns[2].DataPropertyName = "CombinedNameKana";
                        dataGridView1.Columns[3].DataPropertyName = "email";
                        dataGridView1.Columns[4].DataPropertyName = "phonenumber";
                        dataGridView1.Columns[5].DataPropertyName = "departmentName";
                        dataGridView1.Columns[6].DataPropertyName = "PositionName";
                        dataGridView1.Columns[7].DataPropertyName = "hiredate";
                        dataGridView1.Columns[8].DataPropertyName = "status";
                        dataGridView1.Columns[9].DataPropertyName = "lastnamekana";
                        dataGridView1.Columns[10].DataPropertyName = "firstnamekana";
                        dataGridView1.Columns[11].DataPropertyName = "LastName";
                        dataGridView1.Columns[12].DataPropertyName = "FirstName";


                        dataGridView1.DataSource = dataTable;

                      

                    }
                }
            }

        }

        private void btn_detail_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedRows[0].Index;

                DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];

                // 
                string EmployeeID = selectedRow.Cells["employeeid"].Value?.ToString();
                string firstName = selectedRow.Cells["FirstName_"].Value?.ToString();
                string LastName = selectedRow.Cells["LastName"].Value?.ToString();
                string firstNameKana = selectedRow.Cells["firstnamekana_"].Value?.ToString();
                string lastNameKana = selectedRow.Cells["lastnamekana"].Value?.ToString();
                string email = selectedRow.Cells["email"].Value?.ToString();
                string phonenumber = selectedRow.Cells["phonenumber"].Value.ToString();
                string departmentName = selectedRow.Cells["department"].Value?.ToString();
                string PositionName = selectedRow.Cells["Position"].Value?.ToString();
                string hiredate = selectedRow.Cells["hiredate"].Value?.ToString();
                string status = selectedRow.Cells["status"].Value?.ToString();


                // 取得したデータを渡して詳細フォームを表示
                EmployeeDetailForm employeeDetailForm = new EmployeeDetailForm();
                employeeDetailForm.EmployeeID = EmployeeID;
                employeeDetailForm.FirstName = firstName;
                employeeDetailForm.LastName = LastName;
                employeeDetailForm.FirstNameKana = firstNameKana;
                employeeDetailForm.LastNameKana = lastNameKana;
                employeeDetailForm.Email = email;
                employeeDetailForm.PhoneNumber = phonenumber;
                employeeDetailForm.DepartmentName = departmentName;
                employeeDetailForm.PositionName = PositionName;
                employeeDetailForm.HireDate = hiredate;
                employeeDetailForm.Status = status;

                employeeDetailForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("データが選択されていません。");
            }


        }


           
        

    }


}

