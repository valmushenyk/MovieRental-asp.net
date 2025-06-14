# Wypożyczalnia Filmów – ASP.NET MVC

## Opis projektu

Aplikacja internetowa stworzona z wykorzystaniem frameworka ASP.NET MVC służy do zarządzania wypożyczalnią filmów. Umożliwia przeglądanie filmów, dodawanie nowych pozycji oraz zarządzanie dostępnością. Projekt bazuje na szablonie Visual Studio i wykorzystuje podejście Code First z użyciem Entity Framework.

## Zastosowanie biznesowe

Aplikacja może być wykorzystywana przez:

- Wypożyczalnie filmów
- Biblioteki publiczne z sekcją filmów
- Lokalne kluby i centra społecznościowe
- Małe firmy świadczące usługi wypożyczania

Funkcjonalność pozwala m.in. na:
- Śledzenie dostępnych i wypożyczonych filmów
- Efektywne zarządzanie zasobami
- Intuicyjny interfejs dla pracowników

## Główne funkcjonalności

- Przeglądanie dostępnych filmów
- Dodawanie i edytowanie informacji o filmach
- Wypożyczanie i zwracanie filmów
- Panel główny z listą dostępnych oraz wypożyczonych filmów
- Walidacja danych
- Responsywny interfejs

## Struktura i komponenty

### Modele
- Movie – film (Id, Tytuł, Opis, Gatunek, Cena, Dostępność)
- AddMovieViewModel – formularz do dodawania filmów

### Kontrolery
- MovieController – pełna obsługa CRUD dla filmów
- HomeController – nawigacja i strona główna

### Widoki
- Index – lista filmów
- Create – formularz dodawania filmu
- Rented – filmy wypożyczone

### Baza danych
- Podejście Code First
- Automatyczne tworzenie schematu i danych początkowych
- Diagram dostępny w dokumentacji

## Nawigacja

- Home – strona główna
- Available Movies – dostępne filmy
- My Rented Movies – filmy wypożyczone
- Add Movie – dodaj film
- Documentation – dokumentacja projektu

## Technologie

- ASP.NET MVC 5
- C#
- Entity Framework
- SQL Server
- Bootstrap 5
- Visual Studio 2022

## Autorki projektu

Projekt został stworzony przez trzy studentki Akademii Górniczo-Hutniczej w Krakowie, kierunek Informatyka i Ekonometria:

- Gabriela – logika aplikacji (kontrolery, modele, operacje CRUD)
- Valeriya – baza danych, konfiguracja, integracja
- Julia – interfejs użytkownika (widoki, stylizacja, dokumentacja)

## Jak uruchomić projekt?

1. Otwórz plik `Project.sln` w Visual Studio.
2. Przywróć zależności NuGet.
3. Uruchom migracje bazy danych (jeśli wymagane).
4. Wybierz IIS Express i uruchom aplikację.

## Dokumentacja

Szczegółowa dokumentacja znajduje się w pliku `documentation.html`, zawiera:
- Opisy modeli i kontrolerów
- Schemat bazy danych
- Zrzuty ekranu widoków
- Podział pracy zespołowej
