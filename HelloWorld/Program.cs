using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;

namespace PrimeiroPrograma {
    class Program {
        static void Main(string[] args) {
            Console.Write("Digite o tamanho da matriz(linha)(coluna): ");
            string[] vet1 = Console.ReadLine().Split(' ');
            int qntl = int.Parse(vet1[0]);
            int qntc = int.Parse(vet1[1]);
            int[,] matriz = new int[qntl, qntc];
            Console.WriteLine("Agora preencha a matriz:");
            for(int i = 0; i < matriz.GetLength(0); i++) {
                string[] vet = Console.ReadLine().Split(' ');
                for(int j = 0; j < matriz.GetLength(1); j++) {
                    matriz[i, j] = int.Parse(vet[j]);
                }
            }
            Console.Write("Digite o valor que deseja buscar: ");
            int val = int.Parse(Console.ReadLine());
            for(int i = 0; i < matriz.GetLength(0); i++) {
                for(int j = 0; j < matriz.GetLength(1); j++) {
                    if (matriz[i, j] == val) {
                        Console.WriteLine("position: {0},{1}", i, j);
                        if (j>0) {
                            Console.WriteLine("left: " + matriz[i, j - 1]);
                        }
                        if (j<qntc-1) {
                            Console.WriteLine("right: " + matriz[i, j + 1]);
                        }
                        if (i>0) {
                            Console.WriteLine("up: " + matriz[i - 1, j]);
                        }
                        if (i<qntl-1) {
                            Console.WriteLine("down: " + matriz[i + 1, j]);
                        }
                    }
                }
            }
        }
    }
}
