using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgEng_Lab03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        static float[,] Input(DataGridView GV1)
        {
            float[,] matrix = new float[GV1.RowCount, GV1.ColumnCount];
            for (int i = 0; i < matrix.GetLength(0); ++i)
            {
                for (int j = 0; j < matrix.GetLength(1); ++j)
                    matrix[i, j] = Convert.ToSingle(GV1.Rows[i].Cells[j].Value);
            }
            return matrix;
        }



        static int WithMaxSum(float[,] matrix, string key, out float maxSum)
        {
            maxSum = float.MinValue;
            int idxmax = 0;
            for (int i = 0; i < matrix.GetLength(key == "row" ? 0 : 1); ++i)
            {
                float sum = 0;
                for (int j = 0; j < matrix.GetLength(key == "col" ? 0 : 1); ++j)
                {
                    if (key == "row") sum += matrix[i, j];
                    if (key == "col") sum += matrix[j, i];
                    // sum += matrix[i, j];
                }
                if (sum > maxSum)
                {
                    idxmax = i;
                    maxSum = sum;
                }
            }
            return idxmax;
        }

        private void btnSetRowsColls_Click(object sender, EventArgs e)
        {
            // int.Parse
            // if(int.TryParse(textBox1.Text,out value))
            int rows = Convert.ToInt32(eRows.Text);
            int colls = Convert.ToInt32(eColls.Text);
            GV1.RowCount = rows;
            GV1.ColumnCount = colls;
        }

        private void btnGoSolve_Click(object sender, EventArgs e)
        {
            float[,] matr = Input(GV1);
            float maxSumRows, maxSumColls;
            int idxMaxSumRows = WithMaxSum(matr, "row", out maxSumRows);
            int idxMaxSumColls = WithMaxSum(matr, "col", out maxSumColls);
            if (idxMaxSumRows == idxMaxSumColls)
            {
                lOutput.Text = "Max Sum in rows = " + maxSumRows;
                lOutput.Text = "Max Sum in colls = " + maxSumColls;
            }
            else
            {
                lOutput.Text = "Index of row with max sum = " + idxMaxSumRows;
                lOutput.Text = "Index of col with max sum = " + idxMaxSumColls;
            }

        }
    }
}
