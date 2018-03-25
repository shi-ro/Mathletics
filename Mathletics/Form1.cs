using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoftDev_2018_Mathletics;

namespace Mathletics
{
    public partial class Form1 : Form
    {
        Boolean ifOpen;
        Form toOpen;
        List<ProblemSet> problems;
        Dictionary<string, StudentAccount> dictionary { get; set; }
        public Form1()
        {
            InitializeComponent();
            ifOpen = false;

            //test load problemsets
            problems = new List<ProblemSet>();
            
            dictionary = new Dictionary<string, StudentAccount>();

            //ProblemSet basicMultiplication = new ProblemSet("Basic Multiplication", 5, "2 x 2 = 4", null, new BasicMultiplication(new ProblemFunction("_+_", 10, 1)));
            //problems.Add(basicMultiplication);
            //ProblemSet anotherExample = new ProblemSet("Example", 5, "sometihg", null, new BasicMultiplication(new ProblemFunction("(_*_)+_", 100,2)));
            //problems.Add(anotherExample);

            loadDefaultProblemSets();
            if(problems.Count>0)
            {
                loadProblemSet(problems[0]);
            }
            for (int i = 0; i < problems.Count(); i++)
            {
                addToListView(problems[i]);
            }
        }
        public void addProblemsToListView()
        {
            for (int i = 0; i < problems.Count(); i++)
            {
                addToListView(problems[i]);
            }
        }
        public void loadDefaultProblemSets()
        {
            createProblemset("Multiplication", 5, 10 , "5 * 6 = 30", null, "_*_", 9, 2);
            createProblemset("Division", 5, 10, "5 * 6 = 30", null, "_/_", 9, 2);
            createProblemset("Subtraction", 5, 10, "5 * 6 = 30", null, "_-_", 9, 2);
            createProblemset("Addition", 5, 10, "5 * 6 = 30", null, "_+_", 9, 2);
            createProblemset("Better Multiplication", 5, 10, "5 * 6 = 30", null, "_*_*_", 9, 2);
            createProblemset("Combined Division and Multiplication", 5, 10, "5 * 6 = 30", null, "_*_/_", 9, 2);
            createProblemset("Combined Division and Subtraction", 5, 10, "5 * 6 = 30", null, "_*_-_", 9, 2);
            createProblemset("Combined Multiplication and addition", 5, 10, "5 * 6 = 30", null, "_*_+_", 9, 2);
            //problems.Add(new ProblemSet("Simple Addition", 1, "1 + 1 = 2", null, new BasicMultiplication(new ProblemFunction("_+_", 5, 0), "Simple Addition")));
            //problems.Add(new ProblemSet("Simple Subtraction", 1, "2 - 1 = 1", null, new BasicMultiplication(new ProblemFunction("_-_", 10, 0), "Simple Subtraction")));
            //problems.Add(new ProblemSet("Intermediate Addition", 2, "9 + 8 = 17", null, new BasicMultiplication(new ProblemFunction("_+_", 10, 0))));
            //problems.Add(new ProblemSet("Intermediate Subtraction", 2, "20 - 15 = 5", null, new BasicMultiplication(new ProblemFunction("_-_", 20, 0))));
            //problems.Add(new ProblemSet("Simple Chained Addition", 3, "1 + 1 + 1 = 3", null, new BasicMultiplication(new ProblemFunction("_+_+_", 10, 1))));
            //problems.Add(new ProblemSet("Simple Chained Subtraction", 3, "1 - 1 - 2 = -2", null, new BasicMultiplication(new ProblemFunction("_-_-_", 10, 1))));
            //problems.Add(new ProblemSet("Simple Combined Addition and Subtraction", 3, "1 + 1 - 2 - 1 - 1 + 2 = 0", null, new BasicMultiplication(new ProblemFunction("_+_-_-_+_", 10, 1))));
        }

        public void createProblemset(string name, int points, int problem ,string example, PictureBox pic, string funct, int max, int min)
        {
            ProblemSet n = new ProblemSet(name, points, example, null, new BasicMultiplication(new ProblemFunction(funct, max, min), problem, points));
            problems.Add(n);
            Storage.problemDatabase.Add(name, n);
        }

        public static void setIfOpen(Boolean a)
        {
            //ifOpen = a;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Lst_Quests_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loadProblemSet(ProblemSet problemSet)
        {
            problem_name.Text = problemSet.problemSetName;
            problem_points.Text = "" + problemSet.score;
            problem_details.Text = problemSet.example;
            toOpen = problemSet.buttonName;
            problem_image = problemSet.picture;
        }

        private void addToListView(ProblemSet problemSet)
        {
            problem_list.Items.Add(problemSet.problemSetName);
        }

        private void problem_list_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (!(problem_list.SelectedIndex > problems.Count))
            {
                loadProblemSet(problems[problem_list.SelectedIndex]);
                toOpen = problems[problem_list.SelectedIndex].buttonName;
            }
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            toOpen.Show();
            toOpen.FormClosing += loadLeaderboard;
        }

