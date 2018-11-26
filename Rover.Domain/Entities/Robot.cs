using System;
using Rover.Domain.Contracts;

namespace Rover.Domain.Entities
{
    public class Robot : IRobot
    {
        private static RoverFacing roverFacing;
        private static int roverPositionX;
        private static int roverPositionY;

        public RoverFacing RoverFacing { get { return roverFacing; } set { roverFacing = value; } }
        public int RoverPositionX { get { return roverPositionX; } set { roverPositionX = value; } }
        public int RoverPositionY { get { return roverPositionY; } set { roverPositionY = value; } }

        public void ChangeFacing(bool left)
        {
            if (left)
                roverFacing = roverFacing == RoverFacing.North ? RoverFacing.West : (RoverFacing)((int)roverFacing - 1);
            else
                roverFacing = roverFacing == RoverFacing.West ? RoverFacing.North : (RoverFacing)((int)roverFacing + 1);

            Console.WriteLine($"Rover is now at {roverPositionX}, {roverPositionY} - facing {roverFacing}");
        }

        public void MoveForward()
        {
            switch (roverFacing)
            {
                case RoverFacing.North:
                    if (roverPositionX < 4)
                        roverPositionX++;
                    break;
                case RoverFacing.East:
                    if (roverPositionY < 4)
                        roverPositionY++;
                    break;
                case RoverFacing.South:
                    if (roverPositionX > 0)
                        roverPositionX--;
                    break;
                case RoverFacing.West:
                    if (roverPositionY > 0)
                        roverPositionY--;
                    break;
            }

            Console.WriteLine($"Rover is now at {roverPositionX}, {roverPositionY} - facing {roverFacing}");
        }
    }
}