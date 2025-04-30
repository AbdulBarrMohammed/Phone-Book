using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Identity.Client;
using PhoneBook.Controller;
using PhoneBook.Model;
using Spectre.Console;

namespace PhoneBook
{
    static class UserService
    {
        internal static void InsertPhone()
        {
            var name = AnsiConsole.Ask<string>("User name: ");
            var email = AnsiConsole.Ask<string>("User email: ");
            var phoneNumber = AnsiConsole.Ask<string>("User phone number: ");

            UserController.AddPhone(name, email, phoneNumber);
        }
        internal static void DeletePhone()
        {
            var user = GetUserOptionInput();
            UserController.DeletePhone(user);
        }

        internal static void GetUsers()
        {
            var users = UserController.ViewAllPhones();
            UserInterface.ShowPhoneBookTable(users);
        }

        internal static void GetUser()
        {
            var user = UserService.GetUserOptionInput();
            UserInterface.ShowUser(user);
        }
        internal static void UpdateUser()
        {
            var user = GetUserOptionInput();
            user.Name = AnsiConsole.Ask<string>("User name: ");
            user.Email = AnsiConsole.Ask<string>("User email: ");
            user.PhoneNumber = AnsiConsole.Ask<string>("User phone number: ");
            UserController.UpdatePhone(user);
        }
        private static User GetUserOptionInput()
        {
            var users = UserController.ViewAllPhones();
            var userArray = users.Select(x => x.Name).ToArray();
            var option = AnsiConsole.Prompt(new SelectionPrompt<string>()
            .Title("Choose User Phone Book")
            .AddChoices(userArray));

            var id = users.Single(x => x.Name == option).Id;
            var user = UserController.GetPhoneById(id);

            return user;
        }
    }
}
