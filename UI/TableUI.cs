using Spectre.Console;
using DataVerseManager.Models;

namespace DataVerseManager.UI;

// Ansvarar för att visa data i tabellform
public static class TableUI
{
    public static void ShowExpenses(List<Expense> expenses)
    {
        // Skapar en tabell med rundade kanter
        var table = new Table()
            .Border(TableBorder.Rounded)
            .AddColumn("Titel")
            .AddColumn("Belopp")
            .AddColumn("Kategori")
            .AddColumn("Datum");

        // Lägger till varje utgift som en rad
        foreach (var e in expenses)
        {
            table.AddRow(
                e.Title,
                $"{e.Amount} kr",
                e.Category,
                e.Date.ToShortDateString()
            );
        }

        // Skriver ut tabellen i konsolen
        AnsiConsole.Write(table);
    }
}
