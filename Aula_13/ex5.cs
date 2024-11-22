using System;
using System.Diagnostics;

namespace Name
{
    class ex5
    {
        static void OrdenarBubble(int[] vetor)
            {
                int aux;
                for (int i = 0; i < vetor.Length;i ++)
                {
                    for (int j = 0; j < vetor.Length - 1; j++ )
                    {
                        if (vetor[j] < vetor[j+1])
                        {
                            aux = vetor[j];
                            vetor[j] = vetor[j+1];
                            vetor[j+1] = aux;
                        }
                    }
                }
            }

        static void OrdenarSelection(int[] vetor)
        {
            int menor, aux;
            for (int i = 0; i < vetor.Length; i++)
            {
                menor = i;
                for (int j = i + 1; j < vetor.Length; j++)
                {
                    if (vetor[j] > vetor[menor])
                    {
                        menor = j;
                    }
                }
                    aux = vetor[i];
                    vetor[i] = vetor[menor];
                    vetor[menor] = aux;
            }
        }

        static void OrdenarInsertion(int[] vetor)
        {
            int menor, aux;
            for (int i = 0; i < vetor.Length; i++)
            {
                menor = i;
                for (int j = i + 1; j < vetor.Length; j++)
                {
                    if (vetor[j] > vetor[menor])
                    {
                        menor = j;
                    }
                }
                    aux = vetor[i];
                    vetor[i] = vetor[menor];
                    vetor[menor] = aux;
            }
        }


        static void Main(string[] args)
        {
            int[] vetor = new int[1000];
            Random random = new Random();
            for (int i = 0; i < 20; i++)
            {
                vetor[i] = random.Next(1, 101);
            }


            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            OrdenarBubble(vetor);
            stopwatch.Stop();
            Console.WriteLine("Bubble Sort: " + stopwatch.ElapsedMilliseconds + " ms");
            long tempo1 = stopwatch.ElapsedMilliseconds;
            
            stopwatch.Reset(); 
            stopwatch.Start();
            OrdenarSelection(vetor);
            stopwatch.Stop();
            Console.WriteLine("Selection Sort: " + stopwatch.ElapsedMilliseconds + " ms");
            long tempo2 = stopwatch.ElapsedMilliseconds;

            stopwatch.Reset();
            stopwatch.Start();
            OrdenarInsertion(vetor);
            stopwatch.Stop();
            long tempo3 = stopwatch.ElapsedMilliseconds;

            Console.WriteLine("Insertion Sort: " + stopwatch.ElapsedMilliseconds + " ms");

            if (tempo1 < tempo2 && tempo1 < tempo3)
            {
                Console.WriteLine("O Bubble Sort teve o melhor desempenho!");
            }
            else if (tempo2 < tempo1 && tempo2 < tempo3)
            {
                Console.WriteLine("O Selection Sort teve o melhor desempenho!");
            }
            else if (tempo3 < tempo1 && tempo3 < tempo2)
            {
                Console.WriteLine("O Insertion Sort teve o melhor desempenho!");
            }
            else
            {
                Console.WriteLine("Os algoritmos tiveram desempenho semelhante.");
            }
        }
    }
}