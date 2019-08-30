using parking_lot_service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace parking_lot_service.Implementation
{
    public class Car : ICar
    {
        public string PlateNumber { get; set; }
        public string Colour { get; set; }
    }
}
