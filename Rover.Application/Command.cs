using Rover.Domain.Contracts;

namespace Rover.Application
{
    public class Command : ICommand
    {
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
    }
}
