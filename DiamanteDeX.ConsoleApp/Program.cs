using System;

namespace DiamanteDeX.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dimensaodiamante, spaces, quantidadedeX;


            Console.WriteLine("digite a dimensão do diamante");

            dimensaodiamante = Convert.ToInt32(Console.ReadLine());

            int f = dimensaodiamante;


            //Convert.ToInt32(Console.ReadLine());



            if (dimensaodiamante % 2 != 0)
            {

                //cima
                quantidadedeX = 1;
                spaces = (dimensaodiamante - 1) / 2;
                for (int i = 1; spaces > 0; i++)
                {

                    //s
                    for (int j = 1; j <= spaces; j++)
                    {
                        Console.Write(" ");
                    }

                    //X
                    for (int j = 1; j <= quantidadedeX; j++)
                    {


                        Console.Write("X");
                    }

                    spaces--;
                    quantidadedeX += 2;


                    Console.WriteLine();
                }

                //baixo
                for (int i = 1; quantidadedeX > 0; i++)
                {

                    //spaces
                    for (int j = 1; j <= spaces; j++)
                    {
                        Console.Write(" ");
                    }

                    //X
                    for (int j = 1; j <= quantidadedeX; j++)
                    {

                        Console.Write("X");
                    }
                    f--;
                    spaces++;
                    quantidadedeX -= 2;
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Não é ímpar!");
            }

            Console.ReadLine();
        }
    }
}
        
