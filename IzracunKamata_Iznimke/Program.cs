double IznosKamata(double glavnica, double stopa)
{
    if (glavnica < 0)
        throw new ArgumentOutOfRangeException("Glavnica mora biti pozitivna");
    if (stopa < 0 || stopa > 20)
        throw new ArgumentOutOfRangeException("Stopa mora biti 0-20");
    double rezultat = glavnica * stopa / 100;
    return rezultat;
}

bool nastavi = true;
do
{
    try
    {
        Console.Write("Glavnica: ");
        string unos = Console.ReadLine();
        if (string.IsNullOrEmpty(unos))
            nastavi = false;
        else
        {
            bool ok = double.TryParse(unos, out double glavnica);
            if (!ok)
            {
                Console.WriteLine("Pogrešan format broja");
                continue;
            }
            Console.Write("Stopa (0-20%): ");
            unos = Console.ReadLine();
            ok = double.TryParse(unos, out double stopa);
            if (!ok)
            {
                Console.WriteLine("Pogrešan format broja");
                continue;
            }
            double kamata = IznosKamata(glavnica, stopa);
            Console.WriteLine($"Za glavnicu {glavnica:N2} i stopu {stopa} kamata je {kamata:N2}");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Dogodila se pogreška. Tekst: {ex.Message}");
    }
}
while (nastavi);
