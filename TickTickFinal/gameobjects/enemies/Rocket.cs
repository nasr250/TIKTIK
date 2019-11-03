using Microsoft.Xna.Framework;

class Rocket : AnimatedGameObject
{
    protected double spawnTime;
    protected Vector2 startPosition;
    protected bool deadRocket;

    public Rocket(bool moveToLeft, Vector2 startPosition)
    {
        LoadAnimation("Sprites/Rocket/spr_rocket@3", "default", true, 0.2f);
        PlayAnimation("default");
        Mirror = moveToLeft;
        this.startPosition = startPosition;
        Reset();
    }

    public override void Reset()
    {
        deadRocket = false;
        visible = false;    
        isAlive = true;
        position = startPosition;
        velocity = Vector2.Zero;
        spawnTime = GameEnvironment.Random.NextDouble() * 5;
    }

    public override void Update(GameTime gameTime)
    {
        base.Update(gameTime);
        if (spawnTime > 0)
        {
            spawnTime -= gameTime.ElapsedGameTime.TotalSeconds;
            return;
        }       
        velocity.X = 600;
        if (Mirror)
        {
            this.velocity.X *= -1;
        }
        CheckPlayerCollision();
        
        // check if we are outside the screen
        Rectangle screenBox = new Rectangle(0, 0, GameEnvironment.Screen.X, GameEnvironment.Screen.Y);
        if (!screenBox.Intersects(this.BoundingBox))
        {
            Reset();
        }
    }

    public void CheckPlayerCollision()
    {
        Player player = GameWorld.Find("player") as Player;
        if (CollidesWith(player) && visible && player.Velocity.Y <= velocity.Y && isAlive)
        {
            player.Die(false);
        }       
        if (!deadRocket)
        {
            visible = true;
        }
        if (CollidesWith(player) && visible && player.Velocity.Y > velocity.Y && isAlive) //Wanneer er een collision is met de player en wanneer de player hoger is dan de rocket dan gaat de rocket dood.
        {
            RocketDie();
        }   
    }

    public void CheckBombCollision()
    {
        Bomb bomb = GameWorld.Find("bomb") as Bomb;
        if (CollidesWith(bomb) && visible)
        {
            RocketDie();
        }
    }

    public void RocketDie()
    {
        deadRocket = true;
        isAlive = false;
        Reset();
    }
}
