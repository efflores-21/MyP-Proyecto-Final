using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EduStats.Formularios
{
    public partial class Carreras : Form
    {
        public Carreras()
        {
            InitializeComponent();
        }

        private void BtnCarrerasVolver_Click(object sender, EventArgs e)
        {
            MenuDeOpciones menuDeOpciones = new MenuDeOpciones();
            menuDeOpciones.Show();
            this.Close();
        }
    }
}
