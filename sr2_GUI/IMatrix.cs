using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sr2_GUI
{
    interface IMatrix
    {
        public int row_count { get; }
        public int column_count { get; }
        public double GetValue(int i, int j);                          //отдает значение матрицы
        public void SetValue(double chisl, int i, int j);                 //записывает значение

        public void Draw(bool answer, IDrawing drawer);
    }
}
