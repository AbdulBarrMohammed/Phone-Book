using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using PhoneBook.Model;
using Spectre.Console;

namespace PhoneBook
{
    static class UserInterface
    {
        public static void ShowPhoneBookTable(List<User> users)
        {
            var table = new Table();
            table.AddColumn("Name");
            table.AddColumn("Id");
            table.AddColumn("Email");
            table.AddColumn("PhoneNumber");

            foreach (var user in users)
            {
                table.AddRow(user.Id.ToString(), user.Name, user.Email, user.PhoneNumber);
            }

            AnsiConsole.Write(table);

            Console.WriteLine("Enter any key to continue");
            Console.ReadLine();




        }
    }
}
