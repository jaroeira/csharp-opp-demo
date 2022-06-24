using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csharp_oop_demo.src.model
{
    public class Hero : Character
    {
        public int charisma;

        public Hero(string name, int strength, int level, int charisma) : base(name, strength, level, CharacterType.hero)
        {
            this.charisma = charisma;
        }

        public void attackWithWeapon(string weaponName, int bonus)
        {
            this.attackWithWeapon(weaponName);
            System.Console.WriteLine($"{this.name}'s attack gets bonus of {bonus}");
        }

        public override string ToString()
        {
            return base.ToString() + $" Charisma: {this.charisma}";
        }
    }
}