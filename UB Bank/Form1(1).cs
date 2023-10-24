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
    public partial class girişForm : Form
    {
        public girişForm()
        {
            InitializeComponent();
        }

        private void musteriGirisBtn_Click(object sender, EventArgs e)
        {
            MusteriForm mf = new MusteriForm();
            mf.Show();
        }

        private void bankacıGirisBtn_Click(object sender, EventArgs e)
        {
            BankacıForm bf = new BankacıForm();
            bf.Show();
        }
    }
}
