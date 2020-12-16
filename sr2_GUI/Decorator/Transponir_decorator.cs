using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sr2_GUI
{
    class Transponir_decorator : IMatrix //еще в процессе разработки
    {
        private int row, col;
        public int row_count { get { return row; } }
        public int column_count { get { return col; } }

        private List<IMatrix> list;
        private IMatrix Ref_matr;

        public Transponir_decorator(HorizontalGroupOfMatrix matr)
        {
            this.list = matr.CopyList();
            this.Ref_matr = matr;
            row = 0;
            col = 0;
            foreach (IMatrix matrix in list)
            {
                if (matrix.column_count >= col)
                {
                    col = matrix.column_count;
                }
                row = row + matrix.row_count;
            }
        }

        public void Draw(IDrawing drawer)
        {
            drawer.DrawBorder(this);
            foreach (IMatrix matrix in list)
            {
                
                for (int i = 0; i < matrix.row_count; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        drawer.DrawUnit(matrix, i, j);
                    }
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

       
    } 
}
