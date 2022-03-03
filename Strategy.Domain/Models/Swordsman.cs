namespace Strategy.Domain.Models
{
    /// <summary>
    /// Класс мечника.
    /// </summary>
    public sealed class Swordsman : MeleeUnit
    {
        protected override int CanMoveValue { get; } = 5;
        public override int CanAttackValue { get; } = 1;
        public Swordsman(Player player) : base(player)
        {
        }
    }
}