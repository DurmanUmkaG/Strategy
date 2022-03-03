namespace Strategy.Domain.Models
{
    /// <summary>
    /// Лучник.
    /// </summary>
    public sealed class Archer : BaseUnit
    {
        protected override int CanMoveValue { get; } = 3;
        public Archer(Player player) : base(player)
        {

        }

    }
}