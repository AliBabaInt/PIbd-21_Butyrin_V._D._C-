using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingTech
{
	class ArmoredVehicle : Vehicle
	{
		protected readonly int carWidth = 100;
		protected readonly int carHeight = 60;

		protected readonly char separator = ';';

		public ArmoredVehicle(int maxSpeed, float weight, Color mainColor)
		{
			MaxSpeed = maxSpeed;
			Weight = weight;
			MainColor = mainColor;
		}

		public ArmoredVehicle(string info)
		{
			string[] strs = info.Split(separator);
			if (strs.Length == 3)
			{
				MaxSpeed = Convert.ToInt32(strs[0]);
				Weight = Convert.ToInt32(strs[1]);
				MainColor = Color.FromName(strs[2]);
			}
		}

		protected ArmoredVehicle(int maxSpeed, float weight, Color mainColor, int carWidth, int carHeight)
		{
			MaxSpeed = maxSpeed;
			Weight = weight;
			MainColor = mainColor;
			this.carWidth = carWidth;
			this.carHeight = carHeight;
		}

        public override void MoveTransport(Direction direction)
        {
			float step = MaxSpeed * 100 / Weight;

			switch (direction)
			{
				case Direction.Right:
					if (_startPosX + step < _pictureWidth - carWidth)
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
					if (_startPosY + step < _pictureHeight - carHeight)
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
			g.FillRectangle(tank, _startPosX, _startPosY + 20, carWidth, 35);

			Brush wheel = new SolidBrush(Color.Black);
			g.FillEllipse(wheel, _startPosX + 2, _startPosY + carHeight - 15, 15, 15);
			g.FillEllipse(wheel, _startPosX + 22, _startPosY + carHeight - 15, 15, 15);
			g.FillEllipse(wheel, _startPosX + 42, _startPosY + carHeight - 15, 15, 15);
			g.FillEllipse(wheel, _startPosX + 62, _startPosY + carHeight - 15, 15, 15);
			g.FillEllipse(wheel, _startPosX + 82, _startPosY + carHeight - 15, 15, 15);
		}

		public override string ToString()
		{
			return $"{MaxSpeed}{separator}{Weight}{separator}{MainColor.Name}";
		}
	}
}
