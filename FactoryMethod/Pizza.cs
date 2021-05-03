using System;

namespace FactoryMethod
{
    public abstract class Pizza
    {
        protected string _descripcion;
        protected string _origen;

        public void Render()
        {
            Console.WriteLine(string.Format("Pizza de {0} hecha en {1}", _descripcion, _origen));
        }
    }
}