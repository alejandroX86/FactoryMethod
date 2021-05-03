using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Consola
{
    class Program
    {
        static void Main(string[] args)
        {

            Pizzeria pizzeria;
            Pizza pizza;

            pizzeria = new PizzeriaArgentina();

            pizza = pizzeria.CrearPizza("napo");
            pizza.Render();
            pizza = pizzeria.CrearPizza("cancha");
            pizza.Render();

            pizzeria = new PizzeriaItaliana();
            pizza = pizzeria.CrearPizza("napo");
            pizza.Render();
            pizza = pizzeria.CrearPizza("cancha");
            pizza.Render();
            Console.ReadKey();
        }
    }
}
