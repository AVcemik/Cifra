using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaskManager
{
    enum Status
    {
        Ready,
        InProcess,
        delayed
    }
    enum Priority
    {
        Hight,
        Medium,
        Low
    }
    internal abstract class TaskBase : ITask
    {
        public int TaskId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Status Stats { get; set; }
        public Priority Prioritys { get; set; }
        public DateTime Deadline { get; set; }
        public string AssignedTo { get; set; }

        protected TaskBase(int taskId, string title, string description, Status stats, Priority prioritys, DateTime deadline, string assignedTo)
        {
            TaskId = taskId;
            Title = title;
            Description = description;
            Stats = stats;
            Prioritys = prioritys;
            Deadline = deadline;
            AssignedTo = assignedTo;
        }

        public void Assign(User user)
        {
            AssignedTo = user.GetUserName();
        }
        public void ChangeStatus(Status newStatus)
        {
            Stats = newStatus;
        }
        public void EditTask(string title, string description, Status status, Priority priority, DateTime datetime, string assignedTo)
        {
            Title = title;
            Description = description;
            Stats = status;
            Prioritys = priority;
            Deadline = datetime;
            AssignedTo = assignedTo;
        }
    }
}
