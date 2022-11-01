using System;

namespace TheFountainOfObjects
{
    public class Room : GameObject
    {
        public RoomType RoomType { get; set; }

        public Room(Point position) { Position = position; RoomType = RoomType.Empty; }

        public virtual string GetRoomInformation() => null;
        public virtual string GetAdjacentRoomInformation() => null;

        public bool IsAdjacentTo(Point playerPosition)
        {
            int xDifference = Math.Abs(Position.X - playerPosition.X);
            int yDifference = Math.Abs(Position.Y - playerPosition.Y);
            if (xDifference == 1 && yDifference == 0)
                return true;
            if (xDifference == 0 && yDifference == 1)
                return true;
            if (xDifference == 1 && yDifference == 1)
                return true;
            else
                return false;
        }
    }

    public enum RoomType { Empty, Entrance, Pit, Maelstrom, Amarok, Fountain }
}