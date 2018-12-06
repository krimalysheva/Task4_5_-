using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusStopBL
{
    public class Bus
    {
        

        internal event Action<BusStop> BusStopEvent;
        internal bool IsFull { get; set; }
        const double velicity = 16;
        internal event Action<Bus> FullEvent;
        public double X { get; set; }
        internal int StopTime = 0;


        public double Y { get; set; }
        double WidthScr { get; set; }
        public double Length { get; set; }
        double FirtLevel { get; set; }
        double SecondLevel { get; set; }
        public List<SimpleMan> Passengers { get; set; } = new List<SimpleMan>();
        public Bus(double x, double y, double width, double length, double fl, double sl)
        {
            X = x;
            Y = y;
            WidthScr = width;
            Length = length;
            FirtLevel = fl;
            SecondLevel = sl;
        }
        public Bus(double x, double y, double width, double length, double fl, double sl, List<SimpleMan> passengers = null)
        {
            X = x;
            Y = y;
            WidthScr = width;
            Length = length;
            FirtLevel = fl;
            SecondLevel = sl;
            if (passengers == null)
                Passengers = new List<SimpleMan>();
            else
                Passengers = passengers;
            foreach (var passenger in Passengers)
            {
                BusStopEvent += passenger.FromBus;
                passenger.Bus = this;
            }
        }
        internal void StopOn(BusStop busStop)
        {
            StopTime = 10;
            BusStopEvent?.Invoke(busStop);
            IsFull = false;
        }
        public Bus(List<SimpleMan> passengers = null)
        {
            if (passengers == null)
                Passengers = new List<SimpleMan>();
            else
                Passengers = passengers;
            foreach (var passenger in Passengers)
            {
                BusStopEvent += passenger.FromBus;
                passenger.Bus = this;
                passenger.Moving = true;
            }
        }
        internal void CheckOnFull()
        {
            IsFull = true;
            FullEvent?.Invoke(this);
            if (Passengers.Count < 8)
                IsFull = false;
            if (IsFull)
                StopTime = -1;
        }
        //private bool CheakPassengers()
        //{
        //    bool full = false;
        //    if (Passengers.Count == 4)
        //    {
        //        foreach (var passenger in Passengers)
        //            if (passenger.AmoutOfStations == 0)
        //            {
        //                full = false;
        //                break;
        //            }
        //            else
        //            {
        //                full = true;
        //            }
        //    }
        //    else
        //        return false;
        //    return full;
        //}
        public void Time()
        {
            if (StopTime < 0 /*|| CheakPassengers()*/)
            {
                X -= velicity;
                if (!(X > Length && X < WidthScr))
                {
                    X = WidthScr - Length;
                    if (Y == FirtLevel + 76)
                    {
                        Y = SecondLevel + 76;
                    }
                    else
                    {
                        Y = FirtLevel + 76;
                    }
                }
            }
            StopTime--;
        }




        
    }
}
