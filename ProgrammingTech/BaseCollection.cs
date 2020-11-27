using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingTech
{
	public class BaseCollection
	{
		readonly Dictionary<string, Base<Vehicle>> parkingStages;

		public List<string> Keys => parkingStages.Keys.ToList();

		private readonly int pictureWidth;
		private readonly int pictureHeight;

		private readonly char separator = ':';

		public BaseCollection(int pictureWidth, int pictureHeight)
		{
			parkingStages = new Dictionary<string, Base<Vehicle>>();
			this.pictureWidth = pictureWidth;
			this.pictureHeight = pictureHeight;
		}

		public void AddParking(string name)
		{
			if (parkingStages.ContainsKey(name))
			{
				return;
			}
			parkingStages.Add(name, new Base<Vehicle>(pictureWidth, pictureHeight));
		}

		public void DelParking(string name)
		{
			if (parkingStages.ContainsKey(name))
			{
				parkingStages.Remove(name);
			}
		}

		public void DelParkingPlace(int place)
		{
			if (place < parkingStages.Count)
			{
				string[] arr = parkingStages.Keys.ToArray<string>();
				parkingStages.Remove(arr[place]);
			}
		}

		public Base<Vehicle> this[string ind]
		{
			get
			{
				if (parkingStages.ContainsKey(ind))
				{
					return parkingStages[ind];
				}
				return null;
			}
		}

		public void SaveData(string filename)
		{
			if (File.Exists(filename))
			{
				File.Delete(filename);
			}
			using (StreamWriter sw = new StreamWriter(filename, false))
			{
				
				sw.WriteLine($"ParkingCollection", sw);
				foreach (var level in parkingStages)
				{
					//Начинаем парковку
					sw.WriteLine($"Parking{separator}{level.Key}", sw);
					ITransport vehicle = null;
					for (int i = 0; (vehicle = level.Value.GetNext(i)) != null; i++)
					{
						if (vehicle != null)
						{
							//если место не пустое
							//Записываем тип машины
							if (vehicle.GetType().Name == "ArmoredVehicle")
							{
								sw.Write($"ArmoredVehicle{separator}", sw);
							}
							if (vehicle.GetType().Name == "Tank")
							{
								sw.Write($"Tank{separator}", sw);
							}
							//Записываемые параметры
							sw.WriteLine(vehicle + "", sw);
						}
					}
				}
			}
		}

		public void LoadData(string filename)
		{
			if (!File.Exists(filename))
			{
				throw new FileNotFoundException();
			}
			using (StreamReader sr = new StreamReader(filename))
			{
				string line;
				if ((line = sr.ReadLine()) != null)
				{
					if (line.Contains("ParkingCollection"))
					{
						parkingStages.Clear();
					}
					else
					{
						//если нет такой записи, то это не те данные
						throw new WrongFormatException();
					}
					Vehicle vehicle = null;
					string key = string.Empty;
					while ((line = sr.ReadLine()) != null)
					{
						//идем по считанным записям
						if (line.Contains("Parking"))
						{
							//начинаем новую парковку
							key = line.Split(separator)[1];
							parkingStages.Add(key, new Base<Vehicle>(pictureWidth, pictureHeight));
							continue;
						}
						if (string.IsNullOrEmpty(line))
						{
							continue;
						}
						if (line.Split(separator)[0] == "ArmoredVehicle")
						{
							vehicle = new ArmoredVehicle(line.Split(separator)[1]);
						}
						else if (line.Split(separator)[0] == "Tank")
						{
							vehicle = new Tank(line.Split(separator)[1]);
						}
						var result = parkingStages[key] + vehicle;
						if (!result)
						{
							throw new FailedToLoadException();
						}
					}
				}
			}		
		}
	}
}
