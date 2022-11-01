namespace TheFountainOfObjects
{
    public class Maelstrom : Room
    {
        public Maelstrom(Point position) : base(position) { RoomType = RoomType.Maelstrom; }

        public void MalevolentWind(Player player, World world)
        {
            foreach (Room room in world.Grid)
                if (room.RoomType == RoomType.Empty)
                {
                    world.Grid[room.Position.X, room.Position.Y] = this;
                    world.Grid[Position.X, Position.Y] = new Room(Position);
                    Position = new Point(room.Position.X, room.Position.Y);
                    player.Position = new Point(room.Position.X+2, room.Position.Y+1);
                    break;
                }
        }

        public override string GetRoomInformation() => "A maelstrom! You are swept away to another room! The maelstrom is also moved to another room.";
        public override string GetAdjacentRoomInformation() => "You hear the growling and groaning of a maelstrom nearby.";
    }
}