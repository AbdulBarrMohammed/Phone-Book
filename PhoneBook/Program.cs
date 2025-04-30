
using PhoneBook;
using PhoneBook.Controller;
using Spectre.Console;

var isAppRunning = true;
PhoneController phoneController = new();
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
            phoneController.AddPhone();
            break;
        case MenuOptions.DeletePhone:
            phoneController.DeletePhone();
            break;
        case MenuOptions.UpdatePhone:
            phoneController.UpdatePhone();
            break;
        case MenuOptions.ViewAllPhones:
            phoneController.ViewAllPhones();
            break;
        case MenuOptions.ViewPhone:
            phoneController.ViewPhone();
            break;
        case MenuOptions.Quit:
            isAppRunning = false;
            break;


    }



}
