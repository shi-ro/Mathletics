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
        Color UI1 = Color.FromArgb(255, 248, 224, 254);
        Color UI2 = Color.LightGreen;
        public Form1()
        {
            bool connected = Wolf.TestConnection();
            if(!connected)
            {
                InitializeComponentNoConnetion();
                noConnPic.Image = Properties.Resources.NoConnection;
            } else
            {
                InitializeComponent();
                ifOpen = false;

                problems = new List<ProblemSet>();

                dictionary = new Dictionary<string, StudentAccount>();

                loadDefaultProblemSets();
                if (problems.Count > 0)
                {
                    loadProblemSet(problems[0]);
                }
                for (int i = 0; i < problems.Count(); i++)
                {
                    addToListView(problems[i]);
                }
            }
        }

        public void refreshNC(object sender, EventArgs e)
        {
            if(Wolf.TestConnection())
            {
                NowHasConnection();
                
                problems = new List<ProblemSet>();

                dictionary = new Dictionary<string, StudentAccount>();

                loadDefaultProblemSets();
                if (problems.Count > 0)
                {
                    loadProblemSet(problems[0]);
                }
                for (int i = 0; i < problems.Count(); i++)
                {
                    addToListView(problems[i]);
                }
            } else
            {

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
            createProblemset(  "Multiplication"                        ,  5     ,  10  , "5 * 6 = 30"    ,  null  ,  "_*_"                                     ,  9   ,  2  );
            createProblemset(  "Division"                              ,  5     ,  10  , "5 * 6 = 30"    ,  null  ,  "_/_"                                     ,  9   ,  2  );
            createProblemset(  "Subtraction"                           ,  5     ,  10  , "5 * 6 = 30"    ,  null  ,  "_-_"                                     ,  9   ,  2  );
            createProblemset(  "Addition"                              ,  5     ,  10  , "5 * 6 = 30"    ,  null  ,  "_ + _"                                   ,  9   ,  2  );
            createProblemset(  "WordedAddition"                        ,  5     ,  10  , "5 * 6 = 30"    ,  null  ,  "add _ and _"                             ,  9   ,  2  );
            createProblemset(  "Better Multiplication"                 ,  5     ,  10  , "5 * 6 = 30"    ,  null  ,  "_*_*_"                                   ,  9   ,  2  );
            createProblemset(  "Combined Division and Multiplication"  ,  5     ,  10  , "5 * 6 = 30"    ,  null  ,  "_*_/_"                                   ,  9   ,  2  );
            createProblemset(  "Combined Multiplication and addition"  ,  5     ,  10  , "5 * 6 = 30"    ,  null  ,  "_*_+_"                                   ,  9   ,  2  );
            createProblemset(  "Testing Trig"                          ,  100   ,  10  , "cos(10)"       ,  null  ,  "cos(_)"                                  ,  new int[] {0,30,45,60,90,180});
            createProblemset(  "Testing Calculus"                      ,  1000  ,  10  , "someCalcHere"  ,  null  ,  "derivative of x^_ sin _x"                ,  16  ,  3  );
            createProblemset(  "Testing Calculus 2"                    ,  1000  ,  10  , "someCalcHere"  ,  null  ,  "indefinite integral of x^2 3sin^3 x dx"  ,  16  ,  3  );
            createProblemset(  "Percentages"                           ,  5     ,  10  , "%_%"           ,  null  ,  "what is _% of __ "                       ,  99  ,  1  );
        }

        public void createProblemset(string name, int points, int problem ,string example, PictureBox pic, string funct, int max, int min)
        {
            ProblemSet n = new ProblemSet(name, points, example, null, new Solver(new ProblemFunction(funct, max, min), problem, points));
            problems.Add(n);
            Storage.problemDatabase.Add(name, n);
        }
        
        public void createProblemset(string name, int points, int problem, string example, PictureBox pic, string funct, int[] acceptedValues)
        {
            ProblemSet n = new ProblemSet(name, points, example, null, new Solver(new ProblemFunction(funct, acceptedValues), problem, points));
            problems.Add(n);
            Storage.problemDatabase.Add(name, n);
        }

        public static void setIfOpen(Boolean a)
        {

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

        private void Form1_Load_NoConnection(object sender, EventArgs e)
        {

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
           
            Color nc = Color.FromArgb(255, (int)numericUpDown1.Value, (int)numericUpDown2.Value, (int)numericUpDown3.Value);
            pictureBox1.BackColor = nc;
            sampleBack.BackColor = nc;
            LdrbrdTab.BackColor = nc;
            ProblemsTab.BackColor = nc;
        }
        private void ChangedColor2()
        {
            Color nc = Color.FromArgb(255, (int)numericUpDown4.Value, (int)numericUpDown5.Value, (int)numericUpDown6.Value);
            pictureBox2.BackColor = nc;
            sampleButton.BackColor = nc;
            start_button.BackColor = nc;
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

        private void OtherTab_Click(object sender, EventArgs e)
        {

        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (Control c in Extensions.GetAllControls(this))
                {
                    c.Font = fontDialog1.Font;
                }
            }
        }
    }
}
