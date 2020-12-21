using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ProgrammingTech
{
	class Tank : ArmoredVehicle, IEquatable<Tank>
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

		public Tank(string info) : base(info)
		{
			string[] strs = info.Split(separator);
			if (strs.Length == 6)
			{
				MaxSpeed = Convert.ToInt32(strs[0]);
				Weight = Convert.ToInt32(strs[1]);
				MainColor = Color.FromName(strs[2]);
				SecColor = Color.FromName(strs[3]);
				Tower = Convert.ToBoolean(strs[4]);
				Camo = Convert.ToBoolean(strs[5]);
			}
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

		public override string ToString()
		{
			return $"{base.ToString()}{separator}{SecColor.Name}{separator}{Tower}{separator}{Camo}";
		}

		public bool Equals(Tank other)
		{
			if(base.Equals(other))
			{
				if (SecColor != other.SecColor)
				{
					return false;
				}
				if (Tower != other.Tower)
				{
					return false;
				}
				if (Camo != other.Camo)
				{
					return false;
				}
				return true;
			}
			else return false;
		}

		public override bool Equals(Object obj)
		{
			if (obj == null)
			{
		    return false;
			}
			if (!(obj is Tank carObj))
			{
				return false;
			}
			else
			{
				return Equals(carObj);
			}
		}
	}
}
