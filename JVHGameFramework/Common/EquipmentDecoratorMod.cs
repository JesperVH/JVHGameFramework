using System;
using System.Collections.Generic;
using System.Text;

namespace JVHGameFramework.Common
{
    public class EquipmentDecoratorMod : IEquipmentBase
    {
        private IEquipmentBase _equipment;
        private int _addmod;
        public EquipmentDecoratorMod(IEquipmentBase equipment, int addmod)
        {
            _equipment = equipment;
            _addmod = addmod;

        }
        public int BaseMod { get { return _equipment.BaseMod + _addmod; } set {_equipment.BaseMod = value; } }

        public bool AttackWeapon { get => _equipment.AttackWeapon; set => _equipment.AttackWeapon = value; }
        public string Description { get => _equipment.Description; set => _equipment.Description = value; }
        public bool Enchanted { get => _equipment.Enchanted; set => _equipment.Enchanted = value; }
        public int Quality { get => _equipment.Quality; set => _equipment.Quality = value; }

        public override string ToString() { return $"{BaseMod}"; }
    }
}
