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
    public partial class Form1 : Form
    {
        Random rnd;
        PassHelp Ph;
        Form2 f = new Form2();

        public Form1()
        {
            InitializeComponent();
            cblPass.SetItemChecked(1, true);
            rnd = new Random();
            Ph = new PassHelp();
        }

        private void GenPass_Click(object sender, EventArgs e)
        {
            NewPass.Text = "";
            Ph.Pass = "";
            if (cblPass.CheckedItems.Count == 0) return;
            
            for (int i = 0; i < passLength.Value; i++)
            {
                int n = rnd.Next(0, cblPass.CheckedItems.Count);
                string s = cblPass.CheckedItems[n].ToString();
                switch (s)
                {
                    case "Цифры":
                        Ph.Pass += rnd.Next(10).ToString();
                        break;
                    case "Прописные буквы":
                        Ph.Pass += Convert.ToChar(rnd.Next(65, 88));
                        break;
                    case "Строчные буквы":
                        Ph.Pass += Convert.ToChar(rnd.Next(97, 122));
                        break;
                    default:
                        MessageBox.Show("Какая-то ошибка ;)");
                        break;
                }
            }
            NewPass.Text = Ph.Pass;
        }

        private void btnCopyPass_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(NewPass.Text);
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void войтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f.ShowDialog();
        }
    }
}
