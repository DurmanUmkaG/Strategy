namespace Strategy.Domain.Models
{
    /// <summary>
    /// Катапульта.
    /// </summary>
    public sealed class Catapult : RangeUnit
    {
        protected override int CanMoveValue { get; } = 1;
        public override int CanAttackValue { get; } = 10;
        public Catapult(Player player) : base(player)
        {
        }
    }
}