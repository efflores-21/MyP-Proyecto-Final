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
    public partial class GeneroDeLibro : Form
    {
        public GeneroDeLibro()
        {
            InitializeComponent();
        }

        private void BtnGeneroVolver_Click(object sender, EventArgs e)
        {
            MenuDeOpciones menuDeOpciones = new MenuDeOpciones();
            menuDeOpciones.Show();
            this.Close();
        }
    }
}
