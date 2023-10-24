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

        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void müşteriGirişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            MusteriGirisForm mf = new MusteriGirisForm();
            mf.Show();
        }

        private void bankaAdminGirişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            BankacıForm bf = new BankacıForm();
            bf.Show();
        }

        private void bilgiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
