using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;
using System.Text;
using JVHGameFramework.Creatures;
using JVHGameFramework.Interfaces;

namespace JVHGameFramework.Common
{
    public class World: IWorld
    {
        private static World _instance;
        private bool _nearby;
        private List<CreatureBase> creatures = new List<CreatureBase>();
        private CreatureBase hero = new Humanoids(20, 65, 23, Gender.male, HumanoidRaces.human, new Position(4, 1));

        public static World Instance
        {
            get { return _instance ?? (_instance = new World()); }
        }

        private World()
        {
            UpdateState();
        }

        public void UpdateState()
        {
            _nearby = Randomizer.CoinFlip();
        }

        public bool Nearby()
        {

            //foreach(var c in creatures)
            //{
            //    if((hero.X == c.X - 1 || hero.X == c.X + 1) && (hero.Y == c.Y - 1 || hero.Y == c.Y + 1))
            //    {
            //        return true;
            //    }

            //}
            // return false; 
            return creatures.Where(c => (hero.X == c.X - 1 || hero.X == c.X + 1) && (hero.Y == c.Y - 1 || hero.Y == c.Y + 1)).Count() == 1;
        }

        public CreatureBase GetNearbyCreature()
        {
            foreach (var c in creatures)
            {
                if ((hero.X == c.X - 1 || hero.X == c.X + 1) && (hero.Y == c.Y - 1 || hero.Y == c.Y + 1))
                {
                    return c;
                }

            }
            throw new Exception();

        }
        public override string ToString()
        {
            return base.ToString();
        }
        
        
    }
}
