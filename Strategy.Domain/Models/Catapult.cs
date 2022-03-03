namespace Strategy.Domain.Models
{
    /// <summary>
    /// Катапульта.
    /// </summary>
    public sealed class Catapult : BaseUnit
    {
        protected override int CanMoveValue { get; } = 1;
        public Catapult(Player player) : base(player)
        {
        }
    }
}