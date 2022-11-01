namespace TheFountainOfObjects
{
    public abstract class GameObject
    {
        public Point Position { get; set; }

        public void OutOfBounds(World world)
        {
            if (Position.X >= world.Columns) Position = new Point(world.Columns, Position.Y);
            if (Position.X < 0) Position = new Point(0, Position.Y);
            if (Position.Y >= world.Rows) Position = new Point(Position.X, world.Rows);
            if (Position.Y < 0) Position = new Point(Position.X, 0);
        }

    }
}