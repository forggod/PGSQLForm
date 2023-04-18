using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PGSQLForm
{
    public partial class ProductTableForm : Form
    {
        private DataSet dataSet = new DataSet();
        private DataTable dataTable = new DataTable();
        private string _tableName;
        private string[] _columnName = { "Товары", "Клиенты", "Накладные", "Отчёты" };
        public ProductTableForm(string table)
        {
            _tableName = table;
            InitializeComponent();
            this.Show();
            if (_tableName == "products")
            {
                this.Text = _columnName[0];
                string[] strings =
                {
                    _tableName,
                    "ID",
                    "Наименование",
                    "Количество"
                };
                initConnection(strings);
            }
            else if (_tableName == "clients")
            {
                this.Text = _columnName[1];
                string[] strings =
                {
                    _tableName,
                    "ID",
                    "Имя",
                    "Адрес",
                    "Телефон"
                };
                initConnection(strings);
            }
            else if (_tableName == "futura")
            {
                this.Text = _columnName[2];
                string[] strings =
                {
                    _tableName,
                    "ID",
                    "Дата",
                    "ID клиента",
                    "Сумма"
                };
                // TODO: Добавить запрос с внешними ключами
                initConnection(strings);
            }
            else if (_tableName == "futurainfo")
            {
                this.Text = _columnName[3];
                string[] strings =
                {
                    _tableName,
                    "ID",
                    "ID накладной",
                    "ID товара",
                    "Количество",
                    "Итоговая цена"
                };
                // TODO: Добавить запрос с внешними ключами
                initConnection(strings);
            }
        }

        private void toolStripMenuItem_add_Click(object sender, EventArgs e)
        {
            ProductDataForm productDataForm = new ProductDataForm();
            string s = "Добавить данные ";
            if (_tableName == "products")
                s += _columnName[0];
            else if (_tableName == "clients")
                s += _columnName[1];
            else if (_tableName == "futura")
                s += _columnName[2];
            else if (_tableName == "futurainfo")
                s += _columnName[3];
            productDataForm.Text = s;
        }

        private void toolStripMenuItem_modify_Click(object sender, EventArgs e)
        {
            ProductDataForm productDataForm = new ProductDataForm();
            string s = "Изменить данные ";
            if (_tableName == "products")
                s += _columnName[0];
            else if (_tableName == "clients")
                s += _columnName[1];
            else if (_tableName == "futura")
                s += _columnName[2];
            else if (_tableName == "futurainfo")
                s += _columnName[3];
            productDataForm.Text = s;
        }

        private void toolStripMenuItem_delete_Click_(object sender, EventArgs e)
        {

        }

        private void initConnection(string[] strings)
        {
            try
            {
                NpgsqlConnection connection = new NpgsqlConnection("Server=localhost; Port=5432; User Id=postgres; Password=postpass; Database=sitnikov342");
                connection.Open();

                string sql = $"Select * from {strings[0]}";
                using (NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(sql, connection))
                {
                    dataSet.Reset();
                    dataAdapter.Fill(dataSet);
                }

                dataTable = dataSet.Tables[0];
                dataGridView_table.DataSource = dataTable;
                for (int i = 1; i < strings.Length; i++)
                    dataGridView_table.Columns[i - 1].HeaderText = strings[i];
                connection.Close();
            }
            catch (Exception ex)
            {
                this.Hide();
                Console.WriteLine(ex.ToString());
                this.Close();
            }
        }
    }
}
