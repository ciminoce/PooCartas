using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using PooCartas.Entidades.Properties;

namespace PooCartas.Entidades
{
    public class Mazo
    {
        private Carta[] cartas;
        private readonly int NumeroDeCartas;

        private Image imagenCartas;

        public Mazo(int numCartas)
        {
            NumeroDeCartas = numCartas;
            cartas = new Carta[NumeroDeCartas];
            string[] valores = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" };
            string[] palos = new string[] { "Oros", "Copas", "Espadas", "Bastos" };

            int altura = 164;
            int ancho = 107;

            imagenCartas = new Bitmap(Properties.Resources.Baraja_española_completa);

            for (int paloIndex = 0; paloIndex < palos.Length; paloIndex++)
            {
                for (int valorIndex = 0; valorIndex < valores.Length; valorIndex++)
                {
                    Point x1 = new Point(valorIndex * ancho, paloIndex * altura);

                    Rectangle section = new Rectangle(x1, new Size(ancho, altura));
                    Bitmap imagenCartaTemp = CropImage(imagenCartas, section);

                    cartas[(12 * paloIndex) + valorIndex] = new Carta()
                    {
                        Valor = valores[valorIndex],
                        Palo = palos[paloIndex],
                        Imagen = imagenCartaTemp

                    };
                }
            }

        }

        private Bitmap CropImage(Image todas, Rectangle section)
        {
            var bitmap = new Bitmap(section.Width, section.Height);
            using (var g = Graphics.FromImage(bitmap))
            {
                g.DrawImage(todas, 0, 0, section, GraphicsUnit.Pixel);
                return bitmap;
            }
        }

        public Carta[] GetCartas()
        {
            return cartas;
        }

        public void Barajar()
        {
            Random r = new Random(new Guid().GetHashCode());
            for (int indiceCarta = 0; indiceCarta < cartas.Length; indiceCarta++)
            {
                int indiceAleatorio = r.Next(0, 48);

                Carta cartaTemp = cartas[indiceCarta];
                cartas[indiceCarta] = cartas[indiceAleatorio];
                cartas[indiceAleatorio] = cartaTemp;
            }
        }

        public Carta GetCarta(int indexCarta)
        {
            if (indexCarta < 0 || indexCarta > 47)
            {
                throw new Exception("Índice fuera del rango permitido");
            }
            return cartas[indexCarta];
        }
    }
}
