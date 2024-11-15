using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EduStats.Formularios
{
    public partial class MenuDeOpciones : Form
    {
        public MenuDeOpciones()
        {
            InitializeComponent();
        }
        
        private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            PaginaPrincipal paginaPrincipal = new PaginaPrincipal();
            paginaPrincipal.Show();
            this.Close();
        }

        private void btnGeneroDeLibro_Click(object sender, EventArgs e)
        {
            GeneroDeLibro generoDeLibro = new GeneroDeLibro();
            generoDeLibro.Show();
            this.Close();
        }

        private void btnHorasDiarias_Click(object sender, EventArgs e)
        {
            HorasDiarias horasDiarias = new HorasDiarias();
            horasDiarias.Show();
            this.Close();
        }

        private void btnTemporada_Click(object sender, EventArgs e)
        {
            Temporada temporada = new Temporada();
            temporada.Show();
            this.Close();
        }

        private void btnCarreras_Click(object sender, EventArgs e)
        {
            Carreras carreras = new Carreras();
            carreras.Show();
            this.Close();
        }
    }
}
