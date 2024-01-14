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
    internal class Designer
    {
        private static Designer instance;

        private Designer()
        { }

        public static Designer getInstance()
        {
            if (instance == null)
                instance = new Designer();
            return instance;
        }
        /// <summary>
        /// включает кнопки выбора стороны
        /// </summary>
        /// <param name="cross"></param>
        /// <param name="zero"></param>
        public  void chooseButtonsOn(RadioButton cross, RadioButton zero)
        {
            cross.Enabled = true;
            zero.Enabled = true;
        }
        /// <summary>
        /// отключает кнопки выбора стороны
        /// </summary>
        /// <param name="cross"></param>
        /// <param name="zero"></param>
        public  void chooseButtonsOff(RadioButton cross, RadioButton zero)
        {
            cross.Enabled = false;
            zero.Enabled = false;
        }
        /// <summary>
        /// Устанавливает на кнопку картинку
        /// </summary>
        /// <param name="button"></param>
        /// <param name="image"></param>
        public  void setButtonImg(Button button, Image image)
        { 
            button.BackgroundImage = image;
        }
        /// <summary>
        /// Отключает поля, на которые уже сходили
        /// </summary>
        /// <param name="button"></param>
        public  void setButtonEnabled(Button button)
        { 
            button.Enabled = false;
        }
        /// <summary>
        /// В поле действий уведомляет о том, что ход противника
        /// </summary>
        /// <param name="label"></param>
        public  void enemyStep(Label label1)
        {
            label1.Text = "Ход оппонента";
        }
        /// <summary>
        /// В поле действий уведомляет о том, что ход игрока
        /// </summary>
        /// <param name="label"></param>
        public void yourStep(Label label1)
        {
            label1.Text = "Ваш ход";
        }
        /// <summary>
        /// Включает кнопку играть снова
        /// </summary>
        /// <param name="play"></param>
        /// <param name="play_again"></param>
        public void PlayAgain(Button play, Button play_again)
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
        public void ChooseSide(Label label)
        {
            label.Text = "Выберити сторону";
        }

        /// <summary>
        /// Включает кнопку играть и выключает кнопку играть ещё раз
        /// </summary>
        /// <param name="play"></param>
        /// <param name="play_again"></param>
        public void Play(Button play, Button play_again)
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
        public void RadioButtonsClear(RadioButton cross, RadioButton zero)
        {
            cross.Checked = false;
            zero.Checked = false;
        }

        /// <summary>
        /// Устанавливает подсказку играть в поле действий
        /// </summary>
        /// <param name="label"></param>
        public void StartToPlay(Label label)
        {
            label.Text = "Нажмите играть, чтобы начать";
        }
        /// <summary>
        /// Устанавливает победу в поле действий
        /// </summary>
        /// <param name="label"></param>
        public void YouWin(Label label)
        {
            label.Text = "Победа! Победа - вместо обеда!";
        }

        /// <summary>
        /// устнавливает поражение в поле действий
        /// </summary>
        /// <param name="label"></param>
        public void YouLose(Label label)
        {
            label.Text = "Бро, тебе нужно тренироваться!";
        }
        /// <summary>
        /// Устанавливает ничью в поле действий
        /// </summary>
        /// <param name="label"></param>
        public void Draw(Label label)
        {
            label.Text = "Ничья, давай переиграем!";
        }
        
        /// <summary>
        /// устанавливает стандартный стиль
        /// </summary>
        /// <param name="main"></param>
        public void StandartStyle(MainWindow main, Panel GamePanel, Panel AboutPanel)
        {
            main.BackColor = Color.WhiteSmoke;
            GamePanel.BackColor = Color.WhiteSmoke;
            AboutPanel.BackColor = Color.WhiteSmoke;
            main.ForeColor = Color.Black;
        }
        /// <summary>
        /// устанавливает темный стиль
        /// </summary>
        /// <param name="main"></param>
        public void DarkStyle(MainWindow main, Panel GamePanel, Panel AboutPanel)
        {
            main.BackColor = Color.DarkSlateGray;
            GamePanel.BackColor = Color.DarkSlateGray;
            AboutPanel.BackColor = Color.DarkSlateGray;
            main.ForeColor= Color.LightPink;
        }

        /// <summary>
        /// устанавливает другой стиль
        /// </summary>
        /// <param name="main"></param>
        public void AnotherStyle(MainWindow main, Panel GamePanel, Panel AboutPanel)
        {
            main.BackColor = SystemColors.Window;
            GamePanel.BackColor = SystemColors.Window;
            AboutPanel.BackColor = SystemColors.Window;
            main.ForeColor = Color.Black;
        }

        /// <summary>
        /// устанавлиает значение кнопки играть, на игра идет
        /// </summary>
        /// <param name="btn"></param>
        public void GameOn(Button btn)
        {
            btn.Text = "Игра идет";
        }

        /// <summary>
        /// Возвращает текст играть
        /// </summary>
        /// <param name="btn"></param>
        public void ToPlay(Button btn)
        {
            btn.Text = "Играть";
        }

        /// <summary>
        /// устанавливает в статистику сохраненные параметры
        /// </summary>
        /// <param name="easy"></param>
        /// <param name="medium"></param>
        /// <param name="hard"></param>
        public void Stats(Label easywin, Label mediumwin, Label hardwin, Label easylose, Label mediumlose, Label hardlose)
        {
            easywin.Text = Settings.Default.EasyWin.ToString();
            mediumwin.Text = Settings.Default.MediumWin.ToString();
            hardwin.Text = Settings.Default.HardWin.ToString();

            easylose.Text = Settings.Default.EasyLose.ToString();
            mediumlose.Text = Settings.Default.MediumLose.ToString();
            hardlose.Text = Settings.Default.HardLose.ToString();
        }
    }
}
