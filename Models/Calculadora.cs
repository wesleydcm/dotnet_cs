using System;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;
using DotnetCs.Models;

namespace DotnetCs.Models
{
    public class Calculadora
    {
        public void Somar(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }
        public void Subtrair(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = { x - y}");
        }

        public void Multiplicar(int x, int y)
        {
            Console.WriteLine($"{x} * {y} = { x * y}");
        }
        public void Divisao(int x, int y)
        {
            Console.WriteLine($"{x} / {y} = { x / y}");
        }

        
    }
}
