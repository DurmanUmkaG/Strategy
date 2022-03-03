using System.Windows.Media;

namespace Strategy.Domain.Models
{
    /// <summary>
    /// Класс всадника.
    /// </summary>
    public sealed class Horseman : MeleeUnit
    {
        protected override int CanMoveValue { get; } = 10;
        public override int CanAttackValue { get; } = 1;
        public override int Damage { get; } = 75;
        public override int HP { get; } = 200;
        public override ImageSource SourceImage { get; } = BuildSourceFromPath("Resources/Units/Horseman.png");
        public Horseman(Player player) : base(player)
        {
        }
    }
}