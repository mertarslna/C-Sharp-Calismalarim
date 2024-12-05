﻿using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecapDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            GenerateButtons();
        }
        public void GenerateButtons()
        {
            Button[,] buttons = new Button[8, 8]; //Button[] buton = new Button[64
            //buton.Width = 50;
            //buton.Height = 50;
            //buton.Text = "Button 1";
            //this.Controls.Add(buton);
            int top = 0, left = 0;
            for (int i = 0; i < buttons.GetUpperBound(0); i++)
            {
                for (int j = 0; j < buttons.GetUpperBound(1); j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Width = 50;
                    buttons[i, j].Height = 50;
                    buttons[i, j].Left = left;
                    buttons[i, j].Top = top

                        ;
                    if ((i + j) % 2 == 0)
                        buttons[i, j].BackColor = Color.Black;
                    else
                        buttons[i, j].BackColor = Color.White;
                    left += 50;
                    this.Controls.Add(buttons[i, j]); // this form'a karşılık gelir
                }
                left = 0;
                top += 50;
            }
        }
    }
}
