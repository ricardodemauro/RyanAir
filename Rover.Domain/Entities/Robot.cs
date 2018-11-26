﻿using System;
using Rover.Domain.Contracts;

namespace Rover.Domain.Entities
{
    public class Robot : IRobot
    {
        static RoverFacing roverFacing;
        static int roverPositionX;
        static int roverPositionY;

        public void ChangeToLeft()
        {
            roverFacing = roverFacing == RoverFacing.North ? RoverFacing.West : (RoverFacing)((int)roverFacing - 1);
            Console.WriteLine($"Rover is now at {roverPositionX}, {roverPositionY} - facing {roverFacing}");
        }

        public void ChangeToRight()
        {
            roverFacing = roverFacing == RoverFacing.West ? RoverFacing.North : (RoverFacing)((int)roverFacing + 1);
            Console.WriteLine($"Rover is now at {roverPositionX}, {roverPositionY} - facing {roverFacing}");
        }

        public void Move()
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