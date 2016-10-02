using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaskManager
{
    public class TaskManager
    {
        int count = 0;
        ICollection<Task> tasks = new List<Task>();

        public int TasksCount
        {
            get
            {
                return this.count;
            }
        }

        public void AddTask(Task task)
        {
            if (task == null)
            {
                throw new ArgumentNullException("Task is null");
            }

            this.tasks.Add(task);
            count++;
        }
    }
}
