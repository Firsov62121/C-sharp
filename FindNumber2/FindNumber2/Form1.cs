using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindNumber2
{
    public partial class Form1 : Form
    {
        private MainLogic game;
        public Form1()
        {
            InitializeComponent();

            newGame();
            infoPannel.Text = "";
        }

        private int ButtonClicked(int n)
        {
            int res = game.checkNum(n);
            switch(res){
                case MainLogic.FAIL:
                    infoPannel.Text = "Вы проиграли! Началась новая игра!";
                    inputNumberBox.Text = "";
                    newGame();
                    return 1;
                case MainLogic.EQUAL:
                    newGame();
                    infoPannel.Text = "Вы Выиграли! Началась новая игра!";
                    return 1;
                case MainLogic.LESS:
                    infoPannel.Text = "Ваше число меньше загаданного!";
                    PrevInformation.Text += "\n" + n + " меньше загаданного числа;";
                    break;
                case MainLogic.MORE:
                    infoPannel.Text = "Ваше число больше загаданного!";
                    PrevInformation.Text += "\n" + n + " больше загаданного числа;";
                    break;
                case MainLogic.OUT_OF_RANGE:
                    infoPannel.Text = "Ваше число не входит в указанный диапозон!";
                    break;
                case MainLogic.REPEAT_OF_NUMBER:
                    infoPannel.Text = "Вы уже вводили это число, оно не совпадает с загаданным!";
                    break;
                case MainLogic.BAD_ANSWER:
                    infoPannel.Text = "Проанализируйте ещё раз информацию о прошлых попытках.";
                    break;
            }
            countOfHealth.Text = String.Format("{0}", game.TryingCount);
            prevNumbers.Text = game.getPrevNumbers();
            return 1;
        }

        private void buttonReload_Click(object sender, EventArgs e)
        {
            infoPannel.Text = "Началась новая игра!";
            newGame();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int n = int.Parse(inputNumberBox.Text);
                if(n > 9 || n < 0)
                    infoPannel.Text = "Вы ввели число не из диапозона от 0 до 9."; 
                else
                    ButtonClicked(n);
            }catch(Exception)
            {
                infoPannel.Text = "Вы ввели некорректные данные!";
            }
            inputNumberBox.Text = "";
        }

        private void newGame()
        {
            inputNumberBox.Text = "";
            PrevInformation.Text = "Информация о прошлых попытках: ";
            game = new MainLogic();
            countOfHealth.Text = String.Format("{0}", game.TryingCount);
            prevNumbers.Text = game.getPrevNumbers();
        }
    }
}
