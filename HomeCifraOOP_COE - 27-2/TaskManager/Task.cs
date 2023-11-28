using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaskManager
{
    internal class Task : TaskBase
    {
        public Task(int taskId, string title, string description, Status stats, Priority prioritys, DateTime deadline, string assignedTo) : base(taskId, title, description, stats, prioritys, deadline, assignedTo)
        {

        }
    }
}
