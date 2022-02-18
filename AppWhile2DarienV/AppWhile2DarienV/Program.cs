namespace AppWhile2DarienV
{
    class Program
    {
        static void Main(string[] args)
        {
            //Título
            Console.WriteLine("Programa Incremento Número While");

            //Declaración de variables
            int num=0, contador = 0;

            //Solicitar datos
            Console.WriteLine("Digite un número");
            num = Math.Abs(int.Parse(Console.ReadLine()));

            //While

            while (contador < num)
            {
                contador++;
                Console.WriteLine(" - " + contador);
            }

            Console.ReadKey();

        }
     }
}