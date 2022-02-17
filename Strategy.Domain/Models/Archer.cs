namespace Strategy.Domain.Models
{
    /// <summary>
    /// Лучник.
    /// </summary>
    public sealed class Archer : BaseUnit
    {
        /// <inheritdoc />
        public Archer(Player player) : base(player)
        {
        }
    }
}