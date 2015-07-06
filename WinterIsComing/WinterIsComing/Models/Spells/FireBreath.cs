namespace WinterIsComing.Models.Spells
{
    public class FireBreath : Spell
    {
        private const int DefaultCost = 30;


        public FireBreath(int damage)
            : base(damage, DefaultCost)
        {
        }
    }
}
