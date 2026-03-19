namespace HelloWorld
{
    class Program
    {

        static void Main()
        {
            //Data Type
            //var MyNum =5;
            //var MyDoubleNum =5.999;
            //var Myletter= 'd';
            //var MyBool = true;
            //var Mytext = "hello";
            //var  Name = "julio";
            //Console.WriteLine($"Hellow World  {Name}");
            //Console.WriteLine($"thank for coming {Name}");

            DateOnly DateConverted = new DateOnly();
            string nameInput;
            string BirthdayImput;
            Console.WriteLine("Hola bienvenido al calculador de anios");
            Console.WriteLine("escribe tu nombre : ");
            nameInput=Console.ReadLine();
            Console.WriteLine($"un gusto conocerte {nameInput}");
            Console.WriteLine("escribe tu fecha de nacimiento en formato dd/mm/yy : ");
            BirthdayImput=Console.ReadLine();
            bool isDateValid=DateOnly.TryParse(BirthdayImput,out DateConverted);
            if (isDateValid==false) Console.WriteLine($"la fecha de nacimiento es invalida {BirthdayImput} ");
            var person=new Person
            {
                Name=nameInput,
                Birthday=DateConverted,
                Age= DateTime.Now.Year-DateConverted.Year
            };
            Console.WriteLine($"tu nombre es :   {person.Name}");
            Console.WriteLine($"tu Fecha de nacimiento es :  {person.Birthday}");
            Console.WriteLine($"tu Edad es :  {person.Age}");
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public DateOnly Birthday { get; set; }
    }
}