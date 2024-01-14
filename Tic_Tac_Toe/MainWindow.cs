using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tic_Tac_Toe.Properties;

namespace Tic_Tac_Toe
{
    public partial class MainWindow : Form
    {
        Player player; //игрок
        Enemy enemy; //комп
        bool isPlaying = false; // идет ли игра?
        Button[,] buttons = new Button[3,3]; //игровое поле
        bool isAgain = false;
        Difficulty difficulty = Difficulty.easy ;
        enum Difficulty { easy = 1, medium, hard};
        enum Style { Standart = 0, Dark, Another};
        Designer designer = Designer.getInstance();
        public MainWindow()
        {
            InitializeComponent();
            buttons.SetValue(Btn_0_0, 0, 0);
            buttons.SetValue(Btn_0_1, 0, 1);
            buttons.SetValue(Btn_0_2, 0, 2);
            buttons.SetValue(Btn_1_0, 1, 0);
            buttons.SetValue(Btn_1_1, 1, 1);
            buttons.SetValue(Btn_1_2, 1, 2);
            buttons.SetValue(Btn_2_0, 2, 0);
            buttons.SetValue(Btn_2_1, 2, 1);
            buttons.SetValue(Btn_2_2, 2, 2);

            player = new Player(Action_Label, buttons);
            enemy = new Enemy(Action_Label, buttons);
            //устанавливаем сохраненные стили
            switch (Properties.Settings.Default.Style)
            {
                case (int)Style.Standart:
                    designer.StandartStyle(this, GamePanel, AboutPanel);
                    break;
                case (int)Style.Dark:
                    designer.DarkStyle(this, GamePanel, AboutPanel);
                    break;
                case (int)Style.Another:
                    designer.AnotherStyle(this, GamePanel, AboutPanel);
                    break;
                default:
                    break;
            }
            //заполняем статистику
            designer.Stats(EasyWinCount, MediumWinCount, HardWinCount, EasyLoseCount, MediumLoseCount, HardLoseCount);
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            // получаем имя кнопки отправителя
            string btnName = sender.GetType().GetProperty("Name").GetValue(sender).ToString();
            int x = btnName[4] - '0'; //просто мем какой-то
            int y = btnName[6] - '0'; // и майкрософт даже не хотят исправлять этот колхоз?
            //если игра не началась то код не выполняется
            if (isPlaying)
            {
                //блокаем кнопки, что бы за раз не прокликаклось
                // не работает, вероятно из за очереди встроенное в винду
                isPlaying = false;
                int[] arr = { x, y };
                //ход игрока
                //играет игрок, если выиграл то предлагаем сыграть ещё раз
                char playerchose = player.play(arr, (Button)sender);
                if (playerchose == player.getSide())
                {
                    designer.PlayAgain(Play_Btn, PlayAgain_Btn);
                    designer.YouWin(Action_Label);
                    switch((int)difficulty)
                    {
                        case 1:
                            int newwin = Settings.Default.EasyWin;
                            newwin++;
                            EasyWinCount.Text = newwin.ToString();
                            Settings.Default.EasyWin = newwin;
                            break;
                        case 2:
                            newwin = Settings.Default.MediumWin;
                            newwin++;
                            MediumWinCount.Text = newwin.ToString();
                            Settings.Default.MediumWin = newwin;
                            break;
                        case 3:
                            newwin = Settings.Default.HardWin;
                            newwin++;
                            HardWinCount.Text = newwin.ToString();
                            Settings.Default.HardWin = newwin;
                            break;
                        default:
                            break;
                    }
                    Settings.Default.Save();
                    return;
                }
                //проверка на ничью
                if (playerchose == '-')
                {
                    designer.PlayAgain(Play_Btn, PlayAgain_Btn);
                    designer.Draw(Action_Label);
                    return;
                }
                //показываем что ход компьюетар
                designer.enemyStep(Action_Label);
                //включаем таймер
                timer.Start();
                //должен быть тик
                //по тику другой код выполняется
                //разлочим кнопки
                isPlaying = true;
            }
        }
        private void About_Btn_Click(object sender, EventArgs e)
        {
            //открывает окно с описанием игры
            GamePanel.Visible = false;
            AboutPanel.Visible = true;
            //отключаем кнопки выбора стороны
            designer.chooseButtonsOff(Cross_Choose_Btn, Zero_Choose_Btn);
        }

        private void Back_Btn_Click(object sender, EventArgs e)
        {
            //возвращает в окно с игрой
            GamePanel.Visible = true;
            AboutPanel.Visible = false;
            //включает кнопки выбора стороны, если игра ещё не была начата
            if (!isPlaying)
            {
                designer.chooseButtonsOn(Cross_Choose_Btn, Zero_Choose_Btn);
            }
        }

