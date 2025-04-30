
using PhoneBook;
using Spectre.Console;

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
