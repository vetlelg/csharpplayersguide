using System;

namespace TheFountainOfObjects
{
    public class Player : GameObject
    {
        public Player(Point position) { Position = position; }
        public int Arrows { get; set; } = 5;

        // Get input from player and interact with the world based on the player's input
        public void Action(World world)
        {
            Display.AskForAction();
            string input = Console.ReadLine();
            switch (input)
            {
                case "move north":
                    MoveNorth(world);
                    break;
                case "move south":
                    MoveSouth(world);
                    break;
                case "move east":
                    MoveEast(world);
                    break;
                case "move west":
                    MoveWest(world);
                    break;
                case "enable fountain":
                    EnableFountain(world);
                    break;
                case "shoot north":
                    ShootNorth(world);
                    break;
                case "shoot south":
                    ShootSouth(world);
                    break;
                case "shoot east":
                    ShootEast(world);
                    break;
                case "shoot west":
                    ShootWest(world);
                    break;
                case "help":
                    Display.Help();
                    break;
            }
        }

        // Actions that the player can do
        private void MoveNorth(World world)
        {
            if (Position.Y < world.Rows-1)
                Position = new Point(Position.X, Position.Y+1);
            else
                Display.MoveEdgeOfMap();
        }
        private void MoveSouth(World world)
        {
            if (Position.Y > 0)
                Position = new Point(Position.X, Position.Y-1);
            else
                Display.MoveEdgeOfMap();
        }
        private void MoveEast(World world)
        {
            if (Position.X > 0)
                Position = new Point(Position.X-1, Position.Y);
            else
                Display.MoveEdgeOfMap();
        }
        private void MoveWest(World world)
        {
            if (Position.X < world.Columns-1)
                Position = new Point(Position.X+1, Position.Y);
            else
                Display.MoveEdgeOfMap();
        }
        private void EnableFountain(World world)
        {
            if (world.GetRoom(Position).RoomType == RoomType.Fountain)
            {
                Fountain fountain = (Fountain) world.Grid[Position.X, Position.Y];
                fountain.IsEnabled = true;
            }
            else
                Display.NoEffect();
        }
        private void ShootNorth(World world)
        {
            Point target = new Point(Position.X, Position.Y+1);
            if (Position.Y < world.Rows-1)
                if (world.GetRoom(target).RoomType == RoomType.Amarok || world.GetRoom(target).RoomType == RoomType.Maelstrom)
                    world.Grid[target.X, target.Y] = new Room(target);
            Arrows--;
        }
        private void ShootSouth(World world)
        {
            Point target = new Point(Position.X, Position.Y-1);
            if (Position.Y > 0)
                if (world.GetRoom(target).RoomType == RoomType.Amarok || world.GetRoom(target).RoomType == RoomType.Maelstrom)
                    world.Grid[target.X, target.Y] = new Room(target);
            Arrows--;
        }
        private void ShootEast(World world)
        {
            Point target = new Point(Position.X-1, Position.Y);
            if (Position.X > 0)
                if (world.GetRoom(target).RoomType == RoomType.Amarok || world.GetRoom(target).RoomType == RoomType.Maelstrom)
                    world.Grid[target.X, target.Y] = new Room(target);
            Arrows--;
        }
        private void ShootWest(World world)
        {
            Point target = new Point(Position.X+1, Position.Y);
            if (Position.X < world.Columns-1)
                if (world.GetRoom(target).RoomType == RoomType.Amarok || world.GetRoom(target).RoomType == RoomType.Maelstrom)
                    world.Grid[target.X, target.Y] = new Room(target);
            Arrows--;
        }

    }
}