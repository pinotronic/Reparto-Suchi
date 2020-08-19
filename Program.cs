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
            repartoShushi.PeticionServicio();
        }
    }
}
