using Microsoft.Xna.Framework;

class Bomb : AnimatedGameObject
{    
    public Bomb(bool moveToLeft, Vector2 BombPosition) : base(5, "Bomb")
    {
        LoadAnimation("Sprites/Bomb/spr_Bomb@3", "default", true, 0.2f);
        PlayAnimation("default");       
        this.Position = BombPosition;
        if (moveToLeft) Mirror = moveToLeft;          
    }

    public override void Update(GameTime gameTime)
    {
        base.Update(gameTime);
        visible = true;
        velocity.X = 600;
        if (Mirror)
        {
            velocity.X *= -1;
        }

        Rectangle screenBox = new Rectangle(0, 0, GameEnvironment.Screen.X, GameEnvironment.Screen.Y);
        if (!screenBox.Intersects(this.BoundingBox))
        {
            Player.shooting = false;
            visible = false;
        }
    } 
}

