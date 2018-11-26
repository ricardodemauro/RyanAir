namespace Rover.Domain.Contracts
{
    public interface IRobot
    {
        RoverFacing RoverFacing { get; set; }
        int RoverPositionX { get; set; }
        int RoverPositionY { get; set; }
        void ChangeFacing(bool left);
        void MoveForward();
    }
}
