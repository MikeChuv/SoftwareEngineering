using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgEng_Lab04
{
    public partial class MainForm : Form
    {
        public int[,] matrix;
        public int nRows, nColls;
        public bool sumTaskRB, eqTaskRB;
        public string taskString;
        public MainForm()
        {
            InitializeComponent();
            sumTaskRB = true;
            eqTaskRB = false;
            nRows = nColls = 2;
            taskString = "Задание";
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectForm selectForm;
            selectForm = new SelectForm();
            selectForm.sumTask.Checked = sumTaskRB;
            selectForm.eqTask.Checked = eqTaskRB;
            selectForm.main = this;
            menuItemSelectTask.Enabled = false;
            selectForm.Show();
        }

        private void menuItemWork_Click(object sender, EventArgs e)
        {
            WorkForm workForm;
            workForm = new WorkForm();
            workForm.GV1.RowCount = nRows;
            workForm.GV1.ColumnCount = nColls;
            workForm.lTaskText.Text = taskString;
            workForm.main = this;
            menuItemWork.Enabled = false;
            workForm.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 ab;
            ab = new AboutBox1();
            //ab.Show();
            ab.ShowDialog(); // модальное
        }
    }
}
