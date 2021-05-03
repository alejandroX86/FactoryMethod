
namespace FactoryMethod
{
    public class PizzeriaArgentina : Pizzeria
    {
        public override Pizza CrearPizza(string tipo)
        {
            if (tipo == "cancha")
            {
                return new PizzaCancha("Argentina");
            }
            else if (tipo == "napo")
            {
                return new PizzaNapolitana("Argentina");
            }
            else
            {
                return null;
            }
        }
    }
}