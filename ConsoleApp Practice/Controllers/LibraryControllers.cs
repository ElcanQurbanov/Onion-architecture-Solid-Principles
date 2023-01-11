using DomainLayer.Entities;
using ServiceLayer.Helpers;
using ServiceLayer.Services;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Practice.Controllers
{
    public class LibraryControllers
    {

        private readonly ILibraryService _libraryService;

        public LibraryControllers()
        {
            _libraryService = new LibraryService();
        }

        public void Create()
        {
            ConsoleColor.DarkCyan.WriteConsole("Please add library name:");
            LibraryName: string libraryName = Console.ReadLine();

            ConsoleColor.Red.WriteConsole("Please add library seat count");
            SeatCount: string seatCountStr = Console.ReadLine();

            int seatCount;

            bool isCorrectSeatCount = int.TryParse(seatCountStr, out seatCount);

            if (isCorrectSeatCount)
            {
                try
                {

                    Library library = new Library
                    {
                        Name = libraryName,
                        SeatCount = seatCount
                    };

                    var response = _libraryService.Create(library);

                    ConsoleColor.Green.WriteConsole($"{response.Id} {response.Name} {response.SeatCount}");
                }
                catch (Exception ex)
                {

                    ConsoleColor.Red.WriteConsole(ex.Message + "/" + "Please try again");
                    goto LibraryName;
                }
            }
            else
            {
                ConsoleColor.Red.WriteConsole("Please add correct format seat count");
                goto SeatCount;
            }
        }
    }
}
