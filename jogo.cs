using System;
using System.Drawing;

namespace Jogo
{
    class Program
    {
        static void Main(String[] args)
        {
            Random randNum = new Random();

            AtributoJogador jogador1 = new AtributoJogador();
            AtributoJogador jogador2 = new AtributoJogador();

            Console.WriteLine("Entre com o nome do primeiro jogador:");
            jogador1.Nome = Console.ReadLine();

            Console.WriteLine("Entre com o nome do segundo jogador:");
            jogador2.Nome = Console.ReadLine();

            jogador1.Energias = 10;
            jogador1.id = 1;


            jogador2.Energias = 10;
            jogador2.id = 2;


            int valor = randNum.Next(1, 3);


            if (valor == 1)
            {
                Console.WriteLine("O jogo será iniciado por: " + jogador1.Nome);

            }
            else
            {
                Console.WriteLine("O jogo será iniciado por: " + jogador2.Nome);

            }

            int valor1;
            int valor2;
            int valor3;

            int ContJ1 = 0;
            int ContJ2 = 0;

            if (valor == 1)
            {
                Console.WriteLine(jogador1.Nome + " aperte enter para receber suas cartas");
                Console.ReadLine();

                valor1 = randNum.Next(10, 13);
                valor2 = randNum.Next(10, 13);
                valor3 = randNum.Next(10, 13);

                Console.WriteLine(valor1);
                Console.WriteLine(valor2);
                Console.WriteLine(valor3);

                if ((valor1 != valor2) || (valor1 != valor3) || (valor2 != valor3))
                {
                    jogador1.Energias = (jogador1.Energias - 1);

                    Console.WriteLine("Como suas cartas foram diferentes você perdeu 1 energia");
                    Console.WriteLine("Te restam: " + jogador1.Energias + "energias ");
                }
                else
                {
                    Console.WriteLine("Como suas cartas foram iguais " + jogador1.Nome + " continua com " + jogador1.Energias + " energias ");

                }


                ContJ1++;

            }

            if (valor == 2)
            {

                Console.WriteLine(jogador2.Nome + " aperte enter para receber suas cartas");
                Console.ReadLine();

                valor1 = randNum.Next(10, 13);
                valor2 = randNum.Next(10, 13);
                valor3 = randNum.Next(10, 13);

                Console.WriteLine(valor1);
                Console.WriteLine(valor2);
                Console.WriteLine(valor3);

                if ((valor1 != valor2) || (valor1 != valor3) || (valor2 != valor3))
                {
                    jogador2.Energias -= 1;
                    Console.WriteLine("Como suas cartas foram diferentes você perdeu 1 energia");

                    Console.WriteLine("Te restam: " + jogador2.Energias + "energias ");


                }

                ContJ2++;

            }

            while (jogador1.Energias > 0 || jogador2.Energias > 0)
            {


                while (ContJ1 <= ContJ2)
                {

                    Console.WriteLine(jogador1.Nome + " aperte enter para receber suas cartas");
                    Console.ReadLine();

                    valor1 = randNum.Next(10, 13);
                    valor2 = randNum.Next(10, 13);
                    valor3 = randNum.Next(10, 13);

                    Console.WriteLine(valor1);
                    Console.WriteLine(valor2);
                    Console.WriteLine(valor3);

                    if ((valor1 != valor2) || (valor1 != valor3) || (valor2 != valor3))
                    {
                        jogador1.Energias -= 1;

                        Console.WriteLine("Como suas cartas foram diferentes você perdeu 1 energia");
                        Console.WriteLine("Te restam:" + jogador1.Energias + "energias ");
                    }

                    ContJ1++;


                }
                while (ContJ2 < ContJ1)
                {

                    Console.WriteLine(jogador2.Nome + " aperte enter para receber suas cartas");
                    Console.ReadLine();

                    valor1 = randNum.Next(10, 13);
                    valor2 = randNum.Next(10, 13);
                    valor3 = randNum.Next(10, 13);

                    Console.WriteLine(valor1);
                    Console.WriteLine(valor2);
                    Console.WriteLine(valor3);

                    if ((valor1 != valor2) || (valor1 != valor3) || (valor2 != valor3))
                    {
                        jogador2.Energias -= 1;
                        Console.WriteLine("Como suas cartas foram diferentes você perdeu 1 energia");
                        Console.WriteLine("Te restam: " + jogador2.Energias + "energias ");
                    }

                    ContJ2++;


                }
            }





        }
    }
}
