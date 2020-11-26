using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ProgrammingTech
{
	class Tank : ArmoredVehicle
	{

		public Color SecColor { private set; get; }

		public bool Tower { private set; get; }
		public bool Camo { private set; get;}

		public Tank(int maxSpeed, float weight, Color mainColor, Color secColor, bool tower, bool camo) : base(maxSpeed, weight, mainColor, 100, 60)
		{
			SecColor = secColor;
			Tower = tower;
			Camo = camo;
		}


		public override void DrawTransport(Graphics g)
		{
			base.DrawTransport(g);

			if (Tower)
			{
				Brush tower = new SolidBrush(MainColor);
				g.FillEllipse(tower, _startPosX + 20, _startPosY, 60, 40);

				g.FillRectangle(tower, _startPosX + carWidth / 2, _startPosY + 5, carWidth / 2, 5);
			}

			if (Camo)
			{
				Brush camo = new SolidBrush(SecColor);

				g.FillEllipse(camo, _startPosX, _startPosY + 25, 30, 10);
				g.FillEllipse(camo, _startPosX + 15, _startPosY + 25, 60, 15);
				g.FillEllipse(camo, _startPosX + 60, _startPosY + 25, 40, 20);
			}
		}

		public void SetSecColor(Color color)
		{
			SecColor = color;
		}

	}
}
