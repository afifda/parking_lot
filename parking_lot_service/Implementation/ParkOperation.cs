using parking_lot_service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace parking_lot_service.Implementation
{
    public class ParkOperation : IParkOperation
    {
        public IList<IPark> ParkingLot { get; set; }
        public void CreateParkingLot(int lotCount)
        {
            for (var i = 1; i <= lotCount; i++)
            {
                var _park = new Park()
                {
                    SlotNumber = i
                };
                ParkingLot.Add(_park);
            }
        }

        public IList<IPark> GetParkingLot()
        {
            return ParkingLot;
        }

        public IList<string> GetPlateNumbersByColour(string colour)
        {
            var result = new List<string>();
            for (var i = 1; i <= ParkingLot.Count; i++)
            {
                if (ParkingLot[i].Car.Colour == colour)
                {
                    result.Add(ParkingLot[i].Car.PlateNumber);
                }
            }
            return result;
        }

        public int GetSlotNumberByPlateNumber(string plateNumber)
        {
            var result = 0;
            for (var i = 1; i <= ParkingLot.Count; i++)
            {
                if (ParkingLot[i].Car.PlateNumber == plateNumber)
                {
                    result = ParkingLot[i].SlotNumber;
                    break;
                }
            }
            return result;
        }

        public IList<int> GetSlotNumbersByColours(string colour)
        {
            var result = new List<int>();
            for (var i = 1; i <= ParkingLot.Count; i++)
            {
                if (ParkingLot[i].Car.Colour == colour)
                {
                    result.Add(ParkingLot[i].SlotNumber);
                }
            }
            return result;
        }

        public IPark Leave(ICar car)
        {
            for (var i = 1; i <= ParkingLot.Count; i++)
            {
                if (ParkingLot[i].Car.PlateNumber == car.PlateNumber &&
                    ParkingLot[i].Car.Colour == car.Colour)
                {
                    ParkingLot[i].CarOut();
                    return ParkingLot[i];
                }
            }            
            return null;
        }

        public IPark Enter(ICar car)
        {
            for (var i = 1; i <= ParkingLot.Count; i++)
            {
                if (ParkingLot[i].IsAvailable)
                {
                    ParkingLot[i].CarIn(car);
                    return ParkingLot[i];
                }
            }
            return null;
        }
    }
}
