using System;
using System.Collections.Generic;

/*
╔═══════════════════════════════════════════════════════════════╗
║  SOLUTIONS COMPLÈTES - EXERCICES PRÉPARATION IIP2             ║
║  Dimanche 20 avril 2026                                       ║
║  Gabriel - Examen lundi 21 avril                              ║
╚═══════════════════════════════════════════════════════════════╝
*/

namespace SolutionsExercices
{
    class Program
    {
        // ========================================
        // FICHIER 1: EXERCICES COMPRÉHENSION
        // ========================================
        
        // EXERCICE 1: TelPositieve
        // Consigne: Tel het aantal POSITIEVE getallen in een array
        static int TelPositieve(int[] getallen)
        {
            int aantalPositieve = 0;
            
            for (int i = 0; i < getallen.Length; i++)
            {
                if (getallen[i] > 0)
                {
                    aantalPositieve++;  // ✅ COMPTER, pas additionner!
                }
            }
            
            return aantalPositieve;
        }
        
        // EXERCICE 2: GooiTotMinimum
        // Consigne: Gooi dobbelstenen TOTDAT som >= minimum
        static int GooiTotMinimum(int minimum)
        {
            Random random = new Random();
            int aantal = 0;
            int som = 0;
            
            while (som < minimum)  // ✅ TOTDAT = continue TANT QUE pas atteint
            {
                int de1 = random.Next(1, 7);
                int de2 = random.Next(1, 7);
                som = de1 + de2;  // ✅ ADDITION, pas assignment!
                aantal++;
            }
            
            return aantal;  // ✅ Pas de ++
        }
        
        // EXERCICE 3: VindEersteNegatieve
        // Consigne: Retourneer INDEX van eerste negatieve getal, of -1
        static int VindEersteNegatieve(double[] getallen)
        {
            for (int i = 0; i < getallen.Length; i++)
            {
                if (getallen[i] < 0)
                {
                    return i;  // ✅ Retourne INDEX immédiatement!
                }
            }
            return -1;  // ✅ Rien trouvé
        }
        
        // EXERCICE 4: VerzamelTotMaximum
        // Consigne: Verzamel getallen ZOLANG som < maximum
        // ⚠️ NON-PURE (bevat Console.ReadLine)
        static List<int> VerzamelTotMaximum(int maximum)
        {
            List<int> getallen = new List<int>();
            int som = 0;
            
            while (som < maximum)
            {
                Console.Write("Geef een getal: ");
                int getal = Convert.ToInt32(Console.ReadLine());
                getallen.Add(getal);
                som += getal;
            }
            
            return getallen;
        }
        
        // EXERCICE 5: HerhaalBewerking
        // Consigne: Verdubbel getal AANTAL KEREN
        static int HerhaalBewerking(int startgetal, int aantalKeren)
        {
            int resultaat = startgetal;
            
            for (int i = 0; i < aantalKeren; i++)  // ✅ FOR car nombre FIXE
            {
                resultaat = resultaat * 2;
            }
            
            return resultaat;
        }
        
        // ========================================
        // FICHIER 2: EXERCICES CRÉATION MÉTHODES
        // Style SET Examen
        // ========================================
        
        // EXERCICE SET 1: BerekenPrijsMetKorting ⭐⭐
        // Consigne: Bereken totale prijs met korting op basis van aantal
        // 1-4: 0%, 5-9: 10%, 10-19: 15%, 20+: 20%
        static double BerekenPrijsMetKorting(double prijs, int aantal)
        {
            double totaal = prijs * aantal;
            double korting = 0;
            
            if (aantal >= 20)
                korting = 0.20;
            else if (aantal >= 10)
                korting = 0.15;
            else if (aantal >= 5)
                korting = 0.10;
            
            return totaal * (1 - korting);
        }
        
        // EXERCICE SET 2: FilterTemperaturen ⭐⭐⭐
        // Consigne: Retourneer INDICES van dagen binnen bereik [min, max]
        static List<int> FilterTemperaturen(double[] temps, double min, double max)
        {
            List<int> indices = new List<int>();
            
            for (int i = 0; i < temps.Length; i++)
            {
                if (temps[i] >= min && temps[i] <= max)
                {
                    indices.Add(i);  // ✅ Ajouter INDEX, pas température!
                }
            }
            
            return indices;
        }
        
        // EXERCICE SET 3: BerekenReeks ⭐⭐⭐⭐
        // Consigne: Collatz conjecture - tel stappen om 1 te bereiken
        // EVEN: deel door 2, ONEVEN: × 3 + 1
        static int BerekenReeks(int getal)
        {
            int stappen = 0;
            
            while (getal != 1)  // ✅ WHILE car on ne sait pas combien de stappen
            {
                if (getal % 2 == 0)  // EVEN
                {
                    getal = getal / 2;
                }
                else  // ONEVEN
                {
                    getal = getal * 3 + 1;
                }
                stappen++;
            }
            
            return stappen;
        }
        
