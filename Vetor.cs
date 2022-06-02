using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace JogoMemo
{
    class Vetor
    {
        string[] vetImg = new string[12];
        int limit;

        //construtor da classe
        public Vetor(int l)
        {
            vetImg = new string[l];
            limit = l;
        }
        // método para inserir o dado no vetor
        public void InsertData(int pos, string arqv)
        {
            vetImg[pos] = arqv;
        }

        //método para verificar se o dado (o nome da imagem) está no vetor
        public int searchImage(string arqv)
        {
            bool achou = false;
            int indice = 0;
            while ((indice <= limit) && (!achou))
            {
                if (vetImg[indice] == arqv)
                {
                    achou = true;
                } else
                {
                    indice++;
                }
               
            }
            if (achou)
            {
                return indice;
            }
            else
            {
                return -1;
            }
        }
        // este método retorna conteúdo do vetor numa posição específica
        public string returnPosition(int pos)
        {
            return vetImg[pos];
        }

        //método para sortear números, usado para sortear as posições no vetor
        public int sortNumber(int first, int last)
        {
            int num = 0;
            Random sort = new Random();
            return num = sort.Next(first, last);

        }

        //verifica se há algum dado numa posição específica
        public bool OccupiedPosition(int pos)
        {
            if (vetImg[pos] != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //método para limpar os dados do vetor para que o jogo possa recomeçar
        public void clearVector(int l)
        {
            for (int i = 0; i <= l; i++)
            {
                vetImg[i] = null;
            }
        }
    }
}
