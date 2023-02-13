﻿using System;
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
            equallyNo.CheckState = CheckState.Checked;
            
        }
        private void DefaultButtonFormat()
        {
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnCancel.Enabled = false;
        }
        private static List<string> randomNames = new List<string>();
        private static bool alreadyRandom = false;
        public static bool CWTS = false;
        
        public List<string> randomList
        {
            get { return randomNames; }
            set { randomNames = value; }
        }


        private static List<string> combine = new List<string>();
        public List<string> combineCwts
        {
            get { return combine; }
            set { combine = value; }
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
            int selectedIndex = listBoxName.SelectedIndex;
            if (selectedIndex != -1)
            {
                listBoxName.Items.RemoveAt(selectedIndex);
            }

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
            if (equallyYes.CheckState == CheckState.Checked)
            {
                CwtsMode();
                CWTS = true;
                //MessageBox.Show(combineCwts[0]);
            }
            else if (equallyNo.CheckState == CheckState.Checked)
            {
                RandomProcess();
                CWTS = false;
            }
            frmResult formResult = new frmResult();
            formResult.ShowDialog();
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            for (int i = listBoxName.Items.Count - 1; i >= 0; i--)
            {
                listBoxName.Items.RemoveAt(i);
            }
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
            int numOfMembers = listBoxName.Items.Count;
            int randomNum = random.Next(0, numOfMembers);

            if (alreadyRandom == true)
            {
                for (int i = randomNames.Count - 1; i >= 0; i--)
                {
                    randomNames.RemoveAt(i);                  
                }
            }
           
            int count = 0;
            int grp = 1;
            while (count != numOfMembers)
            {
                if (!randomNames.Contains(listBoxName.Items[randomNum]))
                {

                    if (count == 0 || count % numPerGrp == 0)
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

            alreadyRandom = true;       

        }

        // edit this if you want to create your own function
        private void CwtsMode()
        {
            List<string> sixAM = new List<string>();
            List<string> memberDuties = new List<string>();
            
            Random random = new Random();
            int randomNum = random.Next(0, 48);


            
            if (combine.Count != 0)
            {
                for (int i = combine.Count - 1; i >= 0; i--)
                {
                    combine.RemoveAt(i);
                }
                foreach (string str in sixAM)
                {
                    sixAM.Remove(str);
                }

                foreach (string str in memberDuties)
                {
                    memberDuties.Remove(str);
                }

                
            }

            


            //in 6 am duties
            int counter1 = 0;
            while (counter1 != 10)
            {
                if (!sixAM.Contains(listBoxName.Items[randomNum]))
                {
                    sixAM.Add(listBoxName.Items[randomNum].ToString());
                    counter1++;
                }
                randomNum = random.Next(0, 48);
            }
            sixAM.Add(" ");


            
            //Group Assigned
            randomNum = random.Next(0, 48);
            int counter2 = 0;
            
            while (counter2 != 48)
            {
                if(!memberDuties.Contains(listBoxName.Items[randomNum]))
                {
                    memberDuties.Add(listBoxName.Items[randomNum].ToString());
                    counter2++;
                }
                randomNum = random.Next(0, 48);
            }
            

            // Combine

            combine.Add("6 AM DUTY");
            foreach (string officers in sixAM)
            {
                combine.Add(officers);
            }


            
            int grpNum = 1;
            combine.Add("Group Duty");
            foreach (string officers in memberDuties)
            {
                if (grpNum <= 45)
                {
                    combine.Add("Group: " + grpNum.ToString() + " " + officers);
                    grpNum++;
                }
                else
                {
                    if (grpNum == 46)
                    {
                        combine.Add(" ");
                        combine.Add("Gate");
                        grpNum++;
                    }
                    combine.Add(officers);
                }
            }

            



        }

        private void equallyYes_CheckedChanged(object sender, EventArgs e)
        {
            if (equallyYes.CheckState == CheckState.Checked)
            {
                equallyNo.CheckState = CheckState.Unchecked;
            }
            
        }

        private void equallyNo_CheckedChanged(object sender, EventArgs e)
        {
            if (equallyNo.CheckState == CheckState.Checked)
            {
                equallyYes.CheckState = CheckState.Unchecked;
            }
            
        }

        
    }
}
