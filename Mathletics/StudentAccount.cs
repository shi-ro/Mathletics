using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Mathletics
{
    public class StudentAccount
    {
        public string path = Directory.GetCurrentDirectory() + @"\Accounts.dat";
        public string name;
        public int score;
        public List<ProblemSet> completedSets;
        public StudentAccount(String name)
        {
            this.name = name;
            this.score = 0;
            completedSets = new List<ProblemSet>();
        }
        
        public void setScore(int toSet){score = toSet;}

        public void updateList(List<ProblemSet> list){completedSets = list;}

        public void addScore(int toAdd){score += toAdd;}

        public int getScore(){return score;}

        public void addCompletedSet(ProblemSet completed){completedSets.Add(completed);}
    }
}
