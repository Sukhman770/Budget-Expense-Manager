# Budget & Expense Manager

## 📌 Beskrivning
Budget & Expense Manager är ett konsolbaserat C#-program som låter användaren hantera och analysera sina utgifter.  
Programmet använder **Spectre.Console** för ett färgrikt och användarvänligt terminal-UI samt **JSON** för datalagring.

Projektet är utvecklat objektorienterat och uppfyller kursens krav på generiska klasser, felhantering och arbete med kollektioner.

---

## 🛠 Funktioner
- Lägg till utgifter (titel, belopp, kategori, datum)
- Visa alla utgifter i tabellform
- Sök efter utgifter
- Visa enkel statistik (total summa)
- Automatisk sparning och laddning via JSON

---

## 🧱 Teknisk översikt
- **Språk:** C#
- **UI:** Spectre.Console
- **Lagring:** JSON (`System.Text.Json`)
- **Arkitektur:**
  - `Models` – datamodeller
  - `Services` – generisk datalagring
  - `UI` – menyer och tabeller
  - `Program.cs` – startpunkt och programloop

---

## ▶️ Körinstruktioner
1. Öppna projektet i Visual Studio  
2. Installera NuGet-paketet `Spectre.Console`
3. Kör programmet med **Start (▶)**

---

## 🎯 Kursmål som uppfylls
- Objektorienterad programmering
- Generiska klasser
- JSON-hantering
- Felhantering (try/catch)
- LINQ och kollektioner
- Konsolbaserat användargränssnitt
