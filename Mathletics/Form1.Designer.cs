namespace Mathletics
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.ProblemsTab = new System.Windows.Forms.TabPage();
            this.problem_list = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.start_button = new System.Windows.Forms.Button();
            this.problem_points = new System.Windows.Forms.Label();
            this.problem_name = new System.Windows.Forms.Label();
            this.problem_image = new System.Windows.Forms.PictureBox();
            this.problem_details = new System.Windows.Forms.RichTextBox();
            this.LdrbrdTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.listView3 = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.OtherTab = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
            this.MainTabControl.SuspendLayout();
            this.ProblemsTab.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.problem_image)).BeginInit();
            this.LdrbrdTab.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.OtherTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.ProblemsTab);
            this.MainTabControl.Controls.Add(this.LdrbrdTab);
            this.MainTabControl.Controls.Add(this.OtherTab);
            this.MainTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainTabControl.ItemSize = new System.Drawing.Size(100, 50);
            this.MainTabControl.Location = new System.Drawing.Point(1, 1);
            this.MainTabControl.MinimumSize = new System.Drawing.Size(3, 0);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.Padding = new System.Drawing.Point(80, 3);
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(955, 542);
            this.MainTabControl.TabIndex = 0;
            this.MainTabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // ProblemsTab
            // 
            this.ProblemsTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(224)))), ((int)(((byte)(254)))));
            this.ProblemsTab.Controls.Add(this.problem_list);
            this.ProblemsTab.Controls.Add(this.tableLayoutPanel1);
            this.ProblemsTab.Location = new System.Drawing.Point(4, 54);
            this.ProblemsTab.Name = "ProblemsTab";
            this.ProblemsTab.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.ProblemsTab.Size = new System.Drawing.Size(947, 484);
            this.ProblemsTab.TabIndex = 1;
            this.ProblemsTab.Text = "Problems";
            this.ProblemsTab.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // problem_list
            // 
            this.problem_list.FormattingEnabled = true;
            this.problem_list.ItemHeight = 25;
            this.problem_list.Location = new System.Drawing.Point(4, 4);
            this.problem_list.Name = "problem_list";
            this.problem_list.Size = new System.Drawing.Size(473, 454);
            this.problem_list.TabIndex = 2;
            this.problem_list.SelectedIndexChanged += new System.EventHandler(this.problem_list_SelectedIndexChanged_1);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.problem_details, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(483, 7);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(480, 473);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 236F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.problem_image, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(474, 230);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.start_button, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.problem_points, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.problem_name, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(232, 223);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // start_button
            // 
            this.start_button.BackColor = System.Drawing.Color.PaleGreen;
            this.start_button.Location = new System.Drawing.Point(3, 153);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(226, 67);
            this.start_button.TabIndex = 0;
            this.start_button.Text = "START";
            this.start_button.UseVisualStyleBackColor = false;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // problem_points
            // 
            this.problem_points.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.problem_points.AutoSize = true;
            this.problem_points.Location = new System.Drawing.Point(81, 75);
            this.problem_points.Name = "problem_points";
            this.problem_points.Size = new System.Drawing.Size(70, 75);
            this.problem_points.TabIndex = 2;
            this.problem_points.Text = "label2";
            this.problem_points.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // problem_name
            // 
            this.problem_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.problem_name.AutoSize = true;
            this.problem_name.Location = new System.Drawing.Point(81, 0);
            this.problem_name.Name = "problem_name";
            this.problem_name.Size = new System.Drawing.Size(70, 75);
            this.problem_name.TabIndex = 1;
            this.problem_name.Text = "label1";
            this.problem_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // problem_image
            // 
            this.problem_image.Location = new System.Drawing.Point(241, 3);
            this.problem_image.Name = "problem_image";
            this.problem_image.Size = new System.Drawing.Size(230, 223);
            this.problem_image.TabIndex = 3;
            this.problem_image.TabStop = false;
            // 
            // problem_details
            // 
            this.problem_details.Location = new System.Drawing.Point(3, 239);
            this.problem_details.Name = "problem_details";
            this.problem_details.Size = new System.Drawing.Size(474, 231);
            this.problem_details.TabIndex = 3;
            this.problem_details.Text = "";
            // 
            // LdrbrdTab
            // 
            this.LdrbrdTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(224)))), ((int)(((byte)(254)))));
            this.LdrbrdTab.Controls.Add(this.tableLayoutPanel6);
            this.LdrbrdTab.Location = new System.Drawing.Point(4, 54);
            this.LdrbrdTab.Name = "LdrbrdTab";
            this.LdrbrdTab.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.LdrbrdTab.Size = new System.Drawing.Size(947, 484);
            this.LdrbrdTab.TabIndex = 2;
            this.LdrbrdTab.Text = "Leaderboard";
            this.LdrbrdTab.Click += new System.EventHandler(this.LdrbrdTab_Click);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.07596F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.92403F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 107F));
            this.tableLayoutPanel6.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.listView1, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.listView3, 2, 1);
            this.tableLayoutPanel6.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.listView2, 0, 1);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(8, 10);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.20339F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 499F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(934, 528);
            this.tableLayoutPanel6.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rank";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(111, 32);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(712, 439);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // listView3
            // 
            this.listView3.Location = new System.Drawing.Point(829, 32);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(98, 439);
            this.listView3.TabIndex = 5;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.List;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(829, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Score";
            // 
            // listView2
            // 
            this.listView2.Location = new System.Drawing.Point(3, 32);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(102, 439);
            this.listView2.TabIndex = 4;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.List;
            // 
            // OtherTab
            // 
            this.OtherTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(224)))), ((int)(((byte)(254)))));
            this.OtherTab.Controls.Add(this.numericUpDown6);
            this.OtherTab.Controls.Add(this.numericUpDown5);
            this.OtherTab.Controls.Add(this.numericUpDown4);
            this.OtherTab.Controls.Add(this.numericUpDown3);
            this.OtherTab.Controls.Add(this.numericUpDown2);
            this.OtherTab.Controls.Add(this.label5);
            this.OtherTab.Controls.Add(this.pictureBox2);
            this.OtherTab.Controls.Add(this.numericUpDown1);
            this.OtherTab.Controls.Add(this.label4);
            this.OtherTab.Controls.Add(this.pictureBox1);
            this.OtherTab.Location = new System.Drawing.Point(4, 54);
            this.OtherTab.Name = "OtherTab";
            this.OtherTab.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.OtherTab.Size = new System.Drawing.Size(947, 484);
            this.OtherTab.TabIndex = 3;
            this.OtherTab.Text = "Other";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(224)))), ((int)(((byte)(254)))));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(11, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 26);
            this.label4.TabIndex = 1;
            this.label4.Text = "UI Color 1";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(67, 36);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(69, 32);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.Value = new decimal(new int[] {
            248,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 26);
            this.label5.TabIndex = 6;
            this.label5.Text = "UI Color 2";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(12, 118);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(142, 36);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(69, 32);
            this.numericUpDown2.TabIndex = 7;
            this.numericUpDown2.Value = new decimal(new int[] {
            224,
            0,
            0,
            0});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(217, 36);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(69, 32);
            this.numericUpDown3.TabIndex = 8;
            this.numericUpDown3.Value = new decimal(new int[] {
            254,
            0,
            0,
            0});
            this.numericUpDown3.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(68, 118);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(69, 32);
            this.numericUpDown4.TabIndex = 9;
            this.numericUpDown4.ValueChanged += new System.EventHandler(this.numericUpDown4_ValueChanged);
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Location = new System.Drawing.Point(143, 118);
            this.numericUpDown5.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(69, 32);
            this.numericUpDown5.TabIndex = 10;
            this.numericUpDown5.ValueChanged += new System.EventHandler(this.numericUpDown5_ValueChanged);
            // 
            // numericUpDown6
            // 
            this.numericUpDown6.Location = new System.Drawing.Point(218, 118);
            this.numericUpDown6.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown6.Name = "numericUpDown6";
            this.numericUpDown6.Size = new System.Drawing.Size(69, 32);
            this.numericUpDown6.TabIndex = 11;
            this.numericUpDown6.ValueChanged += new System.EventHandler(this.numericUpDown6_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 544);
            this.Controls.Add(this.MainTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Mathletics";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MainTabControl.ResumeLayout(false);
            this.ProblemsTab.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.problem_image)).EndInit();
            this.LdrbrdTab.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.OtherTab.ResumeLayout(false);
            this.OtherTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage ProblemsTab;
        private System.Windows.Forms.TabPage OtherTab;
        private System.Windows.Forms.TabPage LdrbrdTab;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ListBox problem_list;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Label problem_points;
        private System.Windows.Forms.Label problem_name;
        private System.Windows.Forms.PictureBox problem_image;
        private System.Windows.Forms.RichTextBox problem_details;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown6;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

