using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sr2_GUI
{
    class SimpleStrategy : IStrategy
    {
        public string DrawConcreteUnit(IMatrix matr, int x, int y)
        {
            string data_unit = string.Format("{0,4:00}", matr.GetValue(x, y));
            return data_unit;
        }
    }
}
