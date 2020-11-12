using JVHGameFramework.Common;
using JVHGameFramework.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace JVHGameFramework.Creatures
{
    public abstract class Monsters : CreatureBase
    {
        private int _damage;
        public Monsters(int hitPoints, int ageLimit, int age, Gender gender, IPosition position, int damage) : base(hitPoints, ageLimit, age, gender, position)
        {

        }
        public int HitPoints { get; set; }
        public int Age { get; set; }
        public int AgeLimit { get; set; }
        public Gender Gender { get; set; }
        public IPosition Position { get; set; }
        public int Damage { get; set; }
    }
}
