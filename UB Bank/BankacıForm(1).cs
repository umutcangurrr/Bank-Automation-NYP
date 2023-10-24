using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UB_Bank
{
    public partial class BankacıForm : Form
    {
        public BankacıForm()
        {
            InitializeComponent();
        }

        private void bankacıSifreBtn_Click(object sender, EventArgs e)
        {
            Bankacıİslem bi = new Bankacıİslem();
            if (Convert.ToInt32(sifreKontrolTxt.Text) == 1234)
                bi.Show();
            else
                MessageBox.Show("Yanlış şifre girdiniz.");

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked )
            {
                sifreKontrolTxt.UseSystemPasswordChar = true;
            }

            else if (checkBox1.CheckState == CheckState.Unchecked) 
            {
                sifreKontrolTxt.UseSystemPasswordChar = false;
            }
        }
    }
}
