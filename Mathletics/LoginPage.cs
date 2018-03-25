using System;
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
    public partial class LoginPage : Form
    {
        public static string name;
        public Form1 mainform;
        public LoginPage(Form1 mainform)
        {
            this.mainform = mainform;
            InitializeComponent();
            mainform.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e) { }

        private void btn_login_Click(object sender, EventArgs e)
        {
            mainform.Enabled = true;
            String sve = txt_name.Text;
            name = sve;
            Close();
            mainform.manageLogin(sve);
        }

        private void LoginPage_Load(object sender, EventArgs e) { }

        /*private void btn_teacher_Click(object sender, EventArgs e)
        {
            if(txtbox_teacher.Text == "teacher")
            {
                Close();
                mainform.Close();

                Teacher_form tc = new Teacher_form();
                tc.Show();
            }
        }*/

        private void txtbox_teacher_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
