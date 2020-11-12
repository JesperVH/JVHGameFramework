using JVHGameFramework.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace JVHGameFramework.Equipment
{
    public class AttackEquipment : EquipmentBase
    {
        private int _modifier;
        public AttackEquipment(string description, int baseMod, bool attackWeapon, bool enchanted, int quality) : base(description, baseMod, attackWeapon, enchanted, quality)
        {
        }
        public override int Modifier(int basemod, int quality)
        {
            return _modifier = basemod * quality;
        }
        public override string ToString() { return $"{_modifier}"; }
    }
}
