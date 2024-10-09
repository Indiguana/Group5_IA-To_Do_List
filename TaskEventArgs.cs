using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group5_IA_To_Do_List
{
    using System; 
    public class TaskEventArgs : EventArgs
    {
        public Task NewTask { get; }
        public TaskEventArgs(Task newTask)
        {
            NewTask = newTask;
        }
    }
}