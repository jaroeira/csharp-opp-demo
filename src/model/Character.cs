using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csharp_oop_demo.src.model
{


    public abstract class Character
    {
        public readonly string name;
        public int strength;
        public int level;
        public CharacterType type;

        public int numberOfWeapons
        {
            get
            {
                return this.weaponsDict.Count;
            }
        }

        private Dictionary<string, Weapon> weaponsDict = new Dictionary<string, Weapon>();

        public Character(string name, int strength, int level, CharacterType type)
        {
            this.name = name;
            this.strength = strength;
            this.level = level;
            this.type = type;
        }

        public void addWeapon(Weapon weapon)
        {
            if (this.weaponsDict.ContainsKey(weapon.name))
            {
                System.Console.WriteLine($"{this.name} already has the weapon {weapon.name}");
                return;
            }

            this.weaponsDict.Add(weapon.name, weapon);

        }

        public void removeWeapon(string name)
        {
            if (!this.weaponsDict.ContainsKey(name))
            {
                System.Console.WriteLine($"{this.name} does not have the weapon {name}");
                return;
            }

            this.weaponsDict.Remove(name);
        }

        public void showWeapons()
        {
            if (this.weaponsDict.Count == 0)
            {
                System.Console.WriteLine($"{this.name} has no weapons!");
                return;
            }

            System.Console.WriteLine();
            System.Console.WriteLine($"{this.name} has the folowing weapons:");
            this.weaponsDict.Select(i => $"{i.Key}: {i.Value}").ToList().ForEach(System.Console.WriteLine);
            System.Console.WriteLine();
        }

        public void attackWithWeapon(string weaponName)
        {
            if (weaponName == "")
            {
                System.Console.WriteLine();
                System.Console.WriteLine("Can not attack! You must choose a valid weapon first");
                System.Console.WriteLine();
                return;
            }

            if (!this.weaponsDict.ContainsKey(weaponName))
            {
                System.Console.WriteLine();
                System.Console.WriteLine($"Can not attack! Weapon: {weaponName} not available!");
                System.Console.WriteLine();
                return;
            }

            Weapon weapon = this.weaponsDict[weaponName];

            System.Console.WriteLine();
            System.Console.WriteLine($"{this.name} attaked with weapon: {weapon.name} range: {weapon.range} damage: {weapon.damage}");
            System.Console.WriteLine();
        }

        public override string ToString()
        {
            return $"name: {this.name} strength: {this.strength} level: {this.level} type: {this.type} num of weapons: {this.numberOfWeapons}";
        }
    }
}