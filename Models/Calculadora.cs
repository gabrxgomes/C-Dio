using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstruturaDeProjC_.Models
{
    public class Calculadora
    {
        public void Somar(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }

                public void Subtrai(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }

                public void Divide(int x, int y)
        {
            Console.WriteLine($"{x} / {y} = {x / y}");
        }

                public void Multiplica(int x, int y)
        {
            Console.WriteLine($"{x} * {y} = {x * y}");
        }
    }
}