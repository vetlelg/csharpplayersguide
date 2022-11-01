namespace TheFountainOfObjects
{
    public class Pit : Room
    {

        public Pit(Point position) : base(position) { RoomType = RoomType.Pit; }
        
        public override string GetRoomInformation() => "Oh no! You fall to your death in a bottomless pit!";
        public override string GetAdjacentRoomInformation() => "You feel a draft. There is a pit in a nearby room.";
    }
}