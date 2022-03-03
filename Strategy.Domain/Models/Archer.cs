namespace Strategy.Domain.Models
{
    /// <summary>
    /// Лучник.
    /// </summary>
    public sealed class Archer : RangeUnit
    {
        protected override int CanMoveValue { get; } = 3;
        public override int CanAttackValue { get; } = 5;
        public Archer(Player player) : base(player)
        {

        }

    }
}