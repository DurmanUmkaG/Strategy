namespace Strategy.Domain.Models
{
    /// <summary>
    /// Класс мечника.
    /// </summary>
    public sealed class Swordsman : BaseUnit
    {
        protected override int CanMoveValue { get; } = 5;
        public Swordsman(Player player) : base(player)
        {
        }
    }
}