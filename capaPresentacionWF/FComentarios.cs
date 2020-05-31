using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaEntidades;
using capaNegocio;

namespace capaPresentacionWF
{
    public partial class FComentarios : Form
    {

        logicaNegocioComentarios logicaNR = new logicaNegocioComentarios();
        public FComentarios()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttunGuardar_Click(object sender, EventArgs e)
        {
            try
            {

                if (buttonGuardar.Text == "Guardar")
                {
                    capaEntidades.Comentarios objetoComentarios = new capaEntidades.Comentarios();
                    objetoComentarios.nombre = textBoxNombre.Text;
                    objetoComentarios.correo= textBoxCorreo.Text;
                    objetoComentarios.telefono= textBoxTelefono.Text;
                    objetoComentarios.mensaje = textBoxMensaje.Text;
                    if (logicaNR.insertarComentarios(objetoComentarios) == 1)
                    {
                        MessageBox.Show("Agregado con exito");
                        dataGridViewComentarios.DataSource = logicaNR.listarComentarios();
                        textBoxNombre.Text = "";
                        textBoxCorreo.Text = "";
                        textBoxTelefono.Text = "";
                        tabComentarios.SelectedTab = tabPage2;
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar Recurso");
                    }
                }

                if (buttonGuardar.Text == "Actualizar")
                {
                  
                    
                    capaEntidades.Comentarios objetoComentarios = new capaEntidades.Comentarios();
                    objetoComentarios.id_comentarios = Convert.ToInt32(textBoxID.Text);
                    objetoComentarios.nombre = textBoxNombre.Text;
                    objetoComentarios.correo = textBoxCorreo.Text;
                    objetoComentarios.telefono = textBoxTelefono.Text;
                    objetoComentarios.mensaje = textBoxMensaje.Text;
                    if (logicaNR.editarComentarios(objetoComentarios) > 0)
                    {
                        MessageBox.Show("Actualizado con exito");
                        dataGridViewComentarios.DataSource = logicaNR.listarComentarios();
                        textBoxNombre.Text = "";
                        textBoxCorreo.Text = "";
                        textBoxTelefono.Text = "";
                        textBoxMensaje.Text = "";
                        tabComentarios.SelectedTab = tabPage2;
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar Recurso");
                    }
                    buttonGuardar.Text = "Guardar";

                }
            }
            catch
            {
                MessageBox.Show("ERROR");
            }
        }

        private void FComentarios_Load(object sender, EventArgs e)
        {

            textBoxID.Visible = false;
            labelID.Visible = false;
            dataGridViewComentarios.DataSource = logicaNR.listarComentarios();

        }

        private void dataGridViewComentarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            textBoxID.Visible = true;
            textBoxID.Enabled = false;
            labelID.Visible = true;

            textBoxID.Text = dataGridViewComentarios.CurrentRow.Cells["id_comentarios"].Value.ToString();
            textBoxNombre.Text = dataGridViewComentarios.CurrentRow.Cells["nombre"].Value.ToString();
            textBoxCorreo.Text = dataGridViewComentarios.CurrentRow.Cells["correo"].Value.ToString();
            textBoxTelefono.Text = dataGridViewComentarios.CurrentRow.Cells["telefono"].Value.ToString();
            textBoxMensaje.Text = dataGridViewComentarios.CurrentRow.Cells["mensaje"].Value.ToString();
            tabComentarios.SelectedTab = tabPage1;

            buttonGuardar.Text = "Actualizar";

        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            List<Comentarios> listaComentarios= logicaNR.buscarComentarios(textBoxBuscar.Text);
            dataGridViewComentarios.DataSource = listaComentarios;
        }
    }
}
