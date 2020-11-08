﻿using System;
using System.Collections.Generic;
using System.Text;

namespace sr1_VectorWork
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
