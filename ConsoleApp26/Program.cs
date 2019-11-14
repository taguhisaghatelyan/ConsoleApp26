





using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixOperations
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter matrix row and column");
            Matrix matrix = new Matrix();
            matrix.MatrixDemos();
            //matrix.Addition();
            matrix.Multiplication();
            //matrix.ScalarMultiplication();
            matrix.Inverse();//Ինվերսը շատ վատ է ստացվել((
            //matrix.Transpose();
            //matrix.MIsOrtogonal();
            //matrix.SmallestElement();
            //matrix.LargestElement();
        }
    }
}