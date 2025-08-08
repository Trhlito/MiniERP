# MiniERP - Projekt

# ------------------	Konzolová aplikace (C#)		------------------
# --------------------------  ERP3  -------------------------------

Toto je jednoduchá WinForms aplikace, kterou jsem vytvořil jako menší domácí projekt na procvičení práce s C# a SQL Serverem. Snažil jsem se udělat jednoduchý _ERP systém__ (něco jako základní evidence) s moduly pro zákazníky, produkty, objednávky a správu skladu.

## Co aplikace umí:

- Přidávat, upravovat a mazat zákazníky
- Spravovat produkty (včetně kategorií a cen)
- Vytvářet objednávky (s výběrem zákazníka a produktů)
- Uchovávat historii objednávek
- Zobrazit a upravovat skladové množství

## Použité technologie

- **.NET 6 / C# (WinForms)**
- **SQL Server Express** (lokální instance)
- **Stored procedury + typy tabulek** (např. pro objednávky)

## Jak spustit

1. Otevřít projekt v **Visual Studio 2022+**
2. Ujistit se, že běží `SQL Server` a databáze `MiniERP` je dostupná
3. Spustit


# ---------------------		Přihlášení				---------------------

Pro vstup do aplikace použijte následující údaje:

- Uživatelské jméno: admin
- Heslo: admin




# ---------------------		Databáze				---------------------
# ---------------------		MiniERP					---------------------


## Databázová část – SQL Server

Pro backend jsem použil SQL Server Express (lokální instance `localhost\SQLEXPRESS`).  
Snažil jsem se o jednoduchou, ale trošku reálnější strukturu, kde má každá tabulka jasný účel a jsou mezi nimi vazby.

## Použité tabulky:

- `Customers` – zákazníci (ID, jméno, e-mail, telefon)
- `Products` – produkty (ID, název, cena, kategorie, sklad, kód)
- `Orders` – objednávky (napojené na zákazníka)
- `OrderItems` – položky objednávky (napojené na produkt a objednávku)

Každý produkt má i svůj **ProductCode**, který se generuje automaticky podle kategorie.



# ---------------------			Uložené procedury a typy ---------------------

## InsertProductWithCode
- Když přidávám nový produkt, tato procedura **automaticky vygeneruje kód** produktu na základě zvolené kategorie (např. `A1`, `B3`...).
- Používá se například ve formuláři `AddProductForm`.

## spCreateOrderWithItems
- Slouží pro uložení nové objednávky i s více položkami.
- Používá **typ tabulky `OrderItemType`**, který předávám jako parametr typu `READONLY`.

## OrderItemType
- Uživatelský typ tabulky: `ProductID`, `Quantity`, `UnitPrice`.
- Pomocí něj odesílám z WinForms najednou celý obsah objednávky.

## Spuštění

- Pro úspěšné spuštění je zde přiložen soubor s názvem: MiniERP_SQL 
- Pro načtení testovacích dat přiložen soubor s názvem: SQL_Prefab
