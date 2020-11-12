using System;
using System.Collections.Generic;
using System.Text;

namespace JVHGameFramework.Common
{
    public abstract class EquipmentBase : IEquipmentBase
    {
        public EquipmentBase(string description, int baseMod, bool attackWeapon, bool enchanted, int quality)
        {
            Description = description;
            BaseMod = baseMod;
            AttackWeapon = attackWeapon;
            Enchanted = enchanted;
            Quality = quality;

        }
        public string Description { get; set; }
        public virtual int BaseMod { get; set; }
        public bool AttackWeapon { get; set; }
        public bool Enchanted { get; set; }
        public int Quality { get; set; }
        public abstract int Modifier(int baseMod, int quality);
        public override string ToString() { return $"{BaseMod}"; }
    }
}
