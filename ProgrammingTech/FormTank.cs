using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammingTech
{
	public partial class FormTank : Form
	{
		private ITransport vehicle;

		public FormTank()
		{
			InitializeComponent();
		}

		private void Draw()
		{
			Bitmap bmp = new Bitmap(pictureTank.Width, pictureTank.Height);
			Graphics gr = Graphics.FromImage(bmp);
			vehicle.DrawTransport(gr);
			pictureTank.Image = bmp;
		}

		private void buttonCreateArmoredVehicle_Click(object sender, EventArgs e)
		{
			Random rnd = new Random();
			vehicle = new ArmoredVehicle(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Green);
			vehicle.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureTank.Width, pictureTank.Height);
			Draw();
		}

		private void buttonCreateTank_Click(object sender, EventArgs e)
		{
			Random rnd = new Random();
			vehicle = new Tank(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Green, Color.DarkGreen, true, true);
			vehicle.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureTank.Width, pictureTank.Height);
			Draw();
		}

		private void buttonMove_Click(object sender, EventArgs e)
		{
			string name = (sender as Button).Name;
			switch (name)
			{
				case "buttonUp":
					vehicle.MoveTransport(Direction.Up);
					break;
				case "buttonDown":
					vehicle.MoveTransport(Direction.Down);
					break;
				case "buttonRight":
					vehicle.MoveTransport(Direction.Right);
					break;
				case "buttonLeft":
					vehicle.MoveTransport(Direction.Left);
					break;
			}
			Draw();
		}
	}
}
