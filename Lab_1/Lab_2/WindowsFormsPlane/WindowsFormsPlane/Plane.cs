using System.Drawing;
namespace WindowsFormsPlane
{
    public class Car : Vehicle
    {
        /// <summary>
        /// Ширина отрисовки автомобиля
        /// </summary>
        protected readonly int planeWidth = 100;
        /// <summary>
        /// Высота отрисовки автомобиля
        /// </summary>
        protected readonly int planeHeight = 100;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес автомобиля</param>
        /// <param name="mainColor">Основной цвет кузова</param>
        public Car(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }
        /// <summary>
        /// Конструкторс изменением размеров машины
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес автомобиля</param>
        /// <param name="mainColor">Основной цвет кузова</param>
        /// <param name="carWidth">Ширина отрисовки автомобиля</param>
        /// <param name="carHeight">Высота отрисовки автомобиля</param>
        protected Car(int maxSpeed, float weight, Color mainColor, int planeWidth, int
       planeHeight)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            this.planeWidth = planeWidth;
            this.planeHeight = planeHeight;
        }
        public override void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - planeWidth)
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
                    if (_startPosY + step < _pictureHeight - planeHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }
        public override void DrawTransport(Graphics g)
        {
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(MainColor);
            int _startPosXInt = (int)_startPosX;
            int _startPosYInt = (int)_startPosY;

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
