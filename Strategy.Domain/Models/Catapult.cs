namespace Strategy.Domain.Models
{
    /// <summary>
    /// Катапульта.
    /// </summary>
    public sealed class Catapult : BaseUnit
    {
        public Catapult(Player player) : base(player)
        {
        }
    }
}