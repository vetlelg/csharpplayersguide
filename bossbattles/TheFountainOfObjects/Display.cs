using System;
namespace TheFountainOfObjects
{
    public static class Display
    {
        public static void Introduction()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("You enter the Cavern of Objects, a maze of rooms filled with dangerous pits in search of the Fountain of Objects.");
            Console.WriteLine("Light is visible only in the entrance, and no other light is seen anywhere in the caverns. You must navigate the Caverns with your other senses.");
            Console.WriteLine("Find the Fountain of Objects, activate it, and return to the entrance.");
            Console.WriteLine("Look out for pits. You will feel a breeze if a pit is in an adjacent room. If you enter a room with a pit, you will die.");
            Console.WriteLine("Maelstroms are violent forces of sentient wind. Entering a room with one could transport you to any other location in the caverns. You will be able to hear their growling and groaning in nearby rooms.");
            Console.WriteLine("Amaroks roam the caverns. Encountering one is certain death, but they stink and can be smelled in nearby rooms.");
            Console.WriteLine("You carry with you a bow and a quiver of arrows. You can use them to shoot monsters in the caverns but be warned: you have a limited supply");
            Console.WriteLine("Type 'help' and press enter to display all available commands.");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void Help()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Available commands:");
            Console.WriteLine("move north - Move player to the north");
            Console.WriteLine("move south - Move player to the south");
            Console.WriteLine("move east - Move player to the east");
            Console.WriteLine("move west - Move player to the west");
            Console.WriteLine("shoot north - Shoot an arrow to the north");
            Console.WriteLine("shoot south - Shoot an arrow to the south");
            Console.WriteLine("shoot west - Shoot an arrow to the west");
            Console.WriteLine("shoot east - Shoot an arrow to the east");
            Console.WriteLine("enable fountain - Enable the fountain");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void AskForDifficulty()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Choose difficulty (small, medium, large): ");
        }

        // Display player position to console
        public static void Player(Player player)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"You are in the room at (Row={player.Position.Y}, Column={player.Position.X})");
            Console.WriteLine($"Arrows: {player.Arrows}");
            Console.ForegroundColor = ConsoleColor.White;
        }

        // Display information about the current room to console
        public static void CurrentRoomInformation(Player player, World world)
        {
            Room room = world.Grid[player.Position.X, player.Position.Y];

            if (room.RoomType == RoomType.Fountain)
                Console.ForegroundColor = ConsoleColor.Cyan;
            else if (room.RoomType == RoomType.Entrance)
                Console.ForegroundColor = ConsoleColor.Yellow;
            else if (room.RoomType == RoomType.Amarok)
                Console.ForegroundColor = ConsoleColor.DarkRed;
            else if (room.RoomType == RoomType.Pit)
                Console.ForegroundColor = ConsoleColor.DarkRed;
            else if (room.RoomType == RoomType.Maelstrom)
                Console.ForegroundColor = ConsoleColor.DarkBlue;

            if (room.GetRoomInformation() != null)
                Console.WriteLine(room.GetRoomInformation());

            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void AdjacentRoomsInformation(Player player, World world)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            foreach (Room room in world.Grid)
                if (room.IsAdjacentTo(player.Position) && room.GetAdjacentRoomInformation() != null)
                    Console.WriteLine(room.GetAdjacentRoomInformation());
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void AskForAction()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("What do you want to do? ");
        }
        public static void MoveEdgeOfMap()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Can't move past the edge of the map.");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void ShootEdgeOfMap()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Can't shoot past the edge of the map.");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void NoEffect()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("That had no effect.");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void PlayerWon()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("The fountain of Objects has been reactivated, and you have escaped with your life!\nYou win!");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void PlayerLost()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("You lost! Game over!");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void TimeElapsed(DateTime startTime, DateTime endTime)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            TimeSpan timeElapsed = endTime - startTime;
            Console.WriteLine($"Time elapsed: {timeElapsed.Hours}h {timeElapsed.Minutes}m {timeElapsed.Seconds}s.");
            Console.ForegroundColor = ConsoleColor.White;
        }

    }
}