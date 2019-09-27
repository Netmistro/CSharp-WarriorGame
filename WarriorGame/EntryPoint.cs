using WarriorGame.Enum;

namespace WarriorGame
{
    class EntryPoint
    {
        static void Main(string[] args)
        {

            Warrior goodGuy = new Warrior("Bob", Faction.GoodGuy);
            Warrior badGuy = new Warrior("Joe", Faction.BadGuy);
        }
    }
}
