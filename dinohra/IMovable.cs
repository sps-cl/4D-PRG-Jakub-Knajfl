﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dinohra
{
    interface IMovable
    {
        void Move();
        Vector Position { get; set; }
        Vector Speed { get; set; }
    }
}
