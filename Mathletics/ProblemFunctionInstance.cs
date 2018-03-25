using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathletics
{
    public class ProblemFunctionInstance
    {
        public string problem;
        public double result;
        public ProblemFunctionInstance(string problem, double result)
        {
            this.problem = problem;
            this.result = result;
        }
    }
}
