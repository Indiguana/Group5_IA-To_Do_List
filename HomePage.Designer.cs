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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.label1 = new System.Windows.Forms.Label();
            this.SidebarBackground = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.MyTasks = new System.Windows.Forms.ComboBox();
            this.Title = new System.Windows.Forms.TextBox();
            this.createTask = new System.Windows.Forms.Button();
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.checkedListBoxTasks = new System.Windows.Forms.CheckedListBox();
            this.SidebarBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(629, 199);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 0;
            // 
            // SidebarBackground
            // 
            this.SidebarBackground.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SidebarBackground.Controls.Add(this.button1);
            this.SidebarBackground.Controls.Add(this.comboBox1);
            this.SidebarBackground.Controls.Add(this.MyTasks);
            this.SidebarBackground.Location = new System.Drawing.Point(0, 0);
            this.SidebarBackground.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SidebarBackground.Name = "SidebarBackground";
            this.SidebarBackground.Size = new System.Drawing.Size(273, 810);
            this.SidebarBackground.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(16, 602);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 58);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(32, 186);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 27);
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
            this.MyTasks.Location = new System.Drawing.Point(32, 138);
            this.MyTasks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MyTasks.Name = "MyTasks";
            this.MyTasks.Size = new System.Drawing.Size(160, 27);
            this.MyTasks.TabIndex = 3;
            this.MyTasks.Text = "Archived";
            this.MyTasks.SelectedIndexChanged += new System.EventHandler(this.archived_SelectedIndexChanged);
            // 
            // Title
            // 
            this.Title.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(300, 25);
            this.Title.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(613, 69);
            this.Title.TabIndex = 4;
            this.Title.Text = "Client To-Do List";
            // 
            // createTask
            // 
            this.createTask.AutoEllipsis = true;
            this.createTask.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.createTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.createTask.Location = new System.Drawing.Point(734, 553);
            this.createTask.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.createTask.Name = "createTask";
            this.createTask.Size = new System.Drawing.Size(179, 81);
            this.createTask.TabIndex = 6;
            this.createTask.Text = "Create New Task";
            this.createTask.UseVisualStyleBackColor = false;
            this.createTask.Click += new System.EventHandler(this.addTask_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(855, 454);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(855, 379);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // checkedListBoxTasks
            // 
            this.checkedListBoxTasks.FormattingEnabled = true;
            this.checkedListBoxTasks.Location = new System.Drawing.Point(300, 124);
            this.checkedListBoxTasks.Name = "checkedListBoxTasks";
            this.checkedListBoxTasks.Size = new System.Drawing.Size(536, 395);
            this.checkedListBoxTasks.TabIndex = 9;
            this.checkedListBoxTasks.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxTasks_SelectedIndexChanged);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 880);
            this.Controls.Add(this.checkedListBoxTasks);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.createTask);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.SidebarBackground);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "HomePage";
            this.ShowInTaskbar = false;
            this.Text = "Home Page";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.SidebarBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel SidebarBackground;
        private System.Windows.Forms.ComboBox MyTasks;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.Button createTask;
        private System.Windows.Forms.Button button1;
        private System.ServiceProcess.ServiceController serviceController1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckedListBox checkedListBoxTasks;
    }
}

