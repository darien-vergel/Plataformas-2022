namespace AppForEachNotas

{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            int limite,mayores=0,menores=0;
            float nota;

            //Leer limite
            Console.WriteLine("Digite el limite de notas: ");
            limite = int.Parse(Console.ReadLine());
            //Crear Array (Vector)
            float[] notas = new float[limite];
            //Insertar Notas
            for (int contador = 1; contador <= limite; contador++)
            {
                Console.WriteLine("Digite nota " + contador +": ");
                nota = float.Parse(Console.ReadLine());
                notas[contador-1] = nota;
            }
            foreach (float nota2 in notas)
            {
                if (nota2 >= 3)
                {
                    mayores += 1;
                }
                else 
                {
                    menores += 1;
                }
            }

            Console.WriteLine("Las notas mayores son: " + mayores);
            Console.WriteLine("Las notas menores son: " + menores);
            Console.ReadKey();




        }

    }
}