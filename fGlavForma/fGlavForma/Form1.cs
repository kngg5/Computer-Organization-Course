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
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void customsClearanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employees f = new Employees();
            f.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        internal class TamojnaDataSet8 : fGlavForma.TamojnaDataSet8
        {
        }

        internal class TamojnaDataSet7 : fGlavForma.TamojnaDataSet7
        {
        }

        internal class TamojnaDataSet7TableAdapters
        {
            internal class SotrudTableAdapter : fGlavForma.TamojnaDataSet7TableAdapters.SotrudTableAdapter
            {
            }
        }

        internal class TamojnaDataSet8TableAdapters
        {
            internal class ContractorTableAdapter : fGlavForma.TamojnaDataSet8TableAdapters.ContractorTableAdapter
            {
            }
        }
    }
}
