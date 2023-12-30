using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    internal class Player : Template
    {
        public Player(System.Windows.Forms.Label lb, Button[,] btns) : base(lb, btns)
        {
            //передаем в шаблонный родительский класс поле действий и массив кнопок игрового поля
        }

        public override void choseCoord(int[] coord, Button btn)
        {
            //координаты хода
            int a = coord[0];
            int b = coord[1];
            //запоминаем куда сходили
            game[a, b] = getSide();
            //устанавливаем изображение
            if (getSide() == (char)CoordEnum.Cross)
            {
                Designer.setButtonImg(btn, cross_img);
            }
            if (getSide() == (char)CoordEnum.Zero)
            {
                Designer.setButtonImg(btn, zero_img);
            }
            //отключаем кнопку
            Designer.setButtonEnabled(btn);
        }
    }
}
