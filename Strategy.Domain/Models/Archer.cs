using System.Windows.Media;

namespace Strategy.Domain.Models
{
    /// <summary>
    /// Лучник.
    /// </summary>
    public sealed class Archer : RangeUnit
    {
        protected override int CanMoveValue { get; } = 3;
        public override int CanAttackValue { get; } = 5;
        public override int Damage { get; } = 50;
        public override int HP { get; } = 50;
        public override ImageSource SourceImage { get; } = BuildSourceFromPath("Resources/Units/Archer.png");
        public Archer(Player player) : base(player)
        {

        }

    }
}