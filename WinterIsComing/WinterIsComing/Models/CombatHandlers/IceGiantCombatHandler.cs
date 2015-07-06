using System.Collections.Generic;
using System.Linq;
using WinterIsComing.Contracts;
using WinterIsComing.Core.Exceptions;
using WinterIsComing.Models.Spells;

namespace WinterIsComing.Models.CombatHandlers
{
    public class IceGiantCombatHandler : CombatHandler
    {
        public IceGiantCombatHandler(IUnit unit)
            : base(unit)
        {
        }


        public override ISpell GenerateAttack()
        {
            ISpell spell = null;
            int damage = (this.Unit.AttackPoints);
            spell = new Stomp(damage);
            if (this.Unit.EnergyPoints >= spell.EnergyCost)
            {
                this.Unit.EnergyPoints -= spell.EnergyCost;
                this.Unit.AttackPoints += 5;
                return spell;
            }
            throw new NotEnoughEnergyException(string.Format(Messages.NotEnoughEnergyException, this.Unit.Name, spell.GetType().Name));
        }

        public override IEnumerable<IUnit> PickNextTargets(IEnumerable<IUnit> candidateTargets)
        {
            var targets = candidateTargets.ToList();
            if (targets.Count > 0)
            {
                if (this.Unit.HealthPoints <= 150)
                {
                    IUnit[] target = new IUnit[1];
                    target[0] = targets[0];
                    return target;
                }
            }

            return targets;
        }
    }
}
