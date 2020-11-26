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
		private ITransport tank;

		public FormTank()
		{
			InitializeComponent();
		}

		public void SetCar(ITransport vehicle)
		{
			this.tank = vehicle;
			Draw();
		}

		private void Draw()
		{
			Bitmap bmp = new Bitmap(pictureTank.Width, pictureTank.Height);
			Graphics gr = Graphics.FromImage(bmp);
			tank?.DrawTransport(gr);
			pictureTank.Image = bmp;
		}

		private void buttonCreate_Click(object sender, EventArgs e)
		{
			Random rnd = new Random();
			tank = new ArmoredVehicle(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Green);
			tank.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureTank.Width, pictureTank.Height);
			Draw();
		}

		private void buttonCreateTank_Click(object sender, EventArgs e)
		{
			Random rnd = new Random();
			tank = new Tank(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Green, Color.DarkGreen, true, true);
			tank.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureTank.Width, pictureTank.Height);
			Draw();
		}

		private void buttonMove_Click(object sender, EventArgs e)
		{
			string name = (sender as Button).Name;
			switch (name)
			{
				case "buttonUp":
					tank?.MoveTransport(Direction.Up);
					break;
				case "buttonDown":
					tank?.MoveTransport(Direction.Down);
					break;
				case "buttonRight":
					tank?.MoveTransport(Direction.Right);
					break;
				case "buttonLeft":
					tank?.MoveTransport(Direction.Left);
					break;
			}
			Draw();
		}

	
	}
}
