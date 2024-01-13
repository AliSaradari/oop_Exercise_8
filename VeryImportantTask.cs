using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise_8
{
    public class VeryImportantTask : Task , IShowTaskPriority
    {
        public VeryImportantTask(string description, DateTime dateTime) : base(description, dateTime)
        {
        }

        public override void ShowTask()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            base.ShowTask();
            Console.ResetColor();
        }

        public void ShowTaskPriority(Priority priority)
        {
            Console.WriteLine($"Task Priority: {Priority}");
        }
    }
}
