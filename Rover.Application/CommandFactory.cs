using Rover.Domain;
using Rover.Domain.Contracts;

namespace Rover.Application
{
    public class CommandFactory : ICommandFactory
    {        
        public void ExecuteCommand(string command, IRobot robot)
        {            
            switch (command.ToUpper())
            {
                case "L":
                    robot.ChangeFacing(true);
                    break;
                case "R":
                    robot.ChangeFacing(false);
                    break;
                case "F":
                    robot.MoveForward();
                   break;
            }
        }
    }
}