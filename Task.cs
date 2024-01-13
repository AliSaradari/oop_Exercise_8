using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise_8
{
    public abstract class Task
    {
        private string _description;

        protected Task(string description, DateTime dateTime)
        {
            Description = description;
            DateTime = dateTime;
        }
        public Priority Priority { get; private set; }
        public string Description
        {
            get
            {
                return Description;
            }
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new Exception("Description Cannot Be Empty");
                }
                Description = value;
            }
        }
        public Status Status { get; private set; }
        public DateTime DateTime { get; set; }
        public virtual void ShowTask()
        {
            Console.WriteLine($"Description: {_description}\n" +
                $"Status: {Status}\n" +
                $"Date & Time: {DateTime}");
        }
        public void SetStatus(Status status)
        {
            Status = status;
        }
        public void SetPriority(Priority priority)
        {
            Priority = priority;
        }
    }
}
