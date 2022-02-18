namespace AppWhile3DarienV
{
    class Program
    {
        static void Main(string[] args)
        {
            //Título
            Console.WriteLine("Programa 10 Valores");

            //Declaración de variables
            int num=0, contador = 0;
            float  suma, promedio;
            //Solicitar datos
            Console.WriteLine("Digite un número 1: ");
            num = int.Parse(Console.ReadLine());

            //While

            while (contador < num)
            {
                contador++;
               
            }

            Console.ReadKey();

        }
    }
}