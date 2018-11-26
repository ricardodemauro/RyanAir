using Rover.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rover.Domain.Entities
{
    public class Right : ICommand
    {
        public string Abreviation { get { return "L"; } set { } }
        public string Description { get { return "Rotate to Left"; } set { } }

        public void ChangeFacingPosition(ref RoverFacing roverFacing, ref int roverPositionX, ref int roverPositionY)
        {
            roverFacing = roverFacing == RoverFacing.West ? RoverFacing.North : (RoverFacing)((int)roverFacing + 1);
            Console.WriteLine($"Rover is now at {roverPositionX}, {roverPositionY} - facing {roverFacing}");
        }

        public bool ValidateCommand()
        {
            throw new NotImplementedException();
        }
    }
}
