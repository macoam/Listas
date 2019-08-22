using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> colores =
                new List<string>();
            colores.Add("Rojo");
            colores.Add("Morado");
            colores.Add("Verde");
            colores.Add("Azul");

            colores.RemoveAt(1);
            colores.Remove("Verde");

            Console.WriteLine("Número de elementos: " + colores.Count);

            int indiceColor = 1;
            foreach(string color in colores)
            {
                Console.WriteLine("Elemento " + indiceColor.ToString() + ":" + color);

                indiceColor++;
            }

            Console.Read();
        }
    }
}
