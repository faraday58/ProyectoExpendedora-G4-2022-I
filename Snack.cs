using System;

namespace ProyectoExpendedora_G4_2022_I
{
    class Snack:Expendedora
    {
        public Snack()
        {
            Marca = "AMS";
            CantProductos = 430;
            Precio = 15;
            Temperatura = 14;
            Saludar();
            TiempoDespliegue();
            Console.WriteLine("Marca: {0}", Marca);
            TiempoDespliegue();
            Console.WriteLine("Temperatura: {0} [°C] ", Temperatura);
            TiempoDespliegue();
            string codigo = MostrarCodigoProducto();
            TiempoDespliegue();
            MostrarPrecio(codigo);
        }
    }
}
