using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace JogoMemo
{
    public partial class Form1 : Form
    {
        Vetor ObjImagens = new Vetor(12);

        int acertos = 0;
        int cliques = 0;
        
        string[] par = new string[2];
        int[] botoes = new int[2];

        string pasta = @"C:\Users\Ana\Desktop\JogoMemo\Resources\";

        string[] nomeImagens = {"assustado.png", "feliz.png", "medo.png", "nerd.png", "rindo.png", "tedio.png"};    
        public Form1()
        {
            InitializeComponent();
            startGame(false);

        }


        public void isWinner()
        {
            if (acertos == 6)
            {
                var resultado = MessageBox.Show("Você ganhou!!! Deseja recomeçar?", "Você ganhou!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.No) 
                {
                    MessageBox.Show("Obrigado por jogar!"); 
                    Application.Exit(); 
                }
                if (resultado == DialogResult.Yes) 
                {
                    startGame(true);
                }
            }
        }

        public bool checkPosition() 
        {
            switch(botoes[0])
            {
                case 1:
                    Application.DoEvents();
                    Thread.Sleep(400);
                    button1.BackgroundImage = JogoMemo.Properties.Resources.carta;
                    return true;
                    
                case 2:
                    Application.DoEvents();
                    Thread.Sleep(400);
                    button2.BackgroundImage = JogoMemo.Properties.Resources.carta;
                    return true;

                case 3:
                    Application.DoEvents();
                    Thread.Sleep(400);
                    button3.BackgroundImage = JogoMemo.Properties.Resources.carta;
                    return true;

                case 4:
                    Application.DoEvents();
                    Thread.Sleep(400);
                    button4.BackgroundImage = JogoMemo.Properties.Resources.carta;
                    return true;

                case 5:
                    Application.DoEvents();
                    Thread.Sleep(400);
                    button5.BackgroundImage = JogoMemo.Properties.Resources.carta;
                    return true;

                case 6:
                    Application.DoEvents();
                    Thread.Sleep(400);
                    button6.BackgroundImage = JogoMemo.Properties.Resources.carta;
                    return true;

                case 7:
                    Application.DoEvents();
                    Thread.Sleep(400);
                    button7.BackgroundImage = JogoMemo.Properties.Resources.carta;
                    return true;

                case 8:
                    Application.DoEvents();
                    Thread.Sleep(400);
                    button8.BackgroundImage = JogoMemo.Properties.Resources.carta;
                    return true;

                case 9:
                    Application.DoEvents();
                    Thread.Sleep(400);
                    button9.BackgroundImage = JogoMemo.Properties.Resources.carta;
                    return true;

                case 10:
                    Application.DoEvents();
                    Thread.Sleep(400);
                    button10.BackgroundImage = JogoMemo.Properties.Resources.carta;
                    return true;

                case 11:
                    Application.DoEvents();
                    Thread.Sleep(400);
                    button11.BackgroundImage = JogoMemo.Properties.Resources.carta;
                    return true;

                case 12:
                    Application.DoEvents();
                    Thread.Sleep(400);
                    button12.BackgroundImage = JogoMemo.Properties.Resources.carta;
                    return true;
            }
            return false;
        }

        public void startGame(bool isPlayingAgain)
        {
            if (isPlayingAgain)
            {
                ObjImagens.clearVector(11);
                acertos = 0;
                cliques = 0;
            }

            foreach (Button imagens in Controls.OfType<Button>())
            {
                imagens.BackgroundImage = Image.FromFile(pasta + "carta.jpg");
            }

            int posicao;
            int indice = 0;
            int indice2 = 0;
            for (int i = 0; i <= 11; i++)
            {
            inicio:
                posicao = ObjImagens.sortNumber(0, 12);
                if (ObjImagens.OccupiedPosition(posicao) == true)
                {
                    if (indice >= 12)
                    {

                        if (indice2 > 5)
                        {
                            indice2 = 0;
                        }
                        indice++;
                        ObjImagens.InsertData(posicao, nomeImagens[indice2]);
                        indice2++;
                        break;
                    }
                    else
                    {
                        goto inicio;
                    }
                }
                else
                {
                    indice++;
                    if (indice2 > 5)
                    {
                        indice2 = 0;
                    }
                    ObjImagens.InsertData(posicao, nomeImagens[indice2]);
                    indice2++;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cliques++;

            if (cliques == 1)
            {
                botoes[0] = 1;
                par[0] = ObjImagens.returnPosition(0);
                button1.BackgroundImage = Image.FromFile(pasta + ObjImagens.returnPosition(0));
            }
            else if (cliques == 2)
            {
                botoes[1] = 2;
                par[1] = ObjImagens.returnPosition(0);
                button1.BackgroundImage = Image.FromFile(pasta + ObjImagens.returnPosition(0));
                if (par[0] == par[1])
                {
                    acertos++;
                    isWinner();
                }
                else
                {
                    if (checkPosition())
                    {
                        Application.DoEvents();
                        button1.BackgroundImage = JogoMemo.Properties.Resources.carta;
                    }
                }
                cliques = 0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cliques++;

            if (cliques == 1)
            {
                botoes[0] = 2;
                par[0] = ObjImagens.returnPosition(1);
                button2.BackgroundImage = Image.FromFile(pasta + ObjImagens.returnPosition(1));
            }
            else if (cliques == 2)
            {
                botoes[1] = 2;
                par[1] = ObjImagens.returnPosition(1);
                button2.BackgroundImage = Image.FromFile(pasta + ObjImagens.returnPosition(1));
                if (par[0] == par[1])
                {
                    acertos++;
                    isWinner();
                }
                else
                {
                    if (checkPosition())
                    {
                        Application.DoEvents();
                        button2.BackgroundImage = JogoMemo.Properties.Resources.carta;
                    }
                }
                cliques = 0;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cliques++;

            if (cliques == 1)
            {
                botoes[0] = 3;
                par[0] = ObjImagens.returnPosition(2);
                button3.BackgroundImage = Image.FromFile(pasta + ObjImagens.returnPosition(2));
            }
            else if (cliques == 2)
            {
                botoes[1] = 3;
                par[1] = ObjImagens.returnPosition(2);
                button3.BackgroundImage = Image.FromFile(pasta + ObjImagens.returnPosition(2));
                if (par[0] == par[1])
                {
                    acertos++;
                    isWinner();
                }
                else
                {
                    if (checkPosition())
                    {
                        Application.DoEvents();
                        button3.BackgroundImage = JogoMemo.Properties.Resources.carta;
                    }
                }
                cliques = 0;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cliques++;

            if (cliques == 1)
            {
                botoes[0] = 4;
                par[0] = ObjImagens.returnPosition(3);
                button4.BackgroundImage = Image.FromFile(pasta + ObjImagens.returnPosition(3));
            }
            else if (cliques == 2)
            {
                botoes[1] = 4;
                par[1] = ObjImagens.returnPosition(3);
                button4.BackgroundImage = Image.FromFile(pasta + ObjImagens.returnPosition(3));
                if (par[0] == par[1])
                {
                    acertos++;
                    isWinner();
                }
                else
                {
                    if (checkPosition())
                    {
                        Application.DoEvents();
                        button4.BackgroundImage = JogoMemo.Properties.Resources.carta;
                    }
                }
                cliques = 0;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            cliques++;

            if (cliques == 1)
            {
                botoes[0] = 8;
                par[0] = ObjImagens.returnPosition(4);
                button8.BackgroundImage = Image.FromFile(pasta + ObjImagens.returnPosition(4));
            }
            else if (cliques == 2)
            {
                botoes[1] = 8;
                par[1] = ObjImagens.returnPosition(4);
                button8.BackgroundImage = Image.FromFile(pasta + ObjImagens.returnPosition(4));
                if (par[0] == par[1])
                {
                    acertos++;
                    isWinner();
                }
                else
                {
                    if (checkPosition())
                    {
                        Application.DoEvents();
                        button8.BackgroundImage = JogoMemo.Properties.Resources.carta;
                    }
                }
                cliques = 0;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            cliques++;

            if (cliques == 1)
            {
                botoes[0] = 7;
                par[0] = ObjImagens.returnPosition(5);
                button7.BackgroundImage = Image.FromFile(pasta + ObjImagens.returnPosition(5));
            }
            else if (cliques == 2)
            {
                botoes[1] = 7;
                par[1] = ObjImagens.returnPosition(5);
                button7.BackgroundImage = Image.FromFile(pasta + ObjImagens.returnPosition(5));
                if (par[0] == par[1])
                {
                    acertos++;
                    isWinner();
                }
                else
                {
                    if (checkPosition())
                    {
                        Application.DoEvents();
                        button7.BackgroundImage = JogoMemo.Properties.Resources.carta;
                    }
                }
                cliques = 0;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            cliques++;

            if (cliques == 1)
            {
                botoes[0] = 6;
                par[0] = ObjImagens.returnPosition(6);
                button6.BackgroundImage = Image.FromFile(pasta + ObjImagens.returnPosition(6));
            }
            else if (cliques == 2)
            {
                botoes[1] = 3;
                par[1] = ObjImagens.returnPosition(6);
                button6.BackgroundImage = Image.FromFile(pasta + ObjImagens.returnPosition(6));
                if (par[0] == par[1])
                {
                    acertos++;
                    isWinner();
                }
                else
                {
                    if (checkPosition())
                    {
                        Application.DoEvents();
                        button6.BackgroundImage = JogoMemo.Properties.Resources.carta;
                    }
                }
                cliques = 0;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cliques++;

            if (cliques == 1)
            {
                botoes[0] = 5;
                par[0] = ObjImagens.returnPosition(7);
                button5.BackgroundImage = Image.FromFile(pasta + ObjImagens.returnPosition(7));
            }
            else if (cliques == 2)
            {
                botoes[1] = 5;
                par[1] = ObjImagens.returnPosition(7);
                button5.BackgroundImage = Image.FromFile(pasta + ObjImagens.returnPosition(7));
                if (par[0] == par[1]) acertos++;
                else
                {
                    if (checkPosition())
                    {
                        Application.DoEvents();
                        button5.BackgroundImage = JogoMemo.Properties.Resources.carta;
                    }
                }
                cliques = 0;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            cliques++;

            if (cliques == 1)
            {
                botoes[0] = 12;
                par[0] = ObjImagens.returnPosition(8);
                button12.BackgroundImage = Image.FromFile(pasta + ObjImagens.returnPosition(8));
            }
            else if (cliques == 2)
            {
                botoes[1] = 12;
                par[1] = ObjImagens.returnPosition(8);
                button12.BackgroundImage = Image.FromFile(pasta + ObjImagens.returnPosition(8));
                if (par[0] == par[1])
                {
                    acertos++;
                    isWinner();
                }
                else
                {
                    if (checkPosition())
                    {
                        Application.DoEvents();
                        button12.BackgroundImage = JogoMemo.Properties.Resources.carta;
                    }
                }
                cliques = 0;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            cliques++;

            if (cliques == 1)
            {
                botoes[0] = 11;
                par[0] = ObjImagens.returnPosition(9);
                button11.BackgroundImage = Image.FromFile(pasta + ObjImagens.returnPosition(9));
            }
            else if (cliques == 2)
            {
                botoes[1] = 11;
                par[1] = ObjImagens.returnPosition(9);
                button11.BackgroundImage = Image.FromFile(pasta + ObjImagens.returnPosition(9));
                if (par[0] == par[1])
                {
                    acertos++;
                    isWinner();
                }
                else
                {
                    if (checkPosition())
                    {
                        Application.DoEvents();
                        button11.BackgroundImage = JogoMemo.Properties.Resources.carta;
                    }
                }
                cliques = 0;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            cliques++;

            if (cliques == 1)
            {
                botoes[0] = 10;
                par[0] = ObjImagens.returnPosition(10);
                button10.BackgroundImage = Image.FromFile(pasta + ObjImagens.returnPosition(10));
            }
            else if (cliques == 2)
            {
                botoes[1] = 10;
                par[1] = ObjImagens.returnPosition(10);
                button10.BackgroundImage = Image.FromFile(pasta + ObjImagens.returnPosition(10));
                if (par[0] == par[1])
                {
                    acertos++;
                    isWinner();
                }
                else
                {
                    if (checkPosition())
                    {
                        Application.DoEvents();
                        button10.BackgroundImage = JogoMemo.Properties.Resources.carta;
                    }
                }
                cliques = 0;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            cliques++;

            if (cliques == 1)
            {
                botoes[0] = 9;
                par[0] = ObjImagens.returnPosition(11);
                button9.BackgroundImage = Image.FromFile(pasta + ObjImagens.returnPosition(11));
            }
            else if (cliques == 2)
            {
                botoes[1] = 9;
                par[1] = ObjImagens.returnPosition(11);
                button9.BackgroundImage = Image.FromFile(pasta + ObjImagens.returnPosition(11));
                if (par[0] == par[1])
                {
                    acertos++;
                    isWinner();
                }
                else
                {
                    if (checkPosition())
                    {
                        Application.DoEvents();
                        button9.BackgroundImage = JogoMemo.Properties.Resources.carta;
                    }
                }
                cliques = 0;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Você tem certeza que deseja reiniciar o jogo?", "Deseja reiniciar o jogo?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(resultado == DialogResult.Yes)
            {
                startGame(true);
            }
        }
    }
}
