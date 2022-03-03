namespace Strategy.Domain.Models
{
    /// <summary>
    /// Класс всадника.
    /// </summary>
    public sealed class Horseman : MeleeUnit
    {
        protected override int CanMoveValue { get; } = 10;
        public override int CanAttackValue { get; } = 1;
        public Horseman(Player player) : base(player)
        {
        }
    }
}