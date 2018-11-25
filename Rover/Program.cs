using Rover.Application;
using Rover.Domain;
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

                while (true)
                {
                    var command = Console.ReadLine();
                    if (command != "L" && command != "R" && command != "F")
                        throw new Exception("invalid command");

                    var factory = container.Resolve<ICommandFactory>();

                    factory.ExecuteCommand(command);                    
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
