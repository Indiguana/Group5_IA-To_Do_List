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

        private void addTask_Click(object sender, EventArgs e)
        {
            Form1 taskForm = new Form1();
            taskForm.TaskCreated += TaskForm_TaskCreated;
            taskForm.ShowDialog(); 
        }
        private void UpdateTaskList()
        {
            for (int i = 0; i < tasks.Count; i++)
            {
                string displayText = $"{tasks[i].Subject}: {tasks[i].Description} Due: {tasks[i].DueDate.ToShortDateString()} (Tag: {tasks[i].Tags})";
                checkedListBoxTasks.Items.Add(displayText);
            }
        }
        private void UpdateArchives()
        {
            if (archivedTasks.Count > 0)
            {
                string disp = $"{archivedTasks[archivedTasks.Count-1].Subject}: {archivedTasks[archivedTasks.Count-1].Description} Due: {archivedTasks[archivedTasks.Count-1].DueDate.ToShortDateString()}";
                MyTasks.Items.Add(disp);
            }
        }
        private void TaskForm_TaskCreated(object sender, TaskEventArgs e)
        {
            tasks.Add(e.NewTask);
            UpdateTaskList();
        }

        private void checkedListBoxTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = checkedListBoxTasks.Items.Count - 1; i >= 0; i--)
            {
                if (checkedListBoxTasks.GetItemChecked(i))
                {
                    archivedTasks.Add(tasks[i]);
                    checkedListBoxTasks.Items.RemoveAt(i);
                    tasks.RemoveAt(i);
                    UpdateArchives();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Title_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

