using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PhoneBook.Controller;
using PhoneBook.Model;
using Spectre.Console;

namespace PhoneBook
{
    static class UserService
    {
        public static User GetUserOptionInput()
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
