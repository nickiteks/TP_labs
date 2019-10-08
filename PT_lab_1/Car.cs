using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PT_lab_1
{
    public class Car : Vehicle
    {
        /// <summary>
        /// Ширина отрисовки автомобиля
        /// </summary>
        protected const int carWidth = 100;
        /// <summary>
        /// Ширина отрисовки автомобиля
        /// </summary>
        protected const int carHeight = 60;
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
        public override void MoveTransport(Direction direction)
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
        public override void DrawCar(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            
            Brush brTank = new SolidBrush(MainColor);
            g.DrawRectangle(pen, _startPosX + 10, _startPosY - 5, 20, 10);
            g.FillRectangle(brTank, _startPosX + 10, _startPosY - 5, 20, 10);
            g.DrawRectangle(pen, _startPosX + 10, _startPosY - 5, 20, 10);
            g.DrawEllipse(pen, _startPosX, _startPosY, 52, 31);
            g.DrawEllipse(pen, _startPosX - 10, _startPosY + 30, 75, 40);
            g.FillEllipse(brTank, _startPosX, _startPosY, 52, 31);
            g.FillEllipse(brTank, _startPosX - 10, _startPosY + 30, 75, 40);
            g.DrawEllipse(pen, _startPosX, _startPosY, 52, 31);
            g.DrawEllipse(pen, _startPosX - 10, _startPosY + 30, 75, 40);
            int plase = 10;
            for (int i = 0; i < 4; i++)
            {
                g.DrawEllipse(pen, _startPosX - plase, _startPosY + 40, 19, 20);
                plase -= 19;
            }
            g.DrawRectangle(pen, _startPosX + 10, _startPosY + 10, 25, 10);
        }
    }


}