        // ========================================
        // EXERCICES SUPPLÉMENTAIRES STYLE EXAMEN
        // ========================================
        
        // EXERCICE BONUS 1: BerekenGemiddelde
        // Consigne: Bereken gemiddelde van array
        static double BerekenGemiddelde(double[] getallen)
        {
            double som = 0;
            
            for (int i = 0; i < getallen.Length; i++)
            {
                som += getallen[i];
            }
            
            return som / getallen.Length;
        }
        
        // EXERCICE BONUS 2: VindMaximum
        // Consigne: Vind hoogste waarde in array
        static double VindMaximum(double[] getallen)
        {
            double max = getallen[0];
            
            for (int i = 1; i < getallen.Length; i++)
            {
                if (getallen[i] > max)
                {
                    max = getallen[i];
                }
            }
            
            return max;
        }
        
        // EXERCICE BONUS 3: VindIndexVanMaximum
        // Consigne: Vind INDEX van hoogste waarde
        static int VindIndexVanMaximum(double[] getallen)
        {
            double max = getallen[0];
            int index = 0;
            
            for (int i = 1; i < getallen.Length; i++)
            {
                if (getallen[i] > max)
                {
                    max = getallen[i];
                    index = i;
                }
            }
            
            return index;
        }
        
        // EXERCICE BONUS 4: TelVorstdagen
        // Consigne: Tel dagen met temperatuur < 0
        static int TelVorstdagen(double[] temperaturen)
        {
            int aantal = 0;
            
            for (int i = 0; i < temperaturen.Length; i++)
            {
                if (temperaturen[i] < 0)
                {
                    aantal++;
                }
            }
            
            return aantal;
        }
        
        // EXERCICE BONUS 5: IsRegenachtigeWeek
        // Consigne: Check of totale neerslag > drempel
        static bool IsRegenachtigeWeek(int[] neerslag, int drempel)
        {
            int totaal = 0;
            
            for (int i = 0; i < neerslag.Length; i++)
            {
                totaal += neerslag[i];
            }
            
            return totaal > drempel;
        }
        
        // EXERCICE BONUS 6: MaakGetallenReeks
        // Consigne: Maak List van start tot eind
        static List<int> MaakGetallenReeks(int start, int eind)
        {
            List<int> reeks = new List<int>();
            
            for (int i = start; i <= eind; i++)
            {
                reeks.Add(i);
            }
            
            return reeks;
        }
        
        // EXERCICE BONUS 7: FilterEven
        // Consigne: Retourneer nieuwe List met alleen even getallen
        static List<int> FilterEven(int[] getallen)
        {
            List<int> even = new List<int>();
            
            for (int i = 0; i < getallen.Length; i++)
            {
                if (getallen[i] % 2 == 0)
                {
                    even.Add(getallen[i]);
                }
            }
            
            return even;
        }
        
        // EXERCICE BONUS 8: BerekenSom
        // Consigne: Som van alle getallen in array
        static int BerekenSom(int[] getallen)
        {
            int som = 0;
            
            for (int i = 0; i < getallen.Length; i++)
            {
                som += getallen[i];
            }
            
            return som;
        }
        
        // EXERCICE BONUS 9: BevatGetal
        // Consigne: Check of getal voorkomt in array
        static bool BevatGetal(int[] getallen, int zoekGetal)
        {
            for (int i = 0; i < getallen.Length; i++)
            {
                if (getallen[i] == zoekGetal)
                {
                    return true;
                }
            }
            return false;
        }
        
        // EXERCICE BONUS 10: OmkeerArray
        // Consigne: Maak nieuwe array in omgekeerde volgorde
        static int[] OmkeerArray(int[] getallen)
        {
            int[] omgekeerd = new int[getallen.Length];
            
            for (int i = 0; i < getallen.Length; i++)
            {
                omgekeerd[i] = getallen[getallen.Length - 1 - i];
            }
            
            return omgekeerd;
        }
        
        // ========================================
        // MAIN VOOR TESTEN
        // ========================================
        
