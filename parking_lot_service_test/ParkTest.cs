using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using parking_lot_services.Implementation;
using parking_lot_services.Interface;

namespace parking_lot_service_test
{
    [TestClass]
    public class ParkTest
    {
        [TestMethod]
        public void CarIn_ValidCall_SetCarAndAvailability()
        {
            var parkService = new Park();
            var _car = new Car()
            {
                PlateNumber = "XX-12345-ABC",
                Colour = "Black"
            };
            parkService.CarIn(_car);

            Assert.IsFalse(parkService.IsAvailable);
            Assert.AreSame(_car, parkService.Car);
        }

        [TestMethod]
        public void CarOut_ValidCall_SetCarAndAvailability()
        {            
            var _car = new Car()
            {
                PlateNumber = "XX-12345-ABC",
                Colour = "Black"
            };
            var parkService = new Park(_car);
            parkService.CarOut();

            Assert.IsTrue(parkService.IsAvailable);
            Assert.IsNull(parkService.Car);
        }
    }
}
