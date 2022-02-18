namespace AppSwitch1DarienV
{
    class Program
    {
        static void Main(string[] args)
        {
            //Título
            Console.WriteLine("Programa 1 sentencia Switch");

            //Declaración de variables
            String num;

            //Solicitar datos
            Console.WriteLine("Digitite un número en texto");         
            num = Console.ReadLine();

            //Switch

            switch (num.ToUpper())
            {
                case "UNO":
                    Console.WriteLine(" 1 ");
                    break;
                case "DOS":
                    Console.WriteLine(" 2 ");
                    break;
                case "TRES":
                    Console.WriteLine(" 3 ");
                    break;
                case "CUATRO":
                    Console.WriteLine(" 4 ");
                    break;
                case "CINCO":
                    Console.WriteLine(" 5 ");
                    break;
                default:
                    Console.WriteLine(" Fuera de rango ");
                    break;
            }

            Console.ReadKey();
        }

    }
}