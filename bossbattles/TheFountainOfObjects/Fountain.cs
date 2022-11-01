namespace TheFountainOfObjects
{
    public class Fountain : Room
    {
        public bool IsEnabled { get; set; }

        public Fountain(Point position) : base(position) { RoomType = RoomType.Fountain; }

        public override string GetRoomInformation()
        {
            if (IsEnabled)
                return "You hear the rushing waters from the Fountain of Objects. It has been reactivated!";
            else
                return "You hear water dripping in this room. The Fountain of Objects is here!";
        }
    }
}