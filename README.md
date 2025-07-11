# ClientDataAnalysis

## Opis

## Projekt oparty na architekturze warstwowej:

ClientDataAnalysisSolution/
1. ClientDataAnalysis.API/                   # Web API (kontrolery, konfiguracja DI)
2. ClientDataAnalysis.Application/           # Logika biznesowa (Use Cases, interfejsy)
3. ClientDataAnalysis.Domain/                # Modele domenowe
4. ClientDataAnalysis.Infrastructure/        # Implementacje interfejsów (Zip, CSV, ClientData)
5. ClientDataAnalysis.Tests.Units/           # Testy jednostkowe
6. ClientDataAnalysis.Tests.Integrations/    # Testy Integracyjne

---

## Jak uruchomić?

1. Otwórz rozwiązanie w Visual Studio.
2. Ustaw projekt `ClientDataAnalysis.API` jako startowy.
3. Uruchom aplikację (F5 lub Ctrl+F5).
4. Przykładowy plik ZIP z danymi do testów jest dostępny pod adresem:  
   [sample-clients.zip](https://github.com/pwyrwas/ClientDataAnalysis/releases/download/1.0/sample-clients.zip)
5. Po uruchomieniu aplikacji Swagger uruchomi się automatycznie pod adresem:  
   `https://localhost:7130/swagger/index.html`

---

## Co można zmienić / ulepszyć?

- Rejestracja serwisów z wykorzystaniem Autofac (IModule) zamiast domyślnego DI.
- Dalsze rozdzielenie warstw i odpowiedzialności (np. lepsze enkapsulowanie implementacji w Infrastructure).
- Dodanie obsługi większej ilości formatów plików.
- Rozbudowa testów jednostkowych i integracyjnych.
- Dodanie warstwy Cache dla pobieranych danych.

---