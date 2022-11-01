using System;

namespace TheFountainOfObjects
{
    public class World
    {
        public int Rows { get; }
        public int Columns { get; }
        public Room[,] Grid { get; }
        public int[,] TypeGrid { get; }

        // Create the world
        public World()
        {
            // Ask player for input
            Display.AskForDifficulty();
            string size = Console.ReadLine();

            // Determine size of world based on player's input
            // Create grid and determine position of rooms in the grid
            if (size == "small")
            {
                Rows = Columns = 4;
                Grid = new Room[Rows, Columns];
                TypeGrid = new int[,]
                {
                    { 1, 0, 0, 0 },
                    { 3, 0, 0, 0 },
                    { 0, 0, 4, 0 },
                    { 0, 2, 5, 0 }
                };
            }
            else if (size == "medium")
            {
                Rows = Columns = 6;
                Grid = new Room[Rows, Columns];
                TypeGrid = new int[,]
                {
                    { 1, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0 },
                    { 4, 0, 2, 0, 0, 3 },
                    { 0, 0, 0, 0, 2, 0 },
                    { 0, 3, 0, 4, 0, 5 },
                    { 0, 0, 0, 0, 0, 0 }
                };
            }
            else if (size == "large")
            {
                Rows = Columns = 8;
                Grid = new Room[Rows, Columns];
                TypeGrid = new int[,]
                {
                    { 1, 0, 4, 0, 0, 0, 0, 0 },
                    { 2, 0, 0, 4, 0, 0, 0, 0 },
                    { 0, 0, 0, 2, 0, 0, 0, 0 },
                    { 0, 0, 3, 5, 0, 3, 0, 0 },
                    { 3, 0, 0, 4, 2, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0, 0 }
                };
            }

            // Loop through the grid and create rooms
            for (int i = 0; i < Rows; i++)
            {
                for (int n = 0; n < Columns; n++)
                {
                    RoomType type = (RoomType) TypeGrid[i, n];
                    if (type == RoomType.Empty)
                        Grid[i, n] = new Room(new Point(i, n));
                    else if (type == RoomType.Entrance)
                        Grid[i, n] = new Entrance(new Point(i, n));
                    else if (type == RoomType.Pit)
                        Grid[i, n] = new Pit(new Point(i, n));
                    else if (type == RoomType.Maelstrom)
                        Grid[i, n] = new Maelstrom(new Point(i, n));
                    else if (type == RoomType.Amarok)
                        Grid[i, n] = new Amarok(new Point(i, n));
                    else if (type == RoomType.Fountain)
                        Grid[i, n] = new Fountain(new Point(i, n));
                }
            }
        }

        public Room GetRoom(Point position)
        {
            foreach (Room room in Grid)
                if (position.Equals(room.Position))
                    return room;
            return null;
        }

        public Room GetRoom(RoomType type)
        {
            foreach (Room room in Grid)
                if (room.RoomType == type)
                    return room;
            return null;
        }
    }
}