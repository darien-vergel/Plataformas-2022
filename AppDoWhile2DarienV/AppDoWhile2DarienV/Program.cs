namespace AppDoWhileValores

{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            int numero, suma = 0, contador = 0;
           
            Console.WriteLine("Programa Valores Sentencia Do While");
            //Ciclo Do While
            do
            {
                Console.WriteLine("Digite valor");
                numero = int.Parse(Console.ReadLine());
                if (numero != 9999)
                {
                suma += numero;
                }
                contador += 1;
            
            } while
            (numero != 9999);

            //Imprimir Resultado

            if (suma == 0)
            {
                Console.WriteLine("La suma es: " + suma);
            }
            else if (suma <= 0)
            {
                Console.WriteLine("La suma es menor: " + suma);
            }
            else 
            {
                Console.WriteLine("La suma es mayor: " + suma);
            }
                    
            Console.ReadKey();


        }

    }
}