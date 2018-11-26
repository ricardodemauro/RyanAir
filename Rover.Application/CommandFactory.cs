using Rover.Domain;
using Rover.Domain.Entities;
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
            switch (command.ToUpper())
            {
                case "L":
                    new Left().ChangeFacingPosition(ref roverFacing, ref roverPositionX, ref roverPositionY);
                    break;
                case "R":
                    new Right().ChangeFacingPosition(ref roverFacing, ref roverPositionX, ref roverPositionY);
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
