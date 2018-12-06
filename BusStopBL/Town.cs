using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace BusStopBL
{
    public class Town : IDisposable
    {
        //public delegate void BusEvent();
        ////internal event Action<Bus> Full;
        //public event BusEvent OnTheStation;
        internal event Action TimeEvent;
        public void Time() => TimeEvent();


        public List<BusStop> BusStops { get; set; }
        public List<Bus> Buses { get; set; }
        public List<SimpleMan> Passengers { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        const int firstLevel = 652;
        const int secondLevel = 199;
        Thread background;

        public Town(int x, int y)
        {
            X = x;
            Y = y;
            Buses = new List<Bus>();
            BusStops = new List<BusStop>();
            background = new Thread(Background);
            //background.Start();
        }

        public void AddBus(int n)
        {
            List<SimpleMan> newPassengers = new List<SimpleMan>();
            for (int i = 0; i < n; i++)
            {
                newPassengers.Add(new SimpleMan());
            }
            Random rnd = new Random();

            Bus bus = new Bus(BusStops[rnd.Next(0, 2)].X, BusStops[rnd.Next(0, 2)].Y + 76, X, 100, firstLevel, secondLevel, newPassengers);
            if (Passengers == null)
                Passengers = new List<SimpleMan>();
            Passengers.AddRange(newPassengers);
            Buses.Add(bus);
            TimeEvent += bus.Time;


            //List<SimpleMan> newPassengers = new List<SimpleMan>();
            //for (int i = 0; i < n; i++)
            //{
            //    newPassengers.Add(new SimpleMan());
            //}
            //Bus bus = new Bus(newPassengers);
            //if (Passengers == null)
            //    Passengers = new List<SimpleMan>();
            //Passengers.AddRange(newPassengers);
            //Buses.Add(bus);
            //TimeTickEvent += bus.TimeTick;
        }



        public void RandomBusesAndPassengers()
        {
            Random rnd = new Random();
            //Buses.Add(new Bus(BusStops[0].X, BusStops[0].Y + 76, X, 100, firstLevel, secondLevel));

            foreach (var busstop in BusStops)
            {
                int N = rnd.Next(1, 2);

                for (int i = 0; i < N; i++)
                {
                    Buses.Add(new Bus(busstop.X + 127 * i, busstop.Y + 76, X, 100, firstLevel, secondLevel));
                }
                int P = rnd.Next(4, 7);
                for (int i = 0; i < P; i++)
                {
                    busstop.AddPassenger(busstop.X + (108) * i, busstop.Y + 90);
                    //busstop.Passengers[i].BusStop = busstop;
                }
            }
            Buses[0].Passengers = new List<SimpleMan>();
            SimpleMan simpleMan = new SimpleMan();
            simpleMan.Bus = Buses[0];
            Buses[0].BusStopEvent += simpleMan.FromBus;
            Buses[0].FullEvent += simpleMan.CheckOnFull;
            Buses[0].Passengers.Add(simpleMan);
            background.Start();
        }
        public void Background()
        {
            while (true)
                for (int i = 0; i < Buses.Count; i++)
                {
                    for (int j = 0; j < BusStops.Count; j++)
                    {
                        if (Math.Abs(Buses[i].X - BusStops[j].X) < 20 && Math.Abs(Buses[i].Y - BusStops[j].Y) < 100 && Buses[i].StopTime < -10)
                        {
                            Buses[i].CheckOnFull();
                            if(!Buses[i].IsFull)
                            {
                                Buses[i].StopOn(BusStops[j]);
                                BusStops[j].Stop(Buses[i]);
                                BusStops[j].Add();
                            }
                            
                        }
                    }
                }
        }
        //private void BackgroundCheck()
        //{
        //    foreach (var busstop in BusStops)
        //    {
        //        foreach (var bus in Buses)
        //            if (busstop.X == bus.X)
        //            {
        //                bus.IsMoving = false;
        //                //bus.OnTheStation += bus.State;
        //                foreach (var passenger in busstop.GetListOfPassengets())
        //                    bus.OnTheStation += passenger.GetOnTheBus;
        //                bus.IsMoving = true;
        //                //вызов события по посадке пассажиров
        //                //bus.IsMoving = true;
        //            }
        //    }
        //}
        public void Dispose()
        {
            background.Abort();
        }
    }
}
