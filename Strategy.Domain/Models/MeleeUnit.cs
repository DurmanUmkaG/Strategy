using Strategy.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Domain
{
    public abstract class MeleeUnit : BaseUnit
    {
        protected MeleeUnit(Player player) : base(player)
        {
        }

        public bool CanAttack(int dx, int dy)
        {
            return (dx == -CanAttackValue || dx == 0 || dx == CanAttackValue) &&
                (dy == -CanAttackValue || dy == 0 || dy == CanAttackValue);
        }
    }
}
