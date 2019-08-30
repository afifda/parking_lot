using System;
using System.Collections.Generic;
using System.Text;

namespace parking_lot_service.Interface
{
    public interface IPark
    {
        int SlotNumber { get; set; }
        bool IsAvailable { get; set; }
        ICar Car { get; set; }
        void CarIn(ICar _car);
        void CarOut();
    }
}
