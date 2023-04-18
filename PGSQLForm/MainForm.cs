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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button_products_Click(object sender, EventArgs e)
        {
            // Товары
            ProductTableForm productTableForm = new ProductTableForm("products");
        }

        private void button_clients_Click(object sender, EventArgs e)
        {
            // Клиенты
            ProductTableForm productTableForm = new ProductTableForm("clients");
        }

        private void button_invoices_Click(object sender, EventArgs e)
        {
            // Накладные
            ProductTableForm productTableForm = new ProductTableForm("futura");
        }

        private void button_reports_Click(object sender, EventArgs e)
        {
            // Отчёты
            ProductTableForm productTableForm = new ProductTableForm("futurainfo");
        }
    }
}
