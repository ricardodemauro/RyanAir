using Rover.Application;
using Rover.Domain;
using Rover.Domain.Contracts;
using Rover.Domain.Entities;
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

                Console.WriteLine("Write a command. Default position is North (0,0).\nExit (E); Rotate Left (L); Rotate Right (R), Forward (F):");

                do
                {
                    command.Abreviation = Console.ReadLine();

                    if (!string.IsNullOrEmpty(command.Abreviation) && command.Abreviation.ToUpper() != "E")
                    {
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
                }
                while (command.Abreviation.ToUpper() != "E");
            }
            catch (Exception)
            {
                Console.Write("Error, try again...");
                Environment.Exit(0);
            }
        }
    }
}