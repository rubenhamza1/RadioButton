using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void gbVrstaPrijevoza_Enter(object sender, EventArgs e)
        {

        }

        private void buttonRezerviraj_Click(object sender, EventArgs e)
        {
            if (rbAvion.Checked)
            {
                textBox1.Text = "Odabrali ste prijevoz avionom.";
            }
            if (rbAutobus.Checked)
            {
                textBox1.Text = "Odabrali ste prijevoz autobusem.";
            }
            if (rbVlastiti.Checked)
            {
                textBox1.Text = "Odabrali ste vlastiti prijevoz.";
            }
        }
    }
}
