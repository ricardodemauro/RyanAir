using System;
using Rover.Domain.Contracts;

namespace Rover.Domain.Entities
{
    public class Robot : IRobot
    {
        public void ChangeToLeft(ref RoverFacing roverFacing, ref int roverPositionX, ref int roverPositionY)
        {
            roverFacing = roverFacing == RoverFacing.North ? RoverFacing.West : (RoverFacing)((int)roverFacing - 1);
            Console.WriteLine($"Rover is now at {roverPositionX}, {roverPositionY} - facing {roverFacing}");
        }

        public void ChangeToRight(ref RoverFacing roverFacing, ref int roverPositionX, ref int roverPositionY)
        {
            roverFacing = roverFacing == RoverFacing.West ? RoverFacing.North : (RoverFacing)((int)roverFacing + 1);
            Console.WriteLine($"Rover is now at {roverPositionX}, {roverPositionY} - facing {roverFacing}");
        }

        public void Move(ref RoverFacing roverFacing, ref int roverPositionX, ref int roverPositionY)
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
