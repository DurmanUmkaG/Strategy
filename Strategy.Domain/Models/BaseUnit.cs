﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Domain.Models
{
    public abstract class BaseUnit: Base
    {
        public Player Player { get; }

        protected abstract int CanMoveValue { get; }
        public BaseUnit(Player player)
        {
            Player = player;
        }

        public bool CanMove(int x, int y)
        {
            if (Math.Abs(X - x) > CanMoveValue || Math.Abs(Y - y) > CanMoveValue)
                return false;
            return true;
        }
    }
}
