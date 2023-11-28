using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaskManager
{
    internal class Project
    {
        public int projectId;
        public string title;
        public string description;
        public List<Task> tasks = new ();

        public void AddTask(Task task)
        {
            tasks.Add(task);
        }
        public void RemoveTask(Task task)
        {
            tasks.Remove(task);
        }
    }
}
