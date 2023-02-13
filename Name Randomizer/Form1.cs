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
        private static List<string> randomNames = new List<string>();
        public List<string> randomList
        {
            get { return randomNames; }
            set { randomNames = value; }
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
        private void btnRandom_Click(object sender, EventArgs e)
        {
            RandomProcess();
            frmResult formResult = new frmResult();
            formResult.ShowDialog();
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

        private void txtNumOfGroups_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                // If not, cancel the key press
                e.Handled = true;
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                // If not, cancel the key press
                e.Handled = true;
            }
        }
        private void RandomProcess()
        {


            Random random = new Random();

            //int numOfGrps = Convert.ToInt32(txtNumOfGroups.Text);
            int numPerGrp = Convert.ToInt32(txtNumOfMembers.Text);
            int numOfMembers = listBoxName.Items.Count ;
            int randomNum = random.Next(0, numOfMembers);

            int count = 0;
            int grp = 1;
            while (count != numOfMembers)
            {
                if (!randomNames.Contains(listBoxName.Items[randomNum]))
                {
                                     
                    if (count == 0 || (count + 1) % numPerGrp == 0)
                    {
                        string groupNum = grp.ToString() + ": ";
                        randomNames.Add("Group :" + groupNum);
                        //randomNames.Add(" ");
                        grp++;
                    }

                    randomNames.Add(listBoxName.Items[randomNum].ToString());
                    count++;

                }
                randomNum = random.Next(0, numOfMembers);
            }

        }
    }
}
