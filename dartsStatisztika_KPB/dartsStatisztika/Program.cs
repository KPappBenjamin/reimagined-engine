using dartsStatisztika_Lib;

Rounds korok = new(File.ReadAllLines("dobasok.txt"));

Console.WriteLine("2. feladat");
Console.WriteLine($"Körök száma: {korok.NumberOfRounds}");

Console.WriteLine("3. feladat");
Console.WriteLine($"3. dobásra Bullseye: {korok.CountBullseyeOnThirdThrow}");

Console.WriteLine("4. feladat");
Console.Write("Adja meg a szektor értékét! Szektor= ");
string givenSector = Console.ReadLine();

Console.WriteLine($"Az 1. játékos a (z) {givenSector} szektoros dobásainak száma: {korok.CountPlayerSpecificSectorThrow(1,givenSector)}");
Console.WriteLine($"A 2. játékos a (z) {givenSector} szektoros dobásainak száma: {korok.CountPlayerSpecificSectorThrow(2, givenSector)}");

Console.WriteLine("5. feladat");
Console.WriteLine($"Az 1. játékos {korok.CountPlayerMaxPossibleThrow(1)} db 180-ast dobott.");
Console.WriteLine($"A 2. játékos { korok.CountPlayerMaxPossibleThrow(2)} db 180-ast dobott.");