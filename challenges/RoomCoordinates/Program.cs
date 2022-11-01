using System;

namespace RoomCoordinates
{
    class Program
    {
        static void Main(string[] args)
        {
            Coordinate p1 = new Coordinate(1, 1);
            Coordinate p2 = new Coordinate(2, 2);
            Coordinate p3 = new Coordinate(3, 2);
            Coordinate p4 = new Coordinate(5, 5);

            Console.WriteLine(p1.IsAdjacentTo(p2));
            Console.WriteLine(p1.IsAdjacentTo(p3));
            Console.WriteLine(p1.IsAdjacentTo(p4));
            Console.WriteLine(p2.IsAdjacentTo(p3));

        }
    }

    public struct Coordinate
    {
        private int Row { get; }
        private int Col { get; }

        public Coordinate(int row, int col) { Row = row; Col = col; }

        public bool IsAdjacentTo(Coordinate p)
        {
            int rowDifference = Math.Abs(Row - p.Row);
            int colDifference = Math.Abs(Col - p.Col);
            if (rowDifference == 1 && colDifference == 0) return true;
            if (rowDifference == 0 && colDifference == 1) return true;
            if (rowDifference == 1 && colDifference == 1) return true;
            
            return false;
        }
    }
}
