﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenricProblems
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    namespace GenericProblem
    {
        internal class TestClass21
        {
            public float floatCompare(float first, float second, float third)
            {
                if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
                {
                    return first;
                }
                if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
                {
                    return second;
                }
                if (third.CompareTo(first) > 0 && third.CompareTo(second) > 0)
                {
                    return third;
                }
                return 0;
            }
        }
    }

}
