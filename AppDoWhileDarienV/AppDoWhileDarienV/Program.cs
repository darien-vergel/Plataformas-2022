namespace AppDoWhileProm

{
    class Program 
    {
    static void Main(string[] args) 
        {
            //Variables
            int numero, suma=0, contador=0;
            float promedio;

            Console.WriteLine("Programa Promedio Sentencia Do While");
            //Ciclo Do While
            do
            {
                Console.WriteLine("Digite Número");
                numero = int.Parse(Console.ReadLine());
                suma += numero;
                contador +=1;

            } while
            (numero != 0);

            //Operaciones
            promedio = suma / (contador-1);

            //Imprimir Resultado
            Console.WriteLine("Promedio: " + promedio);
            Console.ReadKey();


        }

    }
}