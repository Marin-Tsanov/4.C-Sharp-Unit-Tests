using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Models
{
    public class Tasker
    {
        private ILogger /*ConsoleLogger*/ logger;
        private IIdProvider /*IdProvider*/ idProvider;    

        public ICollection<Task> Tasks { get; set; }

        public Tasker(ILogger logger, IIdProvider idProvider)
        {
            this.Tasks = new List<Task>();
            this.logger = logger/*new ConsoleLogger()*/;
            this.idProvider = idProvider/*new IdProvider()*/;
        }

       public void Save(Task task)
        {
            //if (task == null)
            //{
            //    throw new ArgumentNullException();
            //}

            task.Id = idProvider.Id;
            this.Tasks.Add(task);
            //this.logger.Log(string.Format("Added task with id {0}", task.Id));
            try
            {
                this.logger.Log(string.Format("Added task with id {0}", task.Id));
            }
            catch (ArgumentNullException)
            {
                
            }
        }

        public void Delete(int id)
        {
            var taskFound = this.Tasks
                .SingleOrDefault(task => task.Id == id);

            if (taskFound == null)
            {
                this.logger.Log($"Task with {id} is not found");
                return;
            }
            this.Tasks.Remove(taskFound);
            this.logger.Log($"Task with {id} has been removed !");
        }

        public void AllTasks()
        {
            foreach (var task in this.Tasks)
            {
                this.logger.Log($"Task [{task.Id}]");
            }
        }
        //markDone(task);
        
        //showAll();
    }
}
