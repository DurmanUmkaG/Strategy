﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Domain.Models
{
    public class BaseUnit: Base
    {
        public BaseUnit(Player player)
        {
            Player = player;
        }
        public Player Player { get; }
    }
}
