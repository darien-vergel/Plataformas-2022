namespace AppForEach

{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            int[] sueldos = new int[5];

            Console.WriteLine("Programa Sentencia For Each");         

            for (int contador = 0; contador < 5; contador++)
            {
                Console.WriteLine("Digite el sueldo: " );
                sueldos[contador] = int.Parse(Console.ReadLine());
            }

            foreach (int sueldo in sueldos) 
            {
                Console.WriteLine(sueldo);
            }
            Console.WriteLine();

        }

    }
}