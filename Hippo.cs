using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMonoGame;

namespace EasyTestGetAllIntersectingActors
{
    internal class Hippo : Actor
    {
        private int time = 0;
        public override void Act()
        {
            time += 1;
            if (time > 40)
            {
                List<Actor> flies = GetIntersectingActors(typeof(Fly));
                foreach (var fly in flies)
                {
                    fly.Y -= 50;
                }
            } 
        }
    }
}
