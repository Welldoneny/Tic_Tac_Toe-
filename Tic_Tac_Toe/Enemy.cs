using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    internal class Enemy : Template
    {
        public Enemy(Label lb, Button[,] btns) : base(lb, btns)
        {
        }
        private char getEnemySide()
        {
            if (getSide() == (char)CoordEnum.Cross)
            {
                return (char)CoordEnum.Zero;
            }
            else
            { 
                return (char)CoordEnum.Cross;
            }
        }

        public override void choseCoord(int[] coord, Button btn)
        {
            //генерация случайных значений
            int x = coord[0];
            int y = coord[1];
            Random rand = new Random();
            int a = rand.Next(3);
            int b = rand.Next(3);
            //пока случайные значения не будут дефолтными мы генерируем новые
            while (game[a, b] != (char)CoordEnum.Defolt ) 
            {
                a = rand.Next(3);
                b = rand.Next(3);
            }
            //когда координаты выпали на свободную клетку, то работаем с ней
            game[a, b] = getSide();
            if (getSide() == (char)CoordEnum.Cross)
            {
                Designer.setButtonImg(buttons[a, b], cross_img);
            }
            if (getSide() == (char)CoordEnum.Zero)
            {
                Designer.setButtonImg(buttons[a, b], zero_img);
            }
            Designer.setButtonEnabled(buttons[a, b]);
        }
    }
}
