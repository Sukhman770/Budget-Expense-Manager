using System.Text.Json;

namespace DataVerseManager.Services;

// Generisk klass som kan lagra vilken datatyp som helst
public class DataStore<T>
{
    // Lista som håller alla objekt av typen T
    public List<T> Items { get; private set; } = new();

    // Lägger till ett objekt i listan
    public void AddItem(T item)
    {
        Items.Add(item);
    }

    // Tar bort ett objekt baserat på ett villkor
    public void RemoveItem(Predicate<T> predicate)
    {
        var item = Items.Find(predicate);
        if (item != null)
            Items.Remove(item);
    }

    // Söker och filtrerar data med LINQ
    public List<T> FindItems(Func<T, bool> predicate)
    {
        return Items.Where(predicate).ToList();
    }

    // Sparar listan till en JSON-fil
    public void SaveToJson(string path)
    {
        try
        {
            var json = JsonSerializer.Serialize(
                Items,
                new JsonSerializerOptions { WriteIndented = true }
            );

            File.WriteAllText(path, json);
        }
        catch (Exception ex)
        {
            // Fångar fel vid filhantering
            throw new Exception("Kunde inte spara data", ex);
        }
    }

    // Läser in data från JSON-fil
    public void LoadFromJson(string path)
    {
        try
        {
            if (!File.Exists(path))
                return;

            var json = File.ReadAllText(path);

            // Om filen är tom eller felaktig → ny lista
            Items = JsonSerializer.Deserialize<List<T>>(json) ?? new();
        }
        catch (Exception ex)
        {
            throw new Exception("Kunde inte läsa data", ex);
        }
    }
}
