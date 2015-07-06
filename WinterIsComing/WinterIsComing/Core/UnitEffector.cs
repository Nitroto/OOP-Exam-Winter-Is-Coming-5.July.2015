using System.Collections.Generic;
using WinterIsComing.Contracts;

namespace WinterIsComing.Core
{
    class UnitEffector : IUnitEffector
    {
        public void ApplyEffect(IEnumerable<IUnit> units)
        {
            foreach (var unit in units)
            {
                unit.HealthPoints += 50;
            }
        }
    }
}
