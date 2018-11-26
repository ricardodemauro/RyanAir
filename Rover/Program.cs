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
                container.RegisterType<IRobot, Robot>();

                var factory = container.Resolve<ICommandFactory>();
                var command = container.Resolve<ICommand>();
                var robot = container.Resolve<IRobot>();

                WriteMessagesToUser();

                do
                {
                    command.Abreviation = Console.ReadLine();

                    if (command.Validate())
                    {
                        factory.ExecuteCommand(command.Abreviation, robot);
                    }
                    else
                    {
                        Console.WriteLine("Invalid command");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }
                }
                while (command.Abreviation.ToUpper() != "E");
            }
            catch (Exception)
            {
                Console.Write("Error, try again...");
                Environment.Exit(0);
            }
        }

        private static void WriteMessagesToUser()
        {
            Console.WriteLine("Write a command. Default is: North (0,0)");
            Console.WriteLine("Exit (E)");
            Console.WriteLine("Rotate Left (L)");
            Console.WriteLine("Rotate Right (R)");
            Console.WriteLine("Forward (F)");
        }
    }
}