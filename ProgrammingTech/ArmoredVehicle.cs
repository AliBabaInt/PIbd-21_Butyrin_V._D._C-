using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingTech
{
	public class ArmoredVehicle : Vehicle
	{
		protected readonly int vehicleWidth = 100;
		protected readonly int vehicleHeight = 60;


		public ArmoredVehicle(int maxSpeed, float weight, Color mainColor)
		{
			MaxSpeed = maxSpeed;
			Weight = weight;
			MainColor = mainColor;
		}

		protected ArmoredVehicle(int maxSpeed, float weight, Color mainColor, int vehicleWidth, int vehicleHeight)
		{
			MaxSpeed = maxSpeed;
			Weight = weight;
			MainColor = mainColor;
			this.vehicleWidth = vehicleWidth;
			this.vehicleHeight = vehicleHeight;
		}

		public override void MoveTransport(Direction direction)
		{
			float step = MaxSpeed * 100 / Weight;

			switch (direction)
			{
				case Direction.Right:
					if (_startPosX + step < _pictureWidth - vehicleWidth)
					{
						_startPosX += step;
					}
					break;
				case Direction.Left:
					if (_startPosX - step > 0)
					{
						_startPosX -= step;
					}
					break;
				case Direction.Up:
					if (_startPosY - step > 0)
					{
						_startPosY -= step;
					}
					break;
				case Direction.Down:
					if (_startPosY + step < _pictureHeight - vehicleHeight)
					{
						_startPosY += step;
					}
					break;
			}
		}

		public override void DrawTransport(Graphics g)
		{
			Pen pen = new Pen(Color.Black);

			Brush tank = new SolidBrush(MainColor);
			g.FillRectangle(tank, _startPosX, _startPosY + 20, vehicleWidth, 35);

			Brush wheel = new SolidBrush(Color.Black);
			g.FillEllipse(wheel, _startPosX + 2, _startPosY + vehicleHeight - 15, 15, 15);
			g.FillEllipse(wheel, _startPosX + 22, _startPosY + vehicleHeight - 15, 15, 15);
			g.FillEllipse(wheel, _startPosX + 42, _startPosY + vehicleHeight - 15, 15, 15);
			g.FillEllipse(wheel, _startPosX + 62, _startPosY + vehicleHeight - 15, 15, 15);
			g.FillEllipse(wheel, _startPosX + 82, _startPosY + vehicleHeight - 15, 15, 15);
		}
	}
}

