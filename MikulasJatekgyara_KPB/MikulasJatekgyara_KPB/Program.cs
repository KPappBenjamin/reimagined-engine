using MikulasJatekgyara_Lib;

File.Delete("hibalista.txt");

GyartasAdatok gyartasAdatok = new(GyartasAdatokBeolvasasa("gyartas.txt"));

Console.WriteLine($"Elérhető gyártás azonosítók: " +
    $"{string.Join("; ", gyartasAdatok.ElerhetoGyartasAzonositok)}");
Console.WriteLine();

Jatekok gyartottJatekok = new(AjandekokBeolvasasa("ajandekok.txt"));

Console.WriteLine($"A gyártott játékok: " +
    $"{string.Join(", ", gyartottJatekok.JatekTipusok)}");
Console.WriteLine();

Feladatok feladatok = FeladatokHozzaadasa(FeladatokBeolvasasa("feladatok.txt"));

Console.WriteLine("Az elvégezhető feladatok:");
foreach(var item in feladatok.FeladatLista)
{
    Console.WriteLine("\t"+item);    
}
Console.WriteLine();

Console.WriteLine("Játékonként a készítendő darabszámok:");
foreach(var item in feladatok.FeladatLista.GroupBy(x=>x.JatekTipus.Megnevezes))
{
    Console.WriteLine($"\t{item.Key}: {item.Sum(x=>x.Darabszam)} db");
}


IEnumerable<GyartasAdat> GyartasAdatokBeolvasasa(string fajnev)
{
    foreach(var gyartasAdat in File.ReadAllLines(fajnev).Skip(1))
    {
        string[] adatok = gyartasAdat.Split(';');
        yield return new GyartasAdat(adatok[0], adatok[1], int.Parse(adatok[2]));
    }
}

IEnumerable<Jatek> AjandekokBeolvasasa(string fajnev)
{
    foreach(var jatek in File.ReadAllLines(fajnev).Skip(1))
    {
        yield return JatekFactory.Factory(jatek, gyartasAdatok);
    }
}

IEnumerable<Feladat> FeladatokBeolvasasa(string fajnev)
{
    foreach(var item in File.ReadAllLines(fajnev).Skip(1))
    {
        string[] adatok = item.Split(";");
        Jatek? jatek = gyartottJatekok[adatok[0]];
        int darabszam = int.Parse(adatok[1]);
        if (jatek is null)
        {
            File.AppendAllText("hibalista.txt", 
                $"{adatok[0]}: Ilyen azonosítójú játékot nem gyártanak\n");
        }
        else
        {
            Feladat? feladat = null;
            try
            {
                feladat = new(jatek, darabszam);
            }
            catch (TulSokFeladatException ex)
            {
                File.AppendAllText("hibalista.txt", $"{ex.Message} - " +
                    $"{darabszam} db {jatek.Megnevezes}: {jatek.ElkeszitesiIdo*darabszam} perc\n");
            }
            if (feladat is not null)
                yield return feladat;
        }
    }
}

Feladatok FeladatokHozzaadasa(IEnumerable<Feladat> beolvasottFeladatok)
{
    Feladatok feladatok = new();
    foreach(var feladat in beolvasottFeladatok)
    {
        feladatok += feladat;
    }
    return feladatok;
}