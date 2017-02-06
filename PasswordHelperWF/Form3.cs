using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordHelperWF
{
    public partial class Form3 : Form
    {
        Form1 F1 = new Form1();
        Form2 F2 = new Form2();

        public Form3()
        {
            InitializeComponent();
            F1.Close();
            F2.Close();
        }

        public void FillingLVLogPass()
        {
            PassHelp PH = new PassHelp("sada", "seffff", "esfse");

            foreach (var item in PH.PHList)
            {
                LVSiteLogPass.Items.Add(item.Login, item.Pass);
            };
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