        static void Main(string[] args)
        {
            Console.WriteLine("╔═══════════════════════════════════════╗");
            Console.WriteLine("║  SOLUTIONS - Tests                    ║");
            Console.WriteLine("╚═══════════════════════════════════════╝\n");
            
            // Test TelPositieve
            int[] test1 = { 5, -3, 10, -2, 7, 0 };
            Console.WriteLine($"TelPositieve: {TelPositieve(test1)} (verwacht: 3)");
            
            // Test GooiTotMinimum
            Console.WriteLine($"GooiTotMinimum(10): {GooiTotMinimum(10)} worpen");
            
            // Test VindEersteNegatieve
            double[] test3 = { 5.5, 3.2, -1.5, 8.0, -2.0 };
            Console.WriteLine($"VindEersteNegatieve: index {VindEersteNegatieve(test3)} (verwacht: 2)");
            
            // Test HerhaalBewerking
            Console.WriteLine($"HerhaalBewerking(3, 4): {HerhaalBewerking(3, 4)} (verwacht: 48)");
            
            // Test BerekenPrijsMetKorting
            Console.WriteLine($"BerekenPrijsMetKorting(10, 7): {BerekenPrijsMetKorting(10.0, 7)} (verwacht: 63)");
            
            // Test FilterTemperaturen
            double[] temps = { 12.5, 8.0, 15.2, 20.1, 9.5, 11.0, 18.5 };
            List<int> filtered = FilterTemperaturen(temps, 10.0, 16.0);
            Console.Write("FilterTemperaturen: [");
            Console.Write(string.Join(", ", filtered));
            Console.WriteLine("] (verwacht: [0, 2, 5])");
            
            // Test BerekenReeks
            Console.WriteLine($"BerekenReeks(3): {BerekenReeks(3)} stappen (verwacht: 7)");
            Console.WriteLine($"BerekenReeks(10): {BerekenReeks(10)} stappen (verwacht: 6)");
            
            // Test BerekenGemiddelde
            double[] test8 = { 10, 20, 30 };
            Console.WriteLine($"BerekenGemiddelde: {BerekenGemiddelde(test8)} (verwacht: 20)");
            
            Console.WriteLine("\n✅ Alle tests voltooid!");
            Console.ReadKey();
        }
    }
}

/*
╔═══════════════════════════════════════════════════════════════╗
║  BELANGRIJKE PATRONEN VOOR HET EXAMEN                         ║
╚═══════════════════════════════════════════════════════════════╝

1. ARRAY DOORLOPEN EN TELLEN:
   ────────────────────────────
   int aantal = 0;
   for (int i = 0; i < array.Length; i++)
   {
       if (conditie)
           aantal++;
   }
   return aantal;

2. EERSTE ELEMENT VINDEN:
   ────────────────────────
   for (int i = 0; i < array.Length; i++)
   {
       if (conditie)
           return i;  // STOP immédiatement!
   }
   return -1;  // Rien trouvé

3. MAXIMUM/MINIMUM VINDEN:
   ────────────────────────
   double max = array[0];
   for (int i = 1; i < array.Length; i++)
   {
       if (array[i] > max)
           max = array[i];
   }
   return max;

4. NIEUWE LIST MAKEN EN FILTEREN:
   ─────────────────────────────
   List<int> resultaat = new List<int>();
   for (int i = 0; i < array.Length; i++)
   {
       if (conditie)
           resultaat.Add(array[i]);  // Of Add(i) voor indices
   }
   return resultaat;

5. WHILE LOOP MET CONDITIE:
   ─────────────────────────
   int som = 0;
   while (som < target)
   {
       // doe iets
       som += ...;
   }
   return aantal;

6. FOR LOOP AANTAL KEREN:
   ─────────────────────────
   for (int i = 0; i < aantalKeren; i++)
   {
       // herhaal bewerking
   }

╔═══════════════════════════════════════════════════════════════╗
║  MOTS-CLÉS → TYPE DE LOOP                                     ║
╚═══════════════════════════════════════════════════════════════╝

"zolang"          → WHILE (tant que condition)
"totdat"          → WHILE (continue jusqu'à)
"zodra"           → FOR + RETURN (dès que trouvé)
"aantal keren"    → FOR (nombre fixe)
"voor elke"       → FOREACH
"eerste"          → RETURN dans loop
"alle"            → Parcourir tout avec loop

╔═══════════════════════════════════════════════════════════════╗
║  CHECKLIST AVANT L'EXAMEN                                     ║
╚═══════════════════════════════════════════════════════════════╝

□ Je lis la consigne 2 FOIS
□ Je souligne les mots-clés (zolang, totdat, aantal, eerste)
□ Je connais le returntype
□ Je connais TOUS les paramètres
□ Je sais quelle loop utiliser
□ Je comprends QUAND la loop s'arrête
□ Je sais CE QUE je retourne (valeur? index? List?)
□ J'écris la signature AVANT le corps
□ Je teste mentalement avec un exemple

╔═══════════════════════════════════════════════════════════════╗
║  BON COURAGE GABRIEL! TU ES PRÊT! 💪                          ║
╚═══════════════════════════════════════════════════════════════╝
*/
