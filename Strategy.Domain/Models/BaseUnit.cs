using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Domain.Models
{
    public class BaseUnit
    {
        public BaseUnit(Player player)
        {
            Player = player;
        }

        /// <summary>
        /// Координата x лучника на карте.
        /// </summary>
        public int X { get; set; }

        /// <summary>
        /// Координата y лучника на карте.
        /// </summary>
        public int Y { get; set; }

        /// <summary>
        /// Игрок, который управляет юнитом.
        /// </summary>
        public Player Player { get; }
    }
}
