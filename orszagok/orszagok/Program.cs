using orszagok_Lib;

Orszagok orszagok = new(File.ReadAllLines("orszagok.csv").Skip(1));

Console.WriteLine($"{orszagok.Lenght()} adatait tároltuk!");

Console.WriteLine($"Az országok összterülete: {orszagok.SumArea():N0}, " +
    $"az országok összlakosság: {orszagok.SumPopulation():N0}");



Orszag legnagyobbTeruletuOrszag = orszagok.MaxArea();

Console.WriteLine($"A legnagyobb teruletu orszag: {legnagyobbTeruletuOrszag.Nev}");

Orszag legkevesebbLakosuOrszag = orszagok.MinPopulation();

Console.WriteLine($"A legkevesebb lakossal " +
    $"rendelkező ország fővárosa: {legkevesebbLakosuOrszag.Fovaros}");

Console.WriteLine($"{orszagok.CountStartsWithA()} db A betűvel kezdődő ország van.");




//Console.Write("Kérek egy orszag nevet:");
//string intputCountry = Console.ReadLine();

//Orszag keresetOrszag = orszagok.Contains(intputCountry);

//Console.WriteLine(keresetOrszag.Info());



Console.Write("Kérek egy számot: ");
uint intputNumber = uint.Parse(Console.ReadLine());

Console.WriteLine(string.Join(", ", orszagok.SmallerThan(intputNumber)));


File.WriteAllLines("kisebbMo.txt", orszagok.SmallerThanMo(93000));