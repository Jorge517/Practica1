
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//Se aanexo esta libreria
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Se aanexo esta libreria
using Practica1.Clases;
using Practica1.Procedimientos;
using System;
using System.Windows.Forms;


namespace Practica1
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void BtnCambiar_Click(object sender, EventArgs e)
        {

            CambiarUsuario();

        }
        private void BtnCambiar_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void CambiarUsuario()
        {
            //Usuario user = new Usuario();
            // MessageBox.Show("Prueba");
            //LblUsuario.Text = TxtUsuario.Text;
        }

        private void LblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCrearUsuario_Click(object sender, EventArgs e)
        {
            //Invocar sin parametros
            CrearUsuario();

        }

        public void CrearUsuario()
        {
            Usuario user = new Usuario
            {


                //Objetos que creamos, provienen de la clase Usuario, se crea instancia de la classe Usuario
            Nombre = TxtUsuario.Text,
            Email = TxtEmail.Text,
            Password = TxtPassword.Text,
        };
            if (SPHelper.InsertarUsuario(user) == "SI")
            {

                MessageBox.Show("Usuario insertado");
            }
                else
                {
                    MessageBox.Show("Error al crear");

                }
        }
    }
}
