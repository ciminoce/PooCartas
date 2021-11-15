using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PooCartas.Entidades;

namespace PooCartas.Windows
{
    public partial class FrmVerTodas : Form
    {
        public FrmVerTodas()
        {
            InitializeComponent();
        }

        private void FrmVerTodas_Load(object sender, EventArgs e)
        {
            CrearBotonBarajar();
            MostrarCartas(Mazo.GetInstancia().GetCartas());
        }

        private void CrearBotonBarajar()
        {
            this.BarajarButton.Location = new System.Drawing.Point(1393, 750);
            this.BarajarButton.Name = "BarajarButton";
            this.BarajarButton.Size = new System.Drawing.Size(89, 49);
            this.BarajarButton.TabIndex = 0;
            this.BarajarButton.Text = "Barajar";
            this.BarajarButton.UseVisualStyleBackColor = true;
            this.BarajarButton.Click += new System.EventHandler(this.BarajarButton_Click);
            this.panel1.Controls.Add(BarajarButton);
        }

        private void MostrarCartas(Carta[] cartas)
        {
            int contadorCartas = 0;
            int topeCartasPorPalo = 12;
            int contadorFilas = 0;

            int gapColumna = 0;
            int gapFila = 0;
            int anchoPicture = 119;
            int alturaPicture = 182;

            foreach (var carta in cartas)
            {
                Point point = CrearPunto(gapColumna, gapFila, anchoPicture, alturaPicture, contadorCartas,
                    contadorFilas);
                PictureBox pic = CrearPictureBox(point, anchoPicture, alturaPicture, carta.Imagen);
                AgregarPictureAlPanel(panel1, pic);
                contadorCartas++;
                if (contadorCartas == 12)
                {
                    gapColumna = 0;
                    contadorFilas++;
                    contadorCartas = 0;
                }
                else
                {
                    gapColumna = 3;
                }
            }
        }

        private void AgregarPictureAlPanel(Panel panel, PictureBox pic)
        {
            panel.Controls.Add(pic);
        }

        private PictureBox CrearPictureBox(Point point, int anchoPicture, int alturaPicture, Image cartaImagen)
        {
            return new PictureBox()
            {
                Location = point,
                Width = anchoPicture,
                Height = alturaPicture,
                Image = cartaImagen,
                SizeMode = PictureBoxSizeMode.StretchImage
            };

        }

        private Point CrearPunto(int gapColumna, int gapFila, int anchoPicture, int alturaPicture, int contadorCartas, int contadorFilas)
        {
            return new Point(12 + (gapColumna + anchoPicture) * contadorCartas,
                12 + gapFila + (alturaPicture * contadorFilas));
        }

        private void BarajarButton_Click(object sender, EventArgs e)
        {
            QuitarPictureBoxesDelPanel();
            CrearBotonBarajar();
            Mazo.GetInstancia().Barajar();
            MostrarCartas(Mazo.GetInstancia().GetCartas());
        }

        private void QuitarPictureBoxesDelPanel()
        {
            //foreach (Control control. in this.panel1.Controls)
            //{
            //    panel1.Controls.
            //    MessageBox.Show(panel1.Controls.Count.ToString());
            //    if (control is PictureBox)
            //    {
            //        panel1.Controls.Remove(control);
            //    }
            //    panel1.Controls.Remove(control);
            //}
            panel1.Controls.Clear();
        }
    }
}
