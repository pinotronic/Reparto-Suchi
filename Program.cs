using System;

namespace RepartoSushi
{
    class Program
    {
        static void Main(string[] args)
        {
            // CARGAR OBJETOS
            Menu menu = new Menu();
            RepartoSushi repartoShushi = new RepartoSushi();

            // MOSTRAR BIENVENIDA
            menu.Menus();

            // MOSTRAR UNIDADES DISPONIBLES
            repartoShushi.ConsultarUnidades();



            // PEDIR UNIDADES PARA ENVIAR
            //  
            int Opcion = 0;
            Console.WriteLine("\nElige una Opcion");
            Console.WriteLine("1. Salida de Unidad");
            Console.WriteLine("2. Llegada de Unidad");
            
            Opcion = Convert.ToInt32(Console.ReadLine());

            switch (Opcion)
            {  
                case 1:
                    Console.WriteLine("Sale 1 Unidad");
                    break;
                case 2:
                    Console.WriteLine("Llega 1 Unidad");
                    break;

            }
        }
    }
}
