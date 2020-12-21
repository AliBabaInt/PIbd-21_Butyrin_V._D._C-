using NLog;
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
	public partial class FormBase : Form
	{
		private readonly BaseCollection parkingCollection;

		private readonly Logger logger;

		public FormBase()
		{
			InitializeComponent();
			parkingCollection = new BaseCollection(pictureBoxParking.Width, pictureBoxParking.Height);
			logger = LogManager.GetCurrentClassLogger();
		}

		private void ReloadLevels()
		{
			int index = listBoxParking.SelectedIndex;
			listBoxParking.Items.Clear();
			for (int i = 0; i < parkingCollection.Keys.Count; i++)
			{
				listBoxParking.Items.Add(parkingCollection.Keys[i]);
			}
			if (listBoxParking.Items.Count > 0 && (index == -1 || index >= listBoxParking.Items.Count))
			{
				listBoxParking.SelectedIndex = 0;
			}
			else if (listBoxParking.Items.Count > 0 && index > -1 && index < listBoxParking.Items.Count)
			{
				listBoxParking.SelectedIndex = index;
			}
		}


		private void Draw()
		{
			if (listBoxParking.SelectedIndex > -1)
			{
				Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
				Graphics gr = Graphics.FromImage(bmp);
				parkingCollection[listBoxParking.SelectedItem.ToString()].Draw(gr);
				pictureBoxParking.Image = bmp;
			}
		}

		private void buttonArmoredVehicle_Click(object sender, EventArgs e)
		{
			if (listBoxParking.SelectedIndex > -1)
			{
				ColorDialog dialog = new ColorDialog();
				if (dialog.ShowDialog() == DialogResult.OK)
				{
					var vehicle = new ArmoredVehicle(100, 1000, dialog.Color);
					if (parkingCollection[listBoxParking.SelectedItem.ToString()] + vehicle)
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

		private void buttonTank_Click(object sender, EventArgs e)
		{
			if (listBoxParking.SelectedIndex > -1)
			{
				ColorDialog dialog = new ColorDialog();
				if (dialog.ShowDialog() == DialogResult.OK)
				{
			    ColorDialog dialogDop = new ColorDialog();
					if (dialogDop.ShowDialog() == DialogResult.OK)
					{
						var vehicle = new Tank(100, 1000, dialog.Color, dialogDop.Color, true, true);
						if (parkingCollection[listBoxParking.SelectedItem.ToString()] + vehicle)
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
		}

		private void buttonTake_Click(object sender, EventArgs e)
		{
			if (listBoxParking.SelectedIndex > -1 && maskedTextBoxPlace.Text != "")
			{
				try
				{
					var car = parkingCollection[listBoxParking.SelectedItem.ToString()] -
					Convert.ToInt32(maskedTextBoxPlace.Text);
					if (car != null)
					{
						FormTank form = new FormTank();
						form.SetCar(car);
						form.ShowDialog();
						logger.Info($"Изъят автомобиль {car} с места{maskedTextBoxPlace.Text}");
						Draw();
					}
				}
				catch (BaseNotFoundException ex)
				{
					logger.Warn(ex.Message, "Не найдено");
					MessageBox.Show(ex.Message, "Не найдено", MessageBoxButtons.OK,
				   MessageBoxIcon.Error);
				}
				catch (Exception ex)
				{
					logger.Warn(ex.Message, "Неизвестная ошибка");
					MessageBox.Show(ex.Message, "Неизвестная ошибка",
				   MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void buttonAddParking_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(textBoxLevel.Text))
			{
				MessageBox.Show("Введите название парковки", "Ошибка",
			   MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			logger.Info($"Добавили парковку {textBoxLevel.Text}");
			parkingCollection.AddParking(textBoxLevel.Text);
			ReloadLevels();
		}

		private void buttonDelete_Click(object sender, EventArgs e)
		{
			if (listBoxParking.SelectedIndex > -1)
			{
				if (MessageBox.Show($"Удалить парковку {listBoxParking.SelectedItem.ToString()}?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					logger.Info($"Удалили парковку{listBoxParking.SelectedItem.ToString()}");
					parkingCollection.DelParking(textBoxLevel.Text);
					ReloadLevels();
				}
			}
		}

		private void listBoxParking_SelectedIndexChanged(object sender, EventArgs e)
		{
			logger.Info($"Перешли на парковку{listBoxParking.SelectedItem.ToString()}");

			Draw();
		}

		private void buttonAddVehicle_Click(object sender, EventArgs e)
		{
			var formVehicleConfig = new FormVehicleConfig();
			formVehicleConfig.AddEvent(AddVehicle);
			formVehicleConfig.Show();
		}

		private void AddVehicle(Vehicle vehicle)
		{
			if (vehicle != null && listBoxParking.SelectedIndex > -1)
			{
				try
				{
					if ((parkingCollection[listBoxParking.SelectedItem.ToString()]) + vehicle)
					{
						Draw();
						logger.Info($"Добавлен автомобиль {vehicle}");
					}
					else
					{
						MessageBox.Show("Машину не удалось поставить");
					}
					Draw();
				}
				catch (BaseOverflowException ex)
				{
					logger.Warn(ex.Message, "Переполнение");
					MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK,
				   MessageBoxIcon.Error);
				}
				catch (BaseAlreadyHaveException ex)
				{
					logger.Warn(ex.Message, "Дублирование");
					MessageBox.Show(ex.Message, "Дублирование", MessageBoxButtons.OK,
				   MessageBoxIcon.Error);
				}
				catch (Exception ex)
				{
					logger.Warn(ex.Message, "Неизвестная ошибка");
					MessageBox.Show(ex.Message, "Неизвестная ошибка",
				   MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				try
				{
					parkingCollection.SaveData(saveFileDialog.FileName);
					MessageBox.Show("Сохранение прошло успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
					logger.Info("Сохранено в файл " + saveFileDialog.FileName);
				}
				catch (Exception ex)
				{
					logger.Warn(ex.Message, "Неизвестная ошибка при сохранении");
					MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении",
				   MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				try
				{
					parkingCollection.LoadData(openFileDialog.FileName);
					MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK,
					MessageBoxIcon.Information);
					logger.Info("Загружено из файла " + openFileDialog.FileName);
					ReloadLevels();
					Draw();
				}
				catch (BaseOccupiedPlaceException ex)
				{
					logger.Warn(ex.Message, "Занятое место");
					MessageBox.Show(ex.Message, "Занятое место", MessageBoxButtons.OK,
				   MessageBoxIcon.Error);
				}
				catch (Exception ex)
				{
					logger.Warn(ex.Message, "Неизвестная ошибка при сохранении");
					MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении",
				   MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void buttonSort_Click(object sender, EventArgs e)
		{
			if (listBoxParking.SelectedIndex > -1)
			{
				parkingCollection[listBoxParking.SelectedItem.ToString()].Sort();
				Draw();
				logger.Info("Сортировка уровней");
			}
		}
	}
}
