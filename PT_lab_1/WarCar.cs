using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PT_lab_1
{
    public class WarCar : Vehicle
    {
        /// <summary>
        /// Ширина отрисовки автомобиля
        /// </summary>
        protected const int tankWidth = 100;
        /// <summary>
        /// Ширина отрисовки автомобиля
        /// </summary>
        protected const int tankHeight = 60;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес автомобиля</param>
        /// <param name="mainColor">Основной цвет кузова</param>
        public WarCar(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }
        public override void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - tankWidth)
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
                    if (_startPosY + step < _pictureHeight - tankHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }
        public override void drawWarCar(Graphics g)
        {



            Pen pen = new Pen(Color.Black);

            Brush warCar = new SolidBrush(MainColor);
            Brush blackBrush = new SolidBrush(Color.Black);

            g.FillRectangle(warCar, _startPosX + 60, _startPosY + 35, 50, 45);
            g.FillRectangle(blackBrush, _startPosX + 80, _startPosY + 40, 30, 30);
            g.FillRectangle(warCar, _startPosX - 20, _startPosY + 30, 80, 50);
            g.DrawRectangle(pen, _startPosX - 20, _startPosY + 30, 80, 50);
            g.DrawRectangle(pen, _startPosX - 15, _startPosY + 35, 60, 30);
            g.DrawRectangle(pen, _startPosX + 60, _startPosY + 35, 50, 45);

            g.FillEllipse(blackBrush, _startPosX - 18, _startPosY + 70, 40, 40);
            g.FillEllipse(blackBrush, _startPosX + 55, _startPosY + 70, 40, 40);
        }
    }


}

