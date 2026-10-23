double IznosKamata(double glavnica, double stopa)
{
    double rezultat = glavnica * stopa / 100;
    return rezultat;
}

bool nastavi = true;
do
{
    Console.Write("Glavnica: ");
    string unos = Console.ReadLine();
    if (string.IsNullOrEmpty(unos))
        nastavi = false;
    else
    {
        bool ok = double.TryParse(unos, out double glavnica);
        if(!ok)
        {
            Console.WriteLine("Pogrešan format broja");
            continue;
        }
        if(glavnica < 0)
        {
            Console.WriteLine("Glavnica mora biti pozitivan broj");
            continue;
        }
        Console.Write("Stopa (0-20%): ");
        unos = Console.ReadLine();
        ok = double.TryParse(unos,out double stopa);
        if(!ok)
        {
            Console.WriteLine("Pogrešan format broja");
            continue;
        }
        if(stopa < 0 || stopa > 20)
        {
            Console.WriteLine("Stopa mora biti u rasponu 0-20");
            continue;
        }
        double kamata = IznosKamata(glavnica, stopa);
        Console.WriteLine($"Za glavnicu {glavnica:N2} i stopu {stopa} kamata je {kamata:N2}");
    }
}
while (nastavi);

