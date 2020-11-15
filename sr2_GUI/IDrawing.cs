using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sr2_GUI
{
    interface IDrawing
    {
        public void DrawBorder(IMatrix matr); //для отрисовки рамки
        public void DrawUnit(IMatrix matr, int x, int y); //для отрисовки одной ячейки
        public void Print();


        public void NewLine();

    }
}
