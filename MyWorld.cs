using EasyMonoGame;
using Microsoft.Xna.Framework;

namespace EasyTestGetAllIntersectingActors
{
    internal class MyWorld : World
    {
        public MyWorld() : base(600, 800)
        {
            // Tile background with the file "bluerock" in the Content folder.
            //BackgroundTileName = "bluerock";
            BackgroundColor = Color.LightGreen;

            Add(new Hippo(), "hippo", 300, 400);
            Add(new Fly(), "fly", 270, 370);
            Add(new Fly(), "fly", 330, 370);
        }  
    }
}
