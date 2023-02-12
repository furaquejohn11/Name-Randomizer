using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Name_Randomizer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadFormat();

        }
        private void LoadFormat()
        {
            DefaultButtonFormat();
        }
        private void DefaultButtonFormat()
        {
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnCancel.Enabled = false;
        }


        private void AddName()
        {
            if (!listBoxName.Items.Contains(textBox1.Text) && textBox1.Text != "")
            {
                string[] lines = textBox1.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                for (int i = 0; i < lines.Length; i++)
                {
                    listBoxName.Items.Add(lines[i]);
                }
                
            }         
            else if(listBoxName.Items.Contains(textBox1.Text))
            {
                MessageBox.Show("Name already existed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox1.Text != " ")
            {
                MessageBox.Show("Input valid name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        // BUTTON FUNCTIONS
        private void btnAdd_Click(object sender, EventArgs e)
        {

            AddName();
            textBox1.Text = "";
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBoxName.SelectedIndex;
            if (selectedIndex != -1)
            {
                listBoxName.Items[selectedIndex] = textBox1.Text;
            }

            DefaultButtonFormat();
            textBox1.Text = "";

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DefaultButtonFormat();
            textBox1.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DefaultButtonFormat();
            textBox1.Text = "";
        }

        // *************************************************

        private void listBoxName_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Disable add button and enable other two
            btnAdd.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnCancel.Enabled = true;


            int selectedIndex = listBoxName.SelectedIndex;
            if (selectedIndex != -1)
            {
                textBox1.Text = listBoxName.SelectedItem.ToString();
            }

        }

        
    }
}
