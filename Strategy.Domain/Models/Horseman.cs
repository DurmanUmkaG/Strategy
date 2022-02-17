namespace Strategy.Domain.Models
{
    /// <summary>
    /// Класс всадника.
    /// </summary>
    public sealed class Horseman : BaseUnit
    {
        public Horseman(Player player) : base(player)
        {
        }
    }
}