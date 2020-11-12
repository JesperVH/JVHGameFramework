using JVHGameFramework.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace JVHGameFramework.Equipment
{
    public class Boots : EquipmentBase
    {
        private int _modifier;
        public Boots(string description, int baseMod, bool attackWeapon, bool enchanted, int quality) : base(description, baseMod, attackWeapon, enchanted, quality)
        {
        }
        public override int Modifier(int baseMod, int quality)
        {
            return _modifier = baseMod * quality;
        }
    }
}
