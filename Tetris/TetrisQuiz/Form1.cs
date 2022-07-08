using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TetrisQuiz
{
    public partial class Form1 : Form
    {
        Button[,] buttons;
        public static Color[] myColors = new Color[]
        {
            Color.White,
            Color.Gray,
            Color.AliceBlue,
            Color.AntiqueWhite,
            Color.Yellow,
            Color.Orange,
            Color.LightBlue,
            Color.Brown,
            Color.Purple,
            Color.Coral
        };
        bool[,] field;
        int[,] field2;
        bool isStart = true;
        bool finished = false;
        int countOfFigures = 0;
        List<Pair[]> figures = new List<Pair[]>();
        public static int n = 7;

        public Form1()
        {
            InitializeComponent();
            buttons = new Button[n , n];
            field = new bool[n, n];
            infoLabel.Text = $"Input field.";
            for (int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    field[i, j] = true;
                    int i1 = i, j1 = j;
                    buttons[i, j] = new Button();
                    buttons[i, j].Margin = new Padding(0);
                    buttons[i, j].FlatAppearance.BorderSize = 0;
                    buttons[i, j].Click += (sender, e) => ChangeButton(i1, j1);
                    buttons[i, j].BackColor = Color.LightGreen;
                    buttons[i, j].Size = new Size(60, 60);
                    tableLayoutPanel1.Controls.Add(buttons[i, j], i, j);
                }
            }
        }

        private void ChangeButton(int i, int j)
        {
            if (!finished)
            {
                field[i, j] = !field[i, j];
                if (field[i, j])
                    buttons[i, j].BackColor = Color.LightGreen;
                else
                    buttons[i, j].BackColor = Color.Blue;
            }
        }

        private void finishClicked(object sender, EventArgs e)
        {
            finished = true;
            bool res = FieldCalculator.CanPave(field2, figures);
            if (res)
            {
                ClearField();
                for(int i = 0; i < n; i++)
                {
                    for(int j = 0; j < n; j++)
                    {
                        if (field2[i, j] == -1)
                            buttons[i, j].BackColor = Color.Blue;
                        else
                            buttons[i, j].BackColor = myColors[(field2[i, j] + 2) % myColors.Length];
                    }
                }
            }
            else
            {
                infoLabel.Text = "No solutions.";
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (field2[i, j] == -1)
                            buttons[i, j].BackColor = Color.Blue;
                        else
                            buttons[i, j].BackColor = myColors[field2[i, j] + 2 % myColors.Length];
                    }
                }
            }
        }

        private void OkClicked(object sender, EventArgs e)
        {
            if (!finished)
            {
                if (isStart)
                {
                    field2 = new int[n, n];
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            field2[i, j] = field[i, j] ? 0 : -1;
                        }
                    }
                    isStart = false;
                    infoLabel.Text = $"Input figure #{countOfFigures + 1}.";
                    ClearField();
                }
                else
                {
                    var tmp = FieldCalculator.FindFigures(field);
                    figures.AddRange(tmp);
                    countOfFigures++;
                    infoLabel.Text = $"Input figure #{countOfFigures + 1}.";
                    ClearField();
                }
            }
        }

        private void ClearField()
        {
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    buttons[i, j].BackColor = Color.Blue;
                }
            }
            field = new bool[n, n];
        }

        private void NewGameClicked(object sender, EventArgs e)
        {
            field = new bool[n, n];
            infoLabel.Text = $"Input field.";
            isStart = true;
            finished = false;
            countOfFigures = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    field[i, j] = true;
                    int i1 = i, j1 = j;
                    buttons[i, j].BackColor = Color.LightGreen;
                }
            }
        }
    }
}
