using Rover.Domain;
using System;


namespace Rover.Application
{
    public class CommandFactory : ICommandFactory
    {
        static RoverFacing roverFacing;
        static int roverPositionX;
        static int roverPositionY;

        public void ExecuteCommand(string command)
        {
            switch (command)
            {
                case "L":
                    roverFacing = roverFacing == RoverFacing.North ? RoverFacing.West : (RoverFacing)((int)roverFacing - 1);
                    Console.WriteLine($"Rover is now at {roverPositionX}, {roverPositionY} - facing {roverFacing}");
                    break;
                case "R":
                    roverFacing = roverFacing == RoverFacing.West ? RoverFacing.North : (RoverFacing)((int)roverFacing + 1);
                    Console.WriteLine($"Rover is now at {roverPositionX}, {roverPositionY} - facing {roverFacing}");
                    break;
                case "F":
                    switch (roverFacing)
                    {
                        case RoverFacing.North:
                            roverPositionX++;
                            break;
                        case RoverFacing.East:
                            roverPositionY++;
                            break;
                        case RoverFacing.South:
                            roverPositionX--;
                            break;
                        case RoverFacing.West:
                            roverPositionY--;
                            break;
                    }
                    Console.WriteLine($"Rover is now at {roverPositionX}, {roverPositionY} - facing {roverFacing}");
                    break;
                default:
                    throw new Exception("invalid command");
            }
        }
    }
}
