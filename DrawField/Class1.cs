using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawField
{
    public class DrawField
    {
        Town Town;
        Bitmap bmp;
        Graphics g;
        Image ImBusstop { get; set; }
        Image ImPassenger { get; set; }
        Image ImBus { get; set; }
        public DrawField(Town town)
        {
            Town = town;
            bmp = new Bitmap(Town.X, Town.Y);
            g = Graphics.FromImage(bmp);
        }
        public DrawField(Town town, Image busstop, Image bus, Image passenger)
        {
            Town = town;
            ImBusstop = busstop;
            ImBus = bus;
            ImPassenger = passenger;
            bmp = new Bitmap(Town.X, Town.Y);
            g = Graphics.FromImage(bmp);
        }
        public void DrawBusStop(BusStop bs)
        {
            g.DrawImage(ImBusstop, (float)bs.X, (float)bs.Y);
            int i = 0;
            int dx = 0;
            if (bs.Passengers.Count != 0)
                dx = ImBusstop.Width / bs.Passengers.Count;
            foreach (var passenger in bs.Passengers)
            {
                g.DrawImage(ImPassenger, (float)bs.X + dx * i, (float)bs.Y + 90);
                i++;
            }
        }
        private void DrawBus(Bus bus)
        {

            if (bus.Passengers != null)
            {
                int i = 0;
                double dx = bus.Length / bus.Passengers.Count;


                foreach (var passenger in bus.Passengers)
                {
                    g.DrawImage(ImPassenger, (float)(bus.X + i * dx), (float)bus.Y);
                    i++;
                }
            }
            g.DrawImage(ImBus, (float)bus.X, (float)bus.Y);

        }

        public Bitmap GetBmp()
        {
            g.Clear(Color.White);
            foreach (var busstop in Town.BusStops)
            {
                DrawBusStop(busstop);
            }
            foreach (var bus in Town.Buses)
            {
                DrawBus(bus);
                bus.Time();
            }
            return bmp;
        }
    }
}
