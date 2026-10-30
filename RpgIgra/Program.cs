(int hpIgrac, int hpCudoviste) Napad(Random random, int hpIgrac, int hpCudoviste, bool kriticniUdarac)
{

    int stetaIgrac = random.Next(2, 15);
    int stetaCudoviste = random.Next(2, 11);
    if(kriticniUdarac)
    {
        int sansaKriticni = random.Next(1, 3);
        if (sansaKriticni == 1)
            stetaIgrac *= 2;
    }
    hpIgrac -= stetaCudoviste;
    hpCudoviste -= stetaIgrac;

    Console.WriteLine($"Nanijeli ste štetu {stetaIgrac} a čudovište vas je ranilo za {stetaCudoviste}. Zdravlje igrača: {hpIgrac}, zdravlje čudovišta {hpCudoviste}");
    return (hpIgrac, hpCudoviste);
}

bool nastavi = true;
Random random = new Random();
do
{
    Console.WriteLine("Mini Rpg igra. Unesite a za obični napad, k za kritični udarac, n za novu igru ili ništa za kraj");
    int hpIgrac = 50;
    int hpCudoviste = 40;
    while(hpIgrac > 0 && hpCudoviste > 0)
    {
        Console.Write("Unesite potez: ");
        string potez = Console.ReadLine();
        if(string.IsNullOrEmpty(potez))
        {
            nastavi = false;
            break;
        }
        if(potez == "n")
        {
            break;
        }
        if (potez != "a" && potez != "k")
            continue;
        (int hpIgrac, int hpCudoviste) rezultat = Napad(random, hpIgrac, hpCudoviste, potez == "k");
        hpIgrac = rezultat.hpIgrac;
        hpCudoviste = rezultat.hpCudoviste;
        
    }
    if (hpIgrac > 0)
        Console.WriteLine("Pobijedili ste čudovište");
    else
        Console.WriteLine("Čudovište vas je pobijedilo");

}
while (nastavi);