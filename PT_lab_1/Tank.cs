using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PT_lab_1
{
    class Tank : WarCar , IComparable<Tank>, IEquatable<Tank>
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



        public Tank(int maxSpeed, float weight, Color mainColor, Color dopColor,
bool frontSpoiler, bool sideSpoiler, bool backSpoiler) :
 base(maxSpeed, weight, mainColor)
        {
            DopColor = dopColor;
            firstGun = frontSpoiler;
            secondGun = sideSpoiler;
            thirdGun = backSpoiler;
            Random rnd = new Random();
        }
        public Tank(string info) : base(info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 8)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
                firstGun = Convert.ToBoolean(strs[4]);
                thirdGun = Convert.ToBoolean(strs[5]);
                secondGun = Convert.ToBoolean(strs[6]);
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
            if (thirdGun)
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
            g.FillEllipse(brTank, _startPosX, _startPosY, 52, 31);
            g.DrawEllipse(pen, _startPosX, _startPosY, 52, 31);

            base.DrawCar(g);

        }
        public override string ToString()
        {
            return base.ToString() + ";" + DopColor.Name + ";" + firstGun + ";" +
           secondGun + ";" + thirdGun+";0";
        }

        public int CompareTo(Tank other)
        {
            var res = (this is WarCar).CompareTo(other is WarCar);
            if (res != 0)
            {
                return res;
            }
            if (DopColor != other.DopColor)
            {
                DopColor.Name.CompareTo(other.DopColor.Name);
            }
            if (firstGun != other.firstGun)
            {
                return firstGun.CompareTo(other.firstGun);
            }
            if (secondGun != other.secondGun)
            {
                return secondGun.CompareTo(other.secondGun);
            }
            if (thirdGun != other.thirdGun)
            {
                return thirdGun.CompareTo(other.thirdGun);
            }
            return 0;
        }

        public bool Equals(Tank other)
        {
            var res = (this as WarCar).Equals(other as WarCar);
            if (!res)
            {
                return res;
            }
            if (GetType().Name != other.GetType().Name)
            {
                return false;
            }
            if (DopColor != other.DopColor)
            {
                return false;
            }
            if (firstGun != other.firstGun)
            {
                return false;
            }
 
            if (secondGun != other.secondGun)
            {
                return false;
            }
            if (thirdGun != other.thirdGun)
            {
                return false;
            }
            return true;
        }
        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Tank carObj))
            {
                return false;
            }
            else
            {
                return Equals(carObj);
            }
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}

