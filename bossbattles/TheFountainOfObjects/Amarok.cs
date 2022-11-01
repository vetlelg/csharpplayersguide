namespace TheFountainOfObjects
{
    public class Amarok : Room
    {
        public Amarok(Point position) : base(position) { RoomType = RoomType.Amarok; }

        public override string GetRoomInformation() => "A giant, rotting, wolf-like creature suddenly attacks! You are instantly killed!";
        public override string GetAdjacentRoomInformation() => "You can smell the rotten stench of an amarok in a nearby room.";
    }
}