﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingTech
{
	public class Parking<T> where T : class, ITransport
	{
		private readonly List<T> _places;
		private readonly int _maxCount;

		private readonly int pictureWidth;
		private readonly int pictureHeight;

		private readonly int _placeSizeWidth = 210;
		private readonly int _placeSizeHeight = 80;

		public Parking(int picWidth, int picHeight)
		{
			int width = picWidth / _placeSizeWidth;
			int height = picHeight / _placeSizeHeight;
			_maxCount = width * height;
			_places = new List<T>();
			pictureWidth = picWidth;
			pictureHeight = picHeight;
		}

		public static bool operator +(Parking<T> p, T vehicle)
		{
			if (p._places.Count >= p._maxCount)
			{
				return false;
			}
			p._places.Add(vehicle);
			return true;
			//p._places[i].SetPosition(i / (p.pictureHeight / p._placeSizeHeight) * p._placeSizeWidth + 5, i % (p.pictureHeight / p._placeSizeHeight) * p._placeSizeHeight + 10, p.pictureWidth, p.pictureHeight);

		}

		public static T operator -(Parking<T> p, int index)
		{
			if (index < -1 || index > p._places.Count)
			{
				return null;
			}
			T vehicle = p._places[index];
			p._places.RemoveAt(index);
			return vehicle;

		}

		public void Draw(Graphics g)
		{
			DrawMarking(g);
			for (int i = 0; i < _places.Count; ++i)
			{
				_places[i].SetPosition(5 + i / 5 * _placeSizeWidth + 5, i % 5 *
			   _placeSizeHeight + 15, pictureWidth, pictureHeight);
				_places[i].DrawTransport(g);
			}

		}

		private void DrawMarking(Graphics g)
		{
			Pen pen = new Pen(Color.Black, 3);
			for (int i = 0; i < pictureWidth / _placeSizeWidth; i++)
			{
				for (int j = 0; j < pictureHeight / _placeSizeHeight + 1; ++j)
				{//линия рамзетки места
					g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight, i * _placeSizeWidth + _placeSizeWidth / 2, j * _placeSizeHeight);
				}
				g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth, (pictureHeight / _placeSizeHeight) * _placeSizeHeight);
			}
		}
	}
}
