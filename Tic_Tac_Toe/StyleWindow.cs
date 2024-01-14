using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class StyleWindow : Form
    {
        MainWindow main;
        Panel game;
        Panel about;
        enum Style { Standart = 0, Dark, Another };
        Designer designer;
        public StyleWindow(MainWindow main, Panel GamePanel, Panel AboutPanel)
        {
            InitializeComponent();
            this.main = main;
            this.game = GamePanel;
            this.about = AboutPanel;
            designer = Designer.getInstance();
        }

        //установка стандартного стиля
        private void StandartStyleBtn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Style = (int)Style.Standart;
            Properties.Settings.Default.Save();
            designer.StandartStyle(main, game, about);
        }

        //установка темного стиля
        private void DarkStyleBtn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Style = (int)Style.Dark;
            Properties.Settings.Default.Save();
            designer.DarkStyle(main, game, about);
        }

        //установка другого стиля
        private void AnotherStyleBtn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Style = (int)Style.Another;
            Properties.Settings.Default.Save();
            designer.AnotherStyle(main, game, about);
        }
    }
}
