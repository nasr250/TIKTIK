using System;
using Microsoft.Xna.Framework;

abstract class WaterDrop : SpriteGameObject
{
    protected int counter;
    protected int velocity = 2;
    protected static Random random = new Random();
    protected int randomcounter = random.Next(100, 201);
    public WaterDrop(int layer = 0, string id = "") : base("Sprites/spr_water", layer, id)
    {
    }

    public abstract void MoveDrop();

    public override void Update(GameTime gameTime)
    {
        MoveDrop();
        Player player = GameWorld.Find("player") as Player;
        if (visible && CollidesWith(player))
        {
            visible = false;
            GameEnvironment.AssetManager.PlaySound("Sounds/snd_watercollected");
        }
    }
}
