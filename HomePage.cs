using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group5_IA_To_Do_List
{
    public partial class HomePage : Form
    {
        private List<Task> tasks = new List<Task>();
        private List<Task> archivedTasks = new List<Task>();
        public HomePage()
        {
            InitializeComponent();
            checkedListBoxTasks.ItemCheck += checkedListBoxTasks_SelectedIndexChanged;
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }
        
        private void archived_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        public enum myTags
        {
            IBEnglish = 0,
            IBCS = 1,
            German = 2,
            IBAnalysis = 3
        }

        private void myTags_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        int numTasks = 0;

        private void addTask_Click(object sender, EventArgs e)
        {
            Form1 taskForm = new Form1();
            taskForm.TaskCreated += TaskForm_TaskCreated;
            taskForm.ShowDialog(); 
            /*
            numTasks++;
            TextBox txtrun = new TextBox();
            txtrun.Name = "txtDynamic";
            txtrun.Location = new System.Drawing.Point(225, 65 + 35 * numTasks);
            txtrun.Size = new System.Drawing.Size(200, 25);
            this.Controls.Add(txtrun);*/
        }

        int onTask = 0;
        private void UpdateTaskList()
        {
            for (int i = onTask; i < tasks.Count; i++)
            {
                string displayText = $"{tasks[i].Subject}: {tasks[i].Description} Due: {tasks[i].DueDate.ToShortDateString()} (Tag: {tasks[i].Tags})";
                checkedListBoxTasks.Items.Add(displayText);
                onTask++;
            }
        }
        int abc = 0;
        private void UpdateArchives()
        {
            for (int i = abc; i < archivedTasks.Count; i++)
            {
                string disp = $"{archivedTasks[i].Subject}: {archivedTasks[i].Description} Due: {archivedTasks[i].DueDate.ToShortDateString()} (Tag: {tasks[i].Tags})";
                MyTasks.Items.Add(disp);
                i++;
            }
        }
        private void TaskForm_TaskCreated(object sender, TaskEventArgs e)
        {
            tasks.Add(e.NewTask);
            UpdateTaskList();
            UpdateArchives();
        }
 

        private void checkedListBoxTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = checkedListBoxTasks.Items.Count - 1; i >= 0; i--)
            {
                if (checkedListBoxTasks.GetItemChecked(i))
                {
                    checkedListBoxTasks.Items.RemoveAt(i);

  
                    if (i < tasks.Count)
                    {
                        archivedTasks.Add(tasks[i]);
                        tasks.RemoveAt(i);
                    }
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

       

    }
    }

