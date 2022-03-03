using System.Windows.Media;

namespace Strategy.Domain.Models
{
    /// <summary>
    /// Непроходимая наземная поверхность.
    /// </summary>
    public sealed class Water : BaseMapObject
    {
        public override ImageSource SourceImage { get; } = BuildSourceFromPath("Resources/Ground/Water.png");
    }
}