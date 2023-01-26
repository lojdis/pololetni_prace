// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ahoj tohle je program na splátková kalendář");
Console.WriteLine("Kolik jste si půjčili?");
int pujcka = int.Parse(Console.ReadLine()); //umožní vložit častku
double doba_splatky = 36.0;
double urok = 0.05;
double sazba = (pujcka * urok) / doba_splatky;
double mesicni_splatka = pujcka / 36.0;
Console.WriteLine("        Měsíční splátka(KČ)     Úrok(KČ)                Zbývá");
double zbytek = pujcka;
for (int i = 1; i < 37; i++) //vypíše od prvního měsíce měsíční splátky
    Console.WriteLine($"{i}.\t{mesicni_splatka}\t{sazba}\t{zbytek}"); //vypíše sumo 
zbytek -= mesicni_splatka;
Console.WriteLine($"Celkem  {mesicni_splatka * doba_splatky}                 {sazba * doba_splatky}");
Console.WriteLine("Děkuji za použivání mého programu");
