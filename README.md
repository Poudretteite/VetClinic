# VetClinic

Desktopowa aplikacja do zarządzania kliniką weterynaryjną, napisana w C# (.NET 9, Windows Forms) z bazą danych PostgreSQL obsługiwaną przez Entity Framework Core.

Projekt powstał na zajęcia **Programowanie obiektowe 2** na Uniwersytecie Rzeszowskim (2025). Pełny opis klas i widoków znajduje się w pliku [Dokumentacja.pdf](Dokumentacja.pdf).

## Funkcje

- **Strona główna**: wykresy liczby wizyt w ostatnich miesiącach i stanu magazynowego leków oraz panel zmiany połączenia z bazą danych
- **Zwierzęta**: lista z wyszukiwarką, filtrowanie po typie, szczegóły, właściciel i historia wizyt
- **Właściciele**: dane kontaktowe i przypisane zwierzęta
- **Lekarze**: specjalizacja, tryb pracy (kliniczny / terenowy) i lista wizyt
- **Wizyty**: rejestrowanie wizyt z diagnozą i przepisanymi lekami
- **Leki i zamówienia**: stan magazynu i historia zamówień
- Dodawanie, edycja i usuwanie rekordów we wszystkich modułach
- Walidacja danych, m.in.:
  - poprawność adresu e-mail i wymagane pola,
  - maksymalnie 5 wizyt dziennie na jednego lekarza,
  - brak możliwości umawiania wizyt w weekendy
- Automatyczne migracje i wypełnianie pustej bazy przykładowymi danymi (Bogus)

## Technologie

| Obszar | Narzędzia |
|---|---|
| Język / platforma | C#, .NET 9 (`net9.0-windows`) |
| Interfejs | Windows Forms, WinForms.DataVisualization (wykresy) |
| Baza danych | PostgreSQL, Entity Framework Core 9 + Npgsql |
| Dane testowe | Bogus, Bogus.Healthcare |

## Model danych

| Tabela | Opis |
|---|---|
| `osoby` | właściciele zwierząt (imię, nazwisko, e-mail, telefon, data urodzenia) |
| `lekarze` | lekarze (dziedziczą po `Osoba`) ze specjalizacją i trybem pracy |
| `zwierzeta` | zwierzęta z typem, gatunkiem, wiekiem i właścicielem |
| `wizyty` | wizyty: zwierzę, lekarz, data, opis |
| `leki` | leki i ich ilość w magazynie |
| `zamowienia` | zamówienia leków |
| `WizytaLek` | tabela łącząca wizyty z lekami (relacja wiele-do-wielu) |

## Struktura projektu

```
VetClinic/
├── Data/            # AppDbContext
├── Forms/           # widoki (*View) i formularze dodawania (*AddForm)
├── Migrations/      # migracje EF Core
├── Models/          # encje: Osoba, Lekarz, Zwierze, Wizyta, Lek, Zamowienie
├── Seeders/         # generowanie przykładowych danych
├── AppDbContextFactory.cs
├── Constants.cs     # słowniki (typy zwierząt, diagnozy, leki) i połączenie z bazą
├── Program.cs       # punkt wejścia: migracje + seedowanie, start MainForm
└── appsettings.json # connection string
```

## Uruchomienie

### Wymagania

- Windows
- [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
- PostgreSQL działający lokalnie na porcie 5432
- Visual Studio 2022 (opcjonalnie)

### Kroki

1. Sklonuj repozytorium:
   ```bash
   git clone https://github.com/Poudretteite/VetClinic.git
   cd VetClinic
   ```
2. Utwórz w PostgreSQL pustą bazę `VetClinic`.
3. Ustaw dane logowania w `VetClinic/appsettings.json`:
   ```json
   "DefaultConnection": "Host=localhost;Port=5432;Database=VetClinic;Username=postgres;Password=TWOJE_HASLO"
   ```
   Domyślne dane połączenia są też w `Constants.cs` (`CurrentConnectionString`) i w panelu na stronie głównej, gdzie można je zmienić w trakcie działania aplikacji.
4. Uruchom aplikację:
   ```bash
   dotnet run --project VetClinic
   ```
   albo otwórz `VetClinic.sln` w Visual Studio i wciśnij F5.

Przy pierwszym starcie aplikacja sama wykona migracje i wypełni bazę przykładowymi danymi.

### Migracje (opcjonalnie)

Projekt zawiera lokalne narzędzie `dotnet-ef`:

```bash
dotnet tool restore
dotnet ef database update --project VetClinic
```

## Autorka

Natalia Skorupa. Projekt na przedmiot Programowanie obiektowe 2, prowadzący: mgr Wojciech Gałka.
