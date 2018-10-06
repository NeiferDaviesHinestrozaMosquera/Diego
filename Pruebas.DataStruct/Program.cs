using System;
using System.Collections.Generic;
using DataStructs;

namespace Pruebas.DataStruct
{
    class Program
    {
        static void Main(string[] args)
        {
         
            SingleList<int> listaDeEnteros = new SingleList<int>();
          
            Console.Write("Ingrese la cantidad de elementos de la lista:");
            int cantidad = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            for (int i = 0; i < cantidad; i++)
            {
                    int nuevoNumero = random.Next(0, 100);
                    listaDeEnteros.AddNode(nuevoNumero);
            }

            listaDeEnteros.ImprimirLista();

            Console.WriteLine("\n Escoja una opcion\n ");

            int option = 0;

            Console.WriteLine("1. Imprimir Lista");
            Console.WriteLine("2. Agregar Valor al Inicio");
            Console.WriteLine("3. Agregar Valor al Final ");
            Console.WriteLine("4. Ordenamiento Burbuja");
            Console.WriteLine("5. Buscar Elemento");
            Console.WriteLine("6. Salir");

            option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:

                    listaDeEnteros.ImprimirLista();

                    break;

                case 2:
                    Console.WriteLine("Ingrese el nuevo valor");
                    int valor = Convert.ToInt32(Console.ReadLine());
                    listaDeEnteros.AddNodeInicio(valor);
                    listaDeEnteros.ImprimirLista();

                    break;
                    
                case 3:

                    Console.WriteLine("Ingrese el nuevo valor");
                    int valor2 = Convert.ToInt32(Console.ReadLine());
                    listaDeEnteros.AddNodeFinal(listaDeEnteros, valor2);
                    listaDeEnteros.ImprimirLista();

                    break;

                case 4:
                    BurbujaList burbujaList = new BurbujaList();
                    burbujaList.Cargar(listaDeEnteros);

                    break;

                case 5:
                    Console.WriteLine("Ingrese el valor a buscar");
                    int valor3 = Convert.ToInt32(Console.ReadLine());
                    listaDeEnteros.SearchNode(listaDeEnteros,valor3);

                    break;
            }
            Console.Read();
        }
    }
}