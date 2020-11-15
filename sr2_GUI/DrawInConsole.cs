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
        static string SimpleElementTemplate = "{0, -4:00}";

        private List<string> bufer;
        private string buf_el;
        private string border;

        public DrawInConsole()
        {
            bufer = new List<string>();
            buf_el = "";
            border = "";
        }

        public void DrawBorder(IMatrix matr)
        {
            int border_len = matr.column_count * 8;
            while (border_len-- != 0)
            {
                border += "-";
            }
            border += "\n";
        }

        public void NewLine()
        {
             bufer.Add("\n");
        }


        public void DrawUnit(IMatrix matr, int x, int y)
        {
            buf_el = "";
            switch (matr)
            {
                case SimpleMatrix:
                    {
                        buf_el += String.Format(SimpleElementTemplate, matr.GetValue(x, y));
                        break;
                    }

                case SparseMatrix:
                    {
                        if (matr.GetValue(x, y) == 0)
                        {
                            buf_el += "    ";
                        }
                        else
                        {
                            buf_el += String.Format(SimpleElementTemplate, matr.GetValue(x, y));
                        }
                        break;
                    }


                default:
                    buf_el += String.Format(SimpleElementTemplate, matr.GetValue(x, y));
                    break;
        
            }

            bufer.Add(buf_el);
            bufer[bufer.LastIndexOf(buf_el)] = String.Format("| {0} |", buf_el);
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
