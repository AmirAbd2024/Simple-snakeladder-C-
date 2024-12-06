using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace SnakeAndLadder
{
    public partial class Form1 : Form
    {
        byte player1LOC = 1, player2LOC = 1;
        bool IsPlayer1 = true;
        char[] mapType;
        byte[] mapDes;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            configMapArray();
            configGraph();
            IsPlayer1 = false;
            graphLocation(1, true);
            IsPlayer1 = true;
            graphLocation(1, true);
        }


        void graphLocation(byte number, bool IsDirectDest)
        {
            byte tmpLocVal = 1;
            ChanceBTN.Enabled = false; 

            if (!IsDirectDest)
            {
                if (IsPlayer1) { player1LOC += number; tmpLocVal = player1LOC; }
                else { player2LOC += number; tmpLocVal = player2LOC; }
            }
            else
            {
                if (IsPlayer1) { player1LOC = number; tmpLocVal = player1LOC; }
                else { player2LOC = number; tmpLocVal = player2LOC; }
            }


            int locY = (tmpLocVal % 10 != 0) ? panel1.Height - ((tmpLocVal / 10) * (panel1.Height / 10)) - (panel1.Height / 10 * 3 / 4) : panel1.Height - (((tmpLocVal / 10) - 1) * (panel1.Height / 10)) - (panel1.Height / 10 * 3 / 4);
            int locX = (tmpLocVal % 10 != 0) ? (((tmpLocVal % 10) - 1) * (panel1.Width / 10)) + ((panel1.Width / 10) / 3) : panel1.Width - ((panel1.Width / 10) * 3 / 4);


            if (tmpLocVal > 100 && IsPlayer1) { MessageBox.Show("Dice value is over 100 for player 1"); player1LOC -= number; ChanceBTN.Enabled = true; }
            else if (tmpLocVal > 100 && !IsPlayer1) { MessageBox.Show("Dice value is over 100 for player 2"); player2LOC -= number; ChanceBTN.Enabled = true; }
            else if (tmpLocVal == 100 && IsPlayer1) { playing1.Location = new Point(locX, locY); MessageBox.Show("Player 1 is winner"); ChanceBTN.Enabled = false; }
            else if (tmpLocVal == 100 && !IsPlayer1) { playing2.Location = new Point(locX, locY); MessageBox.Show("Player 2 is winner"); ChanceBTN.Enabled = false; }
            else
            {

                if (IsPlayer1) { playing1.Location = new Point(locX, locY); label1.Text = "Player 1 :  " + player1LOC; ChanceBTN.Enabled = true; }
                else { playing2.Location = new Point(locX, locY); label1.Text = "Player 2 :  " + player2LOC; ChanceBTN.Enabled = true; }

                for (int i = 0; i < 101; i++)
                {
                    if (mapType[tmpLocVal] != 'e') { ChanceBTN.Enabled = false; MessageBox.Show(((mapType[tmpLocVal] == 's') ? "Snake to  " : "Jump to  ") + mapDes[tmpLocVal]); graphLocation(mapDes[tmpLocVal], true); break; }
                }
            }
        }


        void check4SameCell()
        {
            if (player1LOC == player2LOC)
            {
                MessageBox.Show((IsPlayer1) ? "Player 1 sent player 2 to start point." : "Player 2 sent player 1 to start point.");
                IsPlayer1 = !IsPlayer1;
                graphLocation(1, true);
                IsPlayer1 = !IsPlayer1;
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            byte CHVAL = Convert.ToByte(rnd.Next(1, 7));
            label2.Text = CHVAL.ToString();
            graphLocation(CHVAL, false);
            check4SameCell();
            IsPlayer1 = !IsPlayer1;
        }

        void configMapArray()
        {
            int mapLen = 101;
            mapType = new char[mapLen];
            mapDes = new byte[mapLen];
            for (int i = 0; i < mapLen; i++) { mapType[i] = 'e'; }
            mapType[3] = 'l'; mapType[6] = 'l'; mapType[20] = 'l'; mapType[36] = 'l'; mapType[63] = 'l'; mapType[68] = 'l';
            mapDes[3] = 51; mapDes[6] = 27; mapDes[20] = 70; mapDes[36] = 55; mapDes[63] = 95; mapDes[68] = 98;
            mapType[25] = 's'; mapType[34] = 's'; mapType[47] = 's'; mapType[65] = 's'; mapType[87] = 's'; mapType[91] = 's'; mapType[99] = 's';
            mapDes[25] = 5; mapDes[34] = 1; mapDes[47] = 19; mapDes[65] = 52; mapDes[87] = 57; mapDes[91] = 61; mapDes[99] = 69;
        }

        void configGraph()
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(0, 0, playing1.Width, playing1.Height);
            playing1.Region = new Region(gp);
            playing2.Region = new Region(gp);
        }

       

    }
}
