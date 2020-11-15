using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sr2_GUI
{
    class SimpleMatrix: SomeMatrix
    {
        public SimpleMatrix(int r, int c) : base(r, c)
        {

        }

        protected override IVector Create(int co)
        {
            return new SimpleVector(co);
        }
    }
}
