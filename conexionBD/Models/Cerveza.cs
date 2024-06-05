using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaUno.Models
{
    internal class Cerveza : Bebida, IBebidaAlcoholica
    {
        public Cerveza(int Cantidad, string Nombre, string Marca)
            : base(Nombre, Cantidad, Marca)
        {
        }

        public Cerveza()
        {

        }

        public Cerveza(int cantidad, string nombre)
        {
            this.cantidad = cantidad;
            this.nombre = nombre;
        }

        public int alcohol { get; set; }

        public void maxRecomendado()
        {
            Console.WriteLine("El maximo permito de birras es cinco latas por persona");
        }

    }
}
