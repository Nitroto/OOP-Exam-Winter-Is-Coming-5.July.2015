using System.Collections.Generic;
using WinterIsComing.Contracts;

namespace WinterIsComing.Models.CombatHandlers
{
    public abstract class CombatHandler : ICombatHandler
    {
        private IUnit unit;

        protected CombatHandler(IUnit unit)
        {
            this.Unit = unit;
        }

        public IUnit Unit
        {
            get
            {
                return this.unit;
            }

            set
            {
                //validation
                this.unit = value;
            }
        }

        public abstract ISpell GenerateAttack();

        public abstract IEnumerable<IUnit> PickNextTargets(IEnumerable<IUnit> candidateTargets);

    }
}
