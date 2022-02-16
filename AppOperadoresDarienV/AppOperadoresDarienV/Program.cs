namespace Operaciones {

    class Program {
        static void Main (string[] args) 
        {
            //Título
            Console.WriteLine("Programa suma y promedio");

            //Declaración de variables
            float num1, num2, num3, num4, suma,promedio;
        
            //Solicitar datos
            Console.WriteLine("Digite número 1: ");
            num1 = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite número 2: ");
            num2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite número 3: ");
            num3 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite número 4: ");
            num4 = float.Parse(Console.ReadLine());

            //Operaciones
            suma = num1 + num2 + num3 + num4;
            promedio = suma / 4;

            //Resultado
            Console.WriteLine("La suma de las notas es: " + suma);
            Console.WriteLine("El promedio es: " + promedio);
            Console.ReadKey();

        }

    } 
}