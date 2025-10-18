# ChessBoard 2.0

Ett C#-program som genererar ett N×N schackbräde i konsolen.

## Beskrivning

Programmet låter användaren mata in en storlek (3-50) och skriver sedan ut ett schackbräde med svarta ◼︎) och vita (◻︎) rutor i ett klassiskt schackbrädesmönster.

## Hur man kör programmet

### Förutsättningar
- Visual Studio 2022 eller senare
- .NET 8.0

### Steg för att köra:

1. Klona repositoryt:
```bash
git clone https://github.com/exikoz/ChessBoard2.0.git
```

2. Öppna `ChessBoard2.0.sln` i Visual Studio

3. Tryck på `F5` eller klicka på "Start" för att köra programmet

4. Följ instruktionerna i konsolen:
   - Ange en siffra mellan 3 och 50
   - Schackbrädet kommer att visas

## Exempel

### Input: 5
```
◼︎◻︎◼︎◻︎◼︎
◻︎◼︎◻︎◼︎◻︎
◼︎◻︎◼︎◻︎◼︎
◻︎◼︎◻︎◼︎◻︎
◼︎◻︎◼︎◻︎◼︎
```

## Teknisk implementation

Programmet använder:
- **Validering**: `int.TryParse()` för säker input-hantering
- **Mönster**: `(row + col) % 2` för att växla mellan svarta och vita rutor
- **Unicode-stöd**: `Console.OutputEncoding` för korrekta tecken

## AI-användning

Under utvecklingen användes **Claude** för:
- Hjälp med input-validering och `TryParse()`
- Förklaring av modulo-operator för schackbrädesmönster
- Tips om Unicode-stöd i C#-konsolen

## Struktur
```
ChessBoard2.0/
├── ChessBoard2.0.sln
├── README.md
└── ChessBoard2.0/
    └── Program.cs
```

## Författare

Hussein Hasnawy