using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Unity;
using Rover.Application;
using Rover.Domain;
using Rover.Domain.Contracts;

namespace Rover.Test
{
    [TestClass]
    public class UnitTest1
    {
        UnityContainer container = new UnityContainer();

        [TestMethod]
        [ExpectedException(typeof(NotImplementedException))]
        public void ValideCommand_NonExistentMethod_NotImplementedException()
        {
            container.RegisterType<ICommand, Command>();
            var command = container.Resolve<ICommand>();
            command.Abreviation = "r";
            command.ValidateCommand();
        }
    }
}
