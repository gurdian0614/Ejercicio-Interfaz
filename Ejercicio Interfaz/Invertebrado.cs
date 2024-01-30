
namespace Ejercicio_Interfaz
{
    internal class Invertebrado : Animal, IAnimal
    {
        public void Imprimir()
        {
            Console.WriteLine($"Nombre: {Nombre}");
        }
    }
}
