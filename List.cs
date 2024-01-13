using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise_8
{
    public static class List
    {
        private static List<ListItem> _toDoList = new();
        public static void CreateList(int capacity)
        {
            for (int i = 1; i <= capacity; i++)
            {
                var item = new ListItem(i);
                _toDoList.Add(item);
            }
        }
        public static void ShowList()
        {
            foreach (var item in _toDoList)
            {
                Console.WriteLine("--------------------");
                Console.WriteLine($"Task {item.Number}:");
                if (item.Task == null)
                {
                    Console.WriteLine("Null");
                }
                if (item.Task != null)
                {
                    item.Task.ShowTask();
                }
                Console.WriteLine("--------------------");

            }
        }
        public static void AddTask(int taskPriority, string description, Status status, DateTime dateTime, int taskNumber)
        {
            switch (taskPriority)
            {
                case 1:
                    {

                        var task = new NormalTask(description, dateTime);
                        task.SetStatus(status);
                        task.SetPriority(Priority.Low);
                        var item = _toDoList.Single(_ => _.Number == taskNumber);
                        item.Task = task;
                        break;
                    }
                case 2:
                    {

                        var task = new ImportantTask(description, dateTime);
                        task.SetStatus(status);
                        task.SetPriority(Priority.Medium);
                        var item = _toDoList.Single(_ => _.Number == taskNumber);
                        item.Task = task;
                        break;
                    }
                case 3:
                    {

                        var task = new VeryImportantTask(description, dateTime);
                        task.SetStatus(status);
                        task.SetPriority(Priority.High);
                        var item = _toDoList.Single(_ => _.Number == taskNumber);
                        item.Task = task;
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid Option");
                        break;
                    }

            }

        }
        public static void ChangeStatus(int taskNumber, int statusOption)
        {
            switch (statusOption)
            {
                case 1:
                    {
                        var item = _toDoList.Single(_ => _.Number == taskNumber);
                        item.Task.SetStatus(Status.Done);
                        break;
                    }
                case 2:
                    {
                        var item = _toDoList.Single(_ => _.Number == taskNumber);
                        item.Task.SetStatus(Status.NotDone);
                        break;
                    }
            }

        }


    }
}
