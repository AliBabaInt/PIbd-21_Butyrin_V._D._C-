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
	public partial class FormVehicleConfig : Form
	{
		Vehicle vehicle = null;

		private event Action<Vehicle> eventAddVehicle;

		public FormVehicleConfig()
		{
			InitializeComponent();
			panelRed.MouseDown += panelColor_MouseDown;
			panelAqua.MouseDown += panelColor_MouseDown;
			panelDarkGreen.MouseDown += panelColor_MouseDown;
			panelFuchsia.MouseDown += panelColor_MouseDown;
			panelGray.MouseDown += panelColor_MouseDown;
			panelGreen.MouseDown += panelColor_MouseDown;
			panelOrange.MouseDown += panelColor_MouseDown;
			panelYellow.MouseDown += panelColor_MouseDown;
			buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
		}

		private void DrawVehicle()
		{
			if (vehicle != null)
			{
				Bitmap bmp = new Bitmap(pictureBoxVehicle.Width, pictureBoxVehicle.Height);
				Graphics gr = Graphics.FromImage(bmp);
				vehicle.SetPosition(5, 5, pictureBoxVehicle.Width, pictureBoxVehicle.Height);
				vehicle.DrawTransport(gr);
				pictureBoxVehicle.Image = bmp;
			}
		}

		public void AddEvent(Action<Vehicle> ev)
		{
			if (eventAddVehicle == null)
			{
				eventAddVehicle = new Action<Vehicle>(ev);
			}
			else
			{
				eventAddVehicle += ev;
			}
		}

		private void labelArmoredVehicle_MouseDown(object sender, MouseEventArgs e)
		{
			labelArmoredVehicle.DoDragDrop(labelArmoredVehicle.Text, DragDropEffects.Move | DragDropEffects.Copy);
		}


		private void labelTank_MouseDown(object sender, MouseEventArgs e)
		{
			labelTank.DoDragDrop(labelTank.Text, DragDropEffects.Move | DragDropEffects.Copy);
		}

		private void panelVehicle_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.Text))
			{
				e.Effect = DragDropEffects.Copy;
			}
			else
			{
				e.Effect = DragDropEffects.None;
			}
		}

		private void panelVehicle_DragDrop(object sender, DragEventArgs e)
		{
			switch (e.Data.GetData(DataFormats.Text).ToString())
			{
				case "БТР":
					vehicle = new ArmoredVehicle(100, 500, Color.Green);
					break;
				case "Танк":
					vehicle = new Tank(100, 500, Color.Green, Color.DarkGreen, checkBoxTower.Checked, checkBoxCamo.Checked);
					break;
			}
			DrawVehicle();

		}

		private void panelColor_MouseDown(object sender, MouseEventArgs e)
		{
			(sender as Panel).DoDragDrop((sender as Panel).BackColor, DragDropEffects.Move | DragDropEffects.Copy);
		}

		private void labelMainColor_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(typeof(Color)))
			{
				e.Effect = DragDropEffects.Copy;
			}
			else
			{
				e.Effect = DragDropEffects.None;
			}
		}

		private void labelMainColor_DragDrop(object sender, DragEventArgs e)
		{
			if (vehicle != null)
			{
				vehicle.SetMainColor((Color)e.Data.GetData(typeof(Color)));
			}
			DrawVehicle();
		}

		private void labelSeconadryColor_DragDrop(object sender, DragEventArgs e)
		{
			if (vehicle is Tank)
			{
				(vehicle as Tank).SetSecColor((Color)e.Data.GetData(typeof(Color)));
			}
			DrawVehicle();
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			eventAddVehicle?.Invoke(vehicle);
			Close();
		}
	}
}
