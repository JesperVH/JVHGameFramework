using JVHGameFramework.Common;
using JVHGameFramework.Equipment;
using JVHGameFramework.Interfaces;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace JVHGameFramework.Creatures
{
    public class Humanoids : CreatureBase
    {
        private Armor _armor;
        private Boots _boots;
        private Shield _shield;

        private List<EquipmentBase> inventory = new List<EquipmentBase>();
        
        public Humanoids(int hitPoints, int ageLimit, int age, Gender gender, HumanoidRaces race, IPosition position) : base(hitPoints, ageLimit, age, gender, position)
        {
        }

        public void AddEquipment(EquipmentBase e)
        {
            inventory.Add(e);
        }

        public int DealDamage(List<EquipmentBase> i)
        {
            EquipmentBase w = null;
            foreach(var weapon in inventory)
            {
                if(weapon.AttackWeapon == true)
                {
                    if(w == null)
                    {
                        w = weapon;
                    }
                    else if(weapon.Modifier(weapon.BaseMod, weapon.Quality) > w.Modifier(w.BaseMod, w.Quality))
                    {
                        w = weapon;
                    }
                }
            }

            return w.Modifier(w.BaseMod, w.Quality);
        }
        
        public List<EquipmentBase> Inventory { get; set; }
        
        public void Act()
        {
            if(TheWorld.Nearby())
            {
                DealDamage(inventory);
            }
        }
    }
}
