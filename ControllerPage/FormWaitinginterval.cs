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
    public partial class FormWaitinginterval : Form
    {
        public FormWaitinginterval()
        {
            InitializeComponent();
        }
        public decimal WaitingIntervalselection { get; set; }
        private void button1_Click(object sender, EventArgs e)
        {
            this.WaitingIntervalselection = numericUpDown2.Value;
            this.DialogResult = DialogResult.OK;
            this.Close();

        }
    }
}
