# planer budzetowy 
### Prosta aplikacja do zarządzania swoimi wydatkami WPF C#

<img width="711" alt="1zaliczenie" src="https://user-images.githubusercontent.com/94643456/224173729-fbdec516-e1e4-4936-80a4-4dedafe302b5.PNG">

## Interfejs użytkownika:
* Okno główne z zakładkami dla różnych funkcji (np. "Wprowadzanie wydatków", "Przeglądanie budżetu", "Statystyki")
* Wprowadzanie wydatków: Formularz z polami na wprowadzanie informacji o wydatkach (data, kategoria, kwota, notatki itp.) i przyciskiem "Dodaj wydatek".
* Przeglądanie budżetu: Tabela lub lista wydatków z widocznymi kolumnami dla daty, kategorii, kwoty i notatek. Użytkownik może sortować wydatki według różnych kolumn i filtrować je według daty, kategorii itp.
* Statystyki: Wykresy i diagramy prezentujące informacje o wydatkach, takie jak wydatki w poszczególnych kategoriach lub wydatki w określonym okresie czasu.

## Struktura kodu:
* Klasa MainWindow, która jest głównym oknem aplikacji i zawiera zakładki dla różnych funkcji.
* Klasa Expense, która reprezentuje pojedynczy wydatek i zawiera pola takie jak data, kategoria, kwota i notatki.
* Klasa ExpensesDatabase, która przechowuje listę wydatków i umożliwia dodawanie, usuwanie i przeglądanie wydatków.
* Klasa ExpenseViewModel, która jest pośrednikiem między klasą MainWindow a klasą ExpensesDatabase. Zawiera metody i właściwości umożliwiające wykonywanie różnych działań na wydatkach, takich jak dodawanie, usuwanie, sortowanie i filtrowanie.
* Klasa ChartViewModel, która zawiera dane i metody potrzebne do tworzenia wykresów i diagramów.

## Funkcjonalność aplikacji:
* Dodawanie wydatków: Użytkownik wprowadza informacje o wydatkach w formularzu, a następnie naciska przycisk "Dodaj wydatek". Wydatki są przechowywane w bazie danych ExpensesDatabase.
* Przeglądanie wydatków: Użytkownik wybiera zakładkę "Przeglądanie budżetu", a następnie przegląda wydatki w tabeli lub liście. Użytkownik może sortować i filtrować wydatki według różnych kryteriów.
* Tworzenie wykresów i diagramów: Użytkownik wybiera zakładkę "Statystyki", a następnie przegląda wykresy i diagramy prezentujące informacje o wydatkach. Użytkownik może wybrać okres czasu i kategorię, dla której chce wyświetlić informacje.

## Inspiracja:
(https://www.youtube.com/watch?v=PzP8mw7JUzI&t=223s&ab_channel=Payload)
