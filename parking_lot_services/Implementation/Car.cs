using parking_lot_services.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace parking_lot_services.Implementation
{
    public class Car : ICar
    {
        public string PlateNumber { get; set; }
        public string Colour { get; set; }
    }
}
