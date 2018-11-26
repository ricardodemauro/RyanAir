namespace Rover.Domain.Contracts
{
    public interface ICommand
    {
        string Description { get; set; }
        string Abreviation { get; set; }
        bool ValidateCommand();
        void ChangeFacingPosition(ref RoverFacing roverFacing, ref int roverPositionX, ref int roverPositionY);
    }
}
