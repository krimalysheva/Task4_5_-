using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DrawingField;
using BusStopBL;

namespace TasksForAtt2
{
    public partial class Form1 : Form
    {
        //Bitmap bmp;
        DrawField draw;
        Town town;
        public Form1()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            Image busstop = Properties.Resources.p_BusStop /*@"p_BusStop.png"*/;
            Image passenger = Properties.Resources.p_Passenger/*(@"p_Passenger.png")*/;
            Image bus = Properties.Resources.p_Bus/*(@"p_Bus.png")*/;
            town = new Town(Width, Height);
            draw = new DrawField(town);
            town.BusStops = new List<BusStop>();
            town.BusStops.Add(new BusStop(busstop.Width, busstop.Height, Width, Height));
            town.BusStops.Add(new BusStop(Width - busstop.Width * 2 - busstop.Width / 2, busstop.Height, Width, Height));
            town.BusStops.Add(new BusStop(Width / 2 - busstop.Width + busstop.Width / 3, Height - busstop.Height - 50 - busstop.Height / 2, Width, Height));
            town.RandomBusesAndPassengers();
            
            draw = new DrawField(town, busstop, bus, passenger);
            DrawTimer.Start();
            ChangeTimer.Start();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            town.Dispose();
        }

        private void DrawTimer_Tick(object sender, EventArgs e)
        {
            result.Image = draw.GetBmp();
        }
    }
}
