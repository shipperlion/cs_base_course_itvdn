using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMyMatrix
{
    class MyMatrix
    {
        int[,] matrix;

        void InitializeMatrix()
        {
            Console.Write("Enter the number of elements: ");
            int size = Convert.ToInt32(Console.ReadLine());
            matrix = new int[size, size];
        }

        public MyMatrix()
        {
            InitializeMatrix();
            Random rnd = new Random();
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(0); j++)
                {
                    matrix[i, j] = rnd.Next(0, 50);
                }
            }
        }

        public MyMatrix(int size)
        {
            matrix = new int[size, size];
            Random rnd = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    matrix[i, j] = rnd.Next(0, 50);
                }
            }
        }

        public void Print()
        {
            for(int i = 0; i < matrix.GetLength(0);i++)
            {
                for(int j = 0; j < matrix.GetLength(0); j++)
                {
                    Console.Write("{0} ", matrix[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public void PrintDerivative()
        {
            int matrixRank = matrix.GetLength(0) - 1;
            for (int k = 0; k < matrix.GetLength(0); k++)
            {
                for (int i = 0; i < matrixRank; i++)
                {
                    for (int j = 0; j < matrixRank; j++)
                    {
                        Console.Write("{0} ", matrix[i, j]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                matrixRank--;
            }
        }

        public void IncreaseRank()
        {
            MyMatrix newMatrix = new MyMatrix(matrix.GetLength(0) + 1);
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(0); j++)
                {
                    newMatrix.matrix[i, j] = matrix[i, j];
                }
            }
            matrix = newMatrix.matrix;
        }

        public void DecreaseRank()
        {
            if (matrix.GetLength(0) == 1)
            {
                Console.WriteLine("Cannot decrease rank");
            }
            else
            {
                MyMatrix newMatrix = new MyMatrix(matrix.GetLength(0) - 1);
                for (int i = 0; i < newMatrix.matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < newMatrix.matrix.GetLength(0); j++)
                    {
                        newMatrix.matrix[i, j] = matrix[i, j];
                    }
                }
                matrix = newMatrix.matrix;
            }
        }
    }
}
