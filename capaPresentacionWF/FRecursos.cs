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
    public partial class FRecursos : Form
    {
        logicaNegocioRecursos logicaNR = new logicaNegocioRecursos();
        
        public FRecursos()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {

                if (buttonGuardar.Text == "Guardar")
                {
                    capaEntidades.Recursos objetoRecurso = new capaEntidades.Recursos();
                    objetoRecurso.nombre = textBoxNombre.Text;
                    objetoRecurso.codigo = textBoxCodigo.Text;
                    objetoRecurso.descripcion = textBoxDescripcion.Text;
                    if (logicaNR.insertarRecursos(objetoRecurso) == 1)
                    {
                        MessageBox.Show("Agregado con exito");
                        dataGridViewRecursos.DataSource = logicaNR.listarRecursos();
                        textBoxNombre.Text = "";
                        textBoxCodigo.Text = "";
                        textBoxDescripcion.Text = "";
                        tabRecursos.SelectedTab = tabPage2;
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar Recurso");
                    }
                }

                if (buttonGuardar.Text == "Actualizar")
                {
                    Recursos objetoRecurso = new Recursos();
                    objetoRecurso.id_recursos = Convert.ToInt32(textBoxID.Text);
                    objetoRecurso.nombre = textBoxNombre.Text;
                    objetoRecurso.codigo = textBoxCodigo.Text;
                    objetoRecurso.descripcion = textBoxDescripcion.Text;
                    if (logicaNR.editarRecursos(objetoRecurso) >0)
                    {
                        MessageBox.Show("Actualizado con exito");
                        dataGridViewRecursos.DataSource = logicaNR.listarRecursos();
                        textBoxNombre.Text = "";
                        textBoxCodigo.Text = "";
                        textBoxDescripcion.Text = "";
                        tabRecursos.SelectedTab = tabPage2;
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

        private void FRecursos_Load(object sender, EventArgs e)
        {
            textBoxID.Visible = false;
            labelID.Visible = false;
            dataGridViewRecursos.DataSource = logicaNR.listarRecursos();

        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            textBoxID.Visible = true;
            textBoxID.Enabled = false;
            labelID.Visible = true;

            textBoxID.Text = dataGridViewRecursos.CurrentRow.Cells["id_recursos"].Value.ToString();
            textBoxNombre.Text = dataGridViewRecursos.CurrentRow.Cells["nombre"].Value.ToString();
            textBoxCodigo.Text = dataGridViewRecursos.CurrentRow.Cells["codigo"].Value.ToString();
            textBoxDescripcion.Text = dataGridViewRecursos.CurrentRow.Cells["descripcion"].Value.ToString();
            tabRecursos.SelectedTab = tabPage1;

            buttonGuardar.Text = "Actualizar";

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            int codigoR = Convert.ToInt32(dataGridViewRecursos.CurrentRow.Cells["id_recursos"].Value.ToString());

            try
            {
                if (logicaNR.eliminarRecursos(codigoR) >0)
                {
                    MessageBox.Show("Eliminado con exito");
                    dataGridViewRecursos.DataSource = logicaNR.listarRecursos();
                }

                

            }
            catch
            {

                MessageBox.Show("ERROR al eliminar recurso");

            }
        }

        private void dataGridViewRecursos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            List<Recursos> listaRecursos = logicaNR.buscarRecursos(textBoxBuscar.Text);
            dataGridViewRecursos.DataSource = listaRecursos;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}

