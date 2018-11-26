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

        [TestMethod]
        public void ValidateCommand_ValidateLowerCase_False()
        {
            container.RegisterType<ICommand, Command>();
            var command = container.Resolve<ICommand>();
            command.Abreviation = "r";
            var result = command.ValidateCommand();
            Assert.AreEqual(true, result);
        }
    }
}
