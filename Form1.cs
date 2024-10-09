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
    public partial class Form1 : Form
    {
        public event EventHandler<TaskEventArgs> TaskCreated; 
        public Form1()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Form1_Load);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string subject = txtSubject.Text;
            DateTime dueDate = dtpDueDate.Value;
            string description = txtDescription.Text; 
            string selectedTag = comboBoxTags.SelectedItem?.ToString();

            Task newTask = new Task
            {
                Subject = subject,
                DueDate = dueDate,
                Tags = selectedTag
            };
            TaskCreated?.Invoke(this, new TaskEventArgs(newTask));
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxTags_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxTags.Items.Add("High Priority");
            comboBoxTags.Items.Add("Low Priority");
            comboBoxTags.Items.Add("High Difficulty");
            comboBoxTags.Items.Add("Low Difficulty");
        }
    }
}
