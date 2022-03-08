using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Strategy.Domain.Models
{
    public abstract class BaseUnit : Base
    {
        public Player Player { get; }

        protected abstract int CanMoveValue { get; }
        public abstract int CanAttackValue { get; }
        public abstract int Damage { get; }
        public abstract int HP { get; }

        public abstract bool CanAttack(int x, int y);

        public abstract int AttackUnit(int x, int y);
        public static ImageSource DeadUnitSource { get; } = BuildSourceFromPath("Resources/Units/Dead.png");
        protected BaseUnit(Player player)
        {
            Player = player;
        }
        public bool IsEqualCoordinates(int x, int y)
        {
            return X == x && Y == y;
        }
        public bool CanMove(int x, int y)
        {
            return !(Math.Abs(X - x) > CanMoveValue || Math.Abs(Y - y) > CanMoveValue);
        }
        public bool IsMelee(int dx, int dy)
        {
            return (dx == -1 || dx == 0 || dx == 1) &&
                (dy == -1 || dy == 0 || dy == 1);
        }
    }
}
