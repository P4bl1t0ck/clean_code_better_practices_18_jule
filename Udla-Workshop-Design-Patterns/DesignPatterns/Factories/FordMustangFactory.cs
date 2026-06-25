using DesignPatterns.FactoryMethods;
using DesignPatterns.Models;

namespace DesignPatterns.Factories
{
    public class FordMustangFactory :CarFactory
    {
        // Implementa el mismo método 'Create' pero devolviendo un Mustang
        public override Car Create()
        {
            return new Car("red", "Ford", "Mustang");
        }
    }
}
