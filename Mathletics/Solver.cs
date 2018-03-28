using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Mathletics;
using System.Text.RegularExpressions;

namespace SoftDev_2018_Mathletics
{
    public partial class Solver : Form
    {
        String inputAns;
        string intAns;
        string correctAns;
        int numTries;

        int finished = 0;
        int problems = 0;

        int score = 0;
        
        int combo = 0;

        String attemptedProblems;

        public ProblemFunction problemFunction;
        ProblemFunctionInstance currentProblem;

        Regex rgx = new Regex(@"^-?\d+(.\d+)?$", RegexOptions.Compiled);
        
        public Solver(ProblemFunction problemFunction, int problems, int score)
        {
            this.score = score;
            this.problems = problems;
            this.problemFunction = problemFunction;
            
            InitializeComponent();
            
        }
        private void TextBoxKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EnterButtonClicked();
                e.Handled = true;
                e.SuppressKeyPress = true; 
            }
        }
        public ProblemFunction GetProblemFunction()
        {
            return problemFunction;
        }
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            inputAns = textBox1.Text;
        }
        private void btn_enter_Click(object sender, EventArgs e)
        {
            EnterButtonClicked();
        }
        private void EnterButtonClicked()
        {
            if (rgx.IsMatch(textBox1.Text))
            {
                intAns = textBox1.Text; 
                if (intAns == correctAns)
                {
                    combo++;
                    Storage.currentUser.score += score;
                    Storage.accounts[Storage.currentUser.name].score = Storage.currentUser.score;
                    Console.WriteLine($"[UDT] PTS : { Storage.accounts[Storage.currentUser.name].score }");
                    if(combo==1)
                    {
                        lbl_Incorrect.Text = "Correct!";
                    } else
                    {
                        lbl_Incorrect.Text = $"Correct X {combo} !";
                    }
                    addAttemptedProblems(true);
                    textBox1.Clear();
                    updateProblem();
                }
                else
                {
                    numTries--;
                    if (numTries == 0)
                    {
                        addAttemptedProblems(false);
                        updateProblem();
                    }
                    else
                    {
                        if (numTries == 1)
                        {
                            lbl_Incorrect.Text = "Incorrect. 1 try left.";
                        }
                        else
                        {
                            lbl_Incorrect.Text = "Incorrect. " + numTries + " tries left.";
                        }
                        textBox1.Text = "";
                        combo = 0;
                    }
                }
            }
            else
            {
                lbl_Incorrect.Text = "Please input a valid answer";
                textBox1.Text = "";
            }
        }
        private void addAttemptedProblems(Boolean isCorrect)
        {
            if(isCorrect)
            {
                String oldAttemptedProblems = attemptedProblems;
                attemptedProblems = formatProblemOutput(currentProblem.problem + "") + "   =   " + inputAns + "\n" + oldAttemptedProblems;
            }
            else
            {
                String oldAttemptedProblems = attemptedProblems;
                attemptedProblems = formatProblemOutput(currentProblem.problem + "") + "   =   " + inputAns + "   Correct Answer:   " + currentProblem.result + "\n" + oldAttemptedProblems;
            }
            rTxtBx_answers.Text = attemptedProblems;
        }
        private void updateProblem()
        {
            currentProblem = problemFunction.getInstance();
            textBox1.Clear();
            numTries = 3;
            lbl_var1.Text = formatProblemOutput(currentProblem.problem);
            inputAns = "";
            intAns = "";
            correctAns = currentProblem.result;
            Console.WriteLine($"\t\t\t[ RECIEVED DATA ]\n\n[DTA] PRB : {currentProblem.problem}\n[DTA] ANS : {currentProblem.result}\n");
        }

        private string formatProblemOutput(string output)
        {
            string ret = "";
            string ops = "+-/*%";
            foreach (char c in output)
            {
                if (ops.Contains(c))
                {
                    ret += "   " + c + "   ";
                }
                else if(c=='(')
                {
                    ret += "(   ";
                }
                else if(c==')')
                {
                    ret += "   )";
                }
                else
                {
                    ret += c;
                }
            }
            return ret;
        }

        private void BasicMultiplication_FormClosed(object sender, EventArgs e)
        {
            Mathletics.Form1.setIfOpen(false);
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void label1_Click_2(object sender, EventArgs e)
        {
        }
        private void BasicMultiplication_Load(object sender, EventArgs e)
        {
            btn_enter.FlatStyle = FlatStyle.Flat;
            btn_enter.FlatAppearance.BorderColor = Color.Green;
            btn_enter.FlatAppearance.BorderSize = 0;
            btn_enter.BackColor = Color.PaleGreen;

            FormClosed += new FormClosedEventHandler(BasicMultiplication_FormClosed);

            textBox1.KeyUp += TextBoxKeyUp;
            inputAns = "";
            intAns = "";
            numTries = 3;

            lbl_notvalid.Hide();
            lbl_Correct.Hide();
            lbl_Incorrect.Text = "";
            label1.Text = "";

            updateProblem();
        }
        private void lbl_Correct_Click(object sender, EventArgs e)
        {

        }
        private void lbl_notvalid_Click(object sender, EventArgs e)
        {

        }

        private void rTxtBx_answers_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
    }