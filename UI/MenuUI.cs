using Spectre.Console;

namespace DataVerseManager.UI;

// Ansvarar endast för menyer och val
public static class MenuUI
{
    // Visar huvudmenyn och returnerar användarens val
    public static string MainMenu()
    {
        return AnsiConsole.Prompt(
            new SelectionPrompt<string>()
                .Title("[cyan]Budget Manager[/]")
                .AddChoices(
                    "Lägg till utgift",
                    "Visa alla",
                    "Sök",
                    "Statistik",
                    " Avsluta"
                ));
    }
}
