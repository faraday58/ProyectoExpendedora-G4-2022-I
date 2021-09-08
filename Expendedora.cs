using System;
using System.Threading;
namespace ProyectoExpendedora_G4_2022_I
{
    class Expendedora
    {
        #region Atributos (Campos)
        private string marca;
        private ushort cantProductos;
        private float precio;
        private byte temperatura;
        #endregion

        public Expendedora()
        {
            marca = "AMS";
            cantProductos = 430;
            precio = 15;
            temperatura = 14;
            Saludar();
            TiempoDespliegue();
            Console.WriteLine("Marca: {0}", marca);
            TiempoDespliegue();
            Console.WriteLine("Temperatura: {0} [°C] ", temperatura);
            TiempoDespliegue();
            string codigo=MostrarCodigoProducto();
            TiempoDespliegue();
            MostrarPrecio(codigo);
        }

        public Expendedora(string marca)
        {
            this.marca = marca;
            Saludar();
            TiempoDespliegue();
            Console.WriteLine("Marca: {0}", marca);
            
        }

        public Expendedora(ushort cantProductos)
        {
            marca = "AMS";
            this.cantProductos = cantProductos;
            Saludar();
            TiempoDespliegue();
            Console.WriteLine("Marca: {0}  \n Cantidad de Productos: {1}", marca, this.cantProductos);

        }
        public Expendedora(string marca,ushort cantProductos)
        {
            this.marca = marca;
            this.cantProductos= cantProductos;


        }

        public string MostrarCodigoProducto()
        {
            //Variable local
            string codigo;
            Console.WriteLine("1A: Papas \n 2A: Doritos \n 3B: Jugo");
            Console.WriteLine("Ingrese el código del producto a elegir:");
            codigo = Console.ReadLine();
            return codigo;
        }

        public void MostrarPrecio(string codigo)
        {
            switch(codigo)
            {
                case "1A":
                    Console.WriteLine("Precio: ${0}", precio);
                    break;
                case "2A":
                    Console.WriteLine("Precio: ${0}", precio-1);
                    break;
                case "3B":
                    Console.WriteLine("Precio: ${0}", precio+2);
                    break;
                default:
                    Console.WriteLine(" Ingrese un código válido ");
                    break;
            }

        }

        #region Métodos
        public void cambiarTemperatura()
        {
            temperatura--; //temperatura=temperatura - 1
            TiempoDespliegue();
            Console.WriteLine("Temperatura: {0} [°C] ", temperatura);

        }

        public void Saludar()
        {
            Console.WriteLine("****Bienvenido*****");
        }


        public void TiempoDespliegue()
        {
            Thread.Sleep(3000);
            Console.Clear();
        }


        #endregion

    }
}