        private void Cross_Choose_Btn_CheckedChanged(object sender, EventArgs e)
        {
            //устанавливает сторону игрока как крестик
            if (!isAgain) //проверка на то, что выбор первый раз, не во время повторной игры
            {
                designer.StartToPlay(Action_Label);
                player.setSide((char)Template.CoordEnum.Cross);
                enemy.setSide((char)Template.CoordEnum.Zero);
            }
        }

        private void Zero_Choose_Btn_CheckedChanged(object sender, EventArgs e)
        {
            //устанавливает сторону игрока как нолик
            if (!isAgain)
            {
                //просим дизайнера показать что мы выбрали сторону и готовы к игре
                designer.StartToPlay(Action_Label);
                //устанавливаем выбранную сторону в класс игрока
                player.setSide((char)Template.CoordEnum.Zero);
                //устанавливаем противопложную сторону в класс противника
                enemy.setSide((char)Template.CoordEnum.Cross);
            }
        }

        private void Play_Btn_Click(object sender, EventArgs e)
        {
            // проверка на выбранную сторону
            if (player.getSide() == (char)Template.CoordEnum.Defolt) 
            {
                MessageBox.Show("Вы не выбрали чем будете играть");
                return;
            }
            // высвечивает "ваш ход"
            designer.yourStep(Action_Label);
            //меняем текст кнопки
            designer.GameOn((Button)sender);
            // игра началась
            isPlaying = true;
            // переключает на окно с игровым полем
            GamePanel.Visible = true;
            AboutPanel.Visible = false;
            StatPanel.Visible = false;
            // отключает кнопки выбора стороны
            designer.chooseButtonsOff(Cross_Choose_Btn, Zero_Choose_Btn);
        }

        private void PlayAgain_Btn_Click(object sender, EventArgs e)
        {
            //очищаем у игрока и у компа поля
            player.clear();
            enemy.clear();
            //очищаем кнопочки
            Designer.clear(buttons);
            //можно выбрать сторону
            designer.chooseButtonsOn(Cross_Choose_Btn, Zero_Choose_Btn);
            //поле действий подсказывает, что нужно выбрать сторону
            designer.ChooseSide(Action_Label);
            //кнопки играть снова появилась
            designer.Play(Play_Btn, PlayAgain_Btn);
            //возвращаем текст кнопке играть
            designer.ToPlay(Play_Btn);
            //очищаем выбор стороны
            isAgain = true;
            designer.RadioButtonsClear(Cross_Choose_Btn, Zero_Choose_Btn);
            isAgain = false;
        }

        //легкий режим
        private void EasyDifficult_Btn_CheckedChanged(object sender, EventArgs e)
        {
            difficulty = Difficulty.easy;
        }

        //средний режим
        private void MediumDifficult_Btn_CheckedChanged(object sender, EventArgs e)
        {
            difficulty = Difficulty.medium;
        }

        //сложный режим
        private void HardDifficultBtn_CheckedChanged(object sender, EventArgs e)
        {
            difficulty = Difficulty.hard;
        }

        //открывает окно редактирования стиля
        private void StyleBtn_Click(object sender, EventArgs e)
        {
            StyleWindow styleWindow = new StyleWindow(this, GamePanel, AboutPanel);
            styleWindow.Show();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            //ходит комп
            char enemychoise = enemy.play((int)difficulty); 
            if (enemychoise == enemy.getSide())                  //если комп собрал 3 в ряд
            {
                designer.PlayAgain(Play_Btn, PlayAgain_Btn);     //предлагаем сыграть ещё раз
                designer.YouLose(Action_Label);                  //сообщаем о проигрыше
                switch ((int)difficulty)
                {
                    case 1:
                        int newwin = Settings.Default.EasyLose;
                        newwin++;
                        EasyLoseCount.Text = newwin.ToString();
                        Settings.Default.EasyLose = newwin;
                        break;
                    case 2:
                        newwin = Settings.Default.MediumLose;
                        newwin++;
                        MediumLoseCount.Text = newwin.ToString();
                        Settings.Default.MediumLose = newwin;
                        break;
                    case 3:
                        newwin = Settings.Default.HardLose;
                        newwin++;
                        HardLoseCount.Text = newwin.ToString();
                        Settings.Default.HardLose = newwin;
                        break;
                    default:
                        break;
                }
                return;
            }
            designer.yourStep(Action_Label);                     //высвечиваем твой ход
            //проверка на ничью
            if (enemychoise == '-')              
            {
                designer.PlayAgain(Play_Btn, PlayAgain_Btn);    //предлагаем сыграть ещё раз
                designer.Draw(Action_Label);                    //сообщаем о ничье
                return;
            }
        }

        private void BackStat_Btn_Click(object sender, EventArgs e)
        {
            GamePanel.Visible = true;
            StatPanel.Visible = false;
            AboutPanel.Visible = false;
        }

        private void Stat_Btn_Click(object sender, EventArgs e)
        {
            GamePanel.Visible = false;
            StatPanel.Visible = true;
            AboutPanel.Visible = false;
        }
    }
}
