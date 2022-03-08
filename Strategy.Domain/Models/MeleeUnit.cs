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

        public override bool CanAttack(int dx, int dy)
        {
            return IsMelee(dx, dy);
        }

        public override int AttackUnit(int x, int y)
        {
            return Damage;
        }
    }
}
