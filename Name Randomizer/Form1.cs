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
            equallyYes.CheckState = CheckState.Checked;
            
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

        private static List<string> exceptionList = new List<string>();
        public List<string> exceptionNames
        {
            get { return exceptionList; }
            set { exceptionList = value; }
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
                if (!Int32.TryParse(txtNumOfMembers.Text, out int x))
                {
                    MessageBox.Show("Please input a value in number or members per group!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
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
            while (count < numOfMembers)
            {
                if (!randomNames.Contains(listBoxName.Items[randomNum]))
                {

                    if (count == 0 || count % numPerGrp == 0)
                    {
                        if (count > 0)
                        {
                            randomNames.Add(" ");
                        }
                        string groupNum = grp.ToString() + ": ";
                        randomNames.Add("Group :" + groupNum);
                        
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
            try
            {
                List<string> sixAM = new List<string>();
                List<string> memberDuties = new List<string>();

                int totalNumOfMembers = listBoxName.Items.Count;

                Random random = new Random();
                int randomNum = random.Next(0, totalNumOfMembers);


                // Checking if the list contains any name
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


                ExceptionFunction();

                // 6 am duties
                int counter1 = 0;


                //sixAM.Add("Monroy, Prince Andrei B.");
                while (counter1 < 10)
                {
                    if (!sixAM.Contains(listBoxName.Items[randomNum]) && !exceptionList.Contains(listBoxName.Items[randomNum]))
                        
                    {
                        sixAM.Add(listBoxName.Items[randomNum].ToString());
                        counter1++;
                    }
                    randomNum = random.Next(0, totalNumOfMembers);
                }
                sixAM.Add(" ");



                //Group Assigned
                randomNum = random.Next(0, totalNumOfMembers);
                int counter2 = 0;

                while (counter2 < totalNumOfMembers)
                {
                    if (!memberDuties.Contains(listBoxName.Items[randomNum]))
                    {
                        memberDuties.Add(listBoxName.Items[randomNum].ToString());
                        counter2++;
                    }
                    randomNum = random.Next(0, totalNumOfMembers);
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
            catch
            {
                MessageBox.Show("Total number of members does not exceed to the given criteria! Are you missing some members?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            



        }

        private void ExceptionFunction()
        {
            if (exceptionList.Count != 0)
            {
                for (int i = exceptionList.Count - 1; i >= 0; i--)
                {
                    exceptionList.RemoveAt(i);
                }
            }
            string[] names = txtException.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            foreach (string str in names)
            {
                exceptionList.Add(str);
            }
        }

        private void equallyYes_CheckedChanged(object sender, EventArgs e)
        {
            if (equallyYes.CheckState == CheckState.Checked)
            {
                equallyNo.CheckState = CheckState.Unchecked;
                txtNumOfMembers.Enabled = false;
                pnlException.Visible = true;
            }
            
        }

        private void equallyNo_CheckedChanged(object sender, EventArgs e)
        {
            if (equallyNo.CheckState == CheckState.Checked)
            {
                equallyYes.CheckState = CheckState.Unchecked;
                txtNumOfMembers.Enabled = true;
                pnlException.Visible = false;
            }
            
        }
    }
}
