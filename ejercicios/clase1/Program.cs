using System;

namespace MJ
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Declaración de variable de tipo integer
            //// llamada "x".
            //int x;
            //// Inicialización de variable llamada "x"
            //// con el valor 4.
            //x = 4;
            //// Declaración e inicialización.
            //int y = 3;
            //float z = 3.3f;
            //double w = 3.52d;
            //char letra = 'A';
            //string frase = "Hola que tal";
            //bool booleanFalso = false;
            //bool boleanoVerdadero = true;
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine(z);
            //Console.WriteLine(w);
            //Console.WriteLine(letra);
            //Console.WriteLine(frase);
            //Console.WriteLine(booleanFalso);
            //Console.WriteLine(boleanoVerdadero);

            //Console.Write("Escriba el primer número: ");
            //int n1 = int.Parse(Console.ReadLine());
            //Console.Write("Escriba el segundo número: ");
            //int n2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("La suma es: " + (n1 + n2));
            //Console.WriteLine("La resta es: " + (n1 - n2));
            //Console.WriteLine("La porcentaje es: " + (n1 % n2));
            //Console.WriteLine("La división es: " + (n1 / n2));
            //Console.WriteLine("La multiplicación es: " + (n1 * n2));

            //Console.Write("Introduzca su edad: ");
            //int age = int.Parse(Console.ReadLine());
            //if (age >= 65)
            //{
            //    Console.WriteLine("Estas jubilado");
            //}
            //else if (age >= 18)
            //{
            //    Console.WriteLine("Eres mayor de edad");
            //}
            //else
            //{
            //    Console.WriteLine("Eres menor de edad");
            //}

            //bool windy = false;
            //bool rainy = true;
            //bool sunny = true;

            //if (!windy && (rainy || sunny))
            //{
            //    Console.WriteLine("Puedes coger el paraguas");
            //}

            Console.Write("Introduzca la nota: ");
            int grade = int.Parse(Console.ReadLine());
            if (grade <= 10 && grade >= 9)
            {
                Console.WriteLine("Sobresaliente");
            }
            else if (grade >= 7 && grade < 9)
            {
                Console.WriteLine("Notable");
            }
            else if (grade >= 6 && grade < 7)
            {
                Console.WriteLine("Bien");
            }
            else if (grade >= 5 && grade < 6)
            {
                Console.WriteLine("Suficiente");
            }
            else if (grade >= 0 && grade < 5)
            {
                Console.WriteLine("Insuficiente");
            }
            else
            {
                Console.WriteLine("Se ha equivocado");
            }

            Console.Write("Introduzca la nota: ");
            int nota = int.Parse(Console.ReadLine());
            switch (nota)
            {
                case 10:
                case 9:
                   Console.WriteLine("Sobresaliente");
                    break;
                case 8:
                case 7:
                    Console.WriteLine("Notable");
                    break;
                case 6:
                    Console.WriteLine("Bien");
                    break;
                case 5:
                    Console.WriteLine("Suficiente");
                    break;
                case 4:
                case 3:
                case 2:
                case 1:
                case 0:
                    Console.WriteLine("Insuficiente");
                    break;
                default:
                    Console.WriteLine("Te has equivocado");
                    break;
            }
        } 
    }
}
