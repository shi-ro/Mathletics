using SoftDev_2018_Mathletics;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mathletics
{
    public class ProblemSet
    {
        public string problemSetName { get; set; }
        public int score { get; set; }
        public string example { get; set; }
        public PictureBox picture { get; set; }
        public Solver buttonName { get; set; }
        public int problems = 10;

        public static string path= Directory.GetCurrentDirectory() + @"\Problems.dat";
        
        public ProblemSet(string problemSetName, int scorePerQuestion, string example, PictureBox picture, Solver buttonName)
        {
            this.problemSetName = problemSetName;
            this.score = scorePerQuestion;
            this.example = example;
            this.picture = picture;
            this.buttonName = buttonName;
        }
    }
}
