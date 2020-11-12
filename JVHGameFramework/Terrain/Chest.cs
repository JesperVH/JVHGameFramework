using JVHGameFramework.Common;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace JVHGameFramework.Terrain
{
    public class Chest: TerrainBase
    {
        private List<EquipmentBase> content = new List<EquipmentBase>();
        public Chest(bool isPassable, bool isBreakable, string description, List<EquipmentBase> content): base(isPassable, isBreakable, description)
        {
            this.content.AddRange(content);
        }

        public List<EquipmentBase> Search()
        {
            List<EquipmentBase> l = new List<EquipmentBase>(content);
            content.Clear();
            return l;
        }
    }
}
