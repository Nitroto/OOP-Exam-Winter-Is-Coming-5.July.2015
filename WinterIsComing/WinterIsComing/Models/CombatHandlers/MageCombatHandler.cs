using System.Collections.Generic;
using System.Linq;
using WinterIsComing.Contracts;
using WinterIsComing.Core.Exceptions;
using WinterIsComing.Models.Spells;

namespace WinterIsComing.Models.CombatHandlers
{
    public class MageCombatHandler : CombatHandler
    {
        private ISpell lastSuccessfullSpell;

        public MageCombatHandler(IUnit unit)
            : base(unit)
        {
            this.lastSuccessfullSpell = null;
        }


        public override ISpell GenerateAttack()
        {
            ISpell spell = null;
            if (this.lastSuccessfullSpell == null || this.lastSuccessfullSpell is Blizzard)
            {
                spell = new FireBreath(this.Unit.AttackPoints);
            }
            else
            {
                spell = new Blizzard(this.Unit.AttackPoints * 2);
            }
            if (this.Unit.EnergyPoints >= spell.EnergyCost)
            {
                this.lastSuccessfullSpell = spell;
                this.Unit.EnergyPoints -= spell.EnergyCost;
                return spell;
            }
            throw new NotEnoughEnergyException(string.Format(Messages.NotEnoughEnergyException, this.Unit.Name, spell.GetType().Name));
        }

        public override IEnumerable<IUnit> PickNextTargets(IEnumerable<IUnit> candidateTargets)
        {
            var targets = candidateTargets.OrderByDescending(t => t.HealthPoints).ThenBy(t => t.Name).ToList();
            if (targets.Count > 3)
            {
                IUnit[] only3Targets = new IUnit[3];
                for (int i = 0; i < only3Targets.Length; i++)
                {
                    only3Targets[i] = targets[i];
                }
                return only3Targets;
            }
            return targets;
        }
    }
}
