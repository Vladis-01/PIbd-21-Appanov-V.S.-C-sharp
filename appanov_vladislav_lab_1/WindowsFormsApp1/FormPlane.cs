﻿using System;
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
	public partial class FormPlane : Form
	{
		private BomberPlane plane;
		/// <summary>
		/// Конструктор
		/// </summary>

		public FormPlane()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Метод отрисовки машины
		/// </summary>
		private void Draw()
		{
			Bitmap bmp = new Bitmap(pictureBoxPlans.Width, pictureBoxPlans.Height);
			Graphics gr = Graphics.FromImage(bmp);
			plane.DrawTransport(gr);
			pictureBoxPlans.Image = bmp;
		}
		/// <summary>
		/// Обработка нажатия кнопки "Создать"
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>

		private void create_Click(object sender, EventArgs e)
		{
			Random rnd = new Random();
			plane = new BomberPlane(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Blue, Color.Black,
		   true, true);
			plane.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxPlans.Width,
		   pictureBoxPlans.Height);
			Draw();
			 
		}

		/// <summary>
		/// Обработка нажатия кнопок управления
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonMove_Click(object sender, EventArgs e)
		{
			//получаем имя кнопки
			string name = (sender as Button).Name;
			switch (name)
			{
				case "buttonUp":
					plane.MoveTransport(Direction.Up);
					break;
				case "buttonDown":
					plane.MoveTransport(Direction.Down);
					break;
				case "buttonLeft":
					plane.MoveTransport(Direction.Left);
					break;
				case "buttonRight":
					plane.MoveTransport(Direction.Right);
					break;
			}
			Draw();
		}
	}
}
