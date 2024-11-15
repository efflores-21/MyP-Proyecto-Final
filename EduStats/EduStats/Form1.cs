using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EduStats.Formularios;

namespace EduStats
{
    public partial class PaginaPrincipal : Form
    {
        private const string UsuarioC = "12345678";
        private const string ContraseñaC = "123456";
        public PaginaPrincipal()
        {
            InitializeComponent();
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            string UsuarioIn = tbUsuario.Text;
            string ContraseñaIn = tbContraseña.Text;

            if (UsuarioIn.Length != 8)
            {
                MessageBox.Show("Usuario Invalido");
            }
            if (ContraseñaIn.Length != 6)
            {
                MessageBox.Show("Contraseña Invalida");
            }
            if (UsuarioIn == UsuarioC && ContraseñaIn == ContraseñaC)
            {
                MenuDeOpciones paginaPrincipal2 = new MenuDeOpciones();
                paginaPrincipal2.Show();
                this.Hide();
            }
            else { MessageBox.Show("Accesso Denegado, Usuario o Contraseña Incorrectos.");
            }

        }

        private void btnCerrarPC_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
