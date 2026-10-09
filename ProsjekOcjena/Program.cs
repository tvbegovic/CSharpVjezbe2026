try
{
	Console.Write("Ocjena C: ");
	string unos = Console.ReadLine();
	int ocjenaC = int.Parse(unos);
	Console.Write("Ocjena C++: ");
	unos = Console.ReadLine();
	int ocjenaCPlus = int.Parse(unos);
	Console.Write("Ocjena C#: ");
	unos = Console.ReadLine();
	int ocjenaCSharp = int.Parse(unos);
	//ako su lijevo i desno od znaka / cijeli brojevi, dobivamo cjelobrojno dijeljenje. Zato 3 pretvaramo u 3.0
	double prosjek = (ocjenaC + ocjenaCPlus + ocjenaCSharp) / 3.0;
	Console.WriteLine($"Prosjek ocjena je {prosjek:N2}");
}
catch (Exception ex)
{
	Console.WriteLine($"Dogodila se pogreška. Tekst: {ex.Message}");
}