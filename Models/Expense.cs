namespace DataVerseManager.Models;

// Modellklass som representerar en utgift
public class Expense
{
    // Unikt ID – används för att identifiera objekt
    public Guid Id { get; set; } = Guid.NewGuid();

    // Namn / beskrivning av utgiften
    public string Title { get; set; }

    // Beloppet som spenderats
    public decimal Amount { get; set; }

    // Kategori, t.ex. Mat, Nöje, Hyra
    public string Category { get; set; }

    // Datum när utgiften skapades
    public DateTime Date { get; set; }
}
