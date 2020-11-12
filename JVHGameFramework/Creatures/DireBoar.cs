using JVHGameFramework.Common;
using JVHGameFramework.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace JVHGameFramework.Creatures
{
    public class DireBoar : Beasts
    {
        public DireBoar(int hitPoints, int ageLimit, int age, Gender gender, IPosition position, int baseDmg) : base(hitPoints, ageLimit, age, gender, position, baseDmg)
        {
        }
    }
}
