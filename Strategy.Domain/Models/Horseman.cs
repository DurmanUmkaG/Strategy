namespace Strategy.Domain.Models
{
    /// <summary>
    /// Класс всадника.
    /// </summary>
    public sealed class Horseman : BaseUnit
    {
        protected override int CanMoveValue { get; } = 10;
        public Horseman(Player player) : base(player)
        {
        }
    }
}