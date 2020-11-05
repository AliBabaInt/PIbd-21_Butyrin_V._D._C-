using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ProgrammingTech
{
	class Tank
	{
		//Начальные координаты
		private float _startPosX;
		private float _startPosY;

		//Высота и ширина окна отрисовки
		private int _pictureWidth;
		private int _pictureHeight;

		//Высота и ширина танка
		private readonly int tankWidth = 100;
		private readonly int tankHeight = 60;

		public int MaxSpeed { private set; get; }

		public float Weight { private set; get; }

		public Color MainColor { private set; get; }
		public Color SecColor { private set; get; }

		public bool Tower { private set; get; }
		public bool Camo { private set; get;}

		public Tank(int maxSpeed, float weight, Color mainColor, Color secColor, bool tower, bool camo)
		{
			MaxSpeed = maxSpeed;
			Weight = weight;
			MainColor = mainColor;
			SecColor = secColor;
			Tower = tower;
			Camo = camo;
		}

		public void SetPosition(int x, int y, int width, int height)
		{
			_startPosX = (float)x;
			_startPosY = (float)y;

			_pictureHeight = height;
			_pictureWidth = width;
		}

		public void MoveTransport(Direction direction)
		{
			float step = MaxSpeed * 100 / Weight;

			switch (direction)
			{
				case Direction.Right:
					if (_startPosX + step < _pictureWidth - tankWidth)
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
					if (_startPosY + step < _pictureHeight - tankHeight)
					{
						_startPosY += step;
					}
					break;
			}
		}

		public void DrawTransport(Graphics g)
		{
			Pen pen = new Pen(Color.Black);
			/*
			g.DrawRectangle(pen, _startPosX, _startPosY + 20, tankWidth, 35);
			g.DrawEllipse(pen, _startPosX + 2, _startPosY + tankHeight - 15, 15, 15);
			g.DrawEllipse(pen, _startPosX + 22, _startPosY + tankHeight - 15, 15, 15);
			g.DrawEllipse(pen, _startPosX + 42, _startPosY + tankHeight - 15, 15, 15);
			g.DrawEllipse(pen, _startPosX + 62, _startPosY + tankHeight - 15, 15, 15);
			g.DrawEllipse(pen, _startPosX + 82, _startPosY + tankHeight - 15, 15, 15);
			*/

			Brush tank = new SolidBrush(MainColor);
			g.FillRectangle(tank, _startPosX, _startPosY + 20, tankWidth, 35);

			Brush wheel = new SolidBrush(Color.Black);
			g.FillEllipse(wheel, _startPosX + 2, _startPosY + tankHeight - 15, 15, 15);
			g.FillEllipse(wheel, _startPosX + 22, _startPosY + tankHeight - 15, 15, 15);
			g.FillEllipse(wheel, _startPosX + 42, _startPosY + tankHeight - 15, 15, 15);
			g.FillEllipse(wheel, _startPosX + 62, _startPosY + tankHeight - 15, 15, 15);
			g.FillEllipse(wheel, _startPosX + 82, _startPosY + tankHeight - 15, 15, 15);

			if (Tower)
			{
				Brush tower = new SolidBrush(MainColor);
				//g.DrawEllipse(pen, _startPosX + 20, _startPosY, 60, 40);
				g.FillEllipse(tower, _startPosX + 20, _startPosY, 60, 40);

				//g.DrawRectangle(pen, _startPosX + tankWidth / 2, _startPosY + 5, tankWidth / 2, 5);
				g.FillRectangle(tower, _startPosX + tankWidth / 2, _startPosY + 5, tankWidth / 2, 5);
			}

			if (Camo)
			{
				Brush camo = new SolidBrush(SecColor);

				g.FillEllipse(camo, _startPosX, _startPosY + 25, 30, 10);
				g.FillEllipse(camo, _startPosX + 15, _startPosY + 25, 60, 15);
				g.FillEllipse(camo, _startPosX + 60, _startPosY + 25, 40, 20);
			}
		}

	}
}
