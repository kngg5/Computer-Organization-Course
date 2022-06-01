using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fGlavForma
{
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Products_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tamojnaDataSet7.Products". При необходимости она может быть перемещена или удалена.
            this.productsTableAdapter1.Fill(this.tamojnaDataSet7.Products);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tamojnaDataSet6.Products". При необходимости она может быть перемещена или удалена.
            this.productsTableAdapter.Fill(this.tamojnaDataSet6.Products);

        }
    }
}
