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
        Regex basicTest = new Regex(@"-?(?:\d+(?:\.\d+)?)[+\-/*%](?:(?:\d+(\.\d+)?)[+\-/*%])*(?:\d+(?:\.\d+)?)", RegexOptions.Compiled);

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
            Console.WriteLine("\n\t\t\t[ GENERATING PROBLEM AND SOLUTION ]\n");
            string ans = Wolf.GetSolution(repl);
            Console.WriteLine($"[DBG]     : {ans}\n");
            return new ProblemFunctionInstance(repl, ans);
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
