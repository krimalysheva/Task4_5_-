﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinConveerBL
{
    public class SimpleMan : IMechanic
    {
        public Conveer BusStop { get; set; }
        public  Bus Bus { get; set; }
        public int AmoutOfStations { get; set; }

        public void OnBus(Bus bus)
        {
            if (!bus.IsFull || bus.Passengers.Count != bus.sits)
            {
                if (BusStop.consignment != null)
                    BusStop.consignment.Remove(this);
                BusStop.BusEvent -= this.OnBus;
                BusStop = null;
                Bus = bus;
                Bus.Passengers.Add(this);
                Bus.BusStopEvent += this.FromBus;
                Bus.FullEvent += CheckOnFull;
            }
        }
        public void FromBus(Conveer busStop)
        {
            if (AmoutOfStations == 0)
            {
                if (Bus.Passengers != null)
                    Bus.Passengers.Remove(this);
                Bus.BusStopEvent -= this.FromBus;
                Bus.FullEvent -= CheckOnFull;
                Bus = null;
                BusStop = busStop;
            }
            else
                AmoutOfStations--;
        
        }
        internal void CheckOnFull(Bus bus)
        {
            bus.IsFull = bus.IsFull && (AmoutOfStations != 0);
            if (AmoutOfStations != 0)
                AmoutOfStations--;
        }

        public SimpleMan(int stations)
        {
            if (stations < 3 && stations > 0)
                AmoutOfStations = stations;
        }
        public SimpleMan()
        { }
        
    }
}
