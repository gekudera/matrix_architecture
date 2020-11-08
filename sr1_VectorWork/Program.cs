using System;
using System.Collections.Specialized;

namespace sr1_VectorWork
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleMatrix a = new SimpleMatrix(5, 5);
            InitiatorMatrix.RandomMatr(a, 25, 100);
            Console.WriteLine("Simple Matrix: ");
            a.Print();
            StatisticMatrix simp = new StatisticMatrix(a);
            simp.StatPrint();
            SparseMatrix b = new SparseMatrix(5, 5);
            InitiatorMatrix.RandomMatr(b, 5, 100);
            Console.WriteLine("\nSparse matrix: ");
            b.Print();
            StatisticMatrix spars = new StatisticMatrix(b);
            spars.StatPrint();
        }
    }
}
