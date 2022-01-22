using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProgEng_Lab04
{
    public partial class SelectForm : Form
    {
        public MainForm main;
        public SelectForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConfirmTask_Click(object sender, EventArgs e)
        {

            main.sumTaskRB = sumTask.Checked;
            main.eqTaskRB = eqTask.Checked;
            if(sumTask.Checked) main.taskString = sumTask.Text;
            if(eqTask.Checked) main.taskString = eqTask.Text;
            Close();
        }

        private void SelectForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            main.menuItemSelectTask.Enabled = true;
        }
    }
}
