using Microsoft.VisualStudio.TestTools.UnitTesting;
using Unity;
using Rover.Domain;
using Rover.Domain.Contracts;

namespace Rover.Test
{
    [TestClass]
    public class UnitTest1
    {
        UnityContainer container = new UnityContainer();

        static RoverFacing roverFacing;
        static int roverPositionX;
        static int roverPositionY;

        [TestMethod]
        public void ValidateCommand_ValidateLowerCase_False()
        {
            container.RegisterType<ICommand, Command>();
            var command = container.Resolve<ICommand>();
            command.Abreviation = "r";
            var result = command.ValidateCommand();
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void LeftCommandExecute_ChangePosition_Success()
        {
            container.RegisterType<ICommand, Command>();
            var command = container.Resolve<ICommand>();
            command.Abreviation = "l";
            command.ChangeFacingPosition(ref roverFacing, ref roverPositionX, ref roverPositionY);            
        }
    }
}
