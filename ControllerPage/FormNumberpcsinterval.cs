using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControllerPage
{
    public partial class FormNumberpcsinterval : Form
    {
        public FormNumberpcsinterval()
        {
            InitializeComponent();
        }
        public string Pcsselection;

        private void Numberpcsinterval_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] val = { "0", "0", "0" };
            val[0] = numericUpDown2.Value.ToString();
            val[1] = numericUpDown1.Value.ToString();
            val[2] = numericUpDown3.Value.ToString();
            this.Pcsselection = string.Join("",val);
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
