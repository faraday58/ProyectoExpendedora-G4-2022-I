using System;

namespace ProyectoExpendedora_G4_2022_I
{
    class TiendaExpendedoras
    {
        static void Main()
        {
            /*Expendedora miNuevaExpendedora = new Expendedora();
            Console.WriteLine("***********************************");
            Console.WriteLine("Ingresa la marca de la expendedora que deseas probar  ");
            string marca = Console.ReadLine();
            Expendedora miExpendedoraPrueba = new Expendedora(marca);
            Console.WriteLine("***********************************");*/
             //Console.WriteLine("Ingresa la cantidad de productos de la expendedora que deseas probar  ");
             //ushort cantProductos =Convert.ToUInt16( Console.ReadLine());
             //string cantPrductos = Console.ReadLine();
            /* Snack miSnack = new Snack();

             for (int i = 0; i < 10; i++)
             {
                 miSnack.ElevarTemperatura();
             }
            miSnack.MostrarTemperatura();
            */
            
              
            Cafe miExpendedoraCafe = new Cafe();
            miExpendedoraCafe.ElevarTemperatura();
            miExpendedoraCafe.MostrarTemperatura();


            Console.ReadLine();
        }
    }
}
