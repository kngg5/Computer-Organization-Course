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
    public partial class Customs_declaration_export : Form
    {
        public Customs_declaration_export()
        {
            InitializeComponent();
        }

        private void Customs_declaration_export_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tamojnaDataSet7._Customs_declaration_export". При необходимости она может быть перемещена или удалена.
            this.customs_declaration_exportTableAdapter.Fill(this.tamojnaDataSet7._Customs_declaration_export);

        }
    }
}
