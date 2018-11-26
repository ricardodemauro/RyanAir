using System;
using Rover.Domain.Contracts;

namespace Rover.Domain
{
    public class Command : ICommand
    {
        public string Description { get; set; }
        public string Abreviation { get; set; }

        public bool Validate()
        {
            if (string.IsNullOrEmpty(Abreviation) || (
                Abreviation.ToUpper() != "L" &&
                Abreviation.ToUpper() != "R" &&
                Abreviation.ToUpper() != "F" &&
                Abreviation.ToUpper() != "E"))
                return false;

            return true;
        }

        public void ChangeFacing(ref RoverFacing roverFacing, ref int roverPositionX, ref int roverPositionY)
        {
            throw new NotImplementedException();
        }
    }
}
