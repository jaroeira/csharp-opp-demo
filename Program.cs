using csharp_oop_demo;
using csharp_oop_demo.src.model;

// Weapons
var longbow = new Weapon(150, 20, "Longbow");
var shortsword = new Weapon(5, 15, "Shortsword");
var lightsaber = new Weapon(5, 200, "Lightsaber");

System.Console.WriteLine("C# - OOP - RPG - DEMO");
System.Console.WriteLine();
System.Console.WriteLine("Weapons available:");
System.Console.WriteLine(longbow.ToString());
System.Console.WriteLine(shortsword.ToString());
System.Console.WriteLine(lightsaber.ToString());
System.Console.WriteLine("------------------------------------------------------");
System.Console.WriteLine();


// Hero 1 Actions

var hero1 = new Hero("Hero1", 5, 10, 10);
hero1.addWeapon(longbow);
hero1.addWeapon(lightsaber);
hero1.addWeapon(longbow);

System.Console.WriteLine(hero1.ToString());
hero1.showWeapons();

hero1.attackWithWeapon("lightsaber");

hero1.attackWithWeapon("longbow", 10);

System.Console.WriteLine();
System.Console.WriteLine("------------------------------------------------------");
System.Console.WriteLine();

//Monster 1 Actions

var moster1 = new Monster("Monster1", 100, 10, MonsterType.giant, true);
moster1.addWeapon(longbow);
moster1.addWeapon(lightsaber);
moster1.addWeapon(shortsword);
System.Console.WriteLine(moster1.ToString());

moster1.showWeapons();

moster1.attackWithNoWeapon();
moster1.attackWithWeapon("shortsword");



