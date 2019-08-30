using System;
using System.Collections.Generic;
using System.Text;

namespace parking_lot_service.Interface
{
    public interface ICar
    {
        string PlateNumber { get; set; }
        string Colour { get; set; }
    }
}
