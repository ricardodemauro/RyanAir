using Rover.Domain.Contracts;

namespace Rover.Domain
{
    public interface ICommandFactory
    {
        void ExecuteCommand(string command, IRobot robot);
    }
}
