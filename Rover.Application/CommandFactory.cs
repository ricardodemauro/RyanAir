using Rover.Domain;
using Rover.Domain.Contracts;
using System;


namespace Rover.Application
{
    public class CommandFactory : ICommandFactory
    {
        static RoverFacing roverFacing;
        static int roverPositionX;
        static int roverPositionY;

        public void ExecuteCommand(string command, IRobot robot)
        {            
            switch (command.ToUpper())
            {
                case "L":
                    robot.ChangeToLeft(ref roverFacing, ref roverPositionX, ref roverPositionY);
                    break;
                case "R":
                    robot.ChangeToRight(ref roverFacing, ref roverPositionX, ref roverPositionY);
                    break;
                case "F":
                    robot.Move(ref roverFacing, ref roverPositionX, ref roverPositionY);
                   break;
            }
        }
    }
}
