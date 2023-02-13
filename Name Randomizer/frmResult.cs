using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Name_Randomizer
{
    public partial class frmResult : Form
    {
        public frmResult()
        {
            InitializeComponent();
        }

        private void frmResult_Load(object sender, EventArgs e)
        {
            LoadResult();
        }
        private void LoadResult()
        {
            
            Form1 form1 = new Form1();
            //MessageBox.Show(Form1.CWTS.ToString());
            
            if (listBoxResult.Items.Count != 0)
            {
                foreach(string str in listBoxResult.Items)
                {
                    listBoxResult.Items.Remove(str);
                }
            }
            
            if (Form1.CWTS)
            {
                foreach (var names in form1.combineCwts)
                {
                    listBoxResult.Items.Add(names);
                }
            }
            else
            {
            
                foreach (var names in form1.randomList)
                {
                    listBoxResult.Items.Add(names);
                }

             
            }
           
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("list.txt"))
            {
                foreach (string str in  listBoxResult.Items)
                {
                    writer.WriteLine(str);
                }
                MessageBox.Show("Names exported successfully!");
            }
        }
    }
}
