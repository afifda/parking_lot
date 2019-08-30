using parking_lot;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parking_lot_app
{
    class parking_lot
    {
        static void Main(string[] args)
        {
            string command;
            if (args == null || args.Length == 0)
            {
                command = Console.ReadLine();
                while (command != "exit")
                {
                    DoActionCommand(command);
                }
            }
            else if (args != null && args.Length == 1)
            {                
                var file = new StreamReader(args[0]);
                while ((command = file.ReadLine()) != null)
                {
                    DoActionCommand(command);
                }

                file.Close();
            }
            else if (args != null && args.Length != 1)
            {
                Console.WriteLine("The input for running the app was incorrect. Please enter the file path.");
            }

            Console.ReadKey();
        }

        private static void DoActionCommand(string command)
        {
            var splittedCommands = command.Split(' ');
            switch (splittedCommands[0])
            {
                case Constants.CREATE_PARKING_LOT:
                    CreateParkingLot(splittedCommands);
                    break;
                case Constants.PARK:
                    Park(splittedCommands);
                    break;
                case Constants.LEAVE:
                    Leave(splittedCommands);
                    break;
                case Constants.STATUS:
                    GetStatus(splittedCommands);
                    break;
                case Constants.REGISTRATION_NUMBERS_FOR_CARS_WITH_COLOUR:
                    RegistrationNumbersForCarsWithColour(splittedCommands);
                    break;
                case Constants.SLOT_NUMBERS_FOR_CARS_WITH_COLOUR:
                    SlotNumbersForRegistrationNumber(splittedCommands);
                    break;
                case Constants.SLOT_NUMBER_FOR_REGISTRATION_NUMBER:
                    SlotNumbersForRegistrationNumber(splittedCommands);
                    break;

            }
        }

        private static void SlotNumbersForRegistrationNumber(string[] splittedCommands)
        {
            throw new NotImplementedException();
        }

        private static void RegistrationNumbersForCarsWithColour(string[] splittedCommands)
        {
            throw new NotImplementedException();
        }

        private static void GetStatus(string[] splittedCommands)
        {
            throw new NotImplementedException();
        }

        private static void Leave(string[] splittedCommands)
        {
            throw new NotImplementedException();
        }

        private static void Park(string[] splittedCommands)
        {
            throw new NotImplementedException();
        }

        private static void CreateParkingLot(string[] splittedCommands)
        {
            throw new NotImplementedException();
        }
    }
}
