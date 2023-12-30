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
        bool isDarkTheme = false;
        bool isAgain = false;
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
        }


        private void Btn_Click(object sender, EventArgs e)
        {
            // получаем имя кнопки отправителя
            string btnName = sender.GetType().GetProperty("Name").GetValue(sender).ToString();
            int x = btnName[4] - '0'; //просто мем какой-то
            int y =btnName[6] - '0'; // и майкрософт даже не хотят исправлять этот колхоз?
            //если игра не началась то код не выполняется
            if (isPlaying)
            {
                //блокаем кнопки, что бы за раз не прокликаклось
                // не работает, вероятно из за очереди встроенное в винду
                isPlaying = false;
                int[] arr = { x, y };
                //играет игрок, если выиграл то предлагаем сыграть ещё раз
                char playerchose = player.play(arr, (Button)sender);
                if (playerchose == player.getSide())
                {
                    Designer.PlayAgain(Play_Btn, PlayAgain_Btn);
                    Designer.YouWin(Action_Label);
                    return;
                }
                //проверка на ничью
                if (playerchose == '-')
                {
                    Designer.PlayAgain(Play_Btn, PlayAgain_Btn);
                    Designer.Draw(Action_Label);
                    return;
                }
                //типо комп думает
                Designer.enemyStep(Action_Label);
                Thread.Sleep(1000);
                //ходит комп
                char enemychoise = enemy.play(arr, (Button)sender);
                if (enemychoise == enemy.getSide())
                {
                    Designer.PlayAgain(Play_Btn, PlayAgain_Btn);
                    Designer.YouLose(Action_Label);
                    return;
                }
                Designer.yourStep(Action_Label);
                //проверка на ничью
                if (enemychoise == '-')
                {
                    Designer.PlayAgain(Play_Btn, PlayAgain_Btn);
                    Designer.Draw(Action_Label);
                    return;
                }
                //разлочим кнопки
                isPlaying = true;
            }
        }


        private void About_Btn_Click(object sender, EventArgs e)
        {
            //открывает окно с описанием игры
            Game_Controle.SelectTab(1);
            //отключаем кнопки выбора стороны
            Designer.chooseButtonsOff(Cross_Choose_Btn, Zero_Choose_Btn);
        }

        private void Back_Btn_Click(object sender, EventArgs e)
        {
            //возвращает в окно с игрой
            Game_Controle.SelectTab(0);
            //включает кнопки выбора стороны, если игра ещё не была начата
            if (!isPlaying)
            {
                Designer.chooseButtonsOn(Cross_Choose_Btn, Zero_Choose_Btn);
            }
        }

        private void Cross_Choose_Btn_CheckedChanged(object sender, EventArgs e)
        {
            //устанавливает сторону игрока как крестик
            if (!isAgain) //проверка на то, что выбор первый раз, не во время повторной игры
            {
                Designer.StartToPlay(Action_Label);
                player.setSide((char)Template.CoordEnum.Cross);
                enemy.setSide((char)Template.CoordEnum.Zero);
            }
        }

        private void Zero_Choose_Btn_CheckedChanged(object sender, EventArgs e)
        {
            //устанавливает сторону игрока как нолик
            if (!isAgain)
            {
                Designer.StartToPlay(Action_Label);
                player.setSide((char)Template.CoordEnum.Zero);
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
            Designer.yourStep(Action_Label);
            // игра началась
            isPlaying = true;
            // переключает на окно с игровым полем
            Game_Controle.SelectTab(0);
            // отключает кнопки выбора стороны
            Designer.chooseButtonsOff(Cross_Choose_Btn, Zero_Choose_Btn);
        }

        private void PlayAgain_Btn_Click(object sender, EventArgs e)
        {
            //очищаем у игрока и у компа поля
            player.clear();
            enemy.clear();
            //очищаем кнопочки
            Designer.clear(buttons);
            //можно выбрать сторону
            Designer.chooseButtonsOn(Cross_Choose_Btn, Zero_Choose_Btn);
            //поле действий подсказывает, что нужно выбрать сторону
            Designer.ChooseSide(Action_Label);
            //кнопки играть снова появилась
            Designer.Play(Play_Btn, PlayAgain_Btn);
            //очищаем выбор стороны
            isAgain = true;
            Designer.RadioButtonsClear(Cross_Choose_Btn, Zero_Choose_Btn);
            isAgain = false;
        }

    }
}
