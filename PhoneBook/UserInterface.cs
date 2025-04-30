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
        internal static void ShowPhoneBookTable(List<User> users)
        {
            var table = new Table();
            table.AddColumn("Id");
            table.AddColumn("Name");
            table.AddColumn("Email");
            table.AddColumn("PhoneNumber");

            foreach (var user in users)
            {
                table.AddRow(user.Id.ToString(), user.Name, user.Email, user.PhoneNumber);
            }

            AnsiConsole.Write(table);

            Console.WriteLine("Enter any key to continue");
            Console.ReadLine();
            Console.Clear();




        }

        internal static void ShowUser(User user)
        {
            var panel = new Panel($@"Id: {user.Id} Name: {user.Name}
             Email: {user.Email} PhoneNumber: {user.PhoneNumber}");

            panel.Header = new PanelHeader("User Phonebook Info");
            panel.Padding = new Padding(2, 2, 2, 2);

            AnsiConsole.Write(panel);
            Console.WriteLine("Enter any key to continue");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
