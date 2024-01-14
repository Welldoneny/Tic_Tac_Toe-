using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    internal class Enemy : Template
    {
        Designer designer = Designer.getInstance();
        public Enemy(Label lb, Button[,] btns) : base(lb, btns)
        {
            //передача элементов управления в родительский класс
        }
        /// <summary>
        /// возвращает сторону противника
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// в зависимости от сложности выбирает необходимый режим игры
        /// </summary>
        /// <param name="difficulty"></param>
        public override void choseCoord(int difficulty)
        {
            switch (difficulty)
            {
                case 1:
                    easy();
                    break;
                case 2:
                    medium();
                    break;
                case 3:
                    hard();
                    break;
                default:
                    break;
            }
        }
        /// <summary>
        /// легкий режим
        /// </summary>
        private void easy()
        {
            //генерация случайных значений
            //int x = coord[0];
            //int y = coord[1];
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
            Game(a, b);
        }

        /// <summary>
        /// средний режим
        /// </summary>
        private void medium() 
        {
            int a = 10;
            int b = 10;
            //проверяем каждую клетку на то, есть ли смысл на неё сходить
            for (int i = 0; i < game.GetLength(0); i++)
            {
                for (int j = 0; j < game.GetLength(1); j++)
                {
                    double jleft = j+ (2 * (197 * (j + 1) - 257) / (Math.Pow((j + 1), 4) - 19 * Math.Pow((j + 1),3) + 136 * Math.Pow((j + 1),2) - 444 * (j + 1) + 206));
                    double jright = j +  0.25 * (-6 * (j + 1) + Math.Pow((-1),(j + 1)) + 3 * Math.Pow((-1), (2 * (j + 1))) + 12);
                    if (game[i, (int)jleft] == game[i, (int)jright] && game[i, (int)jleft] != getEnemySide() && game[i, (int)jleft] != (char)CoordEnum.Defolt && game[i, j] == (char)CoordEnum.Defolt)
                    {
                        a = i;
                        b = j;
                        break;
                    }
                    if (game[(int)jleft, j] == game[(int)jright, j] && game[(int)jleft, j] != getEnemySide() && game[(int)jleft, j] != (char)CoordEnum.Defolt && game[i, j] == (char)CoordEnum.Defolt)
                    {
                        a = i;
                        b = j;
                        break;
                    }
                }
            }
            //если мы выбрали подходящую клетку, то ходим
            if (a != 10)
            {
                Game(a, b);
            }
            //иначе тыкаем пальцем в небо
            else
            {
                easy();
            }
        }
        /// <summary>
        /// сложный режим
        /// </summary>
        private void hard()
        {
            int a = 10;
            int b = 10;
            //проверяем каждую точку на то, является ли она победной для врага
            for (int i = 0; i < game.GetLength(0); i++)
            {
                for (int j = 0; j < game.GetLength(1); j++)
                {
                    double jleft = j + (2 * (197 * (j + 1) - 257) / (Math.Pow((j + 1), 4) - 19 * Math.Pow((j + 1), 3) + 136 * Math.Pow((j + 1), 2) - 444 * (j + 1) + 206));
                    double jright = j + 0.25 * (-6 * (j + 1) + Math.Pow((-1), (j + 1)) + 3 * Math.Pow((-1), (2 * (j + 1))) + 12);
                    double ileft = 0;
                    double iright = 0;
                    switch (i)
                    {
                        case 0:
                            ileft = 1;
                            iright = 2;
                            break;
                        case 1:
                            ileft = 0;
                            iright = 2;
                            break;
                        case 2:
                            ileft = 0;
                            iright = 1;
                            break;
                        default:
                            break;
                    }
                    if (game[i, (int)jleft] == game[i, (int)jright] && game[i, (int)jleft] == getEnemySide() && game[i, (int)jleft] != (char)CoordEnum.Defolt && game[i, j] == (char)CoordEnum.Defolt)
                    {
                        a = i;
                        b = j;
                        break;
                    }
                    //MessageBox.Show(((int)ileft).ToString() + " " + ((int)iright).ToString());
                    if (game[(int)ileft, j] == game[(int)iright, j] && game[(int)ileft, j] == getEnemySide() && game[(int)ileft, j] != (char)CoordEnum.Defolt && game[i, j] == (char)CoordEnum.Defolt)
                    {
                        a = i;
                        b = j;
                        break;
                    }
                    if (game[1, 1] == game[2, 2] && game[0, 0] == (char)CoordEnum.Defolt && game[1, 1] == getEnemySide() && game[1, 1] != (char)CoordEnum.Defolt)
                    {
                        a = 0;
                        b = 0;
                        break;
                    }
                    if (game[1, 1] == game[2, 0] && game[1, 1] != (char)CoordEnum.Defolt && game[0, 2] == (char)CoordEnum.Defolt && game[1, 1] == getEnemySide())
                    {
                        a = 0;
                        b = 2;
                        break;
                    }
                    if ((game[0, 0] == game[2, 2] || game[0, 2] == game[2, 0]) && (game[0, 0] != (char)CoordEnum.Defolt || game[0,2] != (char)CoordEnum.Defolt) && game[1, 1] == (char)CoordEnum.Defolt && (game[0, 2] == getEnemySide() || game[0,0] == getEnemySide()))
                    {
                        a = 1;
                        b = 1;
                        break;
                    }
                    if (game[0, 2] == game[1, 1] && game[0, 2] != (char)CoordEnum.Defolt && game[2, 0] == (char)CoordEnum.Defolt && game[1, 1] == getEnemySide())
                    {
                        a = 2;
                        b = 0;
                        break;
                    }
                    if (game[0, 0] == game[1, 1] && game[0, 0] != (char)CoordEnum.Defolt && game[2, 2] == (char)CoordEnum.Defolt && game[1, 1] == getEnemySide())
                    {
                        a = 2;
                        b = 2;
                        break;
                    }
                }
            }
            if (a != 10)
            {
                Game(a,b);
            }
            else
            {
                easy();
            }
        }
        private void Game(int a, int b)
        {
                game[a, b] = getSide();
                if (getSide() == (char)CoordEnum.Cross)
                {
                    designer.setButtonImg(buttons[a, b], cross_img);
                }
                if (getSide() == (char)CoordEnum.Zero)
                {
                    designer.setButtonImg(buttons[a, b], zero_img);
                }
                designer.setButtonEnabled(buttons[a, b]);
        }
    }
}
