namespace Rover.Domain.Contracts
{
    public interface IRobot
    {
        void ChangeToLeft();
        void ChangeToRight();
        void Move();
    }
}
