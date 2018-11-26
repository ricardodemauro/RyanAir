namespace Rover.Domain.Contracts
{
    public interface IRobot
    {
        void ChangeToLeft(ref RoverFacing roverFacing, ref int roverPositionX, ref int roverPositionY);
        void ChangeToRight(ref RoverFacing roverFacing, ref int roverPositionX, ref int roverPositionY);
        void Move(ref RoverFacing roverFacing, ref int roverPositionX, ref int roverPositionY);
    }
}
