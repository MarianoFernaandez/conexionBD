using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaUno.Models
{
    internal class Bebida
    {
        public string nombre { get; set; }
        public int cantidad { get; set; }

        public string marca { get; set; }

        /*
           get { return _nombre; }
           set { _nombre = value; }
       */

        public string GetNombre()
        {
            return nombre;
        }
        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void setCantidad(int cantidad)
        {
            this.cantidad = cantidad;
        }

        public string GetMarca()
        {
            return marca;
        }
        public void SetMarca (string marca)
        {
            this.marca = marca;
        }

        public Bebida(string nombre, int cantidad, string marca)
        {
            this.nombre = nombre;
            this.cantidad = cantidad;
        }

        public Bebida() { }

        public Bebida(string v1, int v2)
        {
        }

        public void tomarse(int cuantoBebio)
        {
            this.cantidad -= cuantoBebio;
        }
    }
}
