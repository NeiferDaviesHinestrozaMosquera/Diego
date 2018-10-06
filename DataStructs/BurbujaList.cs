using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructs
{
    public class BurbujaList
    {
        public int[] vector;

        public void Cargar(SingleList<int> vectors)
        {
            Console.Write("\n");
            Console.WriteLine("\n Metodo de Burbuja");
            SingleList<int> listaDeEnteros = new SingleList<int>();
            listaDeEnteros = vectors;
            vector = new int[listaDeEnteros.Count];
            for (int f = 0; f < listaDeEnteros.Count; f++)
            {
                vector[f] = listaDeEnteros.Head.Value;
                listaDeEnteros.Head = listaDeEnteros.Head.Next;
            }
            MetodoBurbuja();
            Imprimir();
        }
        public void MetodoBurbuja()
        {
            int t;
            for (int a = 1; a < vector.Length; a++)
                for (int b = vector.Length - 1; b >= a; b--)
                {
                    if (vector[b - 1] > vector[b])
                    {
                        t = vector[b - 1];
                        vector[b - 1] = vector[b];
                        vector[b] = t;
                    }
                }
        }

        public void Imprimir()
        {
            Console.WriteLine("\nElementos de la Lista ordenados en forma ascendente");
            for (int f = 0; f < vector.Length; f++)
            {
                Console.Write(vector[f] + "  ");
            }
            Console.ReadKey();
        }
    }
}
