using System.Collections.Generic;
using System.Linq;
using WinterIsComing.Contracts;
using WinterIsComing.Core.Exceptions;
using WinterIsComing.Models.Spells;

namespace WinterIsComing.Models.CombatHandlers
{
    public class WarriorCombatHandler : CombatHandler
    {
        public WarriorCombatHandler(IUnit unit)
            : base(unit)
        {
        }


        public override ISpell GenerateAttack()
        {
            int damege = this.Unit.AttackPoints;
            ISpell spell = null;
            if (this.Unit.HealthPoints <= 80)
            {
                spell = new Cleave((damege + (2 * this.Unit.HealthPoints)));
            }
            else
            {
                spell = new Cleave(damege);
            }
            if (this.Unit.HealthPoints > 50 && this.Unit.EnergyPoints >= spell.EnergyCost)
            {
                this.Unit.EnergyPoints -= spell.EnergyCost;
                return spell;
            }
            else if (this.Unit.HealthPoints < 50)
            {
                return spell;
            }
            throw new NotEnoughEnergyException(string.Format(Messages.NotEnoughEnergyException, this.Unit.Name, spell.GetType().Name));

        }

        public override IEnumerable<IUnit> PickNextTargets(IEnumerable<IUnit> candidateTargets)
        {
            var targets = candidateTargets.OrderBy(t => t.HealthPoints).ThenBy(t => t.Name).ToList();
            if (targets.Count > 0)
            {
                IUnit[] target = new IUnit[1];
                target[0] = targets[0];
                return target;
            }
            return targets;
        }
    }
}
