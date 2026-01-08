using DataVerseManager.Models;
using DataVerseManager.Services;
using DataVerseManager.UI;
using Spectre.Console;


// Skapar DataStore för Expense-objekt
var store = new DataStore<Expense>();

// Laddar data från JSON vid start
store.LoadFromJson("data.json");

// Visar en animerad titel
AnsiConsole.Write(
    new FigletText("DataVerse")
        .Centered()
        .Color(Color.Cyan)
);

bool running = true;

// Programloop
while (running)
{
    var choice = MenuUI.MainMenu();

    switch (choice)
    {
        case "Lägg till utgift":
            try
            {
                // Hämtar input från användaren
                var title = AnsiConsole.Ask<string>("Titel:");
                var amount = AnsiConsole.Ask<decimal>("Belopp:");
                var category = AnsiConsole.Ask<string>("Kategori:");

                // Skapar nytt Expense-objekt
                store.AddItem(new Expense
                {
                    Title = title,
                    Amount = amount,
                    Category = category,
                    Date = DateTime.Now
                });

                AnsiConsole.MarkupLine("[green]Utgift sparad![/]");
            }
            catch
            {
                // Felhantering vid ogiltig input
                AnsiConsole.MarkupLine("[red]Felaktig input[/]");
            }
            break;

        case "Visa alla":
            // Visar alla sparade utgifter
            TableUI.ShowExpenses(store.Items);
            break;

        case "Sök":
            // Söker med LINQ baserat på titel
            var keyword = AnsiConsole.Ask<string>("Sök titel:");
            var results = store.FindItems(
                e => e.Title.Contains(keyword)
            );
            TableUI.ShowExpenses(results);
            break;

        case "Statistik":
            // Summerar alla belopp med LINQ
            var total = store.Items.Sum(e => e.Amount);
            AnsiConsole.MarkupLine(
                $"[yellow]Totalt spenderat: {total} kr[/]"
            );
            break;

        case "Avsluta":
            // Sparar data vid avslut
            store.SaveToJson("data.json");
            running = false;
            break;
    }
}
