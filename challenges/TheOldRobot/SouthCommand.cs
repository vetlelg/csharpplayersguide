using System;

namespace TheOldRobot
{
    public class SouthCommand : IRobotCommand
    {
        public void Run(Robot robot)
        {
            if (robot.IsPowered == true) robot.Y--;
        }

    }
}