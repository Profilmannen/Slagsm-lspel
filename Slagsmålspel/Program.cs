// See https://aka.ms/new-console-template for more information

using System;

int heroHp = 100;
int villainHp = 100;

string heroName = "Profil";
string villainName = "Benim";

Random generator = new Random();

while (heroHp > 0 && villainHp > 0){
    Console.WriteLine("\n----- ===== NY DUELL ===== -----");
    Console.WriteLine($"{heroName}: {heroHp} {villainName}: {villainHp}\n");

    int heroDamage = generator.Next(20);
    villainHp -= heroDamage;
    villainHp = Math.Max(0, villainHp);
    Console.WriteLine($"{heroName} gör {heroDamage} skada på {villainName}");

    int villainDamage = generator.Next(20);
    heroHp -= villainDamage;
    heroHp = Math.Max(0, heroHp);
    Console.WriteLine($"{villainName} gör {villainDamage} skada på {heroName}");

    Console.WriteLine("Valfri knapp för nästa duell");
    Console.ReadKey();




}

Console.WriteLine("\n----- ===== Kampen är avklarad ===== -----");

if (heroHp == 0 && villainHp == 0)
{
  Console.WriteLine("Ingen vinnare");
}

else if (heroHp == 0)
{
  Console.WriteLine($"{villainName} Vann kampen! Profil förlora");
}

else
{
  Console.WriteLine($"{heroName} Vann kampen! Benim förlora");
}

Console.WriteLine("Tryck på valfri knapp för att avsluta.");
Console.ReadKey();



