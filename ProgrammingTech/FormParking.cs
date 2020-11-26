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
	public partial class FormParking : Form
	{
		private readonly Parking<ArmoredVehicle> parking;

		public FormParking()
		{
			InitializeComponent();
			parking = new Parking<ArmoredVehicle>(pictureBoxParking.Width, pictureBoxParking.Height);
			Draw();

		}

		private void Draw()
		{
			Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
			Graphics gr = Graphics.FromImage(bmp);
			parking.Draw(gr);
			pictureBoxParking.Image = bmp;
		}

		private void buttonArmoredVehicle_Click(object sender, EventArgs e)
		{
			ColorDialog dialog = new ColorDialog();
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				var car = new ArmoredVehicle(100, 1000, dialog.Color);
				if (parking + car)
				{
					Draw();
				}
				else
				{
					MessageBox.Show("Парковка переполнена");
				}
			}
		}

		private void buttonTank_Click(object sender, EventArgs e)
		{
			ColorDialog dialog = new ColorDialog();
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				ColorDialog dialogDop = new ColorDialog();
				if (dialogDop.ShowDialog() == DialogResult.OK)
				{
					var car = new Tank(100, 1000, dialog.Color, dialogDop.Color, true, true);
					if (parking + car)
					{
						Draw();
					}
					else
					{
						MessageBox.Show("Парковка переполнена");
					}
				}
			}
		}

		private void buttonTake_Click(object sender, EventArgs e)
		{
			if (maskedTextBoxPlace.Text != "")
			{
				var car = parking - Convert.ToInt32(maskedTextBoxPlace.Text);
				if (car != null)
				{
					FormTank form = new FormTank();
					form.SetCar(car);
					form.ShowDialog();
				}
				Draw();
			}
		}
	}
}
