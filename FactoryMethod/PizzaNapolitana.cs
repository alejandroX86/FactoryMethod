
namespace FactoryMethod
{
    public class PizzaNapolitana : Pizza
    {
        public PizzaNapolitana(string origen)
        {
            _descripcion = "Pizza napolitana!";
            _origen = origen;
        }
    }
}