using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace RepartoSushi
{

    class RepartoSushi
    {
        int UnidadesDisponibles = 10;
        int UnidadesRealizandoEnvios = 0;
        public RepartoSushi()
        {
            /*que establezca la cantidad de UnidadesDisponibles en 10 y UnidadesRealizandoEnvios 
             * en 0.*/
            UnidadesDisponibles = 10;
            UnidadesRealizandoEnvios = 0;

        }
        public RepartoSushi(int UnidadesEnviadas)
        {
            /* Constructor con un numero indicado de unidades realizando envíos. 
                Si la cantidad de unidades realizando envíos es mayor que el número 
                máximo de unidades disponibles, la ajustará al máximo.*/

            if (UnidadesRealizandoEnvios >= UnidadesDisponibles)
            {
                UnidadesRealizandoEnvios = 10;
            }

        }
        public RepartoSushi(RepartoSushi TotalUnidadesEnviadas) 
        {
            /* Constructor con todas las unidades realizando envíos que establece 
             * la cantidad de UnidadesDisponibles en 0 y UnidadesRealizandoEnvios en 10.*/
            Console.WriteLine(UnidadesRealizandoEnvios);
        }
        public void RealizarEnvio()
                    {
            /* el cual simula el envío de un pedido de Sushi, traslada una unidad 
            de las UnidadesDisponibles a UnidadesRealizandoEnvios.*/
            String CantidadUnidades;
            Console.WriteLine("\nCuantas Piezas se Solicitan: ");
            CantidadUnidades = (Console.ReadLine());
            UnidadesDisponibles = UnidadesDisponibles - int.Parse(CantidadUnidades);
            UnidadesRealizandoEnvios = UnidadesRealizandoEnvios + 1;

            UnidadesDisponibles = UnidadesDisponibles - 1;
            UnidadesRealizandoEnvios = UnidadesRealizandoEnvios + 1;
            
        }

        public void EnvioCompletado()
        {
            /* simula la acción de la llegada de una unidad que ha entregado Sushi, 
             * traslada una unidad de UnidadesRealizandoEnvios a UnidadesDisponibles */
            UnidadesRealizandoEnvios = UnidadesRealizandoEnvios - 1;
            UnidadesDisponibles = UnidadesDisponibles + 1;
        }
        public void ConsultarUnidades()
        {
            /* muestra la cantidad de unidades Disponibles y la cantidad de unidades 
               Realizando Envíos.*/
            Console.WriteLine("\nLas unidades de sushi disponibles son: " + UnidadesDisponibles);
        }
    }
}
