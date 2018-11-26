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

                Console.WriteLine("Write a command.\nRotate Left (L); Rotate Right (R), Forward (F):");

                while (true)
                {
                    command.Abreviation = Console.ReadLine();

                    if (command.ValidateCommand())
                    {
                        factory.ExecuteCommand(command.Abreviation);
                    }
                    else
                    {
                        Console.WriteLine("Invalid command");
                    }
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
