/* METODOS ABSTRATOS - Quando temos uma Classe muito generica, como a classe Shape (pois cada forma geometrica pode ser de 
 * varios formatos diferentes e a maneira de calcular a area difere de forma em forma.
 *  Obrigatoriamente, Classes que contenham metodos abstratos tambem devem ser declaradas como abstratas.
 * 
 *  No exemplo, criamos um programa para entrar com o numero de formas geometricas e calcular a area delas, podendo ser
 *  circulos ou triangulos. Depois, retorna a area de cada forma.
 *  
 * 
 */

/* >>> PROGRAMA PRINCIPAL <<< */
using System;
using System.Collections.Generic;
using System.Globalization;
using Aula136_MetodosAbstratos.Entities;
using Aula136_MetodosAbstratos.Entities.Enums;

namespace Aula136_MetodosAbstratos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Shape # {i} data:");
                Console.Write("Rectangle or Circle (r/c)? ");
                char c = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());
                if (c == 'r')
                {
                    Console.Write("Widht: ");
                    double widht = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Rectangle(widht, height, color));
                }
                else
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Circle(radius, color));
                }
            }

            Console.WriteLine();
            Console.WriteLine("SHAPE AREAS:");
            foreach (Shape shape in list)
            {
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
