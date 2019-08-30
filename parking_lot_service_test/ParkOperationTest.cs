using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using parking_lot_services.Implementation;
using parking_lot_services.Interface;

namespace parking_lot_service_test
{
    [TestClass]
    public class ParkOperationTest
    {
        private ParkOperation parkOperationService;
        private PrivateObject privateObject;

        [TestInitialize]
        public void Initialize()
        {
            parkOperationService = new ParkOperation();
            privateObject = new PrivateObject(parkOperationService);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CreateParkingLot_InvalidNumbers_ThrowException()
        {
            GenerateParkingLot(0);
        }

        [TestMethod]
        public void CreateParkingLot_ValidNumbers_ParkingLotCreated()
        {
            var ParkingLot = GenerateParkingLot(1);

            Assert.AreEqual(1, ParkingLot.Count);
        }        

        [TestMethod]
        public void GetParkingLot_ValidCall_ParkingLotStatusReturned()
        {
            var ParkingLot = GenerateParkingLot(1);
            var result = (IList<IPark>)parkOperationService.GetParkingLot();

            Assert.AreEqual(1, result.Count);
        }

        [TestMethod]
        public void GetPlateNumbersByColour_ColourExists_PlateNumbersReturned()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void GetPlateNumbersByColour_ColourNotExists_NullsReturned()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void GetSlotNumberByPlateNumber_PlateNumberExists_SlotNumberReturned()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void GetSlotNumberByPlateNumber_PlateNumberNotExists_NullsReturned()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void GetSlotNumbersByColours_ColoursExists_SlotNumbersReturned()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void GetSlotNumbersByColours_ColoursNotExists_NullsReturned()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void Leave_CarExists_StatusReturned()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void Leave_CarNotExists_NullsReturned()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void Enter_SlotAvailable_StatusReturned()
        {
            var _car = new Car()
            {
                PlateNumber = "XX-12345-ABC",
                Colour = "Black"
            };
            var ParkingLot = GenerateParkingLot(1);
            var _carPark = (IPark)parkOperationService.Enter(_car);

            Assert.IsFalse(ParkingLot[0].IsAvailable);
            Assert.AreEqual(_carPark.Car.PlateNumber, ParkingLot[0].Car.PlateNumber);
            Assert.AreEqual(_carPark.Car.Colour, ParkingLot[0].Car.Colour);
        }

        [TestMethod]
        public void Enter_SlotNotAvailable_NullsReturned()
        {
            var _car1 = new Car()
            {
                PlateNumber = "XX-12345-ABC",
                Colour = "Black"
            };
            var _car2 = new Car()
            {
                PlateNumber = "XX-67890-ABC",
                Colour = "White"
            };
            var ParkingLot = GenerateParkingLot(1);
            parkOperationService.Enter(_car1);
            var _carPark = (IPark)parkOperationService.Enter(_car2);

            Assert.IsNull(_carPark);
        }

        private IList<IPark> GenerateParkingLot(int slotCount)
        {
            parkOperationService.CreateParkingLot(1);
            var ParkingLot = (IList<IPark>)privateObject.GetFieldOrProperty("ParkingLot");
            return ParkingLot;
        }
    }
}
