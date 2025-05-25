namespace ToDoListApp
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Welcome to first To Do List application");
            List<string> taskList = new List<string>();
            string option = "";

            while (option != "e") {
                Console.WriteLine("Enter option 1 to enter item into task list");
                Console.WriteLine("Enter option 2 to remove item from task list");
                Console.WriteLine("Enter option 3 to show item of task list");
                Console.WriteLine("Enter option e to exit form application");

                option = Console.ReadLine();

                if (option == "1")
                {
                    Console.WriteLine("Please enter the name of task to add into list");
                    string task = Console.ReadLine();
                    taskList.Add(task);
                    Console.WriteLine("Task added into list succesfully!!!");
                }
                else if (option == "2")
                {
                    for (int i = 0; i < taskList.Count; i++)
                    {
                        Console.WriteLine(i + " : " + taskList[i]);
                    }
                    Console.WriteLine("Please enter task number of task to remove from list");
                    int taskNumber = Convert.ToInt32(Console.ReadLine());
                    taskList.RemoveAt(taskNumber);
                }
                else if (option == "3")
                {
                    Console.WriteLine("Current Task in taskList :");
                    for (int i = 0; i < taskList.Count; i++)
                    {
                        Console.WriteLine(taskList[i]);
                    }
                }
                else if (option == "e")
                {
                    Console.WriteLine("Exit the Program...");
                }
                else
                {
                    Console.WriteLine("Invalid Input... \n Please try agian...");
                }

            }
        }

    }
}