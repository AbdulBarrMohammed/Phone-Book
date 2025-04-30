
using Microsoft.Identity.Client;
using PhoneBook;
using PhoneBook.Controller;
using Spectre.Console;

var isAppRunning = true;
while (isAppRunning)

{

    var option = AnsiConsole.Prompt(
        new SelectionPrompt<MenuOptions>()
        .Title("What would you like to do?")
        .AddChoices(
            MenuOptions.AddPhone,
            MenuOptions.DeletePhone,
            MenuOptions.UpdatePhone,
            MenuOptions.ViewAllPhones,
            MenuOptions.ViewPhone,
            MenuOptions.Quit
            )

    );


    switch (option)

    {
        case MenuOptions.AddPhone:
            UserService.InsertPhone();
            break;
        case MenuOptions.DeletePhone:
            UserService.DeletePhone();
            break;
        case MenuOptions.UpdatePhone:
            UserService.UpdateUser();
            break;
        case MenuOptions.ViewAllPhones:
            UserService.GetUsers();
            break;
        case MenuOptions.ViewPhone:
            UserService.GetUser();

            break;
        case MenuOptions.Quit:
            isAppRunning = false;
            break;


    }



}
