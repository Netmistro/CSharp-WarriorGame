using WarriorGame.Enum;
using WarriorGame.Equipment;

namespace WarriorGame
{
    class Warrior
    {

        private const int GOOD_GUY_STARTING_HEALTH = 100;
        private const int BAD_GUY_STARTING_HEALTH = 100;

        private readonly Faction FACTION;

        private int health;
        private string name;
        private bool isAlive;

        public bool IsAlive
        {
            get
            {
                return isAlive;
            }

        }

        private Weapon weapon;
        private Armour armour;

        public Warrior(string name, Faction faction)
        {
            this.name = name;
            this.FACTION = faction;
            this.isAlive = true;

            switch (faction)
            {
                case Faction.GoodGuy:
                    weapon = new Weapon(faction);
                    armour = new Armour(faction);
                    health = GOOD_GUY_STARTING_HEALTH;

                    break;
                case Faction.BadGuy:
                    weapon = new Weapon(faction);
                    armour = new Armour(faction);
                    health = GOOD_GUY_STARTING_HEALTH;

                    break;
                default:
                    break;
            }
        }

        public void Attack(Warrior enemy)
        {

        }
    }
}
