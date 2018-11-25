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
            throw new NotImplementedException();
        }
    }
}
