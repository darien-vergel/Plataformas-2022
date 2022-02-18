namespace AppSwitch1DarienV
{
    class Program
    {
        static void Main(string[] args)
        {
            //Título
            Console.WriteLine("Programa 1 sentencia Switch");

            //Declaración de variables
            int num;

            //Solicitar datos
            Console.WriteLine("Digitite un número");
            num = int.Parse(Console.ReadLine());


            //Switch

            switch (num)
            {
                case 1: Console.WriteLine(" UNO ");
                    break;
                case 2: Console.WriteLine(" DOS ");
                    break;
                case 3:
                    Console.WriteLine(" TRES ");
                    break;
                case 4:
                    Console.WriteLine(" CUATRO ");
                    break;
                case 5:
                    Console.WriteLine(" CINCO ");
                    break;
                default: Console.WriteLine(" Fuera de rango ");
                    break;
            }

            Console.ReadKey();
        }

    }
}