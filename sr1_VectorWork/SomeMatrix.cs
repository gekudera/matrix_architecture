using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace sr1_VectorWork
{
    abstract class SomeMatrix : IMatrix
    {
        private int row, col;
        private IVector[] matr;

        public SomeMatrix(int r, int c)
        {
            matr = new IVector[r];
            this.row = r;
            this.col = c;
            for (int i = 0; i < r; i++)
            {
                matr[i] = Create(c);
            }
        }

        protected abstract IVector Create(int co);
      
        public int row_count { get { return row; } }
        public int column_count { get { return col; } }

        public void SetValue(double chisl, int i, int j)
        {
            matr[i].SetValue(j, chisl);
        }

        public double GetValue(int i, int j)
        {
            return (matr[i].GetValue(j));
        }

        public void Print()
        {
            Console.WriteLine("______________________");
            foreach (var item in matr)
            {
                Console.Write("|");
                for (int i=0; i<item.Size; i++)
                {
                    Console.Write("{0,2:00}  ", item.GetValue(i));
                    
                }
                Console.Write("|\n");
            }
            Console.WriteLine("______________________");
        }
    }
}
