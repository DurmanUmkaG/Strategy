namespace Strategy.Domain.Models
{
    /// <summary>
    /// Класс мечника.
    /// </summary>
    public sealed class Swordsman : BaseUnit
    {
        public Swordsman(Player player) : base(player)
        {
        }
    }
}