using System;

namespace ProgEng_Lab01
{
    // Если  в  двумерном  массиве  A  номер  столбца  с  максимальной  суммой 
    // элементов совпадает  с номером  строки с  максимальной суммой
    // элементов,  определить сумму  найденных элементов  строки и  столбца, 
    // иначе вывести  номера найденных  строки и  столбца с  максимальными
    // суммами.
    class Program
    {

        static void Input(out float[,] matrix) {
            int rows, colls;
            Console.Write("Rows = ");
            rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("Colls = ");
            colls = Convert.ToInt32(Console.ReadLine());
            matrix = new float[rows, colls];
            // GetLength or GetUpperBound ??
            for (int i = 0; i < matrix.GetLength(0); ++i) {
                for (int j = 0; j < matrix.GetLength(1); ++j)
                    matrix[i, j] = Convert.ToSingle(Console.ReadLine());
            }
        }


        static void Output(float[,] matrix) {
            for (int i = 0; i < matrix.GetLength(0); ++i){
                for (int j = 0; j < matrix.GetLength(1); ++j)
                    Console.Write(matrix[i, j] + " ");
                Console.WriteLine();
            }
        }

        static int WithMaxSum(float[,] matrix, string key, out float maxSum) {
            maxSum = float.MinValue;
            int idxmax = 0;
            for (int i = 0; i < matrix.GetLength(key == "row" ? 0 : 1); ++i) {
                float sum = 0;
                for (int j = 0; j < matrix.GetLength(key == "col" ? 0 : 1); ++j) {
                    if(key == "row") sum += matrix[i, j];
                    if(key == "col") sum += matrix[j, i];
                    // sum += matrix[i, j];
                }
                if (sum > maxSum) {
                    idxmax = i;
                    maxSum = sum;
                }
            }
            return idxmax;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            float[,] matr;
            Input(out matr);
            Output(matr);
            float maxSumRows, maxSumColls;
            int idxMaxSumRows = WithMaxSum(matr, "row", out maxSumRows);
            int idxMaxSumColls = WithMaxSum(matr, "col", out maxSumColls);
            if (idxMaxSumRows == idxMaxSumColls)
            {
                Console.WriteLine("Max Sum in rows = " + maxSumRows);
                Console.WriteLine("Max Sum in colls = " + maxSumColls);
            }
            else {
                Console.WriteLine("Index of row with max sum = " + idxMaxSumRows);
                Console.WriteLine("Index of col with max sum = " + idxMaxSumColls);
            }
        }
    }
}
