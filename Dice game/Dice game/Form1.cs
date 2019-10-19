using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dice_game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdStart_Click(object sender, EventArgs e)
        {
            Random r = new Random();

            int t = new int();

            t = r.Next(0, 6);

            if (t == 0)
                Diceshow1.Image = Dice1.Image;
            else if (t == 1)
                Diceshow1.Image = Dice2.Image;
            else if (t == 2)
                Diceshow1.Image = Dice3.Image;
            else if (t == 3)
                Diceshow1.Image = Dice4.Image;
            else if (t == 4)
                Diceshow1.Image = Dice5.Image;
            else
                Diceshow1.Image = Dice6.Image;

            t = r.Next(0, 6);

            if (t == 0)
                Diceshow2.Image = Dice1.Image;
            else if (t == 1)
                Diceshow2.Image = Dice2.Image;
            else if (t == 2)
                Diceshow2.Image = Dice3.Image;
            else if (t == 3)
                Diceshow2.Image = Dice4.Image;
            else if (t == 4)
                Diceshow2.Image = Dice5.Image;
            else
                Diceshow2.Image = Dice6.Image;


        }

        private void CmdExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
