using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinConveerBL
{
    public class Bus
    {
        internal event Action<Conveer> BusStopEvent;
        internal bool IsFull { get; set; }
        const double velicity = 6;
        internal event Action<Bus> FullEvent;
        public double X { get; set; }
        internal int StopTime = 0;
        public int sits = 3;
        public double Y { get; set; }
        double WidthScr { get; set; }
        public double Length { get; set; }
        double FirtLevel { get; set; }
        double SecondLevel { get; set; }
        public List<IMechanic> Passengers { get; set; } = new List<IMechanic>();
        public bool Disappeared { get; set; }
        internal void StopOn(Conveer busStop)
        {
            lock (busStop.consignment)
            {
                StopTime = 20;
                BusStopEvent?.Invoke(busStop);
                IsFull = false;
                busStop.waitingTime = 0;
                busStop.Revolt = false;
            }

        }

        public Bus(List<IMechanic> passengers = null)
        {
            if (passengers == null)
                Passengers = new List<IMechanic>();
            else
                Passengers = passengers;
            foreach (var passenger in Passengers)
            {
                BusStopEvent += passenger.FromBus;
                passenger.Bus = this;
                //passenger.Moving = true;
            }
        }
        public Bus(double x, double y, double width, double length, double fl, double sl)
        {
            X = x;
            Y = y;
            WidthScr = width;
            Length = length;
            FirtLevel = fl;
            SecondLevel = sl;
            Disappeared = false;
        }
        public Bus(double x, double y, double width, double length, double fl, double sl, List<IMechanic> passengers = null)
        {
            X = x;
            Y = y;
            WidthScr = width;
            Length = length;
            FirtLevel = fl;
            SecondLevel = sl;
            if (passengers == null)
                Passengers = new List<IMechanic>();
            else
                Passengers = passengers;
            foreach (var passenger in Passengers)
            {
                BusStopEvent += passenger.FromBus;
                passenger.Bus = this;
            }
        }

        internal void CheckOnFull()
        {
            IsFull = true;
            FullEvent?.Invoke(this);
            if (Passengers.Count < sits)
                IsFull = false;
            if (IsFull)
                StopTime = -1;
        }
        
        public void TimeTick()
        {
            if (StopTime < 0)
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
