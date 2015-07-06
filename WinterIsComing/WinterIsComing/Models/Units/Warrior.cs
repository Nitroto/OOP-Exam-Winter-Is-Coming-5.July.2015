using WinterIsComing.Models.CombatHandlers;

namespace WinterIsComing.Models.Units
{
    public class Warrior : Unit
    {
        private const int DefaultAttackPoints = 120;
        private const int DefaultDefensePoints = 70;
        private const int DefaultEnergyPoints = 60;
        private const int DefaultHealthPoints = 180;
        private const int DefaultRange = 1;


        public Warrior(string name, int x, int y)
            : base(name, DefaultAttackPoints, DefaultDefensePoints, DefaultHealthPoints, DefaultEnergyPoints, DefaultRange, x, y)
        {
            this.CombatHandler = new WarriorCombatHandler(this);
        }
    }
}
