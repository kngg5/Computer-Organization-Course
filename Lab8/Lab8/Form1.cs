using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void whichAreChosenForCheckbox_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                MessageBox.Show("CheckBox1 is selected");
            }
            if(checkBox2.Checked == true)
            {
                MessageBox.Show("CheckBox2 is selected");
            }
            if (checkBox3.Checked == true)
            {
                MessageBox.Show("CheckBox3 is selected");
            }
        }

        private void propertiesCheckStateForCheckbox_Click(object sender, EventArgs e)
        {
            MessageBox.Show(checkBox1.CheckState.ToString());
            MessageBox.Show(checkBox2.CheckState.ToString());
            MessageBox.Show(checkBox3.CheckState.ToString());
            checkBox1.CheckState = CheckState.Unchecked;
            checkBox2.CheckState = CheckState.Checked;
            checkBox3.CheckState = CheckState.Indeterminate;
            if(checkBox2.CheckState == CheckState.Checked)
            {
                MessageBox.Show("The state of option 2 is equal to selected");
            } else
            {
                MessageBox.Show("The state of choice item 2 is not selected or not defined");
            }
        }

        private void selectProgrammaticallyForCheckbox_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
            checkBox2.Checked = false;
            checkBox3.Checked = true;

        }


        private void whichAreChosenForRadioButton_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            {
                MessageBox.Show("The radioButton1 item is selected");
            }
            if(radioButton2.Checked == true)
            {
                MessageBox.Show("RadioButton2 is selected");
            }
            if (radioButton3.Checked == true)
            {
                MessageBox.Show("RadioButton3 is selected");
            }
            MessageBox.Show("We can only select one item");
        }

        private void selectProgrammaticallyForRadioButton_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            radioButton2.Checked = true;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("The CheckedChanged event has occurred");
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("The CheckedChanged event has occurred");
        }

        private void whichAreChosenForGroupBox_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            {
                MessageBox.Show("The radioButton1 item is selected");
            }
            if(radioButton2.Checked == true)
            {
                MessageBox.Show("RadioButton2 is selected");
            }
            if (radioButton3.Checked == true)
            {
                MessageBox.Show("RadioButton3 is selected");
            }
            if (radioButton4.Checked == true)
            {
                MessageBox.Show("The  radioButton4 item is selected");
            }
            if (radioButton5.Checked == true)
            {
                MessageBox.Show("The RadioButton5 item is selected");
            }
            if (radioButton6.Checked == true)
            {
                MessageBox.Show("RadioButton6 is selected");
            }
            MessageBox.Show("We can select only two items from this group and the previous one");
        }
    }
}
