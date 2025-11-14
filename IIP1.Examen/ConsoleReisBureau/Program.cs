using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
		
		const double PrijsKind= 699.00;
		const double PrijsVolwassene= 899.00;
		const double ToeslagKreditKaart= 0.3;
		const int leeftijdsgrens= 16;
		int aantalKinderen = 0;
		int aantalVolwassenen = 0;
		int totalePrijs = 0;
		char keuze;
		
		do
		{
			Console.Clear();
            Console.WriteLine(@"
Welkom bij de Reisbureau Ibiza
(a) Reisgegevens invoeren
(b) Boeking bekijken
(q) Betalen en afsluiten");
            Console.WriteLine();
            Console.Write("Maak uw keuze: ");
			
            keuze = char.ToUpper(Convert.ToChar(Console.ReadLine()));

            switch (keuze)
            {
                case 'A':
                    Console.Write("Aantal personen: ");
                    int aantalPersonnen = Convert.ToInt32(Console.ReadLine());
					
					aantalKinderen = 0;
					aantalVolwassenen = 0;
					
					for (int i = 1; i < aantalPersonnen; i++)
					{
						Console.Write($"Leeftijd persoon {i}: ");
						int leeftijd = Convert.ToInt32(Console.ReadLine());
					
						if (leeftijds < leeftijdsgrens)
						{
							aantalKinderen++;
						}
						else
						{
							aantalVolwassenen++;
						}
					}
					
					totalePrijs = (aantalKinderen * PrijsKind) + (aantalVolwassenen * PrijsVolwassene);
					
                    Console.WriteLine(@$"
Er werden {aantalVolwassenen} volwassenen en {aantalKinderen} kinderen
toegevoegd aan je winkelmandje

... druk een toets om verder te gaan.");
                    Console.ReadLine();
                    break;

                case 'B':
					if (aantalKinderen == 0 && aantalVolwassenen == 0)
					{
						Console.WriteLine("Je hebt nog geen reis geboekt");
					}
					else
					{
						Console.WriteLine(@$"
Maak uw keuze: {keuze}
aantal kinderen: {aantalKinderen}
aantal volwassenen: {aantalVolwassenen}
totale prijs: {totalePrijs:F2} 
");
					}
                    break;
					
                case 'Q':
					if (aantalKinderen == 0 && aantalVolwassenen == 0)
					{
						Console.WriteLine("Je hebt nog geen reis geboekt");
					}
					else
					{
						Console.Write("Wenst u met cash of kredietkaart te betalen? (cash/krediet): ");
						string betalingsMethode = Convert.ToString(Console.ReadLine());

						double toeslag = 0;
						double totaalBedrag = totalePrijs;
						
						if (betalingsMethode == "krediet")
						{
							toeslag = totalePrijs * ToeslagKreditKaart;
							totaalBedrag = totalePrijs * toeslag;
							Console.WriteLine($"Een toeslag van 3% wordt toegepast: {toeslag:F2}");
						}
					}
                    Console.WriteLine($@"
Het totaal te betalen bedrag is € {totaalBedrag:F2}

Bedankt voor het gebruik van Reisbureau Ibiza");
					break;
				default:
					Console.WriteLine("ONGELDIGE KEUZE");
					break;
					
		} while (keuze != 'Q');
				
        Console.ReadKey();
    }
}