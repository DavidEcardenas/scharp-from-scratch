namespace itm.csharp.basic
{

    public class Challenge1
    {
        public void Run()
        {
            Console.WriteLine("Descripción:En este ejercicio se solicita al usuario un número y eleva este número al cuadrado solo si es positivo.");

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
            Console.WriteLine("Descripción:En este ejercicio se solicita al usuario dos números. Si el primero es mayor, devuelva su doble, de lo contrario devuelva el triple del segundo.");
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
            Console.WriteLine("Descripción:En este ejercicio se  pide al usuario un número. Si es positivo, devuelve su raíz cuadrada, de lo contrario, devuelve su cuadrado.");
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
            Console.WriteLine("Descripción:En este ejercicio se pide al usuario el radio de un círculo y calcula su perímetro.");
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
            Console.WriteLine("Descripción:En este ejercicio se solicita al usuario un número entre 1 y 7 y muestra el día de la semana correspondiente, pero solo considerando los días laborables. ");
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
    public class Challenge6
    {
        public void Run()
        {
            Console.WriteLine("Descripción:En este ejercicio se solicita al usuario su salario anual y, si este excede los 12000, muestra el impuesto a pagar que es el 15% del excedente. ");
            Console.WriteLine("Ingrese su salario anual:");
            if (double.TryParse(Console.ReadLine(), out double salario))
            {
                if (salario > 12000)
                {
                    double excedente = salario - 12000;
                    double impuesto = excedente * 0.15;
                    Console.WriteLine($"Resultado: {impuesto:F0}");
                }
                else
                {
                    Console.WriteLine("Resultado: No debe impuestos.");
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida");
            }
        }
    }

    public class Challenge7
    {
        public void Run()
        {
            Console.WriteLine("Descripción:En este ejercicio se solicita dos números y muestra el residuo de la división del primero entre el segundo.");
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

            if (num2 == 0)
            {
                Console.WriteLine("No se puede dividir por cero");
                return;
            }

            Console.WriteLine($"Resultado: {num1 % num2}");
        }
    }

    public class Challenge8
    {
        public void Run()
        {
            int suma = 0;
            for (int i = 1; i <= 50; i++)
            {
                if (i % 2 == 0)
                    suma += i;
            }
            Console.WriteLine($"Resultado: {suma}");
        }
    }

    public class Challenge9
    {
        public void Run()
        {
            Console.WriteLine("Descripción:En este ejercicio se solicita al usuario los valores para dos fracciones y muestra la diferencia entre esas fracciones. ");
            Console.WriteLine("Ingrese el numerador de la primera fracción:");
            if (!int.TryParse(Console.ReadLine(), out int num1)) return;

            Console.WriteLine("Ingrese el denominador de la primera fracción:");
            if (!int.TryParse(Console.ReadLine(), out int den1) || den1 == 0) return;

            Console.WriteLine("Ingrese el numerador de la segunda fracción:");
            if (!int.TryParse(Console.ReadLine(), out int num2)) return;

            Console.WriteLine("Ingrese el denominador de la segunda fracción:");
            if (!int.TryParse(Console.ReadLine(), out int den2) || den2 == 0) return;

            // Calcular diferencia: a/b - c/d = (a*d - c*b)/(b*d)
            int numerador = num1 * den2 - num2 * den1;
            int denominador = den1 * den2;

            // Simplificar
            int mcd = MCD(Math.Abs(numerador), Math.Abs(denominador));
            numerador /= mcd;
            denominador /= mcd;

            if (numerador == 0)
                Console.WriteLine("Resultado: 0");
            else if (denominador == 1)
                Console.WriteLine($"Resultado: {numerador}");
            else
                Console.WriteLine($"Resultado: {numerador}/{denominador}");
        }

        private int MCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
    }

    public class Challenge10
    {
        public void Run()
        {
            Console.WriteLine("Descripción:En este ejercicio se pide una palabra al usuario y muestra la longitud de esa palabra. ");
            Console.WriteLine("Ingrese una palabra:");
            string? palabra = Console.ReadLine();

            if (!string.IsNullOrEmpty(palabra))
                Console.WriteLine($"Resultado: {palabra.Length}");
            else
                Console.WriteLine("Entrada no válida");
        }
    }

    public class Challenge11
    {
        public void Run()
        {
            Console.WriteLine("Descripción:En este ejercicio se pide al usuario cuatro números y muestra el promedio. ");
            double suma = 0;
            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine($"Ingrese el número {i}:");
                if (double.TryParse(Console.ReadLine(), out double num))
                    suma += num;
                else
                {
                    Console.WriteLine("Entrada no válida");
                    return;
                }
            }

            double promedio = suma / 4;
            Console.WriteLine($"Resultado: {promedio:F0}".Replace(',', '.'));
        }
    }

    public class Challenge12
    {
        public void Run()
        {
            Console.WriteLine("Descripción:En este ejercicio se pide al usuario cinco números y muestra el más pequeño.  ");
            int? menor = null;

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Ingrese el número {i}:");
                if (int.TryParse(Console.ReadLine(), out int num))
                {
                    if (menor == null || num < menor)
                        menor = num;
                }
                else
                {
                    Console.WriteLine("Entrada no válida");
                    return;
                }
            }

            Console.WriteLine($"Resultado: {menor}");
        }
    }

    public class Challenge13
    {
        public void Run()
        {
            Console.WriteLine("Descripción:En este ejercicio se pide una palabra al usuario y devuelve el número de vocales en esa palabra.");
            Console.WriteLine("Ingrese una palabra:");
            string? palabra = Console.ReadLine();

            if (string.IsNullOrEmpty(palabra))
            {
                Console.WriteLine("Entrada no válida");
                return;
            }

            int contador = 0;
            palabra = palabra.ToLower();

            foreach (char c in palabra)
            {
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                    contador++;
            }

            Console.WriteLine($"Resultado: {contador}");
        }
    }

    public class Challenge14
    {
        public void Run()
        {
            Console.WriteLine("Descripción:En este ejercicio se pide un número al usuario y devuelve el factorial de ese número. ");
            Console.WriteLine("Ingrese un número:");
            if (int.TryParse(Console.ReadLine(), out int num) && num >= 0)
            {
                long factorial = 1;
                for (int i = 1; i <= num; i++)
                {
                    factorial *= i;
                }
                Console.WriteLine($"Resultado: {factorial}");
            }
            else
            {
                Console.WriteLine("Entrada no válida o número negativo");
            }
        }
    }
    public class Challenge15
    {
        public void Run()
        {
            Console.WriteLine("Descripción:En este ejercicio se pide un número al usuario y verifica si está en el rango de 10 a 20 (ambos incluidos). ");
            Console.WriteLine("Ingrese un número:");
            if (int.TryParse(Console.ReadLine(), out int num))
            {
                if (num >= 10 && num <= 20)
                    Console.WriteLine("Resultado: Está en el rango.");
                else
                    Console.WriteLine("Resultado: Fuera del rango.");
            }
            else
            {
                Console.WriteLine("Entrada no válida");
            }
        }
    }
}