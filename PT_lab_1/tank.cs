using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PT_lab_1
{




    class tank
    {


       
        private float _startPosX;
       
        private float _startPosY;
        
        private int _pictureWidth;
       
        private int _pictureHeight;
        
        private const int tankWidth = 100;
        
        private const int tankHeight = 60;
        
        public int MaxSpeed { private set; get; }
        
        public float Weight { private set; get; }
        
        public Color MainColor { private set; get; }
        
        public Color DopColor { private set; get; }
        
        public bool firstGun { private set; get; }
        
        public bool secondGun { private set; get; }
        
        public bool thirdGun { private set; get; }
       
        public tank(int maxSpeed, float weight, Color mainColor, Color dopColor,
       bool frontSpoiler, bool sideSpoiler, bool backSpoiler)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            firstGun = frontSpoiler;
            secondGun = sideSpoiler;
            thirdGun = backSpoiler;
        }
       
        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }
      
        public void MoveTransport(ClassDirection.Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case ClassDirection.Direction.Right:
                    if (_startPosX + step < _pictureWidth - tankWidth)
                    {
                        _startPosX += step;
                    }
                    break;
                //влево
                case ClassDirection.Direction.Left:
                    if (_startPosX - step > 0)
                    {
                        _startPosX -= step;
                    }
                    break;
                //вверх
                case ClassDirection.Direction.Up:
                    if (_startPosY - step > 0)
                    {
                        _startPosY -= step;
                    }
                    break;
                //вниз
                case ClassDirection.Direction.Down:
                    if (_startPosY + step < _pictureHeight - tankHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }
      
        public void DrawTank(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
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
