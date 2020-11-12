using JVHGameFramework.Common;
using JVHGameFramework.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace JVHGameFramework.Creatures
{
    public class Manticore : Monsters
    {
        public Manticore(int hitPoints, int ageLimit, int age, Gender gender, IPosition position, int damage) : base(hitPoints, ageLimit, age, gender, position, damage)
        {
        }
    }
}
