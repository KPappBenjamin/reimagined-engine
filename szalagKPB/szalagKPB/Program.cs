using szalagLib;

Rekeszek rekeszek = new(File.ReadAllLines("szallit.txt"));

Console.WriteLine("2. feladat");
Console.Write("Adja meg, melyik adatsorra kíváncsi! ");
int bekertSorszam = int.Parse(Console.ReadLine());
Rekesz bekertSorszamuRekesz = rekeszek.RekeszKereso(bekertSorszam);
Console.WriteLine($"Honnan: {bekertSorszamuRekesz.Honnan} Hova: {bekertSorszamuRekesz.Hova}\n");


Console.WriteLine("3. feladat");
int legnagyobbTavolsag = rekeszek.LegnagyobbTavolsag();
Console.WriteLine($"A legnagyobb távolság: {legnagyobbTavolsag}");
Console.WriteLine($"A maximális távolságú szállítások sorszáma: " +
    string.Join(" ", rekeszek.IndexKereseseTavMegtetelAlapjan(legnagyobbTavolsag)));
Console.WriteLine("");

Console.WriteLine("4. feladat");
Console.WriteLine($"A kezdőpont előtt elhaladó rekeszek össztömege: {rekeszek.KezdoPontElottElhaladtRekeszekTomege()}\n");

Console.WriteLine("5. feladat");
Console.Write("Adja meg a kívánt időpontot! ");
int bekertIdopont = int.Parse(Console.ReadLine());
Console.WriteLine("A szállított rekeszek halmaza:" +
    string.Join(" ", rekeszek.RekeszekIndexeAmiketEppenSzallitanak(bekertIdopont)));

File.WriteAllLines("tomeg.txt",rekeszek.Tomeg.Select(x => $"{x.Item1} {x.Item2}"));