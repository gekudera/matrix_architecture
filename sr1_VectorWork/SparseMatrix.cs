using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace sr1_VectorWork
{
    class SparseMatrix: SomeMatrix
    { 
        public SparseMatrix(int r, int c): base(r,c)
        {
            
        }

        protected override IVector Create(int co)
        {
            return new SparseVector(co);
        }
    }
}
