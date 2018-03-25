using SoftDev_2018_Mathletics;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Mathletics
{
    public static class Storage
    {
        public static Dictionary<string, StudentAccount> accounts = new Dictionary<string, StudentAccount>();
        public static Dictionary<string, ProblemSet> problemDatabase = new Dictionary<string, ProblemSet>();
        public static readonly string PTHACC = Directory.GetCurrentDirectory() + @"\Accounts.dat";
        public static readonly string PTHPRB = Directory.GetCurrentDirectory() + @"\Problems.dat";
        public static string allText;
        public static SimpleFileIO ACCIO = new SimpleFileIO(PTHACC);
        public static SimpleFileIO PRBIO = new SimpleFileIO(PTHPRB);
        public static StudentAccount currentUser;
        public static void WriteAccounts()
        {
            //string cr = ACCIO.Read();
            //string nm = LoginPage.name;
            //string nt = $"{cr}\n{nm}:0:";
            //ACCIO.Write(nt);
            string w = "";
            foreach(string s in accounts.Keys)
            {
                w += $"{accounts[s].name}:{accounts[s].score}:\n";
            }
            Console.WriteLine($">{w}>");
            ACCIO.Write(w);
        }
        public static void WriteProblems()
        {
            string w = "";
            foreach (var item in Storage.problemDatabase)
            {
                //                  name             score                    example                    image                      form                          function                                               max                                               min
                w+= item.Key + ":" + item.Value.score + ":" + item.Value.example + ":" + item.Value.picture + ":" + item.Value.buttonName.problemFunction.function + ":" + item.Value.buttonName.problemFunction.max + ":" + item.Value.buttonName.problemFunction.min + "\n";
            }
            PRBIO.Write(w);
        }
        private static void ReadAccounts()
        {
            string cr = ACCIO.Read();
            string[] ln = cr.Split('\n');
            foreach (string l in ln)
            {
                if (l.Length < 2) { continue; }
                string[] ac = l.Split(':');
                string name = ac[0];
                StudentAccount ns = new StudentAccount(name);
                ns.score = Int32.Parse(ac[1]);
                List<ProblemSet> ps = new List<ProblemSet>();
                ns.updateList(ps);
                accounts.Add(ac[0], ns);
            }
        }
        private static void ReadProblems()
        {
            string cr = PRBIO.Read();
            string[] ln = cr.Split('\n');
            foreach (string l in ln)
            {
                if (l.Length < 2) { continue; }
                string[] r = l.Split(':');
                Console.WriteLine(l);

                ProblemSet newProblemSet = new ProblemSet(r[0], _p(r[1]), r[2], null, new BasicMultiplication(new ProblemFunction(r[3], _p(r[4]), _p(r[5])),_p(r[1]),_p(r[1])));
                problemDatabase.Add(r[0], newProblemSet);
            }
        }
        public static void TryReadProblems()
        {
            try
            {
                ReadProblems();
            } catch (Exception e)
            {
                Console.WriteLine($":[NEW] |PRB| {e}");
                using (FileStream fs = File.Create(PTHPRB)) { }
            }
        }
        public static void TryReadAccounts()
        {
            try
            {
                ReadAccounts();
            } catch (Exception e)
            {
                Console.WriteLine($":[NEW] |ACC| {e}");
                using (FileStream fs = File.Create(PTHACC)) { }
            }
        }
        private static int _p(string n)
        {
            return Int32.Parse(n);
        }

        public static List<ProblemSet> ToProblemSets(this string str)
        {
            List<ProblemSet> r = new List<ProblemSet>();
            string[] pr = str.Split('~');
            foreach(string p in pr)
            {
                r.Add(problemDatabase[p]);
            }
            return r;
        }

        public static string ToFileString(this List<ProblemSet> list)
        {
            string r = "";
            for (int i = 0; i < list.Count; i++)
            {
                r += list[i].problemSetName;
                if (i < list.Count) { r += "~"; }
            }
            return r;
        }
        
        public static StudentAccount getAccount(string name)
        {
            return accounts[name];
        }

        public static void addStudentAccount(string name)
        {
            StudentAccount newAccount = new StudentAccount(name);
            accounts.Add(name, newAccount);
        }
    }
}
