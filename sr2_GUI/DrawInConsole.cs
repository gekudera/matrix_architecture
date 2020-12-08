using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace sr2_GUI
{
    class DrawInConsole : IDrawing
    {

        private List<string> bufer;
        private string buf_el;
        private string border;
        private bool is_border;
        private int count;
        private IStrategy strategy;

        public DrawInConsole(bool is_bord)
        {
            bufer = new List<string>();
            buf_el = "";
            border = "";
            is_border = is_bord;
        }

        public void DrawBorder(IMatrix matr)
        {
            if (is_border)
            {
                int border_len = matr.column_count * 8;
                while (border_len-- != 0)
                {
                    border += "-";
                }
                border += "\n";
            }
        }


        public void DrawUnit(IMatrix matr, int x, int y)
        {
            strategy = matr.GetStrategy();
            buf_el = strategy.DrawConcreteUnit(matr,x,y);

            bufer.Add(buf_el);
            bufer[bufer.LastIndexOf(buf_el)] = String.Format("| {0} |", buf_el);

            count++;
            if (count == matr.column_count)
            {
                bufer.Add("\n");
                count = 0;
            }

        }

        public void Print()
        {
            bufer.Insert(0, border); //если DrawBorder не вызывалось, то рамка не отрисуется, ведь border  -пустая
            bufer.Add(border);
            foreach (string item in bufer)
            {
                Console.Write(item);
            }
            bufer.Clear();
            buf_el = "";
            border = "";
        }
    }
}
