using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tic_Tac_Toe.Properties;

namespace Tic_Tac_Toe
{
    internal abstract class Template
    {
        //картинки крестика и нолика
        protected Image cross_img = Resources.cross;
        protected Image zero_img = Resources.circle;
        // для удобства
        public enum CoordEnum{ Cross = 'X', Zero = 'O', Defolt = '-'}
        //поле действий
        protected System.Windows.Forms.Label label;
        // игровое поле
        protected static char[,] game = new char[3, 3];
        //сторона
        protected char side = (char)CoordEnum.Defolt;
        //массив содержащий кнопки отвечающие за игровое поле
        protected Button[,] buttons = new Button[3, 3];
        //конструктор
        public Template(System.Windows.Forms.Label lb, Button[,] btns) 
        {
            //заполняем игровое поле нулями по умолчанию
            for (int i = 0; i < game.GetLength(0); i++)
            {
                for (int j = 0; j < game.GetLength(1); j++)
                {
                    game[i, j] = (char)CoordEnum.Defolt;
                }
            }
            //получаем доступ к элементам управления            
            label = lb;
            buttons = btns;
        }
        /// <summary>
        /// устанавливает сторону
        /// </summary>
        /// <param name="side"></param>
        public void setSide(char side)
        { 
            this.side = side;
        }
        /// <summary>
        /// возвращает сторону
        /// </summary>
        /// <returns></returns>
        public char getSide()
        { 
            return side;
        }
        /// <summary>
        /// ход по определенным координатам
        /// </summary>
        /// <param name="coord"></param>
        /// <param name="btn"></param>
        virtual public void choseCoord(int[] coord, Button btn) { }
        virtual public void choseCoord(int difficulty) { }
        /// <summary>
        /// проверка на выигрышь
        /// </summary>
        public char check()
        {
            List<char> symbols = new List<char> { };
            symbols.Add('X');
            symbols.Add('O');
            for (int j = 0; j < symbols.Count; j++)
            {
                for (int i = 0; i < game.GetLength(0); i++)
                {
                    if (game[0, i] == symbols[j] && game[1, i] == symbols[j] && game[2, i] == symbols[j])
                    {
                        MessageBox.Show("Три в ряд! Победил - " + symbols[j].ToString());
                        return symbols[j];
                    }
                    if (game[i, 0] == symbols[j] && game[i, 1] == symbols[j] && game[i, 2] == symbols[j])
                    {
                        MessageBox.Show("Три в ряд! Победил - " + symbols[j].ToString());
                        return symbols[j];
                    }
                }
                if (game[0, 0] == symbols[j] && game[1, 1] == symbols[j] && game[2, 2] == symbols[j])
                {
                    MessageBox.Show("Три в ряд! Победил - " + symbols[j].ToString());
                    return symbols[j];
                }
                if (game[2, 0] == symbols[j] && game[1, 1] == symbols[j] && game[0, 2] == symbols[j])
                {
                    MessageBox.Show("Три в ряд! Победил - " + symbols[j].ToString());
                    return symbols[j];
                }
            }
            int k = 0;
            for (int i = 0; i < game.GetLength(0); i++)
            {
                for (int j = 0; j < game.GetLength(1); j++)
                {
                    if (game[i,j] == (char)CoordEnum.Defolt)
                    {
                        k++;
                    }
                }
            }
            if (k == 0)
            {
                MessageBox.Show("Ничья!");
                return (char)CoordEnum.Defolt;
            }
            return ' ';
        }
        /// <summary>
        /// цикл одного хода
        /// </summary>
        public char play(int[] coord, Button btn)
        {
            choseCoord(coord, btn);
            return check();
        }
        public char play(int difficulty)
        {
            choseCoord(difficulty);
            return check();
        }
        /// <summary>
        /// очистка игрового поля
        /// </summary>
        public void clear()
        {
            for (int i = 0; i < game.GetLength(0); i++)
            {
                for (int j = 0; j < game.GetLength(1); j++)
                {
                    game[i, j] = (char)CoordEnum.Defolt;
                }
            }
            side = (char)CoordEnum.Defolt;
        }
    }
}
