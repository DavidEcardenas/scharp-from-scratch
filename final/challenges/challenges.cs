namespace itm.csharp.basic
{
   
    public class Challenge1
    {
    
    public void Run()
    {
    Console.WriteLine("Ingrese un número:");
    int num = int.Parse(Console.ReadLine());
    if (num > 0) Console.WriteLine("Positivo");
    else if (num < 0) Console.WriteLine("Negativo");
    else Console.WriteLine("Es cero");
    }
    }
}