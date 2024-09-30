namespace Group5_IA_To_Do_List
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
            this.label1 = new System.Windows.Forms.Label();
            this.SidebarBackground = new System.Windows.Forms.Panel();
            this.MyTasks = new System.Windows.Forms.ComboBox();
            this.myTags = new System.Windows.Forms.Button();
            this.archivedTasks = new System.Windows.Forms.Button();
            this.IBENGLISHWORK = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SidebarBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(472, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // SidebarBackground
            // 
            this.SidebarBackground.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SidebarBackground.Controls.Add(this.comboBox1);
            this.SidebarBackground.Controls.Add(this.MyTasks);
            this.SidebarBackground.Controls.Add(this.myTags);
            this.SidebarBackground.Controls.Add(this.archivedTasks);
            this.SidebarBackground.Location = new System.Drawing.Point(0, 0);
            this.SidebarBackground.Name = "SidebarBackground";
            this.SidebarBackground.Size = new System.Drawing.Size(205, 658);
            this.SidebarBackground.TabIndex = 1;
            // 
            // MyTasks
            // 
            this.MyTasks.FormattingEnabled = true;
            this.MyTasks.Location = new System.Drawing.Point(24, 233);
            this.MyTasks.Name = "MyTasks";
            this.MyTasks.Size = new System.Drawing.Size(121, 21);
            this.MyTasks.TabIndex = 3;
            // 
            // myTags
            // 
            this.myTags.Location = new System.Drawing.Point(52, 137);
            this.myTags.Name = "myTags";
            this.myTags.Size = new System.Drawing.Size(75, 23);
            this.myTags.TabIndex = 2;
            this.myTags.Text = "My Tasks";
            this.myTags.UseVisualStyleBackColor = true;
            // 
            // archivedTasks
            // 
            this.archivedTasks.Location = new System.Drawing.Point(52, 88);
            this.archivedTasks.Name = "archivedTasks";
            this.archivedTasks.Size = new System.Drawing.Size(75, 23);
            this.archivedTasks.TabIndex = 1;
            this.archivedTasks.Text = "Archived Tasks";
            this.archivedTasks.UseVisualStyleBackColor = true;
            this.archivedTasks.Click += new System.EventHandler(this.button1_Click);
            // 
            // IBENGLISHWORK
            // 
            this.IBENGLISHWORK.FormattingEnabled = true;
            this.IBENGLISHWORK.Location = new System.Drawing.Point(277, 99);
            this.IBENGLISHWORK.Name = "IBENGLISHWORK";
            this.IBENGLISHWORK.Size = new System.Drawing.Size(340, 19);
            this.IBENGLISHWORK.TabIndex = 2;
            this.IBENGLISHWORK.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(277, 141);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(340, 19);
            this.checkedListBox1.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(24, 296);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 715);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.IBENGLISHWORK);
            this.Controls.Add(this.SidebarBackground);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SidebarBackground.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel SidebarBackground;
        private System.Windows.Forms.Button archivedTasks;
        private System.Windows.Forms.Button myTags;
        private System.Windows.Forms.CheckedListBox IBENGLISHWORK;
        private System.Windows.Forms.ComboBox MyTasks;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

