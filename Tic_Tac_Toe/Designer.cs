using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tic_Tac_Toe.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Tic_Tac_Toe
{
    static internal class Designer
    {
        /// <summary>
        /// включает кнопки выбора стороны
        /// </summary>
        /// <param name="cross"></param>
        /// <param name="zero"></param>
        public static void chooseButtonsOn(RadioButton cross, RadioButton zero)
        {
            cross.Enabled = true;
            zero.Enabled = true;
        }
        /// <summary>
        /// отключает кнопки выбора стороны
        /// </summary>
        /// <param name="cross"></param>
        /// <param name="zero"></param>
        public static void chooseButtonsOff(RadioButton cross, RadioButton zero)
        {
            cross.Enabled = false;
            zero.Enabled = false;
        }
        /// <summary>
        /// Устанавливает на кнопку картинку
        /// </summary>
        /// <param name="button"></param>
        /// <param name="image"></param>
        public static void setButtonImg(Button button, Image image)
        { 
            button.BackgroundImage = image;
        }
        /// <summary>
        /// Отключает поля, на которые уже сходили
        /// </summary>
        /// <param name="button"></param>
        public static void setButtonEnabled(Button button)
        { 
            button.Enabled = false;
        }
        /// <summary>
        /// В поле действий уведомляет о том, что ход противника
        /// </summary>
        /// <param name="label"></param>
        public static void enemyStep(Label label)
        {
            label.Text = "Ход оппонента";
        }

        /// <summary>
        /// В поле действий уведомляет о том, что ход игрока
        /// </summary>
        /// <param name="label"></param>
        public static void yourStep(Label label)
        {
            label.Text = "Ваш ход";
        }
        /// <summary>
        /// Включает кнопку играть снова
        /// </summary>
        /// <param name="play"></param>
        /// <param name="play_again"></param>
        public static void PlayAgain(Button play, Button play_again)
        {
            play.Enabled = false;
            play_again.Enabled = true;
            play.Visible = false;
            play_again.Visible = true;
        }

        /// <summary>
        /// Очищает игровое поле
        /// </summary>
        /// <param name="buttons"></param>
        public static void clear(Button[,] buttons)
        {
            Image img = Resources.Defolt_BG;

            for (int i = 0; i < buttons.GetLength(0); i++)
            {
                for (int j = 0; j < buttons.GetLength(1); j++)
                {
                    buttons[i, j].BackgroundImage = img;
                    buttons[i, j].Enabled = true;
                }
            }
        }
        /// <summary>
        /// Устанавливает в поле действия выбор стороны
        /// </summary>
        /// <param name="label"></param>
        public static void ChooseSide(Label label)
        {
            label.Text = "Выберити сторону";
        }

        /// <summary>
        /// Квлючает кнопку играть и выключает кнопку играть ещё раз
        /// </summary>
        /// <param name="play"></param>
        /// <param name="play_again"></param>
        public static void Play(Button play, Button play_again)
        {
            play.Visible = true;
            play_again.Visible = false;
            play.Enabled = true;
            play_again.Enabled = false;
        }

        /// <summary>
        /// Очистка выбора стороны
        /// </summary>
        /// <param name="cross"></param>
        /// <param name="zero"></param>
        public static void RadioButtonsClear(RadioButton cross, RadioButton zero)
        {
            cross.Checked = false;
            zero.Checked = false;
        }

        /// <summary>
        /// Устанавливает подсказку играть в поле действий
        /// </summary>
        /// <param name="label"></param>
        public static void StartToPlay(Label label)
        {
            label.Text = "Нажмите играть, чтобы начать";
        }
        /// <summary>
        /// Устанавливает победу в поле действий
        /// </summary>
        /// <param name="label"></param>
        public static void YouWin(Label label)
        {
            label.Text = "Победа! Победа - вместо обеда!";
        }

        /// <summary>
        /// устнавливает поражение в поле действий
        /// </summary>
        /// <param name="label"></param>
        public static void YouLose(Label label)
        {
            label.Text = "Бро, тебе нужно тренироваться!";
        }

        public static void Draw(Label label)
        {
            label.Text = "Ничья, давай переиграем!";
        }
    }
}
