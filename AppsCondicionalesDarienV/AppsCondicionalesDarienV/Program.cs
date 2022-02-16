namespace AppCondicionales
{
        class Program
    {
        static void Main(string[] args)
        {
            //Título
            Console.WriteLine("Aplicación condicionales IF");

            //Declaración de variables
            int numero;

            //Solicitar datos
            Console.WriteLine("Ingrese un número: ");
            numero = int.Parse(Console.ReadLine());

            //Condicionales

            if (numero < 10)
            {
                Console.WriteLine("El número tiene un digito");
            }
            else if (numero <= 99)
            {
                Console.WriteLine("El número tiene dos digito");
            }
            else 
            {
                Console.WriteLine("El número tiene más de dos digitos");
            }

            Console.ReadKey();
        }

    }
}