namespace Rover.Domain.Contracts
{
    public interface ICommand
    {
        string Abreviation { get; set; }
        bool Validate();
    }
}
