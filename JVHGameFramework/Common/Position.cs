using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using JVHGameFramework.Interfaces;

namespace JVHGameFramework.Common
{
    public class Position : IPosition
    {
        public int X {get; set; }
        public int Y { get; set; }
        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
