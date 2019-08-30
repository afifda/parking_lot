using parking_lot_services.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace parking_lot_services.Implementation
{
    public class Park : IPark
    {
        public Park()
        {
            IsAvailable = true;
        }
        public Park(ICar _car)
        {
            Car = _car;
            IsAvailable = false;
        }
        public int SlotNumber { get; set; }
        public bool IsAvailable { get; set; }
        public ICar Car { get; set; }

        public void CarIn(ICar _car)
        {
            Car = _car;
            IsAvailable = false;
        }

        public void CarOut()
        {
            Car = null;
            IsAvailable = true;
        }
    }
}
