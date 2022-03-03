using System.Windows.Media;

namespace Strategy.Domain.Models
{
    /// <summary>
    /// Класс мечника.
    /// </summary>
    public sealed class Swordsman : MeleeUnit
    {
        protected override int CanMoveValue { get; } = 5;
        public override int CanAttackValue { get; } = 1;
        public override int Damage { get; } = 50;
        public override ImageSource SourceImage { get; } = BuildSourceFromPath("Resources/Units/Swordsman.png");
        public Swordsman(Player player) : base(player)
        {
        }
    }
}