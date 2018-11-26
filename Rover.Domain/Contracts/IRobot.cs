namespace Rover.Domain.Contracts
{
    public interface IRobot
    {
        void ChangeFacing(bool left);
        void MoveForward();
    }
}
