using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace sr2_GUI
{
    class Renumbering_decorator : IMatrix
    {
        public int row_count => Ref_matr.row_count;
        public int column_count => Ref_matr.column_count;


        public IMatrix Ref_matr;
        private int[] rows;
        private int[] columns;

        public Renumbering_decorator(IMatrix matr)
        {
            this.Ref_matr = matr;

            rows = new int[Ref_matr.row_count];
            for (int i=0; i<Ref_matr.row_count; i++)
            {
                rows[i] = i;
            }

            columns = new int[Ref_matr.column_count];
            for (int j=0; j<Ref_matr.column_count; j++)
            {
                columns[j] = j;
            }
        }

        public void Draw(IDrawing drawer)
        {
            drawer.DrawBorder(this.Ref_matr);

            for (int i = 0; i < row_count; i++)
            {
                for (int j = 0; j < column_count; j++)
                {
                    drawer.DrawUnit(this.Ref_matr, rows[i], columns[j]);
                }
            }
            drawer.Print();
        }

        public double GetValue(int i, int j)
        {
            return Ref_matr.GetValue(i, j);
        }

        public void SetValue(double chisl, int i, int j)
        {
            Ref_matr.SetValue(chisl, i, j);
        }

        public IStrategy GetStrategy()
        {
            return (new SimpleStrategy());
        }

        public void Renumber_сol(int first, int second) //поменять столбики местами
        {
            if ((first < Ref_matr.column_count) && (second < Ref_matr.column_count))
            {
                rows[first] = second;
                rows[second] = first;
            }
        }

        public void Renumber_row(int first, int second) //поменять строчки местами
        {
            if ((first < Ref_matr.row_count) && (second < Ref_matr.row_count))
            {
                columns[first] = second;
                columns[second] = first;
            }
        }

    }
}
