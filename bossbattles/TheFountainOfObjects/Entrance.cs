namespace TheFountainOfObjects
{
    public class Entrance : Room
    {
        public Entrance(Point position) : base(position) { RoomType = RoomType.Entrance; }
        public override string GetRoomInformation() => "You see light coming from the cavern entrance.";
    }
}