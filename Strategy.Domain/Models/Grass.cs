using System.Windows.Media;

namespace Strategy.Domain.Models
{
    /// <summary>
    /// Проходимая поверхность на земле.
    /// </summary>
    public sealed class Grass : BaseMapObject
    {
        public override ImageSource SourceImage { get; } = BuildSourceFromPath("Resources/Ground/Grass.png");
    }
}