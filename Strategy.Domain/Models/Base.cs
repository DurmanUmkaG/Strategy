using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Strategy.Domain.Models
{
    public abstract class Base
    {
        public int X { get; set; }
        public int Y { get; set; }
        public abstract ImageSource SourceImage { get; }

        /// <summary>
        /// Получить изображение по указанному пути.
        /// </summary>
        protected static ImageSource BuildSourceFromPath(string path)
        {
            return new BitmapImage(new Uri(path, UriKind.Relative));
        }
    }
}
