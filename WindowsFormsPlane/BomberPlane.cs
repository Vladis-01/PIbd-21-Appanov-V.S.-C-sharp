using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsPlane
{
    class BomberPlane : Plane
    {
        
        public Color DopColor { private set; get; }
        /// <summary>
        /// Признак наличия переднего спойлера
        /// </summary>
        public bool Bombs { private set; get; }
        /// <summary>
        /// изнак наличия мощных двигателей </summary>
        public bool TurboEngine { private set; get; }
        /// Конструктор
        /// </summary>
        /// 
        public BomberPlane(int maxSpeed, float weight, Color mainColor, Color dopColor, bool bombs, bool turboEngine) : 
            base(maxSpeed, weight, mainColor, 100, 100)
        {
            MainColor = mainColor;
            DopColor = dopColor;
            Bombs = bombs;
            TurboEngine = turboEngine;
        }
        /// <summary>
        /// Установка позиции автомобиля
        /// </summary>

        /// <summary>
        /// Изменение направления пермещения
        /// </summary>
        /// <param name="direction">Направление</param>
        /// <summary>
        /// Отрисовка автомобиля
        /// </summary>
        /// <param name="g"></param>
        public override void DrawTransport(Graphics g)
        {
            System.Drawing.SolidBrush myBrush2 = new System.Drawing.SolidBrush(DopColor);
            // отрисуем сперва передний спойлер автомобиля (чтобы потом отрисовка
            // автомобиля на него "легла")

            int _startPosXInt = (int)_startPosX;
            int _startPosYInt = (int)_startPosY;

            if (Bombs)
            {
                g.FillRectangle(myBrush2, _startPosX + 35, _startPosY + 15, 20, 2);
                g.FillRectangle(myBrush2, _startPosX + 35, _startPosY + 20, 20, 2);
                g.FillRectangle(myBrush2, _startPosX + 35, _startPosY + 25, 20, 2);
                g.FillRectangle(myBrush2, _startPosX + 35, _startPosY + 30, 20, 2);

                g.FillRectangle(myBrush2, _startPosX + 35, _startPosY + 80, 20, 2);
                g.FillRectangle(myBrush2, _startPosX + 35, _startPosY + 85, 20, 2);
                g.FillRectangle(myBrush2, _startPosX + 35, _startPosY + 90, 20, 2);
                g.FillRectangle(myBrush2, _startPosX + 35, _startPosY + 95, 20, 2);

            }

            //доп двигатели
            if (TurboEngine)
            {
                g.FillRectangle(myBrush2, _startPosX + 37, _startPosY + 35, 20, 10);
                g.FillRectangle(myBrush2, _startPosX + 37, _startPosY + 65, 20, 10);

                Point pointEngine1 = new Point(_startPosXInt + 38, _startPosYInt + 35);
                Point pointEngine2 = new Point(_startPosXInt + 38, _startPosYInt + 45);
                Point pointEngine3 = new Point(_startPosXInt + 33, _startPosYInt + 40);

                Point pointEngine4 = new Point(_startPosXInt + 38, _startPosYInt + 65);
                Point pointEngine5 = new Point(_startPosXInt + 38, _startPosYInt + 75);
                Point pointEngine6 = new Point(_startPosXInt + 33, _startPosYInt + 70);

                Point[] PointsEngine1 ={
                    pointEngine1,
                    pointEngine2,
                    pointEngine3



                };

                Point[] PointsEngine2 ={
                    pointEngine4,
                    pointEngine5,
                    pointEngine6
                };
                g.FillPolygon(myBrush2, PointsEngine1);
                g.FillPolygon(myBrush2, PointsEngine2);
            }

            base.DrawTransport(g);
        }

        /// <summary>
        /// Смена дополнительного цвета
        /// </summary>
        /// <param name="color"></param>
        public void SetDopColor(Color color)
        {
            DopColor = color;
        }

    }
}
