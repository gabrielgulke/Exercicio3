using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {

            double b, h, area, num;
            Console.WriteLine("Exercicio 2: ");
            Console.WriteLine("1 - Triângulo \n2 - Trapézio \n3 - Paralelograma \nEscolha um a das figuras geométricas: ");
            num = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe a base da figura: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe a altura da figura: ");
            h = Convert.ToDouble(Console.ReadLine());

            switch (num)
            {
                case 1:
                    area = b * h / 2;
                    Console.WriteLine("A area do triângulo é: " + area);
                    break;

                case 2:
                    int B;
                    Console.WriteLine("Precisamos de mais uma informação do trápezio que é sua base menor!");
                    Console.WriteLine("Insira a base menor do trápezio: ");
                    B = Convert.ToInt32(Console.ReadLine());
                    area = ((B + b) / 2) * h;
                    Console.WriteLine("A area do trápezio é: " + area);
                    break;

                case 3:
                    area = b * h;
                    Console.WriteLine("A area do paralelograma é: " + area);
                    break;
            }
            Console.ReadLine();
        }
    }
}
