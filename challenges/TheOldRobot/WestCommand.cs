using System;

namespace TheOldRobot
{
    public class WestCommand : IRobotCommand
    {
        public void Run(Robot robot)
        {
            if (robot.IsPowered == true) robot.X--;
        }

    }
}