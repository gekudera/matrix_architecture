using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sr2_GUI
{
    interface IStrategy
    {
        string DrawConcreteUnit(IMatrix matr, int x, int y);
    }
}
