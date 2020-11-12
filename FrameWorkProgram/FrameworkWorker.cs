using System;
using System.Collections.Generic;
using System.Text;
using JVHGameFramework.Equipment;
using JVHGameFramework.Common;

namespace FrameWorkProgram
{
    public class FrameworkWorker
    {
        public void Worker()
        {
            JVHGameFramework.Equipment.AttackEquipment weapon = new AttackEquipment("Sword", 7, true, false, 2);
            Console.WriteLine(weapon);
            JVHGameFramework.Common.EquipmentDecoratorMod moddedWeapon = new EquipmentDecoratorMod(weapon, 4);
            Console.WriteLine(moddedWeapon);
            Console.WriteLine(weapon);
        }
    }
}
