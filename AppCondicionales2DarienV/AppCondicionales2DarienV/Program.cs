namespace AppCondicionales2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Título
            Console.WriteLine("Aplicación condicionales IF");

            //Declaración de variables
            double num1,num2,suma,diferencia, producto, division;
            
            //Solicitar datos
            Console.WriteLine("Ingrese el número 1: ");
            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el número 2: ");
            num2 = double.Parse(Console.ReadLine());

            //Condicionales

            if (num1 > num2)
            {
                suma = num1 + num2;
                diferencia = num1 - num2;
                Console.WriteLine("La suma de los números es: " + suma + " y su diferencia es de: " + diferencia);
            }
            else {
                producto = num1 * num2;
                division = num1 / num2;
                Console.WriteLine("El producto de los números es: " + producto + " y su división es: " + division);
            }

        }

    }
}