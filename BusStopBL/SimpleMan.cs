using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusStopBL
{
    public class SimpleMan
    {
        internal BusStop BusStop { get; set; }
        internal Bus Bus { get; set; }
        internal void OnBus(Bus bus)
        {
            if(bus.Passengers.Count<8)
            {
                if (BusStop.Passengers != null)
                    BusStop.Passengers.Remove(this);
                BusStop.BusEvent -= this.OnBus;
                BusStop = null;
                Bus = bus;
                Bus.Passengers.Add(this);
                Bus.BusStopEvent += this.FromBus;
                Bus.FullEvent += CheckOnFull;
                Moving = true;
            }
           
        }
        internal void FromBus(BusStop busStop)
        {
            if (AmoutOfStations == 0)
            {
                if (Bus.Passengers != null)
                    Bus.Passengers.Remove(this);
                Bus.BusStopEvent -= this.FromBus;
                Bus.FullEvent -= CheckOnFull;
                Bus = null;
                BusStop = busStop;
                //BusStop.ToAdd.Add(this);
            }
            //else
            //    AmoutOfStations--;
           
            //BusStop.BusEvent += this.OnBus;
        }
        internal void CheckOnFull(Bus bus)
        {
            bus.IsFull = bus.IsFull && (AmoutOfStations != 0);
            if(AmoutOfStations != 0)
                AmoutOfStations--;
        }
        public int AmoutOfStations { get; set; }

        //public double X { get; set; }
        //public double Y { get; set; }
        public bool Moving { get; set; }
        public bool Waiting { get; set; }
        public bool GettingToBus { get; set; }
        const int busv = 2;
        const int pv = 2;
        double WidthScr { get; set; }
        public double Length { get; set; }
        double FirtLevel { get; set; }
        double SecondLevel { get; set; }
        public SimpleMan(int stations)
        {
            if (stations < 3 && stations > 0)
                AmoutOfStations = stations;
            Moving = false;
            Waiting = true;
        }
        public SimpleMan()
        { }
        public SimpleMan(double x, double y, double width, double length, double fl, double sl, int n = 2)
        {
            //X = x;
            //Y = y;
            WidthScr = width;
            Length = length;
            FirtLevel = fl;
            SecondLevel = sl;
            Waiting = true;
            Moving = false;
            AmoutOfStations = n;
        }

        //public void TimeTick()
        //{

        //    if (Moving && AmoutOfStations > 0)
        //    {
        //        X += busv;
        //        if (!(X > Length && X < WidthScr))
        //        {
        //            if (Y == FirtLevel)
        //                Y = SecondLevel;
        //            else
        //                Y = FirtLevel;
        //        }
        //    }
        //    else
        //    {
        //        if (!Waiting)
        //            AmoutOfStations--;
        //    }
        //}
        //public virtual void GetOnTheBus()
        //{
        //    Waiting = false;
        //    Moving = true;
        //    //AmoutOfStations = stations;
        //}
        //public virtual void GetOffTheBus()
        //{
        //    Moving = false;
        //    Waiting = true;
        //    AmoutOfStations = 0;
        //}

    }
}
