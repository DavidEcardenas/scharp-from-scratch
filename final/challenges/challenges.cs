namespace itm.csharp.basic
{

    public class Challenge1
    {
        public void Run()
        {
            Console.WriteLine("Descripción:En este ejercicio se  Solicita al usuario un número y eleva este número al cuadrado solo si es positivo.");

            Console.WriteLine("Ingrese un número:");
            if (int.TryParse(Console.ReadLine(), out int num))
            {
                if (num > 0)
                    Console.WriteLine($"Resultado: {num * num}");
                else if (num < 0)
                    Console.WriteLine("Resultado: Número negativo.");
                else
                    Console.WriteLine("Resultado: 0");
            }
            else
            {
                Console.WriteLine("Entrada no válida");
            }


        }
    }

    public class Challenge2
    {
        public void Run()
        {
            Console.WriteLine("Descripción:En este ejercicio se Solicita al usuario dos números. Si el primero es mayor, devuelva su doble, de lo contrario devuelva el triple del segundo.");
            Console.WriteLine("Ingrese el primer número:");
            if (!int.TryParse(Console.ReadLine(), out int num1))
            {
                Console.WriteLine("Entrada no válida");
                return;
            }

            Console.WriteLine("Ingrese el segundo número:");
            if (!int.TryParse(Console.ReadLine(), out int num2))
            {
                Console.WriteLine("Entrada no válida");
                return;
            }

            if (num1 > num2)
                Console.WriteLine($"Resultado: {num1 * 2}");
            else if (num1 < num2)
                Console.WriteLine($"Resultado: {num2 * 3}");
            else
                Console.WriteLine($"Resultado: {num1 * 2}"); // Si son iguales, doble del primero
        }
    }

    public class Challenge3
    {
        public void Run()
        {
            Console.WriteLine("Descripción:En este ejercicio se  Pide al usuario un número. Si es positivo, devuelve su raíz cuadrada, de lo contrario, devuelve su cuadrado.");
            Console.WriteLine("Ingrese un número:");
            if (int.TryParse(Console.ReadLine(), out int num))
            {
                if (num > 0)
                    Console.WriteLine($"Resultado: {Math.Sqrt(num):F2}");
                else if (num < 0)
                    Console.WriteLine($"Resultado: {num * num}");
                else
                    Console.WriteLine("Resultado: 0");
            }
            else
            {
                Console.WriteLine("Entrada no válida");
            }
        }
    }
    public class Challenge4
    {
        public void Run()
        {
            Console.WriteLine("Descripción:En este ejercicio se Pide al usuario el radio de un círculo y calcula su perímetro.");
            Console.WriteLine("Ingrese el radio del círculo:");
            if (double.TryParse(Console.ReadLine(), out double radio))
            {
                double perimetro = 2 * Math.PI * radio;
                Console.WriteLine($"Resultado: {perimetro:F2}");
            }
            else
            {
                Console.WriteLine("Entrada no válida");
            }
        }
    }
     public class Challenge5
    {
        public void Run()
        {
            Console.WriteLine("Descripción:En este ejercicio se Solicita al usuario un número entre 1 y 7 y muestra el día de la semana correspondiente, pero solo considerando los días laborables. ");
            Console.WriteLine("Ingrese un número del 1 al 7:");
            if (int.TryParse(Console.ReadLine(), out int num))
            {
                switch (num)
                {
                    case 1:
                        Console.WriteLine("Resultado: Lunes");
                        break;
                    case 2:
                        Console.WriteLine("Resultado: Martes");
                        break;
                    case 3:
                        Console.WriteLine("Resultado: Miércoles");
                        break;
                    case 4:
                        Console.WriteLine("Resultado: Jueves");
                        break;
                    case 5:
                        Console.WriteLine("Resultado: Viernes");
                        break;
                    case 6:
                    case 7:
                        Console.WriteLine("Resultado: Número fuera del rango laboral.");
                        break;
                    default:
                        Console.WriteLine("Resultado: Número fuera del rango laboral.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida");
            }
        }
    }
}