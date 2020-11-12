using JVHGameFramework.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;


namespace JVHGameFramework.Common
{
    public abstract class CreatureBase: IPosition
    {
        private int _hitPoints;
        private int _ageLimit;
        private int _age;

        protected IWorld TheWorld { get; }
        public int HitPoints { get; set; }
        public int AgeLimit { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; }
        public KindsOfCreatures Kind { get; }

        protected CreatureBase(int hitPoints, int ageLimit, int age, Gender gender, IPosition position)
        {
            TheWorld = World.Instance;
            HitPoints = hitPoints;
            AgeLimit = ageLimit;
            Age = age;
            Gender = gender;
            X = position.X;
            Y = position.Y;
        }
        public bool Dead
        {
            get { return _hitPoints <= 0 || _age > _ageLimit; }
        }

        public int X { get ; set ; }
        public int Y { get; set; }

        
    }
}
