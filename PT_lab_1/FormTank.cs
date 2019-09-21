using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PT_lab_1
{
    public partial class FormTank : Form
    {
        private tank tank;
       
        public FormTank()
        {
            InitializeComponent();
        }
       
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxTank.Width, pictureBoxTank.Height);
            Graphics gr = Graphics.FromImage(bmp);
            tank.DrawTank(gr);
            pictureBoxTank.Image = bmp;
        }
      
    

   
        private void buttonMove_Click(object sender, EventArgs e)
        {
           
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    tank.MoveTransport(ClassDirection.Direction.Up);
                    break;
                case "buttonDown":
                    tank.MoveTransport(ClassDirection.Direction.Down);
                    break;
                case "buttonLeft":
                    tank.MoveTransport(ClassDirection.Direction.Left);
                    break;
                case "buttonRight":
                    tank.MoveTransport(ClassDirection.Direction.Right);
                    break;
            }
            Draw();
        }

        private void buttonCreate_Click_1(object sender, EventArgs e)
        {

            Random rnd = new Random();
            tank = new tank(rnd.Next(100, 120), rnd.Next(1000, 2000), Color.Green,
           Color.Yellow, true, false, false);
            tank.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxTank.Width,
           pictureBoxTank.Height);
            Draw();

        }
    }
}
