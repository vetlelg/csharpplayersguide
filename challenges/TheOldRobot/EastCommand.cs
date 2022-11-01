using System;

namespace TheOldRobot
{
    public class EastCommand : IRobotCommand
    {
        public void Run(Robot robot)
        {
            if (robot.IsPowered == true) robot.X++;
        }

    }
}