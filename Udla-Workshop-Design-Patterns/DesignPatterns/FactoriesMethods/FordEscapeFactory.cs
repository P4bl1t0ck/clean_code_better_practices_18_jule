using DesignPatterns.Models;

namespace DesignPatterns.FactoryMethods
{
    public class FordEscapeFactory : CarFactory
    {
        //Funcion bastante especifica
        public override Car Create()
        {
            return new Car("red", "Ford", "Escape");
        }
    }
}
