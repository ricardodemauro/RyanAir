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
                    robot.ChangeToLeft();
                    break;
                case "R":
                    robot.ChangeToRight();
                    break;
                case "F":
                    robot.Move();
                   break;
            }
        }
    }
}