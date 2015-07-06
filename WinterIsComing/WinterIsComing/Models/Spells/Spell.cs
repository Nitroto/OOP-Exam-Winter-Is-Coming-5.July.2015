using WinterIsComing.Contracts;

namespace WinterIsComing.Models.Spells
{
    public abstract class Spell : ISpell
    {
        private int damage;
        private int energyCost;


        public Spell(int damage, int energyCost)
        {
            this.Damage = damage;
            this.EnergyCost = energyCost;
        }


        public int Damage
        {
            get
            {
                return this.damage;
            }

            protected set
            {
                //validation
                this.damage = value;
            }
        }

        public int EnergyCost
        {
            get
            {
                return this.energyCost;
            }

            private set
            {
                //validation
                this.energyCost = value;
            }
        }
    }
}
