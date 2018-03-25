using Mathletics;
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


namespace Mathletics
{
    public partial class Teacher_form : Form
    {
        ArrayList scores = new ArrayList();
        ArrayList names = new ArrayList();
        Dictionary<string, int> nameAndScores = new Dictionary<string, int>();
        public static string leaderBoardPath = "C:\\Desktop\\Mathletics\\Mathletics\\StorageDatabase.txt";

        public Teacher_form()
        {
            InitializeComponent();


        }

        public void loadLeaderboard()
        {
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

        private void Teacher_form_Load(object sender, EventArgs e)
        {

            ////display the leaderboard woohoo!
            ////here goes Thalia's code:
            ////  -retrieve data

            ////List<StudentAccount> list = Storage.accounts.Values.ToList();
            ////foreach (var item in list)
            ///*
            //{
            //    item.getScore();
            //    scores.Add(item.getScore());
            //    names.Add(item.name);

            //}
            //*/


            ////  -store in arrays
            ////  -sort it into ranking order
            ////converting it to strings to display:



            //Dictionary<string, int> leaderboard = new Dictionary<string, int>();
            //leaderboard.Add("bob", 24);
            //leaderboard.Add("fred filly", 22);
            //leaderboard.Add("superlong nameislong", 3);



            //for (int i = 1; i <= leaderboard.Count(); i++)
            //{
            //    var item = leaderboard.ElementAt(i-1);
            //    var itemKey = item.Key;
            //    var itemValue = item.Value;

            //    listView2.Items.Add(i + ".");
            //    listView1.Items.Add(itemKey + "");
            //    listView3.Items.Add(itemValue + "");
            //}
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void OtherTab_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_name_Click(object sender, EventArgs e)
        {

        }

        private void lbl_score_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LdrbrdTab_Click(object sender, EventArgs e)
        {

            //display the leaderboard woohoo!
            //here goes Thalia's code:
            //  -retrieve data
            //  -store in arrays
            //  -sort it into ranking order
            //converting it to strings to display:



            Dictionary<string, int> leaderboard = new Dictionary<string, int>();
            leaderboard.Add("bob", 24);
            leaderboard.Add("fred filly", 22);
            leaderboard.Add("superlong nameislong", 3);



            for (int i = 0; i < 3; i++)
            {
                listView1.Items.Add("for gods sake");

                var item = leaderboard.ElementAt(i);
                var itemKey = item.Key;
                var itemValue = item.Value;

                listView2.Items.Add(i + ".");
                listView1.Items.Add(itemKey + "");
                listView3.Items.Add(itemValue + "");
            }

            /*
            private void listView2_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

            private void listView1_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

            private void listView3_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

            private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
            {

            }
            */
        }

        private void start_button_Click(object sender, EventArgs e)
        {

        }
    }
}
