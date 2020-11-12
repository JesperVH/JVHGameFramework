using System;
using System.Collections.Generic;
using System.Text;

namespace JVHGameFramework.Common
{
    class EquipmentDecoratorQuality : IEquipmentBase
    {
        private IEquipmentBase _equipment;
        private int _addqua;
        public EquipmentDecoratorQuality(IEquipmentBase equipment, int addqua)
        {
            _equipment = equipment;
            _addqua = addqua;

        }
        public int BaseMod { get => _equipment.BaseMod;  set => _equipment.BaseMod = value;  }

        public bool AttackWeapon { get => _equipment.AttackWeapon; set => _equipment.AttackWeapon = value; }
        public string Description { get => _equipment.Description; set => _equipment.Description = value; }
        public bool Enchanted { get => _equipment.Enchanted; set => _equipment.Enchanted = value; }
        public int Quality { get {return _equipment.Quality + _addqua; } set { _equipment.Quality = value; } }

        public override string ToString() { return $"{BaseMod}"; }
    }
}
