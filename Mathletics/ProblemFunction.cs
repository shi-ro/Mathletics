using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.JScript;

namespace Mathletics
{
    public class ProblemFunction
    {
        public string function;
        public int max;
        public int min;
        public int[] acceptedValues = null;
        Random rnd = new Random();
        Regex _trigRegex = new Regex(@"(cos|sin|tan|csc|sec|cot)\(((?:-)?\d+(?:.\d+)?)\)", RegexOptions.Compiled);
        Regex _absRegex = new Regex(@"\|((?:-)?\d+(?:.\d+)?)\|", RegexOptions.Compiled);
        private static Microsoft.JScript.Vsa.VsaEngine _engine = Microsoft.JScript.Vsa.VsaEngine.CreateEngine();
        public ProblemFunction(string function, int max, int min)
        {
            this.function = function;
            this.max = max;
            this.min = min;
        }
        public ProblemFunction(string function, int[] acceptedValues)
        {
            this.function = function;
            this.acceptedValues = acceptedValues;
        }
        
        public ProblemFunctionInstance getInstance()
        {
            string repl = "";
            foreach(char c in function)
            {
                if(c=='_')
                {
                    if(acceptedValues==null)
                    {
                        repl += rnd.Next(min, max);
                    } else
                    {
                        repl += acceptedValues[rnd.Next(0, acceptedValues.Length)];
                    }
                } else
                {
                    repl += c;
                }
            }
            //run multiple parsing layers
            string r = _trigRegex.Replace(repl, TrigParse);
            double ans = BasicParse(r).Round(3);
            return new ProblemFunctionInstance(repl, ans);
        }

        public string TrigParse(Match m)
        {
            string trgf = m.Groups[1].Value.ToLower();
            double val = Double.Parse(m.Groups[2].Value).ToRadian();
            switch (trgf)
            {
                case "tan":
                    return $"{Math.Tan(val)}";
                case "cos":
                    return $"{Math.Cos(val)}";
                case "sin":
                    return $"{Math.Sin(val)}";
                case "cot":
                    return $"{1 / Math.Tan(val)}";
                case "sec":
                    return $"{1 / Math.Cos(val)}";
                case "csc":
                    return $"{1 / Math.Sin(val)}";
                default:
                    return $"!";
            }
        }

        public double BasicParse(string exp)
        {
            DataTable table = new DataTable();
            table.Columns.Add("expression", typeof(string), exp);
            DataRow row = table.NewRow();
            table.Rows.Add(row);
            return double.Parse((string)row["expression"]);
        }

        //public string EJS(string exp)
        //{
        //    object Result = null;
        //    try
        //    {
        //        Result = Microsoft.JScript.Eval.JScriptEvaluate(exp, _engine);
        //    }
        //    catch (Exception ex)
        //    {
        //        return ex.Message;
        //    }

        //    return $"{Result}";
        //}

    }
}
