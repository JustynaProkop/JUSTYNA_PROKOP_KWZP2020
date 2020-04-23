using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnClose.Enabled = false;
        }

        
private void btnClose_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(txtButtonLabel.Text);
            form2.Show();
        }

        private void chkButtonEnabled_CheckedChanged(object sender, EventArgs e)
        {
            btnClose.Enabled = chkButtonEnabled.Checked;
        }

        private void txtButtonLabel_TextChanged(object sender, EventArgs e)
        {
            if (txtButtonLabel.TextLength > 0)
            {
                btnClose.Text = txtButtonLabel.Text;
            }
            }
    }
    }

