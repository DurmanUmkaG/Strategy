using System.Windows.Media;

namespace Strategy.Domain.Models
{
    /// <summary>
    /// Катапульта.
    /// </summary>
    public sealed class Catapult : RangeUnit
    {
        protected override int CanMoveValue { get; } = 1;
        public override int CanAttackValue { get; } = 10;
        public override int Damage { get; } = 100;
        public override int HP { get; } = 70;
        public override ImageSource SourceImage { get; } = BuildSourceFromPath("Resources/Units/Catapult.png");
        public Catapult(Player player) : base(player)
        {
        }
    }
}