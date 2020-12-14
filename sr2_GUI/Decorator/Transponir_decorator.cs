using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sr2_GUI.Decorator
{
    class Transponir_decorator : IMatrix //еще в процессе разработки
    {

        public int row_count => Ref_matr.row_count;
        public int column_count => Ref_matr.column_count;


        public IMatrix Ref_matr;
        private List<IMatrix> list;
        private int[] rows;
        private int[] columns;

        public Transponir_decorator(IMatrix matr)
        {
            this.Ref_matr = matr;
            
            rows = new int[Ref_matr.row_count];
            for (int i = 0; i < Ref_matr.row_count; i++)
            {
                rows[i] = i;
            }

            columns = new int[Ref_matr.column_count];
            for (int j = 0; j < Ref_matr.column_count; j++)
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
            return Ref_matr.GetStrategy();
        }

        public void Transpon() 
        {
            for (int i=0; i<column_count; i++)
            {


            }
        }

       
    } 

}
