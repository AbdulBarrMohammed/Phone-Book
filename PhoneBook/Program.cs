
using PhoneBook;
using PhoneBook.Controller;
using Spectre.Console;

var isAppRunning = true;
UserController userController = new();
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
            userController.AddPhone();
            break;
        case MenuOptions.DeletePhone:
            userController.DeletePhone();
            break;
        case MenuOptions.UpdatePhone:
            userController.UpdatePhone();
            break;
        case MenuOptions.ViewAllPhones:
            userController.ViewAllPhones();
            break;
        case MenuOptions.ViewPhone:
            userController.ViewPhone();
            break;
        case MenuOptions.Quit:
            isAppRunning = false;
            break;


    }



}
