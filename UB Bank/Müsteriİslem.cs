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
    public partial class MusteriForm : Form
    {
        public MusteriForm()
        {
            InitializeComponent();
        }

        private void hesapNumGirisBtn_TextChanged(object sender, EventArgs e)
        {

        }

        private void hesapNumGrBtn_Click(object sender, EventArgs e)
        {
            Musteriİslem mi = new Musteriİslem();
            mi.Show();
        }
    }
}
