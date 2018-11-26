using Rover.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rover.Domain.Entities
{
    public class Left : ICommand
    {
        public string Abreviation { get { return "L"; } set { } }
        public string Description { get { return "Rotate to Left"; } set { } }

        public void ChangeFacingPosition(ref RoverFacing roverFacing, ref int roverPositionX, ref int roverPositionY)
        {
            throw new NotImplementedException();
       }

        public bool ValidateCommand()
        {
            throw new NotImplementedException();
        }
    }
}
