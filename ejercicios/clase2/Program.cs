using System;

namespace clase2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Introduce primer número: ");
            //int numero1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Introduce segundo número: ");
            //int numero2 = int.Parse(Console.ReadLine());
            //if (numero1 == numero2)
            //{
            //    Console.WriteLine("Iguales");
            //}
            //else
            //{
            //    Console.WriteLine("Diferentes");
            //    if (numero1 > numero2)
            //    {
            //        Console.WriteLine("Mayor" +numero1);
            //    }
            //    else
            //    {
            ////        Console.WriteLine("Mayor" +numero2);
            ////    }

            ////}
            //Console.WriteLine("Introduce número: ");
            //int x = int.Parse(Console.ReadLine());
            //if (x % 2 == 0)
            //{
            //    Console.WriteLine("Número par");
            //}
            //else
            //{
            //    Console.WriteLine("Número impar");
            //}

            //Console.WriteLine("Introduce el primer número: ");
            //int n1 = int.Parse(Console.ReadLine()); 
            ////Console.WriteLine("Introduce el segundo número: ");
            ////int n2 = int.Parse(Console.ReadLine());
            ////if (n1 % n2 == 0)
            ////{
            ////    Console.WriteLine("Número múltiplo");
            ////}
            ////else
            ////{
            ////    Console.WriteLine("Número no múltiplo");
            ////}

            //Console.WriteLine("Introduce el número: ");
            //int number = int.Parse(Console.ReadLine());
            //if (number == 0)
            //{
            //    Console.WriteLine("Cero");
            //}
            //else if (number > 0)
            //{
            //    Console.WriteLine("Positivo");
            //}
            //else
            //{
            //    Console.WriteLine("Negativo");
            //}

            //Console.WriteLine("Introduce 1,2 ó 3: ");
            //int nmr = int.Parse(Console.ReadLine());
            //switch (nmr)
            //{
            //    case 3:
            //        Console.WriteLine("Capullo");
            //            break;
            //    case 2:
            //        Console.WriteLine("¡Cómete el bocadillo de jamón! y jamón se quedó sin bocadillo");
            //        break;
            //    case 1:
            //        Console.WriteLine("Al mal tiempo buena cara");
            //        break;
            //    default:
            //        Console.WriteLine("Error");
            //        break;
            //}
            //Console.WriteLine("Introduce nota de matemáticas: ");
            //double matemáticas = int.Parse(Console.ReadLine());
            //Console.WriteLine("Introduce nota de inglés: ");
            //double inglés = int.Parse(Console.ReadLine());
            //Console.WriteLine("Introduce nota de historia: ");
            //double historia = int.Parse(Console.ReadLine());
            //Console.Write("Tu nota media es: " + (matemáticas + inglés + historia) / 3);

            Console.WriteLine("Introduce tu altura: ");
            double altura = int.Parse(Console.ReadLine());
            if (altura >= 135 && altura <= 140)
            {
                Console.WriteLine("Eres un pitufo");
            }
            else if (altura > 140 && altura <= 150)
            {
                Console.WriteLine("Eres un minion");
            }
            else if (altura > 150 && altura <= 160)
            {
                Console.WriteLine("Eres un hobbit");
            }
            else
            {
                Console.WriteLine("Estas ideal");
            }
        }
    }
}
