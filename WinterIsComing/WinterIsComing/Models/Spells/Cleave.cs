namespace WinterIsComing.Models.Spells
{
    public class Cleave : Spell
    {
        private const int DefaultCost = 15;


        public Cleave(int damage)
            : base(damage, DefaultCost)
        {
        }
    }
}