        private void Form1_FormClosed(object sender, EventArgs e)
        {
            Console.WriteLine("Closing");
            Storage.WriteAccounts();
            Storage.WriteProblems();
        }

        public void manageLogin(string name)
        {
            if (!Storage.accounts.ContainsKey(name)) 
            {
                StudentAccount acca = new StudentAccount(name);
                Storage.accounts.Add(name, acca);
                Storage.currentUser = acca;
                Storage.WriteAccounts();
            } else
            {
                Storage.currentUser = Storage.accounts[name];
            }
            loginFinished();
        }

        public void loadLeaderboard(object sender, EventArgs e)
        {
            listView1.Clear();
            listView2.Clear();
            listView3.Clear();
            List<StudentAccount> ac = new List<StudentAccount>();
            foreach(string s in Storage.accounts.Keys)
            {
                ac.Add(Storage.accounts[s]);
            }
            ac.Sort((a, b) => { return a.score.CompareTo(b.score); });
            ac.Reverse();

            if (ac.Count >= 15)
            {
                for (int i = 0; i < 15; i++)
                {
                    if (i + 1 < 15 || ac[i].name == LoginPage.name)
                    {
                        listView1.Items.Add(ac[i].name);
                        listView2.Items.Add(i + 1 + "");
                        listView3.Items.Add(ac[i].score + "");
                    }
                }
            }
            else
            {
                for (int i = 0; i < ac.Count; i++)
                {
                    listView1.Items.Add(ac[i].name);
                    listView2.Items.Add(i+1 + "");
                    listView3.Items.Add(ac[i].score + "");
                }
            }
        }

        public void loadLeaderboard()
        {
            listView1.Clear();
            listView2.Clear();
            listView3.Clear();
            List<StudentAccount> ac = new List<StudentAccount>();
            foreach (string s in Storage.accounts.Keys)
            {
                ac.Add(Storage.accounts[s]);
            }
            ac.Sort((a, b) => { return a.score.CompareTo(b.score); });
            ac.Reverse();
            if (ac.Count >= 15)
            {
                for (int i = 0; i < 15; i++)
                {
                    listView1.Items.Add(ac[i].name);
                    listView2.Items.Add(i + 1 + "");
                    listView3.Items.Add(ac[i].score + "");
                }
            }
            else
            {
                for (int i = 0; i < ac.Count; i++)
                {
                    listView1.Items.Add(ac[i].name);
                    listView2.Items.Add(i + 1 + "");
                    listView3.Items.Add(ac[i].score + "");
                }
            }

        }

        public void loginFinished()
        {
            loadLeaderboard();
            //loadProblemsFromStorage();
            //addProblemsToListView();

            /*
            //load leaderboard
            
            scores.Add(5);
            scores.Add(3);
            scores.Add(7);
            names.Add("b");
            names.Add("c");
            names.Add("a");
            
            //Dictionary<string, int> studentData = new Dictionary<string, int>();
            List<int> scores = new List<int>(); //data right here guys
            List<string> names = new List<string>();
            List<StudentAccount> list = Storage.accounts.Values.ToList();
            foreach (var item in list) //fill the list with data
            {
                item.getScore();
                scores.Add(item.getScore());
                names.Add(item.name);
            }

            int largestNumber = 0;
            List<int> newScores = new List<int>();
            List<string> newNames = new List<string>();

            while (scores.Count > 0) //sort
            {
                for (int i = 0; i < scores.Count; i++)
                {
                    if (scores[i] > largestNumber)
                    {
                        newScores.Add(largestNumber);
                        scores.Remove(i);

                        newNames.Add(names[i]);
                        names.Remove(names[i]);
                    }
                }
            }

            for (int i = 1; i <= scores.Count(); i++)
            {
                listView2.Items.Add(i + ".");           //rank
                listView1.Items.Add(newNames[i - 1] + "");      //name
                listView3.Items.Add(newScores[i - 1] + "");    //score
            }
            */
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Storage.readProblemSets();
            //Storage.readStudentAccounts();

            FormClosing += Form1_FormClosed;

            Storage.TryReadProblems();
            Storage.TryReadAccounts();

            LoginPage loginPage = new LoginPage(this);
            loginPage.Show();
        }
        private void loadProblemsFromStorage()
        {
            foreach(string s in Storage.problemDatabase.Keys)
            {
                problems.Add(Storage.problemDatabase[s]);
            }
        }
        private void LdrbrdTab_Click(object sender, EventArgs e)
        {

        }

        private void ChangedColor1()
        {

        }
        private void ChangedColor2()
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            ChangedColor1();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            ChangedColor1();
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            ChangedColor1();
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            ChangedColor2();
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            ChangedColor2();
        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            ChangedColor2();
        }
    }
}
