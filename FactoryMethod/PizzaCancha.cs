
namespace FactoryMethod
{
    public class PizzaCancha : Pizza
    {
        public PizzaCancha(string origen)
        {
            _descripcion = "Pizza de cancha";
            _origen = origen;
        }
    }
}