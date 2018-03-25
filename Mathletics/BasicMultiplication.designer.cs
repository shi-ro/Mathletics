namespace SoftDev_2018_Mathletics
{
    partial class BasicMultiplication
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BasicMultiplication));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_var1 = new System.Windows.Forms.Label();
            this.btn_enter = new System.Windows.Forms.Button();
            this.lbl_notvalid = new System.Windows.Forms.Label();
            this.lbl_Correct = new System.Windows.Forms.Label();
            this.lbl_Incorrect = new System.Windows.Forms.Label();
            this.lbl_prevquestions = new System.Windows.Forms.Label();
            this.rTxtBx_answers = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(18, 94);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(698, 31);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // lbl_var1
            // 
            this.lbl_var1.AutoSize = true;
            this.lbl_var1.Location = new System.Drawing.Point(24, 35);
            this.lbl_var1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_var1.Name = "lbl_var1";
            this.lbl_var1.Size = new System.Drawing.Size(191, 25);
            this.lbl_var1.TabIndex = 1;
            this.lbl_var1.Text = "problem goes here";
            this.lbl_var1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_enter
            // 
            this.btn_enter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_enter.Location = new System.Drawing.Point(732, 87);
            this.btn_enter.Margin = new System.Windows.Forms.Padding(6);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(122, 46);
            this.btn_enter.TabIndex = 5;
            this.btn_enter.Text = "Enter";
            this.btn_enter.UseVisualStyleBackColor = false;
            this.btn_enter.Click += new System.EventHandler(this.btn_enter_Click);
            // 
            // lbl_notvalid
            // 
            this.lbl_notvalid.AutoSize = true;
            this.lbl_notvalid.Location = new System.Drawing.Point(24, 162);
            this.lbl_notvalid.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_notvalid.Name = "lbl_notvalid";
            this.lbl_notvalid.Size = new System.Drawing.Size(275, 25);
            this.lbl_notvalid.TabIndex = 6;
            this.lbl_notvalid.Text = "Please input a valid answer";
            this.lbl_notvalid.Click += new System.EventHandler(this.lbl_notvalid_Click);
            // 
            // lbl_Correct
            // 
            this.lbl_Correct.AutoSize = true;
            this.lbl_Correct.Location = new System.Drawing.Point(24, 163);
            this.lbl_Correct.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Correct.Name = "lbl_Correct";
            this.lbl_Correct.Size = new System.Drawing.Size(88, 25);
            this.lbl_Correct.TabIndex = 7;
            this.lbl_Correct.Text = "Correct!";
            this.lbl_Correct.Click += new System.EventHandler(this.lbl_Correct_Click);
            // 
            // lbl_Incorrect
            // 
            this.lbl_Incorrect.AutoSize = true;
            this.lbl_Incorrect.Location = new System.Drawing.Point(24, 162);
            this.lbl_Incorrect.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Incorrect.Name = "lbl_Incorrect";
            this.lbl_Incorrect.Size = new System.Drawing.Size(95, 25);
            this.lbl_Incorrect.TabIndex = 8;
            this.lbl_Incorrect.Text = "Incorrect";
            // 
            // lbl_prevquestions
            // 
            this.lbl_prevquestions.AutoSize = true;
            this.lbl_prevquestions.Location = new System.Drawing.Point(56, 162);
            this.lbl_prevquestions.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_prevquestions.Name = "lbl_prevquestions";
            this.lbl_prevquestions.Size = new System.Drawing.Size(0, 25);
            this.lbl_prevquestions.TabIndex = 9;
            // 
            // rTxtBx_answers
            // 
            this.rTxtBx_answers.Location = new System.Drawing.Point(18, 217);
            this.rTxtBx_answers.Margin = new System.Windows.Forms.Padding(6);
            this.rTxtBx_answers.Name = "rTxtBx_answers";
            this.rTxtBx_answers.ReadOnly = true;
            this.rTxtBx_answers.Size = new System.Drawing.Size(832, 369);
            this.rTxtBx_answers.TabIndex = 10;
            this.rTxtBx_answers.Text = "";
            this.rTxtBx_answers.TextChanged += new System.EventHandler(this.rTxtBx_answers_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(736, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "R : ";
            // 
            // BasicMultiplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(224)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(878, 613);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rTxtBx_answers);
            this.Controls.Add(this.lbl_prevquestions);
            this.Controls.Add(this.lbl_Incorrect);
            this.Controls.Add(this.lbl_Correct);
            this.Controls.Add(this.lbl_notvalid);
            this.Controls.Add(this.btn_enter);
            this.Controls.Add(this.lbl_var1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "BasicMultiplication";
            this.Text = "Mathletics [Solver]";
            this.Load += new System.EventHandler(this.BasicMultiplication_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_var1;
        private System.Windows.Forms.Button btn_enter;
        private System.Windows.Forms.Label lbl_notvalid;
        private System.Windows.Forms.Label lbl_Correct;
        private System.Windows.Forms.Label lbl_Incorrect;
        private System.Windows.Forms.Label lbl_prevquestions;
        private System.Windows.Forms.RichTextBox rTxtBx_answers;
        private System.Windows.Forms.Label label1;
    }
}