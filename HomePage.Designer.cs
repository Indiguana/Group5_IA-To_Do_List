namespace Group5_IA_To_Do_List
{
    partial class HomePage
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.MyTasks = new System.Windows.Forms.ComboBox();
            this.IBENGLISHWORK = new System.Windows.Forms.CheckedListBox();
            this.DecaProject = new System.Windows.Forms.CheckedListBox();
            this.Title = new System.Windows.Forms.TextBox();
            this.EDESSAYS = new System.Windows.Forms.CheckedListBox();
            this.addTask = new System.Windows.Forms.Button();
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
            this.SidebarBackground.Location = new System.Drawing.Point(0, 0);
            this.SidebarBackground.Name = "SidebarBackground";
            this.SidebarBackground.Size = new System.Drawing.Size(205, 658);
            this.SidebarBackground.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(24, 151);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.Text = "My Tags";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.myTags_SelectedIndexChanged);
            // 
            // MyTasks
            // 
            this.MyTasks.BackColor = System.Drawing.Color.White;
            this.MyTasks.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.MyTasks.ForeColor = System.Drawing.Color.Black;
            this.MyTasks.FormattingEnabled = true;
            this.MyTasks.Location = new System.Drawing.Point(24, 112);
            this.MyTasks.Name = "MyTasks";
            this.MyTasks.Size = new System.Drawing.Size(121, 24);
            this.MyTasks.TabIndex = 3;
            this.MyTasks.Text = "Archived";
            this.MyTasks.SelectedIndexChanged += new System.EventHandler(this.archived_SelectedIndexChanged);
            // 
            // IBENGLISHWORK
            // 
            this.IBENGLISHWORK.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.IBENGLISHWORK.FormattingEnabled = true;
            this.IBENGLISHWORK.Location = new System.Drawing.Point(277, 109);
            this.IBENGLISHWORK.Name = "IBENGLISHWORK";
            this.IBENGLISHWORK.Size = new System.Drawing.Size(340, 4);
            this.IBENGLISHWORK.TabIndex = 2;
            // 
            // DecaProject
            // 
            this.DecaProject.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.DecaProject.FormattingEnabled = true;
            this.DecaProject.Location = new System.Drawing.Point(277, 145);
            this.DecaProject.Name = "DecaProject";
            this.DecaProject.Size = new System.Drawing.Size(340, 4);
            this.DecaProject.TabIndex = 3;
            // 
            // Title
            // 
            this.Title.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(218, 4);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(445, 57);
            this.Title.TabIndex = 4;
            this.Title.Text = "Client To-Do List";
            // 
            // EDESSAYS
            // 
            this.EDESSAYS.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.EDESSAYS.FormattingEnabled = true;
            this.EDESSAYS.Location = new System.Drawing.Point(277, 178);
            this.EDESSAYS.Name = "EDESSAYS";
            this.EDESSAYS.Size = new System.Drawing.Size(340, 4);
            this.EDESSAYS.TabIndex = 5;
            // 
            // addTask
            // 
            this.addTask.AutoEllipsis = true;
            this.addTask.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.addTask.Location = new System.Drawing.Point(621, 576);
            this.addTask.Name = "addTask";
            this.addTask.Size = new System.Drawing.Size(73, 66);
            this.addTask.TabIndex = 6;
            this.addTask.Text = "+";
            this.addTask.UseVisualStyleBackColor = false;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 715);
            this.Controls.Add(this.addTask);
            this.Controls.Add(this.EDESSAYS);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.DecaProject);
            this.Controls.Add(this.IBENGLISHWORK);
            this.Controls.Add(this.SidebarBackground);
            this.Controls.Add(this.label1);
            this.Name = "HomePage";
            this.Text = "Home Page";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.SidebarBackground.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel SidebarBackground;
        private System.Windows.Forms.CheckedListBox IBENGLISHWORK;
        private System.Windows.Forms.ComboBox MyTasks;
        private System.Windows.Forms.CheckedListBox DecaProject;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.CheckedListBox EDESSAYS;
        private System.Windows.Forms.Button addTask;
    }
}

