using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PT_lab_1
{

    public enum Direction
    {
        Up,
        Down,
        Left,
        Right
    }


    class SportCar:Car
    {
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
        /// Количество полос
        /// </summary>
        private int _countLines;
        /// <summary>
        /// Количество полос
        /// </summary>
        public int CountLines
        {
            set
            {
                if (value > 0 && value < 4) _countLines = value;
            }
            get { return _countLines; }
        }
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес автомобиля</param>
        /// <param name="mainColor">Основной цвет кузова</param>
        /// <param name="dopColor">Дополнительный цвет</param>
        /// <param name="frontSpoiler">Признак наличия переднего спойлера</param>
        /// <param name="sideSpoiler">Признак наличия боковых спойлеров</param>
        /// <param name="backSpoiler">Признак наличия заднего спойлера</param>
        public SportCar(int maxSpeed, float weight, Color mainColor, Color dopColor,
       bool frontSpoiler, bool sideSpoiler, bool backSpoiler) :
        base(maxSpeed, weight, mainColor)
        {
            DopColor = dopColor;
            FrontSpoiler = frontSpoiler;
            SideSpoiler = sideSpoiler;

            BackSpoiler = backSpoiler;
            Random rnd = new Random();
            CountLines = rnd.Next(1, 4);
        }
        public override void DrawCar(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush dopBrush = new SolidBrush(DopColor);
            // отрисуем сперва передний спойлер автомобиля (чтобы потом отрисовка

            
 if (FrontSpoiler)
            {
                Brush brFirstGun = new SolidBrush(DopColor);
                g.DrawRectangle(pen, _startPosX + 5, _startPosY + 10, 85, 10);

                g.FillRectangle(brFirstGun, _startPosX + 5, _startPosY + 10, 85, 10);
                g.DrawRectangle(pen, _startPosX + 5, _startPosY + 10, 85, 10);
            }
            if (SideSpoiler)
            {
                Brush brSecondGun = new SolidBrush(DopColor);
                g.DrawRectangle(pen, _startPosX + 5, _startPosY + 40, 85, 6);

                g.FillRectangle(brSecondGun, _startPosX + 5, _startPosY + 40, 85, 6);

                g.DrawRectangle(pen, _startPosX + 5, _startPosY + 40, 85, 6);

            }
            if (SideSpoiler)
            {
                Brush brThirdGun = new SolidBrush(DopColor);
                g.DrawRectangle(pen, _startPosX - 35, _startPosY + 32, 80, 6);
                g.FillRectangle(brThirdGun, _startPosX - 35, _startPosY + 32, 80, 6);
                g.DrawRectangle(pen, _startPosX - 35, _startPosY + 32, 80, 6);
            }
        }
    }

}

