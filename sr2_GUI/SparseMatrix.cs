using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sr2_GUI
{
    class SparseMatrix: SomeMatrix
    {
        public SparseMatrix(int r, int c) : base(r, c)
        {

        }

        protected override IVector Create(int co)
        {
            return new SparseVector(co);
        }
    }
}
