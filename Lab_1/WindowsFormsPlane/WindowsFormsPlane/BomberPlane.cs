using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsPlane
{
    class BomberPlane
    {
        /// <summary>
        /// Левая координата отрисовки автомобиля
        /// </summary>
        private float _startPosX;
        /// <summary>
        /// Правая кооридната отрисовки автомобиля
        /// </summary>
        private float _startPosY;
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private int _pictureWidth;
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private int _pictureHeight;
        /// <summary>
        /// Ширина отрисовки автомобиля
        /// </summary>
        /// 
        private readonly int carWidth = 100;
        /// <summary>
        /// Высота отрисовки автомобиля
        /// </summary>
        private readonly int carHeight = 100;
        /// <summary>
        /// Максимальная скорость
        /// </summary>
        public int MaxSpeed { private set; get; }
        /// <summary>
        /// Вес автомобиля
        /// </summary>
        public float Weight { private set; get; }
        /// <summary>
        /// Основной цвет кузова
        /// </summary>
        public Color MainColor { private set; get; }
        /// <summary>
        /// Дополнительный цвет
        /// </summary>
        public Color DopColor { private set; get; }
        /// <summary>
        /// Признак наличия переднего спойлера
        /// </summary>
        public bool FrontSpoiler { private set; get; }
        /// <summary>
        /// Признак наличия боковых спойлеров
        /// </summary>
        public bool SideSpoiler { private set; get; }
        /// <summary>
        /// Признак наличия заднего спойлера
        /// </summary>
        public bool BackSpoiler { private set; get; }
        /// <summary>
        /// Признак наличия гоночной полосы
        /// </summary>
        public bool SportLine { private set; get; }
        /// <summary>
        /// признак наличия бомб
        /// </summary>
        public bool Bombs { private set; get; }
        /// <summary>
        /// изнак наличия мощных двигателей </summary>
        public bool TurboEngine { private set; get; }
        /// Конструктор
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес автомобиля</param>
        /// <param name="mainColor">Основной цвет кузова</param>
        /// <param name="bombs">Признак наличия бомб</param>
        ///<param name="numberOfBombs">Количество бомб</param>
        public BomberPlane(int maxSpeed, float weight, Color mainColor, Color dopColor, bool bombs, bool turboEngine)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            Bombs = bombs;
            TurboEngine = turboEngine;
        }
        /// <summary>
        /// Установка позиции автомобиля
        /// </summary>
        /// <param name="x">Координата X</param>
        /// <param name="y">Координата Y</param>
        /// <param name="width">Ширина картинки</param>
        /// <param name="height">Высота картинки</param>
        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;

        }
        /// <summary>
        /// Изменение направления пермещения
        /// </summary>
        /// <param name="direction">Направление</param>
        public void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;

            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - carWidth)
                    {
                        _startPosX += step;
                    }
                    break;
                //влево
                case Direction.Left:
                    if (_startPosX - step > 0)
                    {
                        _startPosX -= step;
                    }
                    break;
                //вверх
                case Direction.Up:
                    if (_startPosY - step > 0)
                    {
                        _startPosY -= step;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - carHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }
        /// <summary>
        /// Отрисовка автомобиля
        /// </summary>
        /// <param name="g"></param>
        public void DrawTransport(Graphics g)
        {
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(MainColor);
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
                g.FillPolygon(myBrush, PointsEngine1);
                g.FillPolygon(myBrush, PointsEngine2);
            }


            //задняя часть хвоста
            g.FillRectangle(myBrush, _startPosX, _startPosY + 40, 10, 30);

            //корпус
            g.FillRectangle(myBrush, _startPosX + 10, _startPosY + 50, 80, 10);

            // крылья
            g.FillRectangle(myBrush, _startPosX + 40, _startPosY + 10, 10, 90);

            //нос самолета

            Point pointNose1 = new Point(_startPosXInt + 90, _startPosYInt + 50);
            Point pointNose2 = new Point(_startPosXInt + 90, _startPosYInt + 60);
            Point pointNose3 = new Point(_startPosXInt + 100, _startPosYInt + 55);

            Point[] PointsNose ={
                 pointNose1,
                 pointNose2,
                 pointNose3,

             };
            g.FillPolygon(myBrush, PointsNose);


        }
    }
}
