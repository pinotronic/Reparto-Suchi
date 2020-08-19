using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace RepartoSushi
{

    class RepartoSushi
    {
        private String _unidadesDisponibles;
        private String _unidadesRealizandoEnvios;
        public String UnidadesDisponibles
        {
            get
            {
                return _unidadesDisponibles;
            }

            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    _unidadesDisponibles = value;
                }
            }
        }


        public String UnidadesRealizandoEnvios
        {
            get
            {
                return _unidadesRealizandoEnvios;
            }

            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    _unidadesRealizandoEnvios = value;
                }
            }
        }

        public RepartoSushi()
        {
            /*que establezca la cantidad de UnidadesDisponibles en 10 y UnidadesRealizandoEnvios 
             * en 0.*/
            _unidadesDisponibles = "10";
            _unidadesRealizandoEnvios = "0";

        }
        public RepartoSushi(int UnidadesEnviadas)
        {
            /* Constructor con un numero indicado de unidades realizando envíos. 
                Si la cantidad de unidades realizando envíos es mayor que el número 
                máximo de unidades disponibles, la ajustará al máximo.*/

            if (int.Parse(_unidadesRealizandoEnvios) >= int.Parse(_unidadesDisponibles))
            {
                _unidadesRealizandoEnvios = "10";
            }

        }
        public RepartoSushi(RepartoSushi TotalUnidadesEnviadas) 
        {
            /* Constructor con todas las unidades realizando envíos que establece 
             * la cantidad de UnidadesDisponibles en 0 y UnidadesRealizandoEnvios en 10.*/
            Console.WriteLine(_unidadesRealizandoEnvios);
        }
        public void RealizarEnvio()
                    {
            /* el cual simula el envío de un pedido de Sushi, traslada una unidad 
            de las UnidadesDisponibles a UnidadesRealizandoEnvios.*/
            int CantidadUnidadesDisponibles;
            int CantidadUnidadesEnviadas;

            CantidadUnidadesDisponibles = int.Parse(_unidadesDisponibles) - 1;
            _unidadesDisponibles = CantidadUnidadesDisponibles.ToString();
            CantidadUnidadesEnviadas = int.Parse(_unidadesRealizandoEnvios) + 1;
            _unidadesRealizandoEnvios = CantidadUnidadesEnviadas.ToString();
            ConsultarUnidades();

        }
        


        public void EnvioCompletado()
        {
            /* simula la acción de la llegada de una unidad que ha entregado Sushi, 
             * traslada una unidad de UnidadesRealizandoEnvios a UnidadesDisponibles */
            int CantidadUnidadesDisponibles;
            int CantidadUnidadesEnviadas;

            CantidadUnidadesDisponibles = int.Parse(_unidadesRealizandoEnvios) - 1;
            _unidadesRealizandoEnvios = CantidadUnidadesDisponibles.ToString();
            CantidadUnidadesEnviadas = int.Parse(_unidadesDisponibles) + 1;
            _unidadesDisponibles = CantidadUnidadesEnviadas.ToString();

            ConsultarUnidades();

        }
        public void ConsultarUnidades()
        {
            /* muestra la cantidad de unidades Disponibles y la cantidad de unidades 
               Realizando Envíos.*/
            Console.WriteLine("\nLas Unidades enviadas son: " + _unidadesRealizandoEnvios);
            Console.WriteLine("Las Unidades Disponibles son: " + _unidadesDisponibles);
            Console.ReadKey();

        }
        public void PeticionServicio()
        {
            Menu menu = new Menu();
            int Opcion = 0;
            Console.WriteLine("\nElige una Opcion");
            Console.WriteLine("1. Salida de Unidad");
            Console.WriteLine("2. Llegada de Unidad");
            Console.WriteLine("3. Terminar");

            Opcion = Convert.ToInt32(Console.ReadLine());

            switch (Opcion)
            {
                case 1:
                    Console.WriteLine("Sale 1 Unidad");
                    if (_unidadesDisponibles == "0" & _unidadesRealizandoEnvios == "10")
                    {
                        _unidadesDisponibles = "0";
                        _unidadesRealizandoEnvios = "10";
                        Console.WriteLine("No hay unidades disponibles");
                    }
                    else
                    {
                        RealizarEnvio();
                    }
                    
                    Console.Clear();
                    menu.Menus();
                    PeticionServicio();
                    break;
                case 2:
                    Console.WriteLine("Llega 1 Unidad");
                    if (_unidadesDisponibles == "10" & _unidadesRealizandoEnvios == "0")
                    {
                        _unidadesDisponibles = "10";
                        _unidadesRealizandoEnvios = "0";
                        Console.WriteLine("No hay pedidos");
                    }
                    else
                    {
                        EnvioCompletado();
                    }
                        
                    Console.Clear();
                    menu.Menus();
                    PeticionServicio();
                    break;

                case 3:
                    Console.WriteLine("\nGracias por utilizar nuestros servicios\n");
                    Environment.Exit(0);
                    break;

            }
        }
    }
}
