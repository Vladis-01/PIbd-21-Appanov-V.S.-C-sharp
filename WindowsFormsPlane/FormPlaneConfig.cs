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
    public partial class FormPlaneConfig : Form
    {
        /// <summary>
        /// Переменная-выбранная машина
        /// </summary>
        Vehicle plane = null;

        private event Action<Vehicle> eventAddPlane;

        public FormPlaneConfig()
        {
            InitializeComponent();
            // привязать panelColor_MouseDown к панелям с цветами

            foreach (var item in groupColors.Controls)
            {
                if (item is Panel)
                {
                    ((Panel)item).MouseDown += panelColor_MouseDown;
                }
            }


            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
        }

        /// <summary>
        /// Отрисовать машину
        /// </summary>
        private void DrawPlane()
        {
            if (plane != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxPlane.Width, pictureBoxPlane.Height);
                Graphics gr = Graphics.FromImage(bmp);
                plane.SetPosition(5, 5, pictureBoxPlane.Width, pictureBoxPlane.Height);
                plane.DrawTransport(gr);
                pictureBoxPlane.Image = bmp;
            }
        }

        /// <summary>
        /// Добавление события
        /// </summary>

        /// <param name="ev"></param>
        public void AddEvent(Action<Vehicle> ev)
        {
            if (eventAddPlane == null)
            {
                eventAddPlane = new Action<Vehicle>(ev);
            }
            else
            {
                eventAddPlane += ev;
            }
        }


        /// <summary>
        /// Отправляем цвет с панели
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            // Прописать логику вызова dragDrop для панелей, используя sender
            ((Panel)sender).DoDragDrop(((Panel)sender).BackColor, DragDropEffects.Move | DragDropEffects.Copy);
        }
        /// <summary>
        /// Проверка получаемой информации (ее типа на соответствие требуемому)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelColor_DragEnter(object sender, DragEventArgs e)
        {

            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }

        }

        private void labelMainColor_DragDrop(object sender, DragEventArgs e)
        {
            plane?.SetMainColor((Color)e.Data.GetData(typeof(Color)));
            DrawPlane();
        }

        private void labelPlane_MouseDown(object sender, MouseEventArgs e)
        {
            ((Label)sender).DoDragDrop(((Label)sender).Name, DragDropEffects.Move | DragDropEffects.Copy);
        }
        private void panelPlane_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "labelPlane":

                    plane = new Plane((int)numericUpDownMaxSpeed.Value,
                   (int)numericUpDownWeight.Value, Color.White);
                    break;
                case "labelBomberPlane":
                    plane = new BomberPlane((int)numericUpDownMaxSpeed.Value,
                   (int)numericUpDownWeight.Value, Color.White, Color.White,
                    checkBoxBombs.Checked, checkBoxTurboEngine.Checked);
                    break;
            }
            DrawPlane();
        }

        private void panelPlane_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if(plane is BomberPlane)
            {
                BomberPlane bomberPlane = (BomberPlane)plane;
                bomberPlane.SetDopColor((Color)e.Data.GetData(typeof(Color)));
                plane = bomberPlane;
                DrawPlane();
            }         
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            eventAddPlane?.Invoke(plane);
            Close();
        }
    }
}
