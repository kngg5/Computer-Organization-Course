using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace fGlavForma
{
    public partial class Employees : Form
    {
        public Employees()
        {
            InitializeComponent();
            
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tamojnaDataSet8.Contractor". При необходимости она может быть перемещена или удалена.
            this.contractorTableAdapter.Fill(this.tamojnaDataSet8.Contractor);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tamojnaDataSet7.Sotrud". При необходимости она может быть перемещена или удалена.
            this.sotrudTableAdapter.Fill(this.tamojnaDataSet7.Sotrud);
            SqlConnection con = new SqlConnection("Data Source=tamojnaDataSet7BindingSource; Integrated Security=TRUE");


        }

        private void bindingNavigator2_RefreshItems(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

      

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            comboBox1.DataSource = tamojnaDataSet7BindingSource;
            comboBox1.DisplayMember = "Sotrud";
            comboBox1.ValueMember = "Id_Tam";

            Customs child = new Customs();
            Departments child4 = new Departments();
            Positions child2 = new Positions();
            Ranks child3 = new Ranks();

            if (comboBox1.Text == "Customs") {  Customs.Show(); }
            {
                if (comboBox1.Text == "Departments") { Departments.Show(); }
            }
            {
                if (comboBox1.Text == "Positions") { Positions.Show(); }
            }
            {
                if (comboBox1.Text == "Ranks") {  Ranks.Show(); }

            }
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }
    }

    internal class Ranks
    {
        internal static void Show()
        {
            throw new NotImplementedException();
        }
    }

    internal class Positions
    {
        internal static void Show()
        {
            throw new NotImplementedException();
        }
    }

    internal class Departments
    {
        internal static void Show()
        {
            throw new NotImplementedException();
        }
    }

    internal class Customs
    { 
        TamojnaDataSet7TableAdapter.SotrudTableAdapter = 
        internal static void Show()
        {
            throw new NotImplementedException();
        }
    }
}
