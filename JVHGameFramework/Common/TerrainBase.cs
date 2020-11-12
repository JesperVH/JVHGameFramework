using System;
using System.Collections.Generic;
using System.Text;

namespace JVHGameFramework.Common
{
    public abstract class TerrainBase
    {
        public bool IsPassable { get; set; }
        public bool IsBreakable { get;  set; }
        public string Description { get; set; }

        public TerrainBase(bool isPassable, bool isBreakable, string description)
        {

        }

        public string ToString()
        {
            return "";
        }
    }
}
