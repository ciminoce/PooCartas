using PooCartas.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PooCartas.Windows
{
    public partial class FrmCarta : Form
    {
        public FrmCarta()
        {
            InitializeComponent();
        }

        private Carta carta;
        private void FrmCarta_Load(object sender, EventArgs e)
        {
            CargarDatosComboCartas(ref CartasComboBox);
        }

        private void CargarDatosComboCartas(ref ComboBox combo)
        {
            combo.DataSource = Mazo.GetInstancia().GetCartas();
        }

        private void CartasComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CartasComboBox.SelectedIndex>=0)
            {
                carta = (Carta) CartasComboBox.SelectedItem;
                CartaPictureBox.Image = carta.Imagen;
                CartaPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                carta = null;
            }
        }
    }
}
