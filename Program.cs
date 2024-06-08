using PylayCola.menus;
namespace PylayCola.Main
{
    //Pila y cola

    internal class Program
    {
        private static void Main(string[] args)
        {
            short opcion = 0;
            Menus menu = new Menus();
            bool running = true;
            while (running)
            {
                Console.Clear();
                System.Console.WriteLine("------------- Cola y Pila-------------");
                System.Console.WriteLine("1. Pila");
                System.Console.WriteLine("2. Cola");
                System.Console.WriteLine("0. Salir");
                System.Console.Write("Elija la opcion que desee: ");
                opcion = short.Parse(Console.ReadLine()!);
                switch (opcion)
                {
                    case 0:
                        running = false;
                    break;
                    case 1:
                        menu.menuCola();
                        break;
                    case 2:
                        menu.menuPila();
                        break;

                }

            }
        }
    }

}
