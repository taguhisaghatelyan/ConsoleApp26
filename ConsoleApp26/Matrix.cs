using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixOperations
{
    class Matrix
    {
        static int m = Convert.ToInt32(Console.ReadLine());
        static int n = Convert.ToInt32(Console.ReadLine());
        int[,] mat1 = new int[m, n];
        int[,] mat2 = new int[m, n];
        Random r = new Random();
        public void MatrixDemos()
        {
            Console.WriteLine("First Matrix`");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    mat1[i, j] = r.Next(9);
                    Console.Write(mat1[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Second Matrix`");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    mat2[i, j] = r.Next(9);
                    Console.Write(mat2[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        public void Addition()
        {
            Console.WriteLine("Addition of two matrix`");
            int[,] addMat = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    addMat[i, j] = mat1[i, j] + mat2[i, j];
                    if (addMat[i, j] > 9)
                    {
                        Console.Write(addMat[i, j] + " ");
                    }
                    else
                    {
                        Console.Write(addMat[i, j] + "  ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        public void Multiplication()
        {
            Console.WriteLine("Multiplication of two matrix`");
            int[,] multMat = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int sum = 0;
                    for (int k = 0; k < m; k++)
                    {
                        sum = sum + mat1[i, k] * mat2[k, j];
                    }
                    multMat[i, j] = sum;
                    if (multMat[i, j] > 9)
                    {
                        Console.Write(multMat[i, j] + " ");
                    }
                    else
                    {
                        Console.Write(multMat[i, j] + "  ");
                    }
                
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        
        }
        public void ScalarMultiplication()
        {
            Console.Write("Enter scalar number  ");
            int k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Scalar Multiplication of first matrix`");
            int[,] scMalt = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    scMalt[i, j] = k * mat1[i, j];
                    if (scMalt[i, j] > 9)
                    {
                        Console.Write(scMalt[i, j] + " ");
                    }
                    else
                    {
                        Console.Write(scMalt[i, j] + "  ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        public void Inverse()
        {
            Console.WriteLine("Our new 3x3 matrix for inversing");
            double det = 0;
            double[,] inv = new double[3, 3];
            Random r = new Random();
            for (int i=0;i<3;i++)
            {
                for(int j=0;j<3;j++)
                {

                    inv[i, j] = r.Next(10);
                    Console.Write(inv[i,j]+" ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < 3; i++)
                det = det + (inv[0, i] * (inv[1, (i + 1) % 3] * inv[2, (i + 2) % 3] - inv[1, (i + 2) % 3] * inv[2, (i + 1) % 3]));
            Console.WriteLine("Transpose of 3x3  matrix(for inversing)`");
            double[,] trans = new double[3,3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    trans[j, i] = inv[i, j];
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if ((i+j)%2 ==0)
                    {
                        Console.Write(trans[i, j] + " ");
                    }
                    else
                    {
                        Console.Write((-1)*trans[i, j] + "  ");
                    }
                }
                Console.WriteLine();
            }
            double[,] inverse = new double[3, 3];
            if (det != 0)
            {
                Console.WriteLine("This is our 3x3 Inverse");
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        inverse[i, j] = trans[i,j]/det;
                        Console.Write(inverse[i,j]+" ");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("This matrix doesn't have inverse");
            }
        }
        public void Transpose()
        {
            Console.WriteLine("Transpose of  first matrix`");
            int[,] trans = new int[n, m];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    trans[j, i] = mat1[i, j];
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (trans[i, j] > 9)
                    {
                        Console.Write(trans[i, j] + " ");
                    }
                    else
                    {
                        Console.Write(trans[i, j] + "  ");
                    }
                }
                Console.WriteLine();
            }
           
            

            
        }
        public void MIsOrtogonal()
        {
            Console.WriteLine("Our new mxn matrix `");

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    mat2[i, j] = r.Next(9);
                    Console.Write(mat2[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Transpose of new matrix");
            //int[,] mult = new int[m, m];
            int[,] trans = new int[n, m];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    trans[j, i] = mat2[i, j];
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (trans[i, j] > 9)
                    {
                        Console.Write(trans[i, j] + " ");
                    }
                    else
                    {
                        Console.Write(trans[i, j] + "  ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Multiplication of new matrix and its transpose A*A-1`");

            int[,] isOrt = new int[m, m];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    int sum = 0;
                    for (int k = 0; k < m; k++)
                    {
                        sum = sum + mat2[i, k] * trans[k, j];
                    }
                    isOrt[i, j] = sum;
                    Console.Write(isOrt[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("This is identity matrix");
            int[,] identity = new int[m, m];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (i == j)
                    {
                        identity[i, j] = 1;
                    }
                    else
                    {
                        identity[i, j] = 0;
                    }
                    Console.Write(identity[i, j] + " ");
                }
                Console.WriteLine();
            }
            //int[,] sample = { { 1, 0, 0 },{ 0,1,0},{ 0,0,1} }; // for this ex. enter 3x3 matrix (m=3,n=3) (1)
            bool comp = true;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    //if(sample[i,j]==identity[i,j])
                    if (isOrt[i, j] == identity[i, j])
                    {
                        comp = true;
                    }

                    else
                    {
                        comp = false;
                    }
                }
            }
            if (comp)
            {
                Console.WriteLine("New Matrix is orthogonal");
            }
            else
            {
                Console.WriteLine("New matrix does not orthogonal");
            }
        }
        public void SmallestElement()
        {
            Console.WriteLine("Smallest element of first matrix");
            //int min = int.MaxValue;
            int min = mat1[0, 0];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat1[i, j] < min)
                        min = mat1[i, j];
                }
            }
            Console.WriteLine(min);
        }
        public void LargestElement()
        {
            Console.WriteLine("Largest element of first matrix");
            //int min = int.MinValue;
            int max = mat1[0, 0];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat1[i, j] > max)
                        max = mat1[i, j];
                }
            }
            Console.WriteLine(max);
        }
    }
}

            
        






    




