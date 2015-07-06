namespace WinterIsComing.Models.Spells
{
    public class Stomp : Spell
    {
        private const int DefaultCost = 10;


        public Stomp(int damage)
            : base(damage, DefaultCost)
        {
        }
    }
}
