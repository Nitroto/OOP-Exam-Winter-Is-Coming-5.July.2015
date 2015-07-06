using WinterIsComing.Models.CombatHandlers;

namespace WinterIsComing.Models.Units
{
    public class IceGiant : Unit
    {
        private const int DefaultAttackPoints = 150;
        private const int DefaultDefensePoints = 60;
        private const int DefaultEnergyPoints = 50;
        private const int DefaultHealthPoints = 300;
        private const int DefaultRange = 1;


        public IceGiant(string name, int x, int y)
            : base(name, DefaultAttackPoints, DefaultDefensePoints, DefaultHealthPoints, DefaultEnergyPoints, DefaultRange, x, y)
        {
            this.CombatHandler = new IceGiantCombatHandler(this);
        }
    }
}