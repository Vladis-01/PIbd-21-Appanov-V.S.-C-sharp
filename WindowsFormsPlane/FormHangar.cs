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

namespace WindowsFormsPlane
{
    public partial class FormHangar : Form
    {
        /// <summary>
        /// Объект от класса-парковки
        /// </summary>
        private readonly HangarCollection hangarCollection;

        /// <summary>
        /// Логгер
        /// </summary>
        private readonly Logger logger;

        public FormHangar()
        {
            InitializeComponent();
            hangarCollection = new HangarCollection(pictureBoxHangar.Width,
pictureBoxHangar.Height);
            logger = LogManager.GetCurrentClassLogger();
        }

        /// <summary>
        /// Заполнение listBoxLevels
        /// </summary>
        private void ReloadLevels()
        {
            int index = listBoxHangars.SelectedIndex;
            listBoxHangars.Items.Clear();
            for (int i = 0; i < hangarCollection.Keys.Count; i++)
            {
                listBoxHangars.Items.Add(hangarCollection.Keys[i]);
            }
            if (listBoxHangars.Items.Count > 0 && (index == -1 || index >=
          listBoxHangars.Items.Count))
            {
                listBoxHangars.SelectedIndex = 0;
            }
            else if (listBoxHangars.Items.Count > 0 && index > -1 && index <
           listBoxHangars.Items.Count)
                 {
                    listBoxHangars.SelectedIndex = index;
                 }
        }

        /// <summary>
        /// Метод отрисовки парковки
        /// </summary>
        private void Draw()
        {
            if (listBoxHangars.SelectedIndex > -1)
            {//если выбран один из пуктов в listBox (при старте программы ни один пункт не будет выбран и может возникнуть ошибка, если мы попытаемся обратиться к элементуlistBox)
                Bitmap bmp = new Bitmap(pictureBoxHangar.Width,
pictureBoxHangar.Height);
                Graphics gr = Graphics.FromImage(bmp);
                hangarCollection[listBoxHangars.SelectedItem.ToString()].Draw(gr);
                pictureBoxHangar.Image = bmp;
            }

        }

        /// <summary>
        /// Обработка нажатия кнопки "Добавить парковку"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddHangar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxHangars.Text))
            {
                logger.Warn("Не введено название ангара");
                MessageBox.Show("Введите название ангара", "Ошибка",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            logger.Info($"Добавили ангар {textBoxHangars.Text}");
            hangarCollection.AddHangar(textBoxHangars.Text);
            ReloadLevels();
        }
		/// <summary>
		/// Обработка нажатия кнопки "Удалить парковку"
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonDelHangar_Click(object sender, EventArgs e)
		{
			if (listBoxHangars.SelectedIndex > -1)
			{
				if (MessageBox.Show($"Удалить парковку { listBoxHangars.SelectedItem.ToString()}?", "Удаление", MessageBoxButtons.YesNo,
		   MessageBoxIcon.Question) == DialogResult.Yes)
				{
                    logger.Info($"Удалили ангар{ listBoxHangars.SelectedItem.ToString()}");
                    hangarCollection.DelHangar(listBoxHangars.SelectedItem.ToString());
					ReloadLevels();
				}
			}
		}

		private void buttonSetPlane_Click(object sender, EventArgs e)
        {
            var formPlaneConfig = new FormPlaneConfig();
            formPlaneConfig.AddEvent(AddPlane);
            formPlaneConfig.Show();

        }

        private void AddPlane(Vehicle plane)
        {
            if (plane != null && listBoxHangars.SelectedIndex > -1)
            {
                try
                {
                    if ((hangarCollection[listBoxHangars.SelectedItem.ToString()]) +
                   plane)
                    {
                        Draw();
                        logger.Info($"Добавлен самолет {plane}");
                    }
                    else
                    {
                        logger.Warn("Самолет не удалось поставить");
                        MessageBox.Show("Самолет не удалось поставить");
                    }
                    Draw();
                }
                catch (HangarOverflowException ex)
                {
                    logger.Warn($"Переполнение");
                    MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
                catch (HangarAlreadyHaveException ex)
                {
                    MessageBox.Show(ex.Message, "Дублирование", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    logger.Warn($"Неизвестная ошибка");
                    MessageBox.Show(ex.Message, "Неизвестная ошибка",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonPickUpPlane_Click(object sender, EventArgs e)
        {
            if (listBoxHangars.SelectedIndex > -1 && maskedTextBoxPlace.Text != "")
            {
                try
                {
                    var plane =
                   hangarCollection[listBoxHangars.SelectedItem.ToString()] -
                   Convert.ToInt32(maskedTextBoxPlace.Text);
                    if (plane != null)
                    {
                        FormPlane form = new FormPlane();
                        form.SetPlane(plane);
                        form.ShowDialog();
                        logger.Info($"Изъят самолет {plane} с места{ maskedTextBoxPlace.Text}");
                    Draw();
                    }
                }
                catch (HangarNotFoundException ex)
                {
                    logger.Warn($"Самолет на месте { maskedTextBoxPlace.Text} не найден");
                    MessageBox.Show(ex.Message, "Не найдено", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    logger.Warn($"Неизвестная ошибка");
                    MessageBox.Show(ex.Message, "Неизвестная ошибка",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        /// <summary>
        /// Метод обработки выбора элемента на listBoxLevels
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxHangars_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            logger.Info($"Перешли в ангар{ listBoxHangars.SelectedItem.ToString()}");
            Draw();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    hangarCollection.SaveData(saveFileDialog.FileName);
                    MessageBox.Show("Сохранение прошло успешно", "Результат",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Сохранено в файл " + saveFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    logger.Warn("Неизвестная ошибка при сохранении");
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    hangarCollection.LoadData(openFileDialog.FileName);
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    logger.Info("Загружено из файла " + openFileDialog.FileName);
                    ReloadLevels();
                    Draw();
                }

                catch (Exception ex)
                {
                    logger.Warn("Неизвестная ошибка при загрузке");
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при загрузке",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            if (listBoxHangars.SelectedIndex > -1)
            {
                hangarCollection[listBoxHangars.SelectedItem.ToString()].Sort();
                Draw();
                logger.Info("Сортировка уровней");
            }
        }
    }
}
