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
        public void Validate_InvalidCommand_False()
        {
            var command = container.Resolve<ICommand>();
            command.Abreviation = "a";
            var result = command.Validate();
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Validate_NullCommand_False()
        {
            var command = container.Resolve<ICommand>();
            command.Abreviation = "";
            var result = command.Validate();
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Validate_LowerCase_True()
        {
            var command = container.Resolve<ICommand>();
            command.Abreviation = "r";
            var result = command.Validate();
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void ChangeFacing_LeftPosition_Success()
        {
            var robot = container.Resolve<IRobot>();
            robot.RoverFacing = RoverFacing.North;
            robot.ChangeFacing(true);

            Assert.AreEqual(RoverFacing.West, robot.RoverFacing);
        }

        [TestMethod]
        public void ChangeFacing_RightPosition_Success()
        {
            var robot = container.Resolve<IRobot>();
            robot.RoverFacing = RoverFacing.North;
            robot.ChangeFacing(false);

            Assert.AreEqual(RoverFacing.East, robot.RoverFacing);
        }

        [TestMethod]
        public void MoveForward_FacingWest00_Fail()
        {
            var robot = container.Resolve<IRobot>();
            robot.RoverPositionX = 0;
            robot.RoverPositionY = 0;
            robot.RoverFacing = RoverFacing.West;
            robot.MoveForward();

            Assert.AreEqual(0, robot.RoverPositionX);
            Assert.AreEqual(0, robot.RoverPositionY);
        }

        [TestMethod]
        public void MoveForward_FacingWest11_Success()
        {
            var robot = container.Resolve<IRobot>();
            robot.RoverPositionX = 1;
            robot.RoverPositionY = 1;
            robot.RoverFacing = RoverFacing.West;
            robot.MoveForward();

            Assert.AreEqual(1, robot.RoverPositionX);
            Assert.AreEqual(0, robot.RoverPositionY);
        }

        [TestMethod]
        public void MoveForward_FacingEast04_Fail()
        {
            var robot = container.Resolve<IRobot>();
            robot.RoverPositionX = 0;
            robot.RoverPositionY = 4;
            robot.RoverFacing = RoverFacing.East;
            robot.MoveForward();

            Assert.AreEqual(0, robot.RoverPositionX);
            Assert.AreEqual(4, robot.RoverPositionY);
        }

        [TestMethod]
        public void MoveForward_FacingEast11_Fail()
        {
            var robot = container.Resolve<IRobot>();
            robot.RoverPositionX = 1;
            robot.RoverPositionY = 1;
            robot.RoverFacing = RoverFacing.East;
            robot.MoveForward();

            Assert.AreEqual(1, robot.RoverPositionX);
            Assert.AreEqual(2, robot.RoverPositionY);
        }

        [TestMethod]
        public void MoveForward_FacingSouth00_Fail()
        {
            var robot = container.Resolve<IRobot>();
            robot.RoverPositionX = 0;
            robot.RoverPositionY = 0;
            robot.RoverFacing = RoverFacing.South;
            robot.MoveForward();

            Assert.AreEqual(0, robot.RoverPositionX);
            Assert.AreEqual(0, robot.RoverPositionY);
        }

        [TestMethod]
        public void MoveForward_FacingSouth11_Fail()
        {
            var robot = container.Resolve<IRobot>();
            robot.RoverPositionX = 1;
            robot.RoverPositionY = 1;
            robot.RoverFacing = RoverFacing.South;
            robot.MoveForward();

            Assert.AreEqual(0, robot.RoverPositionX);
            Assert.AreEqual(1, robot.RoverPositionY);
        }

        [TestMethod]
        public void MoveForward_FacingNorth40_Fail()
        {
            var robot = container.Resolve<IRobot>();
            robot.RoverPositionX = 4;
            robot.RoverPositionY = 0;
            robot.RoverFacing = RoverFacing.North;
            robot.MoveForward();

            Assert.AreEqual(4, robot.RoverPositionX);
            Assert.AreEqual(0, robot.RoverPositionY);
        }

        [TestMethod]
        public void MoveForward_FacingNorth11_Fail()
        {
            var robot = container.Resolve<IRobot>();
            robot.RoverPositionX = 1;
            robot.RoverPositionY = 1;
            robot.RoverFacing = RoverFacing.North;
            robot.MoveForward();

            Assert.AreEqual(2, robot.RoverPositionX);
            Assert.AreEqual(1, robot.RoverPositionY);
        }
    }
}