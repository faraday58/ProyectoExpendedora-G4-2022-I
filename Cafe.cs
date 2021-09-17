using System;
namespace ProyectoExpendedora_G4_2022_I
{
    class Cafe:Expendedora
    {

        public override byte Temperatura { 
            get => base.Temperatura;
            set
            {
                if( value < 70 || value > 75)
                {
                    temperatura = 70;
                }
                else
                {
                    temperatura = value;
                }

            }
        }


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
            Console.WriteLine("Temperatura: {0} [°C] ", Temperatura);
            TiempoDespliegue();
            MostrarCodigoProducto();
          
        }

        public override string MostrarCodigoProducto()
        {
            string codigo;
            Console.WriteLine("Ingrese el código del producto deseado \n 23A: Americano \n 25B: Capuchino  ");
            codigo = Console.ReadLine();

            return codigo;
        }

    }
}
