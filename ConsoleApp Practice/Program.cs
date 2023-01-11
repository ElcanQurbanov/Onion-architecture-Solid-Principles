





using ConsoleApp_Practice.Controllers;
using ServiceLayer.Helpers;

LibraryControllers libraryControllers = new();

while (true)
{

    //ConsoleColor.Cyan.WriteConsole("Please select one option: ");
    //ConsoleColor.Cyan.WriteConsole("Library options: 1- Create, 2 - Get all, 3 - Delete");

    GetOptions();

    Option: string option = Console.ReadLine();

    int selectedOption;

    bool isCorrectOption = int.TryParse(option, out selectedOption);

    if (isCorrectOption)
    {
        switch (selectedOption)
        {
            case 1:
                libraryControllers.Create();
                break;
            case 2:
                Console.WriteLine("Get all");
                break;
            case 3:
                Console.WriteLine("Delete");
                break;
            default:
                ConsoleColor.Red.WriteConsole("Please add correct option");
                goto Option;        
        }
    }
    else
    {
        ConsoleColor.Red.WriteConsole("Please add correct format option");
        goto Option;
    }

}


static void GetOptions()
{
    ConsoleColor.Cyan.WriteConsole("Please select one option: ");
    ConsoleColor.Cyan.WriteConsole("Library options: 1- Create, 2 - Get all, 3 - Delete");
}


