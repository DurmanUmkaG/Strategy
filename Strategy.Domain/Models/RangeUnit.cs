using Strategy.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Domain
{
    public abstract class RangeUnit : BaseUnit
    {
        protected RangeUnit(Player player) : base(player)
        {
        }

        public bool CanAttack(int dx, int dy)
        {
            return dx >= -CanAttackValue && dx <= CanAttackValue && dy >= -CanAttackValue && dy <= CanAttackValue;
        }
    }
}
