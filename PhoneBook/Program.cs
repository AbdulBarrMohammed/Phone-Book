
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
            UserController.AddPhone();
            break;
        case MenuOptions.DeletePhone:
            UserController.DeletePhone();
            break;
        case MenuOptions.UpdatePhone:
            UserController.UpdatePhone();
            break;
        case MenuOptions.ViewAllPhones:
            var users = UserController.ViewAllPhones();
            UserInterface.ShowPhoneBookTable(users);
            break;
        case MenuOptions.ViewPhone:
            UserController.ViewPhone();
            break;
        case MenuOptions.Quit:
            isAppRunning = false;
            break;


    }



}
