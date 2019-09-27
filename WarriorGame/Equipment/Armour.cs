using WarriorGame.Enum;
using WarriorGame.Equipment;

namespace WarriorGame.Equipment

{
    internal class Armour
    {
        private int GOOD_GUY_ARMOUR = 5;
        private int BAD_GUY_ARMOUR = 5;

        private int armourPoints;

        public int ArmourPoints
        {
            get
            {
                return armourPoints;
            }
        }

        public Armour(Faction faction)
        {

            switch (faction)
            {
                case Faction.GoodGuy:
                    armourPoints = GOOD_GUY_ARMOUR;

                    break;
                case Faction.BadGuy:
                    armourPoints = BAD_GUY_ARMOUR;

                    break;
                default:
                    break;
            }

        }
    }
}