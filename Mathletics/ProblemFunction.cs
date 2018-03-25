using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathletics
{
    public class ProblemFunction
    {
        public string function;
        public int max;
        public int min;
        Random rnd = new Random();
        public ProblemFunction(string function, int max, int min)
        {
            this.function = function;
            this.max = max;
            this.min = min;
        }
        
        public ProblemFunctionInstance getInstance()
        {
            string repl = "";
            foreach(char c in function)
            {
                if(c=='_')
                {
                    repl += rnd.Next(min, max);
                } else
                {
                    repl += c;
                }
            }
            double ans = Parse(repl);
            return new ProblemFunctionInstance(repl, ans);
        } 

        public double Parse(string expression)
        {
            DataTable table = new DataTable();
            table.Columns.Add("expression", typeof(string), expression);
            DataRow row = table.NewRow();
            table.Rows.Add(row);
            return double.Parse((string)row["expression"]);
        }

    }
}
