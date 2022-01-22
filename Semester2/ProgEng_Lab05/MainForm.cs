using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgEng_Lab05
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

        private void taskWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TaskForm taskForm = new TaskForm();
            taskForm.sumTask.Checked = sumTaskRB;
            taskForm.eqTask.Checked = eqTaskRB;
            taskForm.main = this;
            taskForm.MdiParent = this;
            taskForm.Show();
        }

        private void workWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WorkForm workForm = new WorkForm();
            workForm.GV1.RowCount = nRows;
            workForm.GV1.ColumnCount = nColls;
            workForm.lTaskText.Text = taskString;
            workForm.main = this;
            workForm.MdiParent = this;
            workForm.Show();
        }

        private void tileHorizontallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVerticallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void closeCurrentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null) ActiveMdiChild.Close();
        }

        private void closeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = MdiChildren.Length - 1; i >= 0; --i) {
                MdiChildren[i].Close();
            }
        }
    }
}
