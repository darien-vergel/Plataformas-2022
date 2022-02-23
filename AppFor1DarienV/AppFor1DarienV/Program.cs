namespace AppDoWhileValores

{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            float nota;
            int contador2 = 0, contador3 = 0;

            Console.WriteLine("Programa Sentencia For");
            for (int contador1 = 1; contador1 <= 10 ; contador1++)
            {
                Console.WriteLine("Digite nota " + contador1 + ": ") ;
                nota = float.Parse(Console.ReadLine());

                if (nota == 3 || nota >= 3)
                {
                    contador2++;
                }
                else
                {
                    contador3++;
                }

            }

            Console.WriteLine("Las notas mayores o iguales a 3 son: " + contador2);
            Console.WriteLine("Las notas menores que 3 son: " + contador3);
            Console.ReadKey();



        }

    }
}