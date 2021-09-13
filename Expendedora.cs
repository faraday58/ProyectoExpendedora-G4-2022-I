using System;
using System.Threading;
namespace ProyectoExpendedora_G4_2022_I
{
   abstract class Expendedora
    {
        #region Atributos (Campos)
        private string marca;
        private ushort cantProductos;
        private float precio;
        private byte temperatura;

        #endregion

        #region Propiedades
        public byte Temperatura { 
            get => temperatura;
            set { 
                if( value < 14 || value > 20   )
                {
                    temperatura = 14;
                }
                else
                {
                    temperatura = value;
                }
                
            }
        }

        public string Marca {  get => marca; set => marca = value; }
        public ushort CantProductos { 
            get => cantProductos;
            set
            {
                if (value < 400 || value > 700)
                {
                    cantProductos = 400;
                }
                else
                {
                    cantProductos = value;
                }

            }
        }
        public float Precio { get => precio; set => precio = value; }
        #endregion


        public Expendedora()
        {
        }

        public Expendedora(string marca)
        {
            this.Marca = marca;
            Saludar();
            TiempoDespliegue();
            Console.WriteLine("Marca: {0}", marca);
            
        }

        public Expendedora(ushort cantProductos)
        {
            Marca = "AMS";
            this.CantProductos = cantProductos;
            Saludar();
            TiempoDespliegue();
            Console.WriteLine("Marca: {0}  \n Cantidad de Productos: {1}", Marca, this.CantProductos);

        }
        public Expendedora(string marca,ushort cantProductos)
        {
            this.Marca = marca;
            this.CantProductos= cantProductos;


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
                    Console.WriteLine("Precio: ${0}", Precio);
                    break;
                case "2A":
                    Console.WriteLine("Precio: ${0}", Precio-1);
                    break;
                case "3B":
                    Console.WriteLine("Precio: ${0}", Precio+2);
                    break;
                default:
                    Console.WriteLine(" Ingrese un código válido ");
                    break;
            }

        }

        #region Métodos
        public void ElevarTemperatura()
        {
            Temperatura++; //temperatura=temperatura + 1           

        }

        public void MostrarTemperatura()
        {
            Console.WriteLine("Temperatura: {0} [°C]",Temperatura);
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
