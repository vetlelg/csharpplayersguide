using System;

namespace TheOldRobot
{
    class Program
    {
        static void Main(string[] args)
        {
            Robot robot = new Robot();
            Console.WriteLine("Enter three commands:");
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "stop") break;

                robot.Commands.Add(command switch
                {
                    "on" => new OnCommand(),
                    "off" => new OffCommand(),
                    "north" => new NorthCommand(),
                    "south" => new SouthCommand(),
                    "east" => new EastCommand(),
                    "west" => new WestCommand()
                });
            }
            robot.Run();
        }
    }
}
