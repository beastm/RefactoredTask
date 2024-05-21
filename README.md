# FujtajblRefactored


Komentáře v kódu jsou napsány v angličtině. 
Přestavěl jsem původní strukturu projektu, ale zachoval jsem stejnou logiku aplikace. 
Aplikace funguje jako kalkulačka, ale na rozdíl od původní aplikace se operátor zadává ručně. 
Po přečtení požadavků jsem se snažil dodržet principy SOLID:

*Single-responsibility - Každá třída má specifickou odpovědnost.
*Open-closed - Systém je otevřený pro rozšíření, ale uzavřený pro modifikace, což umožňuje přidávání nových funkcí bez změny stávajícího kódu.
*Liskov substitution - Vzhledem k tomu, že projekt nepoužívá dědičnost, není tento princip aplikován. Kód je však navržen tak, aby budoucí rozšíření a dědičnost byly možné bez narušení správnosti programu.
*Interface segregation - I bez použití rozhraní jsou třídy navrženy s úzkým zaměřením, aby každá třída měla jasně definovanou odpovědnost a klienti nebyli nuceni používat funkce, které nepotřebují.
*Dependency inversion - Moduly mohou byt zavisly na abstraktních třídách nebo jiných závislostech předaných přes konstruktor**.


**Vzhledem k malé funkcionalitě projektu nebyly použity rozhraní, protože by zbytečně zvýšily složitost. Přesto byla zachována struktura, která podporuje SOLID principy bez potřeby rozhraní.
