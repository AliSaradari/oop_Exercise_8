using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise_8
{
    internal class NormalTask : Task , IShowTaskPriority
    {
        public NormalTask(string description, DateTime dateTime) : base(description, dateTime)
        {
        }

        public override void ShowTask()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            base.ShowTask();
            Console.ResetColor();
        }

        public void ShowTaskPriority(Priority priority)
        {
            Console.WriteLine($"Task Priority: {Priority}");
        }
    }
}
