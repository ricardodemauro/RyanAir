using Rover.Application;
using Rover.Domain;
using Rover.Domain.Contracts;
using System;
using Unity;

namespace Rover.UI
{
    public class Rover
    {
        public static void Main()
        {
            try
            {
                var container = new UnityContainer();
                container.RegisterType<ICommandFactory, CommandFactory>();
                container.RegisterType<ICommand, Command>();
                var factory = container.Resolve<ICommandFactory>();
                var command = container.Resolve<ICommand>();

                while (true)
                {
                    Console.WriteLine("Write a command.\nRotate Left (L); Rotate Right (R), Forward (F):");
                    command.Abreviation = Console.ReadLine();
                    command.ValidateCommand();
                    factory.ExecuteCommand(command.Abreviation);
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {

            }
        }
    }
}
