bool nastavi = true;
do
{
    Console.Write("Unesi broj elemenata polja (1-100): ");
    string unos = Console.ReadLine();
    if (string.IsNullOrEmpty(unos))
        nastavi = false;
    else
    {
        bool ok = int.TryParse(unos, out int brojElemenata);
        if(!ok)
        {
            Console.WriteLine("Broj je u pogrešnom formatu");
            continue;
        }
        if(brojElemenata < 1 || brojElemenata > 100)
        {
            Console.WriteLine("Broj je izvan raspona");
            continue;
        }
        int[] brojevi = new int[brojElemenata];
        int i = 0;
        while (i < brojElemenata)
        {
            Console.Write($"Element{i+1}: ");
            unos = Console.ReadLine();
            ok = int.TryParse(unos, out brojevi[i]);
            if(!ok)
            {
                Console.WriteLine("Pogrešan format");
                continue;
            }
            i++;
        }
        Console.Write("Unijeli ste sljedeće polje: ");
        foreach (var broj in brojevi)
        {
            Console.Write($"{broj} ");
        }
        Console.WriteLine();
        int zbroj = 0;
        int najmanji = brojevi[0];
        int najveci = brojevi[0];
        foreach (var broj in brojevi)
        {
            zbroj += broj;
            if (broj < najmanji)
                najmanji = broj;
            if (broj > najveci)
                najveci = broj;
        }
        double prosjek = zbroj * 1.0 / brojElemenata;
        Console.WriteLine($"Zbroj je {zbroj}, najmanji element je {najmanji}, najveći element je {najveci} i prosjek je {prosjek:N2}");

        Console.Write("Sortirano polje je: ");
        Array.Sort(brojevi);        
        foreach (var broj in brojevi)
        {
            Console.Write($"{broj} ");
        }
        Console.WriteLine();
    }
}
while (nastavi);
