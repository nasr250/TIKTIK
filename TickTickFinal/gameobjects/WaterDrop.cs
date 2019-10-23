using System;
using Microsoft.Xna.Framework;

abstract class WaterDrop : SpriteGameObject
{
    protected float bounce;
    protected int counter;
    protected int velocity = 2;

    public WaterDrop(int layer=0, string id="") : base("Sprites/spr_water", layer, id) 
    {
    }

    public abstract void MoveDrop();

    public override void Update(GameTime gameTime)
    {
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
