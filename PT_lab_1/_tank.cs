using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PT_lab_1
{

    


    class _tank : WarCar
    {
        /// <summary>
        /// Дополнительный цвет
        /// </summary>
        public Color DopColor { private set; get; }
        /// <summary>
        /// Признак наличия переднего спойлера
        /// </summary>
        public bool firstGun { private set; get; }
        /// <summary>
        /// Признак наличия боковых спойлеров
        /// </summary>
        public bool secondGun { private set; get; }
        /// <summary>
        /// Признак наличия заднего спойлера
        /// </summary>
        public bool thirdGun { private set; get; }
        /// <summary>
        /// Количество полос
        /// </summary>

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
        public _tank(int maxSpeed, float weight, Color mainColor, Color dopColor,
       bool _firstGun, bool _secondGun, bool _thirdGun) :
        base(maxSpeed, weight, mainColor)
        {
            DopColor = dopColor;
            firstGun = _firstGun;

            secondGun = _secondGun;

            thirdGun = _thirdGun;
            Random rnd = new Random();
        }
        public override void drawWarCar(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush dopBrush = new SolidBrush(DopColor);
            // отрисуем сперва передний спойлер автомобиля (чтобы потом отрисовка


            if (firstGun)
            {
                Brush brFirstGun = new SolidBrush(DopColor);

                g.DrawRectangle(pen, _startPosX + 5, _startPosY + 10, 85, 10);

                g.FillRectangle(brFirstGun, _startPosX + 5, _startPosY + 10, 85, 10);
                g.DrawRectangle(pen, _startPosX + 5, _startPosY + 10, 85, 10);
            }
            if (secondGun)
            {
                Brush brSecondGun = new SolidBrush(DopColor);
                g.DrawRectangle(pen, _startPosX + 5, _startPosY + 40, 85, 6);

                g.FillRectangle(brSecondGun, _startPosX + 5, _startPosY + 40, 85, 6);

                g.DrawRectangle(pen, _startPosX + 5, _startPosY + 40, 85, 6);

            }
            if (secondGun)
            {
                Brush brThirdGun = new SolidBrush(DopColor);
                g.DrawRectangle(pen, _startPosX - 35, _startPosY + 32, 80, 6);
                g.FillRectangle(brThirdGun, _startPosX - 35, _startPosY + 32, 80, 6);
                g.DrawRectangle(pen, _startPosX - 35, _startPosY + 32, 80, 6);
            }




            Brush brTank = new SolidBrush(MainColor);
            g.DrawRectangle(pen, _startPosX + 5, _startPosY + 10, 85, 10);
            g.DrawRectangle(pen, _startPosX + 10, _startPosY - 5, 20, 10);
            g.FillRectangle(brTank, _startPosX + 10, _startPosY - 5, 20, 10);
            g.DrawEllipse(pen, _startPosX, _startPosY, 52, 31);
            //  g.DrawEllipse(pen, _startPosX - 10, _startPosY + 30, 75, 40);
            g.FillEllipse(brTank, _startPosX, _startPosY, 52, 31);
            //  g.FillEllipse(brTank, _startPosX - 10, _startPosY + 30, 75, 40);
            g.DrawEllipse(pen, _startPosX, _startPosY, 52, 31);
            //  g.DrawEllipse(pen, _startPosX - 10, _startPosY + 30, 75, 40);

            base.drawWarCar(g);


        }
    }

}

