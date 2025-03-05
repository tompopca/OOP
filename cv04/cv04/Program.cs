




string testovaciText = "Toto je retezec predstavovany nekolika radky,\n"
+ "ktere jsou od sebe oddeleny znakem LF (Line Feed).\n"
+ "Je tu i nejaky ten vykricnik! Pro ucely testovani i otaznik?\n"
+ "Toto je jen zkratka zkr. ale ne konec vety. A toto je\n"
+ "posledni veta!";

Console.WriteLine(testovaciText);
Console.WriteLine();


StringStatistics s = new StringStatistics(testovaciText);

Console.WriteLine("Počet slov:" + s.PocetSlov());
Console.WriteLine("Počet řádků:" + s.PocetRadku());
Console.WriteLine("Počet vět:" + s.PocetVet());
Console.WriteLine("Nejdelší slovo: " + s.NejdelsiSlovo());
Console.WriteLine("Nejkratší slova: " + s.NejkratsiSlova());
Console.WriteLine("Nejčastější slova: " + s.NejcastejsiSlovo());
Console.WriteLine("Slova podle abecedy: " + s.Abeceda());

Console.ReadLine();
