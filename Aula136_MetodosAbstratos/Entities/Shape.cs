/* >>> CLASSE SHAPE <<< */
using Aula136_MetodosAbstratos.Entities.Enums;

namespace Aula136_MetodosAbstratos.Entities
{
    abstract class Shape // Declaracao da Classe Abstrata
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area(); // Declaracao do Metodo Abstrato
    }
}
