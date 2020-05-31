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
using System.Data.SqlClient;




namespace capaPresentacionWF
{
    public partial class FSolicitud : Form
    {
        
        logicaNegocioRecursos r = new logicaNegocioRecursos();
        logicaNegocioUsuario u = new logicaNegocioUsuario();
        logicaNegocioSolicitud logicaNR = new logicaNegocioSolicitud();

        public FSolicitud()
        {
            InitializeComponent();

         
            //textBoxIdRecursos.Text = cn.consultaidrecursos();



        }
       


        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelID_Click(object sender, EventArgs e)
        {

        }

        private void labelAula_Click(object sender, EventArgs e)
        {

        }

        private void labelNivel_Click(object sender, EventArgs e)
        {

        }

        private void labelFechaSolicitud_Click(object sender, EventArgs e)
        {

        }

        private void labelFechaUso_Click(object sender, EventArgs e)
        {

        }

        private void labelHoraInicio_Click(object sender, EventArgs e)
        {

        }

        private void labelHoraFin_Click(object sender, EventArgs e)
        {

        }

        private void labelAsignatura_Click(object sender, EventArgs e)
        {

        }

        private void labelCarrera_Click(object sender, EventArgs e)
        {

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {



            try
            {

                if (buttonGuardar.Text == "Guardar")
                {
                    capaEntidades.Solicitud objetoSolicitud = new capaEntidades.Solicitud();
                    objetoSolicitud.aula = textBoxAula.Text;
                    objetoSolicitud.nivel = textBoxNivel.Text;
                    objetoSolicitud.fechasolicitud =Convert.ToDateTime(dateTimePickerFechasolicitud.Text);
                    objetoSolicitud.fechauso = Convert.ToDateTime(dateTimePickerFechauso.Text);
                    objetoSolicitud.horainicio = Convert.ToDateTime(textBoxHoraInicio.Text);
                    objetoSolicitud.horafin = Convert.ToDateTime(textBoxHoraFin.Text);
                    objetoSolicitud.carrera = textBoxCarrera.Text;
                    objetoSolicitud.asignatura = textBoxAsignatura.Text;
                    objetoSolicitud.id_recursos =Convert.ToInt32( textBoxIdRecurso.Text);
                    objetoSolicitud.id_usuario = Convert.ToInt32(textBoxIdUsuario.Text);

                    if (logicaNR.insertarSolicitud(objetoSolicitud)>0)
                    {
                        MessageBox.Show("Agregado con exito");
                        dataGridViewSolicitud.DataSource = logicaNR.listarSolicitud();
                        textBoxAula.Text = "";
                        textBoxNivel.Text = "";
                        dateTimePickerFechasolicitud.Text = "";
                        dateTimePickerFechauso.Text = "";
                        textBoxHoraInicio.Text = "";
                        textBoxHoraFin.Text = "";
                        textBoxCarrera.Text = "";
                        textBoxAsignatura.Text = "";
                        tabSolicitud.SelectedTab = tabPage2;
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar Recurso");
                    }
                }

                if (buttonGuardar.Text == "Actualizar")
                {
                    capaEntidades.Solicitud objetoSolicitud = new capaEntidades.Solicitud();
                    objetoSolicitud.id_solicitud = Convert.ToInt32(textBoxID.Text);
                    objetoSolicitud.aula = textBoxAula.Text;
                    objetoSolicitud.nivel = textBoxNivel.Text;
                    objetoSolicitud.fechasolicitud = Convert.ToDateTime(dateTimePickerFechasolicitud.Text);
                    objetoSolicitud.fechauso = Convert.ToDateTime(dateTimePickerFechauso.Text);
                    objetoSolicitud.horainicio = Convert.ToDateTime(textBoxHoraInicio.Text);
                    objetoSolicitud.horafin = Convert.ToDateTime(textBoxHoraFin.Text);
                    objetoSolicitud.carrera = textBoxCarrera.Text;
                    objetoSolicitud.asignatura = textBoxAsignatura.Text;
                    objetoSolicitud.id_recursos =Convert.ToInt32( textBoxIdRecurso.Text);
                    objetoSolicitud.id_usuario =Convert.ToInt32 (textBoxIdUsuario.Text);

                    if (logicaNR.editarSolicitud(objetoSolicitud) ==1)
                    {
                        MessageBox.Show("Actualizado con exito");
                        dataGridViewSolicitud.DataSource = logicaNR.listarSolicitud();
                        textBoxAula.Text = "";
                        textBoxNivel.Text = "";
                        dateTimePickerFechasolicitud.Text = "";
                        dateTimePickerFechauso.Text = "";
                        textBoxHoraInicio.Text = "";
                        textBoxHoraFin.Text = "";
                        textBoxCarrera.Text = "";
                        textBoxAsignatura.Text = "";
                        textBoxIdRecurso.Text = "";
                        textBoxIdUsuario.Text = "";

                        tabSolicitud.SelectedTab = tabPage2;
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

        private void FSolicitud_Load(object sender, EventArgs e)
        {

            logicaNegocioRecursos cargarRecursos = new logicaNegocioRecursos();
            // TODO: esta línea de código carga datos en la tabla 'programacionBaseDeDatosDataSet.recursos' Puede moverla o quitarla según sea necesario.
            this.recursosTableAdapter.Fill(this.programacionBaseDeDatosDataSet.recursos);
            textBoxID.Visible = false;
            labelID.Visible = false;
            dataGridViewSolicitud.DataSource = logicaNR.listarSolicitud();
            dataGridViewIdrecursos.DataSource = r.listarRecursos();
            dataGridViewIdUsuario.DataSource = u.listarUsuarios();
            
            
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonBuscarRecursos_Click(object sender, EventArgs e)
        {

       }

        private void textBoxIdRecurso_TextChanged(object sender, EventArgs e)
        {


            
        }

        private void textBoxIdUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewSolicitud_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            
            List<Solicitud> listaSolicitud = logicaNR.buscarSolicitud(Convert.ToInt32( textBoxBuscar.Text));
            dataGridViewSolicitud.DataSource = listaSolicitud;
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            textBoxID.Visible = true;
            textBoxID.Enabled = false;
            labelID.Visible = true;

            textBoxID.Text = dataGridViewSolicitud.CurrentRow.Cells["id_solicitud"].Value.ToString();
            textBoxAula.Text = dataGridViewSolicitud.CurrentRow.Cells["aula"].Value.ToString();
            textBoxNivel.Text = dataGridViewSolicitud.CurrentRow.Cells["nivel"].Value.ToString();
            dateTimePickerFechasolicitud.Text = dataGridViewSolicitud.CurrentRow.Cells["fechasolicitud"].Value.ToString();
            dateTimePickerFechauso.Text= dataGridViewSolicitud.CurrentRow.Cells["fechauso"].Value.ToString();
            textBoxHoraInicio.Text = dataGridViewSolicitud.CurrentRow.Cells["horainicio"].Value.ToString();
            textBoxHoraFin.Text = dataGridViewSolicitud.CurrentRow.Cells["horafin"].Value.ToString();
            textBoxCarrera.Text = dataGridViewSolicitud.CurrentRow.Cells["carrera"].Value.ToString();
            textBoxAsignatura.Text = dataGridViewSolicitud.CurrentRow.Cells["asignatura"].Value.ToString();
            textBoxIdRecurso.Text = dataGridViewSolicitud.CurrentRow.Cells["id_recursos"].Value.ToString();
            textBoxIdUsuario.Text = dataGridViewSolicitud.CurrentRow.Cells["id_usuario"].Value.ToString();

            tabSolicitud.SelectedTab = tabPage1;

            buttonGuardar.Text = "Actualizar";
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            int codigoS = Convert.ToInt32(dataGridViewSolicitud.CurrentRow.Cells["id_solicitud"].Value.ToString());

            try
            {
                if (logicaNR.eliminarSolicitud(codigoS) > 0)
                {
                    MessageBox.Show("Eliminado con exito");
                    dataGridViewSolicitud.DataSource = logicaNR.listarSolicitud();
                }



            }
            catch
            {

                MessageBox.Show("ERROR al eliminar solicitud");

            }
        }

        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void recursosBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void buttonagregarrecurso_Click(object sender, EventArgs e)
        {
            if (dataGridViewIdrecursos.SelectedRows.Count == 1)
            {

                try
                {
                    textBoxIdRecurso.Text = dataGridViewIdrecursos.CurrentRow.Cells["id_recursos"].Value.ToString();
                    




                }
                catch
                {


                }

            }
            else
            {
                MessageBox.Show("No has seleccionado");
            }

        }

        private void buttonagregarusuario_Click(object sender, EventArgs e)
        {
            if (dataGridViewIdUsuario.SelectedRows.Count == 1)
            {

                try
                {
                    textBoxIdUsuario.Text = dataGridViewIdUsuario.CurrentRow.Cells["id_usuario"].Value.ToString();





                }
                catch
                {


                }

            }
            else
            {
                MessageBox.Show("No has seleccionado");
            }
        }

        private void dataGridViewIdrecursos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePickerFechasolicitud_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
