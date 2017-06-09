using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reproductor_MP3
{
    public partial class Form1 : Form
    {
        bool Play = false;
        List<Cancion> canciones = new List<Cancion>();
        List<Cancion> cancionesBiblioteca = new List<Cancion>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btPlay_Click(object sender, EventArgs e)
        {

        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            OpenFileDialog buscarCanciones = new OpenFileDialog();
            buscarCanciones.Multiselect = true;
            if(buscarCanciones.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {

            }
        }
    }
}
