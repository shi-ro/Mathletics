﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathletics
{
    public class ProblemFunctionInstance
    {
        public string problem;
        public string result;
        public ProblemFunctionInstance(string problem, string result)
        {
            this.problem = problem;
            this.result = result;
        }
    }
}
