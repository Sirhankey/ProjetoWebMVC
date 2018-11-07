using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoFinal.Models
{
    public class JoKenPo
    {
        /*      JOKENPO
         *      0 - PEDRA
         *      1 - PAPEL
         *      2 - TESOURA
         *      PEDRA > TESOURA > PAPEL > PEDRA 
         * */
        int compCount = 0;
        int playerCount = 0;

        public string RoundLabelText { get; set; } = "teste";
        public string PlayerLabelText { get; set; } = "teste";
        public string CompLabelText { get; set; } = "teste";
        public string ScoreLabelText { get; set; } = "teste";


        public int CompPlay { get; set; }
        public int PlayerPlay { get; set; }
        public int Score { get; set; } = 0;
        public int Round { get; set; } = 0;
        Random random;

        public JoKenPo()
        {
            random = new Random();
        }


        public int CompTurn()
        {
            return random.Next(0, 2);
        }
        // 0 - EMPATE | 1 - PC WIN | 2 - PLAYER WIN
        public int VerificaJogada(int jogadaPlayer, int jogadaComp)
        {
            int vencedor = 0;
            switch (jogadaPlayer)
            {
                case 0:
                    {
                        if (jogadaComp == 0) vencedor = 0; //PEDRA | PEDRA
                        if (jogadaComp == 1) vencedor = 1; //PEDRA | PAPEL
                        if (jogadaComp == 2) vencedor = 2; //PEDRA | TESOURA
                    }
                    break;
                case 1:
                    {
                        if (jogadaComp == 0) vencedor = 2; //PAPEL | PEDRA
                        if (jogadaComp == 1) vencedor = 0; //PAPEL | PAPEL
                        if (jogadaComp == 2) vencedor = 1; //PAPEL | TESOURA
                    }
                    break;
                case 2:
                    {
                        if (jogadaComp == 0) vencedor = 1; //TESOURA | PEDRA
                        if (jogadaComp == 1) vencedor = 2; //TESOURA | PAPEL
                        if (jogadaComp == 2) vencedor = 0; //TESOURA | TESOURA
                    }
                    break;
                default:
                    System.Diagnostics.Debug.WriteLine("Default case VerificaJogada() class JoKenPo!!!");
                    break;
            }
            return vencedor;
        }
        public string Jogada(int i)
        {
            if (i == 0) return "Pedra";
            else if (i == 1) return "Papel";
            else return "Tesoura";
        }
        void NextRound()
        {
            Round++;
        }
        void MarcarPonto(int vencedor)
        {
            if (vencedor == 0)
            {
                Score += 0;
            }
            else if (vencedor == 1)
            {
                compCount++;
                Score -= 10;
            }
            else
            {
                playerCount++;
                Score += 10;
            }
        }
        public string ExibirPlacar()
        {
            string textoPlacar = "Player: "+this.playerCount+" | Computador: "+this.compCount;
            return textoPlacar;
        }


    }
}