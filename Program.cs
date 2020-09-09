using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp72
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            string[] valores = { "-", "-", "O", "X" };
            int n = 10;
            int m = 15;
            double contadorX = 0;
            double contadorO = 0;
            double promedioX = 0;
            double promedioO = 0;

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

            Console.WriteLine("\nSalida: ");
            for (int i = 0; i < tablero.GetLength(0); i++)
            {
                for (int j = 0; j < tablero.GetLength(1); j++)
                {
                    Console.Write("|" + salida[i, j]);
                }
                Console.Write("|\n");
            }

            Console.WriteLine("\nModificado: ");
            for (int i = 0; i < tablero.GetLength(0) - 2; i++)
            {
                for (int j = 0; j < tablero.GetLength(1) - 2; j++)
                {
                    if (tablero[i, j] == "X") contadorX++;
                    if (tablero[i, j] == "O") contadorO++;
                    if (tablero[i, j + 0] == tablero[i, j + 1] && tablero[i, j + 1] == tablero[i, j + 2])
                    {
                        if (tablero[i, j] == "X")
                        {
                            salida[i, j + 0] = "1";
                            salida[i, j + 1] = "1";
                            salida[i, j + 2] = "1";
                        }
                        else if (tablero[i, j] == "O")
                        {
                            salida[i, j + 0] = "2";
                            salida[i, j + 1] = "2";
                            salida[i, j + 2] = "2";
                        }
                    }
                    if (tablero[i + 0, j] == tablero[i + 1, j] && tablero[i + 1, j] == tablero[i + 2, j])
                    {
                        if (tablero[i, j] == "X")
                        {
                            salida[i + 0, j] = "1";
                            salida[i + 1, j] = "1";
                            salida[i + 2, j] = "1";
                        }
                        else if (tablero[i, j] == "O")
                        {
                            salida[i + 0, j] = "2";
                            salida[i + 1, j] = "2";
                            salida[i + 2, j] = "2";
                        }
                    }
                }
            }
            for (int i = 0; i < tablero.GetLength(0); i++)
            {
                for (int j = 0; j < tablero.GetLength(1); j++)
                {
                    Console.Write("|" + salida[i, j]);
                }
                Console.Write("\n");
            }
            promedioX = (contadorX * 100) / (n * m);
            Console.WriteLine("\nPorcentaje de X: "+ Math.Round(promedioX, 2));
            promedioO = (contadorO * 100) / (n * m);
            Console.WriteLine("\nPorcentaje de O: " + Math.Round(promedioO, 2));
            double promediorayas = 100 - (promedioO + promedioX);
            Console.WriteLine("\nPorcentaje de -: " + Math.Round(promediorayas, 2));
        }
    }
}
