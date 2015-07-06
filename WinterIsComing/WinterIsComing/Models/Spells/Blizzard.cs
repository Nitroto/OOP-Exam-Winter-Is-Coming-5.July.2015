namespace WinterIsComing.Models.Spells
{
    public class Blizzard : Spell
    {
        private const int DefaultCost = 40;


        public Blizzard(int damage)
            : base(damage, DefaultCost)
        {
        }
    }
}
