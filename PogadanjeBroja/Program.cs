Console.WriteLine("Zamislio sam broj od 1-10. Probaj ga pogoditi.");
Console.Write("Unesi broj: ");
Random rand = new Random();
int zamisljeniBroj = rand.Next(1,11);
string unos = Console.ReadLine();
bool ok = int.TryParse(unos, out int broj);
if(!ok)
{
    Console.WriteLine("Pogrešan format");
    return;
}
if(broj < 1 || broj > 10)
{
    Console.WriteLine("Broj je izvan raspona");
    return;
}
int razlika = Math.Abs(broj - zamisljeniBroj);
switch(razlika)
{
    case 0:
        Console.WriteLine("Sjajno, pogodili ste broj. Imate čokoladu");
        break;
    case 1:
    case 2:
    case 3:
        Console.WriteLine($"Broj je {zamisljeniBroj}. Jako dobro. Osvajate pola čokolade");
        break;
    case 4:
    case 5:
    case 6:
        Console.WriteLine($"Broj je {zamisljeniBroj}. Solidno. Dobili ste jedno rebro čokolade");
        break;
    default:
        Console.WriteLine($"Broj je {zamisljeniBroj}. Više sreće drugi put");
        break;
}
