using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppSmyslov13
{
    public partial class FormWork : Form
    {
        public FormWork()
        {
            InitializeComponent();
        }

        private void buttonLoadList_Click(object sender, EventArgs e)
        {
            DrugsStoreEntities db = new DrugsStoreEntities();

            List<Product> products = db.Products.ToList();

            dataGridViewDrugs.DataSource = null;
            dataGridViewDrugs.DataSource = products;

            dataGridViewDrugs.Columns["Id"].Visible = false;
            dataGridViewDrugs.Columns["Name"].HeaderText = "Название препарата";
            dataGridViewDrugs.Columns["Amount"].HeaderText = "Осталось штук на складе";
            dataGridViewDrugs.Columns["Price"].HeaderText = "Цена за штуку";

        }
    }
}
