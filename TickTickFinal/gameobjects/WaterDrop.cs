using System;
using Microsoft.Xna.Framework;

abstract class WaterDrop : SpriteGameObject
{
    protected float bounce;
    protected int counter;
    protected int velocity = 2;
    protected Random random = new Random();
    protected int randomcounter;
    public WaterDrop(int layer=0, string id="") : base("Sprites/spr_water", layer, id) 
    {
    }

    public abstract void MoveDrop();

    public override void Update(GameTime gameTime)
    {
        randomcounter = random.Next(100, 200);
        randomcounter--;
        counter++;
        MoveDrop();
        Player player = GameWorld.Find("player") as Player;
        if (visible && CollidesWith(player))
        {
            visible = false;
            GameEnvironment.AssetManager.PlaySound("Sounds/snd_watercollected");
        }
    }
}
