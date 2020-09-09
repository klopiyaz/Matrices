using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp73
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            string[] valores = { "-", "-", "O", "X" };
            int n = 10;
            int m = 15;

            string[,] tablero = new string[n, m];
            string[,] salida = new string[n, m];

            for (int i = 0; i < tablero.GetLength(0); i++)
            {
                for (int j = 0; j < tablero.GetLength(1); j++)
                {
                    int indice = random.Next(0, valores.Length);
                    tablero[i, j] = valores[indice];
                    salida[i, j] = "-";
                }
            }

            Console.WriteLine("Entrada= ");
            for (int i = 0; i < tablero.GetLength(0); i++)
            {
                for (int j = 0; j < tablero.GetLength(1); j++)
                {
                    Console.Write("|" + tablero[i, j]);
                }
                Console.Write("|\n");
            }

            Console.WriteLine(" \nEn que posicion de n deseas entrar: ");
            int posicionN = int.Parse(Console.ReadLine());
            Console.WriteLine(" \nEn que posicion de m deseas entrar: ");
            int posicionM = int.Parse(Console.ReadLine());

            if (tablero[posicionN, posicionM] == "X")
            {
                Console.Write("La posicion" + (posicionN, posicionM) + "esta ocupada");
            }
            else
            {
                tablero[posicionN, posicionM] = "X";
                for (int i = 0; i < tablero.GetLength(0); i++)
                {
                    for (int j = 0; j < tablero.GetLength(1); j++)
                    {
                        Console.Write("|" + tablero[i, j]);
                    }
                    Console.Write("|\n");
                }
            }


        }
    }
}
