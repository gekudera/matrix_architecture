using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sr2_GUI
{
    class Transponir_decorator : IMatrix //еще в процессе разработки
    {

        public int row_count => Ref_matr.row_count;
        public int column_count => Ref_matr.column_count;

        private List<IMatrix> list;
        private IMatrix Ref_matr;

        public Transponir_decorator(HorizontalGroupOfMatrix matr)
        {
            this.list = matr.CopyList();
            this.Ref_matr = matr;
        }

        public void Draw(IDrawing drawer)
        {
            foreach (IMatrix matrix in list)
            {
                matrix.Draw(drawer);
            }
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
