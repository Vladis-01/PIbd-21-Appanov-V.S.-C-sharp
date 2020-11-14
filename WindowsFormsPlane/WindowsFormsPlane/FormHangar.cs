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
        private readonly Hangar<Vehicle> hangar;

        public FormHangar()
        {
            InitializeComponent();
            hangar = new Hangar<Vehicle>(pictureBoxHangar.Width,
pictureBoxHangar.Height);
            Draw();

        }

        /// <summary>
        /// Метод отрисовки парковки
        /// </summary>
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxHangar.Width, pictureBoxHangar.Height);
            Graphics gr = Graphics.FromImage(bmp);
            hangar.Draw(gr);
            pictureBoxHangar.Image = bmp;
        }

        private void buttonSetPlane_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var plane = new Plane(100, 1000, dialog.Color);
            if (hangar + plane)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Парковка переполнена");
                }
            }
        }

        private void buttonSetBomberPlane_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var plane = new BomberPlane(100, 1000, dialog.Color, dialogDop.Color,
                   true, true);
                    if (hangar + plane)
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

        private void buttonPickUpPlane_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxHangar.Text != "")
            {
                var plane = hangar - Convert.ToInt32(maskedTextBoxHangar.Text);
                Draw();

                if (plane != null)
                {
                    FormPlane form = new FormPlane();
                    form.SetPlane(plane);
                    form.ShowDialog();
                } 
                
            }
        }
    }
}
