using OOP_Exercise_8;

while (true)
{
    try
    {
        Run();
    }
    catch (Exception ex)
    {
        ShowError(ex.Message);
    }
}
static void Run()
{
    var menu = GetInt("Choose An Option:\n" +
    "1.Create ToDoList\n" +
    "2.Show ToDoList\n" +
    "3.Add Task\n" +
    "4.Change Task Status\n" +
    "0.Exit");
    switch (menu)
    {
        case 0:
            {
                Environment.Exit(0);
                break;
            }
            case 1:
            {
                var listCapacity = GetInt("Enter the number of tasks in the list:");
                List.CreateList(listCapacity);
                break;
            }
        case 2:
            {
                List.ShowList();
                break;
            }
            case 3:
            {
                var taskPriority = GetInt("Choose Task Priority:\n" +
                    "1.Normal Task\n2.Important Task\n3.Very Important Task");
                var taskDescription = GetString("Write Task Description:");
                var taskStatus = Status.NotDone;
                var taskDateTime = DateTime.Now;
                var taskNumber = GetInt("Enter Number of Task:");
                List.AddTask(taskPriority, taskDescription, taskStatus, taskDateTime, taskNumber);
                break;
            }
            case 4:
            {
                var taskNumber = GetInt("Enter Task Number:");
                var status = GetInt("Choose Status:\n" +
                    "1.Done\n" +
                    "2.Not Done");
                List.ChangeStatus(taskNumber, status);
                break;
            }
        default:
            {
                Console.WriteLine("Invalid Option, Please Try Again");
                break;
            }

    }
}
static string GetString(string message)
{
    Console.WriteLine(message);
    var input = Console.ReadLine();
    return input;
}
static int GetInt(string message)
{
    Console.WriteLine(message);
    var input = int.Parse(Console.ReadLine());
    return input;
}
static void ShowError(string message)
{
    Console.WriteLine("#############################");
    Console.WriteLine(message);
    Console.WriteLine("#############################");
}