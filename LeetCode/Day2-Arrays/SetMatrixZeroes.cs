using System;
using System.Collections;
namespace LeetCode.Arrays
{
    public class SetMatrixZeroes
    {
        public int m;
        public int n;
        public string[,] matrix;
        public void getInputAndSetValues()
        {
            Console.WriteLine("Enter m & n");
            m = Convert.ToInt32(Console.ReadLine());
            n = Convert.ToInt32(Console.ReadLine());
            matrix = new string[m,n];
            Console.WriteLine("Enter your m x n matrix");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    var value = Console.ReadLine();
                    if (value.Equals("0"))
                    {
                        setZeroValues(i, j);
                    }
                    if(matrix[i, j]!= "0")
                        matrix[i,j]=value;
                }
            }
            printMatrix();
        }

        private void setZeroValues(int i, int j)
        {
            for (int index = 0; index < m; index++)
            {
                matrix[index, i] = "0";
            }

            for (int index = 0; index < n; index++)
            {
                matrix[j, index] = "0";
            }
        }

        private void printMatrix()
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}