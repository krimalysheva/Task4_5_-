using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace BusStopBL
{
    public class BusStop
    {
        public int RB { get; set; }
        public int BB { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public List<SimpleMan> Passengers { get; set; }
        public List<SimpleMan> ToAdd = new List<SimpleMan>();
        Thread background;
        internal void Add()
        {
            foreach (var item in ToAdd)
            {
                BusEvent += item.OnBus;
            }
            Passengers.AddRange(ToAdd);
            ToAdd.Clear();
        }
        internal event Action<Bus> BusEvent;

        internal void Stop(Bus bus)
        {
            BusEvent?.Invoke(bus);
        }
        public BusStop(List<SimpleMan> passengers = null)
        {
            if (passengers == null)
                Passengers = new List<SimpleMan>();
            else
                Passengers = passengers;
            foreach (var passenger in Passengers)
            {
                BusEvent += passenger.OnBus;
                passenger.BusStop = this;
            }
            
        }
        int pause;
        public void Background()
        {
            while (true)
            {
                if (pause == 0 && Passengers.Count < 7)
                {
                    Random rnd = new Random();
                    int N = rnd.Next(0, 2);
                    for (int i = 0; i < N; i++)
                    {
                        AddPassenger(X +20 + 50 * i, Y + 90);

                    }
                    pause = 100;
                    
                }
                else
                {
                    pause--;
                }
            }
        }

        public BusStop(int x, int y, int rb, int bb)
        {
            X = x;
            Y = y;
            RB = rb;
            BB = bb;
            Passengers = new List<SimpleMan>();
            background = new Thread(Background);
            background.Start();
            pause = 100;
        }
        //public List<SimpleMan> GetListOfPassengets() => Passengers;

        public void AddPassenger(int x, int y)
        {
            if (!(x > 0 && y > 0 && x < RB && y < BB))
                throw new Exception();
            double length = 100;
            double fl = 652;
            double sl = 199;
            Random rnd = new Random();
            SimpleMan simpleMan = new SimpleMan(x, y, X, length, fl, sl, rnd.Next(1,2));
            BusEvent += simpleMan.OnBus;
            simpleMan.BusStop = this;
            Passengers.Add(simpleMan);
        }

    }
}
