using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SinConveerBL;
using DrawConveer;

namespace Task5
{
    public partial class MainForm : Form
    {
       // Bitmap bmp;
        DrawField draw;
        Town town;
        public MainForm()
        {
            InitializeComponent();
        }

        private void DrawTimer_Tick(object sender, EventArgs e)
        {
            result.Image = draw.GetBmp();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Image busstop = Properties.Resources.p_Conveer; /*@"p_BusStop.png"*/;
            Image passenger = Properties.Resources.p_Mechanic/*(@"p_Passenger.png")*/;
            Image bus = Properties.Resources.p_Pogruz/*(@"p_Bus.png")*/;
            Image revolt = Properties.Resources.mark;
            town = new Town(Width, Height);
            draw = new DrawField(town);
            town.BusStops = new List<Conveer>();
            town.BusStops.Add(new Conveer(busstop.Width, busstop.Height, Width, Height));
            town.BusStops.Add(new Conveer(Width - busstop.Width * 2 - busstop.Width / 2, busstop.Height, Width, Height));
            town.BusStops.Add(new Conveer(busstop.Width, Height - busstop.Height - 50 - busstop.Height / 2, Width, Height));
            town.BusStops.Add(new Conveer(Width - busstop.Width * 2 - busstop.Width / 2, Height - busstop.Height - 50 - busstop.Height / 2, Width, Height));
            town.RandomBusesAndPassengers();

            draw = new DrawField(town, busstop, bus, passenger, revolt);
            DrawTimer.Start();
            ChangeTimer.Start();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            town.Dispose();
        }

        private void ReloadModelBttn_Click(object sender, EventArgs e)
        {
            DrawTimer.Dispose();
            ChangeTimer.Dispose();
            town.Dispose();
            Image busstop = Properties.Resources.p_Conveer /*@"p_BusStop.png"*/;
            Image passenger = Properties.Resources.p_Mechanic/*(@"p_Passenger.png")*/;
            Image bus = Properties.Resources.p_Pogruz/*(@"p_Bus.png")*/;
            Image revolt = Properties.Resources.mark;
            town = new Town(Width, Height);
            draw = new DrawField(town);
            town.BusStops = new List<Conveer>();
            town.BusStops.Add(new Conveer(busstop.Width, busstop.Height, Width, Height));
            town.BusStops.Add(new Conveer(Width - busstop.Width * 2 - busstop.Width / 2, busstop.Height, Width, Height));
            town.BusStops.Add(new Conveer(busstop.Width, Height - busstop.Height - 50 - busstop.Height / 2, Width, Height));
            town.BusStops.Add(new Conveer(Width - busstop.Width * 2 - busstop.Width / 2, Height - busstop.Height - 50 - busstop.Height / 2, Width, Height));
            town.RandomBusesAndPassengers();
            draw = new DrawField(town, busstop, bus, passenger, revolt);
            DrawTimer.Start();
            ChangeTimer.Start();
        }

        private void ChangeTimer_Tick(object sender, EventArgs e)
        {
            town.TimeTick();
        }

        private void AddBusBttn_Click(object sender, EventArgs e)
        {
            town.AddBus(0);
        }

        private void AddPassengerBttn_Click(object sender, EventArgs e)
        {
            town.AddPassenger();
        }
    }
}
