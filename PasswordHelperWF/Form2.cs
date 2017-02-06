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
    public partial class Form2 : Form

    {
        Form3 F3 = new Form3();
        PassHelp Ph = new PassHelp();
        
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string Login = tBLogin.Text;
            string Pass = tBPass.Text;

            if (Login == "123")
            {
                if (Pass == "123")
                {
                    F3.Show();
                }
            }
        }
    }
}
