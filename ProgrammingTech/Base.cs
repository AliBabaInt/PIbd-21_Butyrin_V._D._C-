using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingTech
{
	public class Base<T> : IEnumerator<T>, IEnumerable<T>
		where T : class, ITransport
	{
		private readonly List<T> _places;
		private readonly int _maxCount;

		private readonly int pictureWidth;
		private readonly int pictureHeight;

		private readonly int _placeSizeWidth = 210;
		private readonly int _placeSizeHeight = 80;

		private int _currentIndex;
		public T Current => _places[_currentIndex];
		object IEnumerator.Current => _places[_currentIndex];

		public Base(int picWidth, int picHeight)
		{
			int width = picWidth / _placeSizeWidth;
			int height = picHeight / _placeSizeHeight;
			_maxCount = width * height;
			_places = new List<T>();
			pictureWidth = picWidth;
			pictureHeight = picHeight;
		}

		public static bool operator +(Base<T> p, T vehicle)
		{
			if (p._places.Count >= p._maxCount)
			{
				throw new BaseOverflowException();
			}
			if (p._places.Contains(vehicle))
			{
				throw new BaseAlreadyHaveException();
			}
			p._places.Add(vehicle);
			return true;
		}

		public static T operator -(Base<T> p, int index)
		{
			if (index < -1 || index > p._places.Count)
			{
				throw new BaseNotFoundException(index);
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
				_places[i].SetPosition(5 + i / 6 * _placeSizeWidth + 5, i % 6 * _placeSizeHeight + 15, pictureWidth, pictureHeight);
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

		public T GetNext(int index)
		{
			if (index < 0 || index >= _places.Count)
			{
				return null;
			}
			return _places[index];
		}

		public void Sort() => _places.Sort((IComparer<T>)new VehicleComparer());

		public void Dispose()
		{
		}

		public bool MoveNext()
		{
			_currentIndex++;
			return _currentIndex < _places.Count;
		}

		public void Reset()
		{
			_currentIndex = -1;
		}

		public IEnumerator<T> GetEnumerator()
		{
			return this;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return this;
		}
	}
}
