namespace Mathletics
{
    partial class Teacher_form
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
            this.OtherTab = new System.Windows.Forms.TabPage();
            this.LdrbrdTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.listView2 = new System.Windows.Forms.ListView();
            this.listView3 = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.problem_list = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.start_button = new System.Windows.Forms.Button();
            this.problem_points = new System.Windows.Forms.Label();
            this.problem_name = new System.Windows.Forms.Label();
            this.problem_image = new System.Windows.Forms.PictureBox();
            this.problem_details = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.LdrbrdTab.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.MainTabControl.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.problem_image)).BeginInit();
            this.SuspendLayout();
            // 
            // OtherTab
            // 
            this.OtherTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(224)))), ((int)(((byte)(254)))));
            this.OtherTab.Location = new System.Drawing.Point(8, 58);
            this.OtherTab.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.OtherTab.Name = "OtherTab";
            this.OtherTab.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.OtherTab.Size = new System.Drawing.Size(2302, 1012);
            this.OtherTab.TabIndex = 3;
            this.OtherTab.Text = "Other";
            this.OtherTab.Click += new System.EventHandler(this.OtherTab_Click);
            // 
            // LdrbrdTab
            // 
            this.LdrbrdTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(224)))), ((int)(((byte)(254)))));
            this.LdrbrdTab.Controls.Add(this.tableLayoutPanel1);
            this.LdrbrdTab.Location = new System.Drawing.Point(8, 58);
            this.LdrbrdTab.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.LdrbrdTab.Name = "LdrbrdTab";
            this.LdrbrdTab.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.LdrbrdTab.Size = new System.Drawing.Size(2302, 1012);
            this.LdrbrdTab.TabIndex = 2;
            this.LdrbrdTab.Text = "Leaderboard";
            this.LdrbrdTab.Click += new System.EventHandler(this.LdrbrdTab_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.07596F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.92403F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.listView1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.listView2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.listView3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 11);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.20339F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 866F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(2278, 908);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rank";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(280, 48);
            this.listView1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1810, 851);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // listView2
            // 
            this.listView2.Location = new System.Drawing.Point(6, 48);
            this.listView2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(258, 851);
            this.listView2.TabIndex = 4;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.List;
            // 
            // listView3
            // 
            this.listView3.Location = new System.Drawing.Point(2103, 48);
            this.listView3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(158, 851);
            this.listView3.TabIndex = 5;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.List;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2103, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 42);
            this.label3.TabIndex = 2;
            this.label3.Text = "Score";
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.LdrbrdTab);
            this.MainTabControl.Controls.Add(this.OtherTab);
            this.MainTabControl.Controls.Add(this.tabPage2);
            this.MainTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainTabControl.ItemSize = new System.Drawing.Size(100, 50);
            this.MainTabControl.Location = new System.Drawing.Point(24, 3);
            this.MainTabControl.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MainTabControl.MinimumSize = new System.Drawing.Size(6, 0);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.Padding = new System.Drawing.Point(80, 3);
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(2318, 1078);
            this.MainTabControl.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.problem_list);
            this.tabPage2.Controls.Add(this.tableLayoutPanel2);
            this.tabPage2.Location = new System.Drawing.Point(8, 58);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage2.Size = new System.Drawing.Size(2302, 1012);
            this.tabPage2.TabIndex = 5;
            this.tabPage2.Text = "Create Problem Sets";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // problem_list
            // 
            this.problem_list.FormattingEnabled = true;
            this.problem_list.ItemHeight = 51;
            this.problem_list.Location = new System.Drawing.Point(12, 12);
            this.problem_list.Margin = new System.Windows.Forms.Padding(6);
            this.problem_list.Name = "problem_list";
            this.problem_list.Size = new System.Drawing.Size(942, 769);
            this.problem_list.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.problem_details, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(970, 18);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(960, 909);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 472F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.problem_image, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(948, 442);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.start_button, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.problem_points, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.problem_name, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 141F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(464, 430);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // start_button
            // 
            this.start_button.BackColor = System.Drawing.Color.PaleGreen;
            this.start_button.Location = new System.Drawing.Point(6, 294);
            this.start_button.Margin = new System.Windows.Forms.Padding(6);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(452, 130);
            this.start_button.TabIndex = 0;
            this.start_button.Text = "START";
            this.start_button.UseVisualStyleBackColor = false;
            // 
            // problem_points
            // 
            this.problem_points.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.problem_points.AutoSize = true;
            this.problem_points.Location = new System.Drawing.Point(163, 144);
            this.problem_points.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.problem_points.Name = "problem_points";
            this.problem_points.Size = new System.Drawing.Size(138, 144);
            this.problem_points.TabIndex = 2;
            this.problem_points.Text = "label2";
            this.problem_points.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // problem_name
            // 
            this.problem_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.problem_name.AutoSize = true;
            this.problem_name.Location = new System.Drawing.Point(163, 0);
            this.problem_name.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.problem_name.Name = "problem_name";
            this.problem_name.Size = new System.Drawing.Size(138, 144);
            this.problem_name.TabIndex = 1;
            this.problem_name.Text = "label1";
            this.problem_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // problem_image
            // 
            this.problem_image.Location = new System.Drawing.Point(482, 6);
            this.problem_image.Margin = new System.Windows.Forms.Padding(6);
            this.problem_image.Name = "problem_image";
            this.problem_image.Size = new System.Drawing.Size(460, 430);
            this.problem_image.TabIndex = 3;
            this.problem_image.TabStop = false;
            // 
            // problem_details
            // 
            this.problem_details.Location = new System.Drawing.Point(6, 460);
            this.problem_details.Margin = new System.Windows.Forms.Padding(6);
            this.problem_details.Name = "problem_details";
            this.problem_details.Size = new System.Drawing.Size(944, 440);
            this.problem_details.TabIndex = 3;
            this.problem_details.Text = "";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleGreen;
            this.button1.Location = new System.Drawing.Point(506, 797);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(452, 130);
            this.button1.TabIndex = 5;
            this.button1.Text = "EDIT";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PaleGreen;
            this.button2.Location = new System.Drawing.Point(12, 797);
            this.button2.Margin = new System.Windows.Forms.Padding(6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(452, 130);
            this.button2.TabIndex = 6;
            this.button2.Text = "NEW";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Teacher_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1984, 1067);
            this.Controls.Add(this.MainTabControl);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Teacher_form";
            this.Text = "Teacher Account";
            this.Load += new System.EventHandler(this.Teacher_form_Load);
            this.LdrbrdTab.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.MainTabControl.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.problem_image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage OtherTab;
        private System.Windows.Forms.TabPage LdrbrdTab;
        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ListBox problem_list;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Label problem_points;
        private System.Windows.Forms.Label problem_name;
        private System.Windows.Forms.PictureBox problem_image;
        private System.Windows.Forms.RichTextBox problem_details;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

