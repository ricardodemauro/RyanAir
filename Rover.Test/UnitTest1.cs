using Microsoft.VisualStudio.TestTools.UnitTesting;
using Unity;
using Rover.Domain;
using Rover.Domain.Contracts;
using Rover.Application;
using Rover.Domain.Entities;

namespace Rover.Test
{
    [TestClass]
    public class UnitTest1
    {
        UnityContainer container = new UnityContainer();

        public UnitTest1()
        {
            container.RegisterType<ICommand, Command>();
            container.RegisterType<ICommandFactory, CommandFactory>();
            container.RegisterType<IRobot, Robot>();
        }

        [TestMethod]
        public void InvalidateCommand_ValidateLowerCase_False()
        {
            var command = container.Resolve<ICommand>();
            command.Abreviation = "a";
            var result = command.Validate();
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void NullCommand_ValidateLowerCase_False()
        {
            var command = container.Resolve<ICommand>();
            command.Abreviation = "";
            var result = command.Validate();
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void ValidateCommand_ValidateLowerCase_False()
        {
            var command = container.Resolve<ICommand>();
            command.Abreviation = "r";
            var result = command.Validate();
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void ChangeFacing_LeftPosition_Success()
        {
            var command = container.Resolve<ICommand>();
            var factory = container.Resolve<ICommandFactory>();
            var robot = container.Resolve<IRobot>();

            command.Abreviation = "l";
            factory.ExecuteCommand(command.Abreviation, robot);
        }

        [TestMethod]
        public void ChangeFacing_RightPosition_Success()
        {
            var command = container.Resolve<ICommand>();
            var factory = container.Resolve<ICommandFactory>();
            var robot = container.Resolve<IRobot>();

            command.Abreviation = "r";
            factory.ExecuteCommand(command.Abreviation, robot);
        }

        [TestMethod]
        public void MoveForward_FacingWest00_Fail()
        {
            var command = container.Resolve<ICommand>();
            var factory = container.Resolve<ICommandFactory>();
            var robot = container.Resolve<IRobot>();

            command.Abreviation = "f";
            factory.ExecuteCommand(command.Abreviation, robot);
        }

        [TestMethod]
        public void MoveForward_FacingEast04_Fail()
        {
            var command = container.Resolve<ICommand>();
            var factory = container.Resolve<ICommandFactory>();
            var robot = container.Resolve<IRobot>();

            command.Abreviation = "f";
            factory.ExecuteCommand(command.Abreviation, robot);
        }

        [TestMethod]
        public void MoveForward_FacingSouth00_Fail()
        {
            var command = container.Resolve<ICommand>();
            var factory = container.Resolve<ICommandFactory>();
            var robot = container.Resolve<IRobot>();

            command.Abreviation = "f";
            factory.ExecuteCommand(command.Abreviation, robot);
        }

        [TestMethod]
        public void MoveForward_FacingNorth40_Fail()
        {
            var command = container.Resolve<ICommand>();
            var factory = container.Resolve<ICommandFactory>();
            var robot = container.Resolve<IRobot>();

            command.Abreviation = "f";
            factory.ExecuteCommand(command.Abreviation, robot);
        }
    }
}