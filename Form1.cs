using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_da_Velha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int jogador = 0;

        private void sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void opcaoA1_CheckedChanged(object sender, EventArgs e)
        {
            if(jogador%2 == 0)
            {
                a1.Text = "X";
            }
            else
            {
                a1.Text = "O";
            }
            verificarVencedor();
            jogador++;
        }

        private void opcaoA2_CheckedChanged(object sender, EventArgs e)
        {
            if (jogador%2 == 0)
            {
                a2.Text = "X";
            }
            else
            {
                a2.Text = "O";
            }
            verificarVencedor();
            jogador++;
        }

        private void opcaoA3_CheckedChanged(object sender, EventArgs e)
        {
            if (jogador % 2 == 0)
            {
                a3.Text = "X";
            }
            else
            {
                a3.Text = "O";
            }
            verificarVencedor();
            jogador++;
        }

        private void opcaoB1_CheckedChanged(object sender, EventArgs e)
        {
            if (jogador % 2 == 0)
            {
                b1.Text = "X";
            }
            else
            {
                b1.Text = "O";
            }
            verificarVencedor();
            jogador++;
        }

        private void opcaoB2_CheckedChanged(object sender, EventArgs e)
        {
            if (jogador % 2 == 0)
            {
                b2.Text = "X";
            }
            else
            {
                b2.Text = "O";
            }
            verificarVencedor();
            jogador++;
        }

        private void opcaoB3_CheckedChanged(object sender, EventArgs e)
        {
            if (jogador % 2 == 0)
            {
                b3.Text = "X";
            }
            else
            {
                b3.Text = "O";
            }
            verificarVencedor();
            jogador++;
        }

        private void opcaoC1_CheckedChanged(object sender, EventArgs e)
        {
            if (jogador % 2 == 0)
            {
                c1.Text = "X";
            }
            else
            {
                c1.Text = "O";
            }
            verificarVencedor();
            jogador++;
        }

        private void opcaoC2_CheckedChanged(object sender, EventArgs e)
        {
            if (jogador % 2 == 0)
            {
                c2.Text = "X";
            }
            else
            {
                c2.Text = "O";
            }
            verificarVencedor();
            jogador++;
        }

        private void opcaoC3_CheckedChanged(object sender, EventArgs e)
        {
            if (jogador % 2 == 0)
            {
                c3.Text = "X";
            }
            else
            {
                c3.Text = "O";
            }
            verificarVencedor();
            jogador++;
        }
        public void verificarVencedor()
        {
            if ((a1.Text == "X" && a2.Text == "X" && a3.Text == "X") || (b1.Text == "X" && b2.Text == "X" && b3.Text == "X") || (c1.Text == "X" && c2.Text == "X" && c3.Text == "X") || (a1.Text == "X" && b2.Text == "X" && c3.Text == "X") || (a3.Text == "X" && b2.Text == "X" && c1.Text == "X") || (a1.Text == "X" && b1.Text == "X" && c1.Text == "X") || (a2.Text == "X" && b2.Text == "X" && c2.Text == "X") || (a3.Text == "X" && b3.Text == "X" && c3.Text == "X"))
            {
                resultado.Text = "Jogador 1 Venceu!";
            }
            else if ((a1.Text == "O" && a2.Text == "O" && a3.Text == "O") || (b1.Text == "O" && b2.Text == "O" && b3.Text == "O") || (c1.Text == "O" && c2.Text == "O" && c3.Text == "O") || (a1.Text == "O" && b2.Text == "O" && c3.Text == "O") || (a3.Text == "O" && b2.Text == "O" && c1.Text == "O") || (a1.Text == "O" && b1.Text == "O" && c1.Text == "O") || (a2.Text == "O" && b2.Text == "O" && c2.Text == "O") || (a3.Text == "O" && b3.Text == "O" && c3.Text == "O"))
            {
                resultado.Text = "Jogador 2 Venceu!";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            jogador = -1;

            opcaoA1.Checked = false;
            a1.Text = null;
            opcaoA2.Checked = false;
            a2.Text = null;
            opcaoA3.Checked = false;
            a3.Text = null;

            opcaoB1.Checked = false;
            b1.Text = null;
            opcaoB2.Checked = false;
            b2.Text = null;
            opcaoB3.Checked = false;
            b3.Text = null;

            opcaoC1.Checked = false;
            c1.Text = null;
            opcaoC2.Checked = false;
            c2.Text = null;
            opcaoC3.Checked = false;
            c3.Text = null;

            resultado.Text = "";
        }
    }
}
