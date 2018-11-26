using System;
using Rover.Domain.Contracts;

namespace Rover.Domain
{
    public class Command: ICommand
    {
        public string Description { get; set; }
        public string Abreviation { get; set; }

        public bool ValidateCommand()
        {
            if (Abreviation.ToUpper() != "L" && 
                Abreviation.ToUpper() != "R" && 
                Abreviation.ToUpper() != "F")
                return false;

            return true;
        }
    }
}
