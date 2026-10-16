Console.Write("Ocjena baze1: ");
string unos = Console.ReadLine();
bool ok = int.TryParse(unos, out int ocjenaBaze1);
if(!ok)
{
    Console.WriteLine("Pogrešan format");
    return;
}
if(ocjenaBaze1 < 1 || ocjenaBaze1 > 5)
{
    Console.WriteLine("Ocjena mora biti od 1 do 5");
    return;
}
Console.Write("Ocjena baze 2: ");
unos = Console.ReadLine();
ok = int.TryParse(unos, out int ocjenaBaze2);
if (!ok)
{
    Console.WriteLine("Pogrešan format");
    return;
}
if (ocjenaBaze2 < 1 || ocjenaBaze2 > 5)
{
    Console.WriteLine("Ocjena mora biti od 1 do 5");
    return;
}
Console.Write("Ocjena C#: ");
unos = Console.ReadLine();
ok = int.TryParse(unos, out int ocjenaCSharp);
if (!ok)
{
    Console.WriteLine("Pogrešan format");
    return;
}
if (ocjenaCSharp < 1 || ocjenaCSharp > 5)
{
    Console.WriteLine("Ocjena mora biti od 1 do 5");
    return;
}
double prosjek = (ocjenaBaze1 + ocjenaBaze2 + ocjenaCSharp) / 3.0;
Console.WriteLine($"Prosjek ocjena je {prosjek:N2}");
bool PoloziliSve = ocjenaBaze1 > 1 && ocjenaBaze2 > 1 && ocjenaCSharp > 1;
if(!PoloziliSve)
{
    Console.WriteLine("Niste položili sve predmete. Ne mogu odrediti uspjeh");
    return;
}
string uspjeh;
if (prosjek >= 4.5)
    uspjeh = "izvrstan";
else if (prosjek >= 3.5)
    uspjeh = "vrlo dobar";
else if (prosjek >= 2.5)
    uspjeh = "dobar";
else
    uspjeh = "dovoljan";
Console.WriteLine($"Vaš konačni uspjeh je {uspjeh}");



