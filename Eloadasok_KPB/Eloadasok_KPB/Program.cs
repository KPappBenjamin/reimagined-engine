using Eloadasok_Lib;

Performances performances = new(File.ReadAllLines("jegyeladas.csv").Skip(1));

Console.WriteLine("2.feladat");
Console.WriteLine($"\tElőadások száma az évadban: {performances.Count}");

Console.WriteLine("3.feladat");
Performance mostExpensive = performances.MostExpesive();
Console.WriteLine($"\tA legdrágább előadás: {mostExpensive.Name}");
Console.WriteLine($"\tA jegy ára: {mostExpensive.CategoryPrice1} Ft");

Console.WriteLine("4.feladat");
Performance mostWatchedPerformace = performances.LeastAvailableSeats();
if (mostWatchedPerformace.FreeSeats != 0)
{
    Console.WriteLine($"\tA legnézettebb előadás: {mostWatchedPerformace.Name}, üres helyek száma: {mostWatchedPerformace.FreeSeats}");
}
else
{
    Console.WriteLine($"\tVolt teltházas előadás: {mostWatchedPerformace.Name}");
}

Console.WriteLine("5.feladat:");
foreach (var item in performances.DescendingByAudience())
{
    Console.WriteLine($"\t{item.Name} - nézők száma: {item.SumAudience} fő - bevétel: {item.Profit} Ft");
}

Console.WriteLine("6.feladat:");
Console.WriteLine($"\tDarabonkénti bevétel:");
foreach (var item in performances.ProfitPerPerformance())
{
    Console.WriteLine($"\t{item.Item1} - {item.Item2} Ft");
}

File.WriteAllLines("sokszor.txt",performances.PerformedMoreThanOnce());

Console.WriteLine("8.feladat:");
Console.WriteLine($"\tAz öt legolcsóbb előadás");
foreach (var item in performances.CheapestPerformaces(5))
{
    Console.WriteLine($"\t{item.Name} - {item.CategoryPrice2} Ft");
}

Console.WriteLine("9.feladat:");
Console.WriteLine(string.Join(", ", performances.AllPerformaceNames()));
