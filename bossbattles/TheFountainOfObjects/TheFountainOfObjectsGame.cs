using System;

namespace TheFountainOfObjects
{
    public class TheFountainOfObjectsGame
    {
        public void Run()
        {
            // Displays introduction to the console
            Display.Introduction();

            // Create world
            World world = new World();

            // Create a player at the same position as the entrance
            Player player = new Player(world.GetRoom(RoomType.Entrance).Position);

            // Keeps track of how much time a player spends in the Cavern of Objects
            DateTime startTime = DateTime.Now;

            while(true)
            {
                
                // Display status of player. Player position, amount of arrows left etc.
                Display.Player(player);

                // Display information to console about the room the player is currently in
                Display.CurrentRoomInformation(player, world);

                // If the player is in a room with a maelstrom, move the player and maelstrom
                // If player or maelstrom was moved outside of the grid, move them to the edge of the grid instead
                Room room = world.GetRoom(player.Position);
                if (room.RoomType == RoomType.Maelstrom)
                {
                    Maelstrom maelstrom = (Maelstrom) room;
                    maelstrom.MalevolentWind(player, world);
                    player.OutOfBounds(world);
                    maelstrom.OutOfBounds(world);
                    continue;
                }

                // If the fountain is enabled and the player is at the entrance display text to console and end the game
                if (GameOver(player, world)) { Display.TimeElapsed(startTime, DateTime.Now); break; }

                // Display information about what the player can sense from adjacent rooms
                Display.AdjacentRoomsInformation(player, world);

                // Ask player for input, get input from player and let the player interact with the world
                player.Action(world);
            }
        }

        // Check if the fountain has been enabled and if the player is at the entrance
        public bool GameOver(Player player, World world)
        {
            if (PlayerWon(player, world))
            {
                Display.PlayerWon();
                return true;
            }
            else if (PlayerLost(player, world))
            {
                Display.PlayerLost();
                return true;
            }
            else
                return false;
        }

        // The player wins if the fountain is enabled and the player is at the entrance
        public bool PlayerWon(Player player, World world)
        {
            Room room = world.GetRoom(player.Position);
            Fountain fountain = (Fountain) world.GetRoom(RoomType.Fountain);
            if (room.RoomType == RoomType.Entrance && fountain.IsEnabled == true)
                return true;
            else
                return false;
        }

        // The player loses if they are in the same room as an amarok or a pit
        public bool PlayerLost(Player player, World world)
        {
            RoomType type = world.GetRoom(player.Position).RoomType;
            if (type == RoomType.Pit || type == RoomType.Amarok)
                return true;
            else
                return false;
        }
    }

    // Representing a coordinate in the grid
    public struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point(int x, int y) { X = x; Y = y; }
    }
}