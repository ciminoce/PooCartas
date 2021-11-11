using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooCartas.Entidades
{
    public class Carta
    {
        public string Valor { get; set; }
        public string Palo { get; set; }
        public Image Imagen { get; set; }
        public override string ToString()
        {
            return $"{Valor} {Palo.ToUpper()}";
        }
    }
}
