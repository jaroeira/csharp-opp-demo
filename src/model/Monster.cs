using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csharp_oop_demo.src.model
{
    public class Monster : Character
    {
        public readonly bool unkillable;
        public readonly MonsterType monsterType;

        public Monster(string name, int strength, int level, MonsterType monsterType, bool unkillable) : base(name, strength, level, CharacterType.monster)
        {
            this.unkillable = unkillable;
            this.monsterType = monsterType;
        }

        public void attackWithNoWeapon()
        {
            System.Console.WriteLine();
            System.Console.WriteLine($"{this.name} attaked with strength: {this.strength}");
            System.Console.WriteLine();
        }

        public override string ToString()
        {
            return base.ToString() + $" Monster Type: {this.monsterType} Unkillable: {this.unkillable}";
        }
    }
}