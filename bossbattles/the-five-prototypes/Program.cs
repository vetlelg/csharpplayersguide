using System;

namespace the_five_prototypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create two points and print to console
            Point point1 = new Point(-4, 0);
            Point point2 = new Point(2, 3);
            Console.WriteLine($"({point1.X}, {point1.Y})");
            Console.WriteLine($"({point2.X}, {point2.Y})");

            // Create two colors and print rgb values to console
            Color yellow = Color.Yellow;
            Color azure = new Color(0, 127, 255);
            Console.WriteLine($"rgb({yellow.R}, {yellow.G}, {yellow.B})");
            Console.WriteLine($"rgb({azure.R}, {azure.G}, {azure.B})");

            // Create a deck of cards. A card for every color and every rank, and display the cards to console
            Card[] deck = new Card[56];
            for (int i = 1; i <= 4; i++)
            {
                for (int n = 1; n <= 14; n++)
                {
                    int index = i*n - 1;
                    deck[index] = new Card((CardColor) i - 1, (CardRank) n - 1);
                    Console.WriteLine($"The {deck[index].Color} {deck[index].Rank} IsSymbol: {deck[index].IsSymbol} IsNumber: {deck[index].IsNumber}");

                }
            }

            // Create a door. When creating the door the user will be asked to create a passcode.
            // Print status of the door and ask the user for input
            Door door = new Door();
            while (true)
            {
                Console.WriteLine($"The door is {door.State}. What do you want to do?");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "open":
                        door.Open();
                        break;
                    case "close":
                        door.Close();
                        break;
                    case "lock":
                        door.Lock();
                        break;
                    case "unlock":
                        door.Unlock();
                        break;
                    case "change passcode":
                        door.ChangePasscode();
                        break;
                }
            }

            // Create password validator. Get password for user and display if password is valid or invalid
            PasswordValidator validator = new PasswordValidator();
            while (true)
            {
                Console.Write("Enter password: ");
                validator.Password = Console.ReadLine();
                if (validator.IsValid()) Console.WriteLine("Valid.");
                else Console.WriteLine("Invalid.");
            }
        }
    }

    // Class representing a point with x and y coordinates
    public class Point
    {
        public int X { get; }
        public int Y { get; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Point()
        {
            X = 0;
            Y = 0;
        }
    }

    // Class representing a color with rgb values
    public class Color
    {
        public byte R { get; }
        public byte G { get; }
        public byte B { get; }
        
        public Color(byte r, byte g, byte b)
        {
            R = r;
            G = g;
            B = b;
        }

        public static Color White { get; } = new Color(255, 255, 255);
        public static Color Black { get; } = new Color(0, 0, 0);
        public static Color Red { get; } = new Color(255, 0, 0);
        public static Color Orange { get; } = new Color(255, 165, 0);
        public static Color Yellow { get; } = new Color(255, 255, 0);
        public static Color Green { get; } = new Color(0, 128, 0);
        public static Color Blue { get; } = new Color(0, 0, 255);
        public static Color Purple { get; } = new Color(128, 0, 128);
    }

    // Class and enumerations representing a card
    // Each card has a color (red, green, blue, yellow) and a rank (1 through 10, followed by the symbols $,%,^,&)
    public enum CardColor { Red, Green, Blue, Yellow }
    public enum CardRank { One, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, DollarSign, Percent, Caret, Ampersand }
    public class Card
    {
        public CardColor Color { get; }
        public CardRank Rank { get; }

        public Card(CardColor color, CardRank rank)
        {
            Color = color;
            Rank = rank;
        }

        public bool IsSymbol => Rank > CardRank.Ten;
        public bool IsNumber => !IsSymbol;
    }

    // Class representing a door which can be opened, closed, locked and unlocked
    // Enum representing the state of the door
    // Door can only be unlocked with a passcode. Passcode is set when door is created, but can be changed
    public enum DoorState { Open, Closed, Locked }
    public class Door
    {
        public DoorState State { get; private set; } = DoorState.Locked;
        public int Passcode { get; private set; }

        public Door() => GetPassCode("Enter new passcode: ");

        public int GetPassCode(string text)
        {
            Console.Write(text);
            return Convert.ToInt32(Console.ReadLine());
        }
        public void Open()
        {
            if (State == DoorState.Closed) State = DoorState.Open;
            else if (State == DoorState.Open) Console.WriteLine("Already open.");
            else Console.WriteLine("You must unlock the door first.");
        }
        public void Close()
        {
            if (State == DoorState.Open) State = DoorState.Closed;
            else Console.WriteLine("Already closed.");
        }
        public void Lock()
        {
            if (State == DoorState.Closed) State = DoorState.Locked;
            else if (State == DoorState.Locked) Console.WriteLine("Already locked.");
            else Console.WriteLine("You must close the door first.");
        }
        public void Unlock()
        {
            if (State != DoorState.Locked) Console.WriteLine("Already unlocked.");
            else if (GetPassCode("Enter current passcode: ") == Passcode) State = DoorState.Closed;
            else Console.WriteLine("Incorrect passcode.");
        }
        public void ChangePasscode()
        {
            if (GetPassCode("Enter current passcode: ") == Passcode) Passcode = GetPassCode("Enter new passcode: ");
            else Console.WriteLine("Incorrect passcode.");
        }
    }

    // Password validator. Contains properties for password and if password meets password requirements
    // Contains method that checks if the password meets the password requirements
    public class PasswordValidator
    {
        public string Password { get; set; }
        private bool ContainsUpper { get; set; }
        private bool ContainsLower { get; set; }
        private bool ContainsTOrAmpersand { get; set; }
        private bool ContainsNumber { get; set; }
        private int MinLength { get; } = 6;
        private int MaxLength { get; } = 13;

        public bool IsValid()
        {
            foreach (char letter in Password)
            {
                if (char.IsUpper(letter)) ContainsUpper = true;
                if (char.IsLower(letter)) ContainsLower = true;
                if (char.IsNumber(letter)) ContainsNumber = true;
                if (letter == '&' || letter == 'T') ContainsTOrAmpersand = true;
            }
            if (ContainsUpper && ContainsLower && ContainsNumber && ContainsTOrAmpersand && Password.Length >= MinLength && Password.Length <= MaxLength) return true;
            else return false;
        }
    }

}
