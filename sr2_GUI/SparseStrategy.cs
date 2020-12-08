using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sr2_GUI
{
    class SparseStrategy: IStrategy
    {
        public string DrawConcreteUnit(IMatrix matr, int x, int y)
        {
            string data_unit = "";
            if (matr.GetValue(x, y) == 0)
            {
                data_unit = "    ";
            }
            else
            {
                data_unit += String.Format("{0,3:00}", matr.GetValue(x, y));
            }
            return data_unit;
        }
    }
}
