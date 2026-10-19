Console.Write("Unesite broj od 1-100.000: ");
string unos = Console.ReadLine();
bool ok = int.TryParse(unos, out int broj);
if(!ok)
{
    Console.WriteLine("Pogrešan format");
    return;
}
if(broj < 1 || broj > 100000)
{
    Console.WriteLine("Broj je izvan raspona");
    return;
}
//koristimo long umjesto int da ne dođe do overflowa
long suma = 0;
for (int i = 1; i <= broj; i++)
{
    if (i % 3 == 0 || i % 5 == 0)
        suma += i;
}
Console.WriteLine($"Zbroj brojeva od 1 do {broj} djeljivih sa 3 ili 5 je {suma:N0}");
