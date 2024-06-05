using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaUno.Models
{
    internal class Vino : Bebida, IBebidaAlcoholica
    {
        public Vino(int v1, string v2)
        {
        }

        public Vino(int Cantidad, string Nombre, string Marca)
            : base(Nombre, Cantidad, Marca)
        {
        }

        public int alcohol { get; set; }

        public void maxRecomendado()
        {
            Console.WriteLine("El maximo permito de vinos es dos botellas por persona");
        }

    }
}
