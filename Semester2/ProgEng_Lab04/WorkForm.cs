using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProgEng_Lab04
{
    public partial class WorkForm : Form
    {
        public MainForm main;
        public WorkForm()
        {
            InitializeComponent();
           
        }

        static void InitGV(DataGridView GV1, int [,] matr) {
            GV1.RowCount = matr.GetLength(0);
            GV1.ColumnCount = matr.GetLength(1);
            for (int i = 0; i < matr.GetLength(0); ++i)
            {
                for (int j = 0; j < matr.GetLength(1); ++j)
                    GV1.Rows[i].Cells[j].Value = matr[i, j];
            }
        }

        static int[,] Input(DataGridView GV1)
        {
            int[,] matrix = new int[GV1.RowCount, GV1.ColumnCount];
            for (int i = 0; i < matrix.GetLength(0); ++i)
            {
                for (int j = 0; j < matrix.GetLength(1); ++j)
                    matrix[i, j] = Convert.ToInt32(GV1.Rows[i].Cells[j].Value);
            }
            return matrix;
        }

        static Tuple<int, int> MaxDigSum(int[,] matr) {
            int max = int.MinValue;
            Tuple<int, int> res = Tuple.Create(-1, -1);
            for (int i = 0; i < matr.GetLength(0); ++i) {
                for (int j = 0; j < matr.GetLength(1); ++j) {
                    int n = Math.Abs(matr[i, j]);
                    int sum = 0;
                    while (n != 0)
                    {
                        sum += n % 10;
                        n /= 10;
                    }
                    if (sum > max && matr[i, j] > 0) {
                        max = sum;
                        res = Tuple.Create(i, j);
                    }
                }
            }
            return res;
        }

        static Tuple<int, int> FindFirstEq(int[,] matr, int n) { 
            Tuple<int, int> res = Tuple.Create(-1, -1);
            for (int i = 0; i < matr.GetLength(0); ++i) {
                for (int j = 0; j < matr.GetLength(1); ++j) {
                    if(matr[i, j] == n) {
                        res = Tuple.Create(i, j);
                        break;
                    }
                }
                if (res.Item1 != -1) break;
            }
            return res;
        }

        private void btnSetRowsColls_Click(object sender, EventArgs e)
        {
            int rows = Convert.ToInt32(eRows.Text);
            int colls = Convert.ToInt32(eColls.Text);
            GV1.RowCount = rows;
            GV1.ColumnCount = colls;
            main.nRows = rows;
            main.nColls = colls;
        }

        private void WorkForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            main.menuItemWork.Enabled = true;
        }

        private void btnGoSolve_Click(object sender, EventArgs e)
        {
            main.matrix = Input(GV1);
            if (main.sumTaskRB) {
                Tuple<int, int> idxs = MaxDigSum(main.matrix);
                lAnswer.Text = "Ответ: (" + idxs.Item1 + " : " + idxs.Item2 + ")";
            }
            if (main.eqTaskRB) {
                int n = Convert.ToInt32(eNumber.Text);
                Tuple<int, int> idxs = FindFirstEq(main.matrix, n);
                lAnswer.Text = "Ответ: (" + idxs.Item1 + " : " + idxs.Item2 + ")";
            }

        }

        private void WorkForm_Shown(object sender, EventArgs e)
        {
            if (main.matrix != null) {
                eRows.Text = Convert.ToString(main.matrix.GetLength(0));
                eColls.Text = Convert.ToString(main.matrix.GetLength(1));
                InitGV(GV1, main.matrix);
            }
        }
    }
}
