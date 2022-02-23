namespace AppFor2DarienV

{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            int numero = 0, limite = 0, mayores=0, menores=0;

            Console.WriteLine("Programa Sentencia For 2");

            Console.WriteLine("Digite el limte del números");
            limite = int.Parse(Console.ReadLine());
                     

            for (int contador = 0; contador < limite; contador++)
            {
                Console.WriteLine("Digite el número");
                numero = int.Parse(Console.ReadLine());

                if (numero >= 1000)
                {
                    mayores += 1;
                }
                else
                {
                    menores += 1;
                }
            }

            Console.WriteLine("Los números mayores son: " + mayores);
            Console.WriteLine("Los números menores son: " + menores);
            Console.ReadKey();
        }

    }
}