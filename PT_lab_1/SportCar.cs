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


    class SportCar : Car
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
        }
        public SportCar(string info) : base(info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 8)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
                FrontSpoiler = Convert.ToBoolean(strs[4]);
                BackSpoiler = Convert.ToBoolean(strs[5]);
                SideSpoiler = Convert.ToBoolean(strs[6]);
            }
        }

        public void SetDopColor(Color color)
        {
            DopColor = color;
        }


        public override void DrawCar(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush dopBrush = new SolidBrush(DopColor);
            // отрисуем сперва передний спойлер автомобиля (чтобы потом отрисовка
           // автомобиля на него "легла")
            if (FrontSpoiler)
            {
                g.DrawEllipse(pen, _startPosX + 80, _startPosY - 6, 20, 20);
                g.DrawEllipse(pen, _startPosX + 80, _startPosY + 35, 20, 20);
                g.DrawEllipse(pen, _startPosX - 5, _startPosY - 6, 20, 20);
                g.DrawEllipse(pen, _startPosX - 5, _startPosY + 35, 20, 20);
                g.DrawRectangle(pen, _startPosX + 80, _startPosY - 6, 15, 15);
                g.DrawRectangle(pen, _startPosX + 80, _startPosY + 40, 15, 15);
                g.DrawRectangle(pen, _startPosX, _startPosY - 6, 14, 15);
                g.DrawRectangle(pen, _startPosX, _startPosY + 40, 14, 15);

                g.FillEllipse(dopBrush, _startPosX + 80, _startPosY - 5, 20, 20);
                g.FillEllipse(dopBrush, _startPosX + 80, _startPosY + 35, 20, 20);
                g.FillRectangle(dopBrush, _startPosX + 75, _startPosY, 25, 40);
                g.FillRectangle(dopBrush, _startPosX + 80, _startPosY - 5, 15, 15);
                g.FillRectangle(dopBrush, _startPosX + 80, _startPosY + 40, 15, 15);
                g.FillEllipse(dopBrush, _startPosX - 5, _startPosY - 5, 20, 20);
                g.FillEllipse(dopBrush, _startPosX - 5, _startPosY + 35, 20, 20);
                g.FillRectangle(dopBrush, _startPosX - 5, _startPosY, 25, 40);
                g.FillRectangle(dopBrush, _startPosX, _startPosY - 5, 15, 15);
                g.FillRectangle(dopBrush, _startPosX, _startPosY + 40, 15, 15);
            }
            base.DrawCar(g);

            if (SideSpoiler)
            {
                g.DrawRectangle(pen, _startPosX + 25, _startPosY - 6, 39, 10);
                g.DrawRectangle(pen, _startPosX + 25, _startPosY + 45, 39, 10);
            }
            if (SideSpoiler)
            {
                g.DrawRectangle(pen, _startPosX + 25, _startPosY - 6, 39, 10);
                g.DrawRectangle(pen, _startPosX + 25, _startPosY + 45, 39, 10);

            }
        }
    }
}

