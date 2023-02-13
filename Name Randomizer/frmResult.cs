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

            foreach(var names in form1.randomList)
            {
                listBoxResult.Items.Add(names);
            }
           
        }
    }
}
