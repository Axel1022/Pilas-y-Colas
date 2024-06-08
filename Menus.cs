using PylayCola.cola;
using PylayCola.pila;
namespace PylayCola.menus
{
    class Menus
    {

        public void menuCola()
        {
            short opcion;
            bool running = true;
            Cola colaEstudiante = Cola.getInstancia();
            string? Nombre;


            while (running)
            {
                Console.Clear();
                System.Console.WriteLine("------------------- Menu Cola Estudiantes -------------------");
                System.Console.WriteLine("1. Enqueue (Añadir estudiante)");
                System.Console.WriteLine("2. Dequeue (Remover y devolver el estudiante)");
                System.Console.WriteLine("3. Peek (Devolver el primer estudiante)");
                System.Console.WriteLine("4. Count (Obtener el número de estudiantes)");
                System.Console.WriteLine("5. List (Lista los estudiantes)");
                System.Console.WriteLine("0. Salir");
                System.Console.Write("Elija la opcion que desee:");
                opcion = short.Parse(System.Console.ReadLine()!);

                switch (opcion)
                {
                    case 0:
                        running = false;
                        System.Console.WriteLine("Saliendo de Menu Cola");
                        System.Console.WriteLine("Precione una tecla para continuar.");
                        Console.ReadKey();
                        break;
                    case 1:
                        Console.Clear();
                        System.Console.WriteLine("------------ Enqueue (Añadir estudiante) ------------");
                        System.Console.Write("Nombre del estudiante: ");
                        Nombre = Console.ReadLine();
                        colaEstudiante.Enqueue(Nombre!);
                        System.Console.WriteLine("Agregado correctamente.");
                        System.Console.WriteLine("Precione una tecla para continuar.");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        System.Console.WriteLine("------------ Dequeue (Remover y devolver el primer estudiante) ------------");
                        Nombre = colaEstudiante.Dequeue();
                        if (Nombre != "Lista vacia")
                        {
                            System.Console.WriteLine($"Estudiante: {Nombre}");
                        }
                        else
                        {
                            System.Console.WriteLine(Nombre);
                        }
                        System.Console.WriteLine("Precione una tecla para continuar.");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        System.Console.WriteLine("------------ Peek (Devolver el primer estudiante) ------------");
                        Nombre = colaEstudiante.Peek();
                        if (Nombre != "Lista vacia")
                        {
                            System.Console.WriteLine($"Estudiante:{Nombre}");
                        }
                        else
                        {
                            System.Console.WriteLine(Nombre);
                        }
                        System.Console.WriteLine("Precione una tecla para continuar.");
                        Console.ReadKey();
                        break;

                    case 4:
                        Console.Clear();
                        System.Console.WriteLine("------------ Count (Obtener el número de estudiantes) ------------");
                        string Cantidad = colaEstudiante.Count();
                        System.Console.WriteLine($"Cantidad: {Cantidad}");
                        System.Console.WriteLine("Precione una tecla para continuar.");
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Clear();
                        System.Console.WriteLine("------------ List (Lista los estudiantes) ------------");
                        string[] ArrayList = colaEstudiante.Get();
                        System.Console.WriteLine("Lista de estudiantes: ");
                        if (ArrayList.Length > 0)
                        {
                            for (int i = 0; i < ArrayList.Length; i++)
                            {
                                System.Console.WriteLine($"{i}. {ArrayList[i]}");
                            }
                        }
                        else
                        {
                            System.Console.WriteLine("Lista vacia.");
                        }
                        System.Console.WriteLine("Precione una tecla para continuar.");
                        Console.ReadKey();
                        break;
                    default:
                        Console.Clear();
                        System.Console.WriteLine("Opcion incorrecta");
                        System.Console.WriteLine("Precione una tecla para continuar.");
                        Console.ReadKey();
                        break;

                }
            }
        }
        public void menuPila()
        {
            short opcion;
            bool running = true;
            Pila Pila = Pila.getInstancia();
            string? Nombre;


            while (running)
            {
                Console.Clear();
                System.Console.WriteLine("------------------- Menu Pila Estudiantes -------------------");
                System.Console.WriteLine("1. Push (Añadir un estudiante)");
                System.Console.WriteLine("2. Pop (Remover y devolver el estudiante)");
                System.Console.WriteLine("3. Peek (Devolver el primer estudiante)");
                System.Console.WriteLine("4. Count (Obtener el número de estudiantes)");
                System.Console.WriteLine("5. List (Lista los estudiantes)");
                System.Console.WriteLine("0. Salir");
                System.Console.Write("Elija la opcion que desee:");
                opcion = short.Parse(System.Console.ReadLine()!);

                switch (opcion)
                {
                    case 0:
                        running = false;
                        System.Console.WriteLine("Saliendo de Menu Pila");
                        System.Console.WriteLine("Precione una tecla para continuar.");
                        Console.ReadKey();
                        break;
                    case 1:
                        Console.Clear();
                        System.Console.WriteLine("------------ Enqueue (Añadir estudiante) ------------");
                        System.Console.Write("Nombre del estudiante: ");
                        Nombre = Console.ReadLine();
                        Pila.Push(Nombre!);
                        System.Console.WriteLine("Agregado correctamente.");
                        System.Console.WriteLine("Precione una tecla para continuar.");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        System.Console.WriteLine("------------ Dequeue (Remover y devolver el primer estudiante) ------------");
                        Nombre = Pila.Pop();
                        if (Nombre != "Lista vacia")
                        {
                            System.Console.WriteLine($"Estudiante: {Nombre}");
                        }
                        else
                        {
                            System.Console.WriteLine(Nombre);
                        }
                        System.Console.WriteLine("Precione una tecla para continuar.");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        System.Console.WriteLine("------------ Peek (Devolver el primer estudiante) ------------");
                        Nombre = Pila.Peek();
                        if (Nombre != "Lista vacia")
                        {
                            System.Console.WriteLine($"Estudiante:{Nombre}");
                        }
                        else
                        {
                            System.Console.WriteLine(Nombre);
                        }
                        System.Console.WriteLine("Precione una tecla para continuar.");
                        Console.ReadKey();
                        break;

                    case 4:
                        Console.Clear();
                        System.Console.WriteLine("------------ Count (Obtener el número de estudiantes) ------------");
                        string Cantidad = Pila.Count();
                        System.Console.WriteLine($"Cantidad: {Cantidad}");
                        System.Console.WriteLine("Precione una tecla para continuar.");
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Clear();
                        System.Console.WriteLine("------------ List (Lista los estudiantes) ------------");
                        string[] ArrayList = Pila.Get();
                        System.Console.WriteLine("Lista de estudiantes: ");

                        if (ArrayList.Length > 0)
                        {
                            for (int i = 0; i < ArrayList.Length; i++)
                            {
                                System.Console.WriteLine($"{i}. {ArrayList[i]}");
                            }
                        }
                        else
                        {
                            System.Console.WriteLine("Lista vacia.");
                        }

                        System.Console.WriteLine("Precione una tecla para continuar.");
                        Console.ReadKey();
                        break;
                    default:
                        Console.Clear();
                        System.Console.WriteLine("Opcion incorrecta");
                        System.Console.WriteLine("Precione una tecla para continuar.");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
