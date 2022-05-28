// See https://aka.ms/new-console-template for more information
using System.Globalization;
using System;

namespace Project
{
    class Progam
    {
        static void Main(String[] args)
        {
            Random randNum = new Random();
            int maquina = randNum.Next(0, 3);

            string[] teste = new string[3];
            teste[0] = "Pedra";
            teste[1] = "Papel";
            teste[2] = "Tesoura";



            Console.WriteLine("Vamos Jogar!\nFaça a sua escolha: \n[0] Pedra \n[1] Papel \n[2] Tesoura");
            int resposta = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("A Maquina jogou: {0} {1}", maquina, teste[maquina]);
            Console.WriteLine("Você Jogou: {0} {1}", resposta, teste[resposta]);
          
            if (maquina == 0)
            {
                if (resposta == 0)
                {
                    Console.WriteLine("Empate");
                }
                else if (resposta == 1)
                {
                    Console.WriteLine("Você Ganhou");
                }
                else if (resposta == 2)
                {
                    Console.WriteLine("Você Perdeu");
                }
            }
            else if (maquina == 1)
            {

                if (resposta == 0)
                {
                    Console.WriteLine("Você perdeu");
                }
                else if (resposta == 1)
                {
                    Console.WriteLine("Empate");
                }
                else if (resposta == 2)
                {
                    Console.WriteLine("Você Ganhou");
                }
            }
            else if (maquina == 2)
            {
                if (resposta == 0)
                {
                    Console.WriteLine("Você Ganhou");
                }
                else if (resposta == 1)
                {
                    Console.WriteLine("Você Perdeu");
                }
                else if (resposta == 2)
                {
                    Console.WriteLine("Empate");
                }
            }
            /*for (int i = 0; i <=2 ; i++)
            {
                Console.WriteLine("Vamos Jogar melhor de 3?");
            } */
        }
    }
}