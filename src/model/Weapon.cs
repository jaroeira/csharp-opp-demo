
namespace csharp_oop_demo.src.model
{
    public class Weapon
    {
        public readonly int range;
        public readonly int damage;
        public readonly string name;

        public Weapon(int range, int damage, string name)
        {
            this.range = range;
            this.damage = damage;
            this.name = name.Trim().ToLower();
        }

        public override string ToString()
        {
            return $"Weapon => {this.name} range: {this.range} damage: {this.damage}";
        }
    }
}