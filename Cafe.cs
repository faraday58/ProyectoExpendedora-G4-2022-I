using System;
namespace ProyectoExpendedora_G4_2022_I
{
    class Cafe:Expendedora
    {
        public Cafe()
        {
            Marca = "AMSN";
            CantProductos = 100;
            Precio = 15;
            Temperatura = 70;
            Saludar();
            TiempoDespliegue();
            Console.WriteLine("Marca: {0}", Marca);
            TiempoDespliegue();
            Console.WriteLine("Temperatura: {0} [°C] ", 70);
            TiempoDespliegue();
            
        }

    }
}
