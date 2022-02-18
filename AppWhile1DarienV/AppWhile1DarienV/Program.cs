namespace AppWhile1DarienV
{
    class Program
    {
        static void Main(string[] args)
        {
            //Título
            Console.WriteLine("Programa Piezas While");

            //Declaración de variables
            int piezas, aptas=0,contador=0;
            float longitud;

            //Solicitar datos
            Console.WriteLine("Digite un número de piezas");
            piezas = int.Parse(Console.ReadLine());

                      
            //While

            while (contador<piezas) 
            {
                Console.WriteLine("Digitite la longitud de las piezas");
                longitud = float.Parse(Console.ReadLine());
                if (longitud >= 1.20 && longitud <= 1.3) 
                {
                    aptas += 1;
                }
                contador ++;
            }
            Console.WriteLine("Son aptas: " + aptas);

            Console.ReadKey();


        }

    }
}