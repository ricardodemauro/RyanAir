namespace Rover.Domain
{
    public interface ICommandFactory
    {
        void ExecuteCommand(string command);
    }
}
