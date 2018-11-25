namespace Rover.Domain.Contracts
{
    public interface ICommand
    {
        string Description { get; set; }
        string Abreviation { get; set; }
        bool ValidateCommand();
    }
}
