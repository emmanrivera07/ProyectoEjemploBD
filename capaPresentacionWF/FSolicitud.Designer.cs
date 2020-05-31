namespace capaPresentacionWF
{
    partial class FSolicitud
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabSolicitud = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dateTimePickerFechauso = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFechasolicitud = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonagregarusuario = new System.Windows.Forms.Button();
            this.buttonagregarrecurso = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.dataGridViewIdUsuario = new System.Windows.Forms.DataGridView();
            this.dataGridViewIdrecursos = new System.Windows.Forms.DataGridView();
            this.textBoxIdRecurso = new System.Windows.Forms.TextBox();
            this.textBoxIdUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCarrera = new System.Windows.Forms.TextBox();
            this.textBoxAsignatura = new System.Windows.Forms.TextBox();
            this.textBoxHoraFin = new System.Windows.Forms.TextBox();
            this.textBoxHoraInicio = new System.Windows.Forms.TextBox();
            this.textBoxNivel = new System.Windows.Forms.TextBox();
            this.textBoxAula = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelCarrera = new System.Windows.Forms.Label();
            this.labelAsignatura = new System.Windows.Forms.Label();
            this.labelHoraFin = new System.Windows.Forms.Label();
            this.labelHoraInicio = new System.Windows.Forms.Label();
            this.labelFechaUso = new System.Windows.Forms.Label();
            this.labelFechaSolicitud = new System.Windows.Forms.Label();
            this.labelNivel = new System.Windows.Forms.Label();
            this.labelAula = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewSolicitud = new System.Windows.Forms.DataGridView();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.programacionBaseDeDatosDataSet = new capaPresentacionWF.programacionBaseDeDatosDataSet();
            this.recursosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recursosTableAdapter = new capaPresentacionWF.programacionBaseDeDatosDataSetTableAdapters.recursosTableAdapter();
            this.tabSolicitud.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIdUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIdrecursos)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSolicitud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programacionBaseDeDatosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recursosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabSolicitud
            // 
            this.tabSolicitud.Controls.Add(this.tabPage1);
            this.tabSolicitud.Controls.Add(this.tabPage2);
            this.tabSolicitud.Location = new System.Drawing.Point(-1, -2);
            this.tabSolicitud.Name = "tabSolicitud";
            this.tabSolicitud.SelectedIndex = 0;
            this.tabSolicitud.Size = new System.Drawing.Size(1255, 573);
            this.tabSolicitud.TabIndex = 0;
            this.tabSolicitud.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dateTimePickerFechauso);
            this.tabPage1.Controls.Add(this.dateTimePickerFechasolicitud);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.buttonagregarusuario);
            this.tabPage1.Controls.Add(this.buttonagregarrecurso);
            this.tabPage1.Controls.Add(this.buttonGuardar);
            this.tabPage1.Controls.Add(this.dataGridViewIdUsuario);
            this.tabPage1.Controls.Add(this.dataGridViewIdrecursos);
            this.tabPage1.Controls.Add(this.textBoxIdRecurso);
            this.tabPage1.Controls.Add(this.textBoxIdUsuario);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textBoxCarrera);
            this.tabPage1.Controls.Add(this.textBoxAsignatura);
            this.tabPage1.Controls.Add(this.textBoxHoraFin);
            this.tabPage1.Controls.Add(this.textBoxHoraInicio);
            this.tabPage1.Controls.Add(this.textBoxNivel);
            this.tabPage1.Controls.Add(this.textBoxAula);
            this.tabPage1.Controls.Add(this.textBoxID);
            this.tabPage1.Controls.Add(this.labelCarrera);
            this.tabPage1.Controls.Add(this.labelAsignatura);
            this.tabPage1.Controls.Add(this.labelHoraFin);
            this.tabPage1.Controls.Add(this.labelHoraInicio);
            this.tabPage1.Controls.Add(this.labelFechaUso);
            this.tabPage1.Controls.Add(this.labelFechaSolicitud);
            this.tabPage1.Controls.Add(this.labelNivel);
            this.tabPage1.Controls.Add(this.labelAula);
            this.tabPage1.Controls.Add(this.labelID);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1247, 547);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nuevo";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // dateTimePickerFechauso
            // 
            this.dateTimePickerFechauso.Location = new System.Drawing.Point(217, 250);
            this.dateTimePickerFechauso.Name = "dateTimePickerFechauso";
            this.dateTimePickerFechauso.Size = new System.Drawing.Size(218, 20);
            this.dateTimePickerFechauso.TabIndex = 33;
            this.dateTimePickerFechauso.Value = new System.DateTime(2020, 5, 29, 13, 52, 4, 0);
            // 
            // dateTimePickerFechasolicitud
            // 
            this.dateTimePickerFechasolicitud.Location = new System.Drawing.Point(217, 206);
            this.dateTimePickerFechasolicitud.Name = "dateTimePickerFechasolicitud";
            this.dateTimePickerFechasolicitud.Size = new System.Drawing.Size(218, 20);
            this.dateTimePickerFechasolicitud.TabIndex = 32;
            this.dateTimePickerFechasolicitud.Value = new System.DateTime(2020, 5, 29, 13, 41, 24, 0);
            this.dateTimePickerFechasolicitud.ValueChanged += new System.EventHandler(this.dateTimePickerFechasolicitud_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(868, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 16);
            this.label5.TabIndex = 31;
            this.label5.Text = "Seleccione el usuario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(214, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 16);
            this.label4.TabIndex = 30;
            this.label4.Text = "Seleccione el recurso";
            // 
            // buttonagregarusuario
            // 
            this.buttonagregarusuario.Location = new System.Drawing.Point(1074, 512);
            this.buttonagregarusuario.Name = "buttonagregarusuario";
            this.buttonagregarusuario.Size = new System.Drawing.Size(97, 23);
            this.buttonagregarusuario.TabIndex = 29;
            this.buttonagregarusuario.Text = "Agregar Usuario";
            this.buttonagregarusuario.UseVisualStyleBackColor = true;
            this.buttonagregarusuario.Click += new System.EventHandler(this.buttonagregarusuario_Click);
            // 
            // buttonagregarrecurso
            // 
            this.buttonagregarrecurso.Location = new System.Drawing.Point(78, 512);
            this.buttonagregarrecurso.Name = "buttonagregarrecurso";
            this.buttonagregarrecurso.Size = new System.Drawing.Size(95, 23);
            this.buttonagregarrecurso.TabIndex = 28;
            this.buttonagregarrecurso.Text = "Agregar Recurso";
            this.buttonagregarrecurso.UseVisualStyleBackColor = true;
            this.buttonagregarrecurso.Click += new System.EventHandler(this.buttonagregarrecurso_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonGuardar.Location = new System.Drawing.Point(584, 512);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardar.TabIndex = 19;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = false;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // dataGridViewIdUsuario
            // 
            this.dataGridViewIdUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIdUsuario.Location = new System.Drawing.Point(732, 356);
            this.dataGridViewIdUsuario.Name = "dataGridViewIdUsuario";
            this.dataGridViewIdUsuario.Size = new System.Drawing.Size(439, 150);
            this.dataGridViewIdUsuario.TabIndex = 27;
            // 
            // dataGridViewIdrecursos
            // 
            this.dataGridViewIdrecursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIdrecursos.Location = new System.Drawing.Point(78, 356);
            this.dataGridViewIdrecursos.Name = "dataGridViewIdrecursos";
            this.dataGridViewIdrecursos.Size = new System.Drawing.Size(438, 150);
            this.dataGridViewIdrecursos.TabIndex = 26;
            this.dataGridViewIdrecursos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewIdrecursos_CellContentClick);
            // 
            // textBoxIdRecurso
            // 
            this.textBoxIdRecurso.Location = new System.Drawing.Point(217, 284);
            this.textBoxIdRecurso.Name = "textBoxIdRecurso";
            this.textBoxIdRecurso.Size = new System.Drawing.Size(118, 20);
            this.textBoxIdRecurso.TabIndex = 25;
            this.textBoxIdRecurso.TextChanged += new System.EventHandler(this.textBoxIdRecurso_TextChanged);
            // 
            // textBoxIdUsuario
            // 
            this.textBoxIdUsuario.Location = new System.Drawing.Point(871, 248);
            this.textBoxIdUsuario.Name = "textBoxIdUsuario";
            this.textBoxIdUsuario.Size = new System.Drawing.Size(118, 20);
            this.textBoxIdUsuario.TabIndex = 23;
            this.textBoxIdUsuario.TextChanged += new System.EventHandler(this.textBoxIdUsuario_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(729, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 18);
            this.label3.TabIndex = 21;
            this.label3.Text = "Id Usuario";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(75, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 18);
            this.label2.TabIndex = 20;
            this.label2.Text = "Id Recurso";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxCarrera
            // 
            this.textBoxCarrera.Location = new System.Drawing.Point(871, 206);
            this.textBoxCarrera.Name = "textBoxCarrera";
            this.textBoxCarrera.Size = new System.Drawing.Size(118, 20);
            this.textBoxCarrera.TabIndex = 18;
            this.textBoxCarrera.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // textBoxAsignatura
            // 
            this.textBoxAsignatura.Location = new System.Drawing.Point(871, 168);
            this.textBoxAsignatura.Name = "textBoxAsignatura";
            this.textBoxAsignatura.Size = new System.Drawing.Size(118, 20);
            this.textBoxAsignatura.TabIndex = 17;
            this.textBoxAsignatura.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // textBoxHoraFin
            // 
            this.textBoxHoraFin.Location = new System.Drawing.Point(871, 131);
            this.textBoxHoraFin.Name = "textBoxHoraFin";
            this.textBoxHoraFin.Size = new System.Drawing.Size(118, 20);
            this.textBoxHoraFin.TabIndex = 16;
            this.textBoxHoraFin.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // textBoxHoraInicio
            // 
            this.textBoxHoraInicio.Location = new System.Drawing.Point(871, 88);
            this.textBoxHoraInicio.Name = "textBoxHoraInicio";
            this.textBoxHoraInicio.Size = new System.Drawing.Size(118, 20);
            this.textBoxHoraInicio.TabIndex = 15;
            this.textBoxHoraInicio.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // textBoxNivel
            // 
            this.textBoxNivel.Location = new System.Drawing.Point(217, 162);
            this.textBoxNivel.Name = "textBoxNivel";
            this.textBoxNivel.Size = new System.Drawing.Size(118, 20);
            this.textBoxNivel.TabIndex = 12;
            this.textBoxNivel.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBoxAula
            // 
            this.textBoxAula.Location = new System.Drawing.Point(217, 122);
            this.textBoxAula.Name = "textBoxAula";
            this.textBoxAula.Size = new System.Drawing.Size(118, 20);
            this.textBoxAula.TabIndex = 11;
            this.textBoxAula.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(217, 88);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(118, 20);
            this.textBoxID.TabIndex = 10;
            this.textBoxID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelCarrera
            // 
            this.labelCarrera.AutoSize = true;
            this.labelCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCarrera.ForeColor = System.Drawing.Color.Black;
            this.labelCarrera.Location = new System.Drawing.Point(729, 205);
            this.labelCarrera.Name = "labelCarrera";
            this.labelCarrera.Size = new System.Drawing.Size(65, 18);
            this.labelCarrera.TabIndex = 9;
            this.labelCarrera.Text = "Carrera";
            this.labelCarrera.Click += new System.EventHandler(this.labelCarrera_Click);
            // 
            // labelAsignatura
            // 
            this.labelAsignatura.AutoSize = true;
            this.labelAsignatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAsignatura.ForeColor = System.Drawing.Color.Black;
            this.labelAsignatura.Location = new System.Drawing.Point(730, 170);
            this.labelAsignatura.Name = "labelAsignatura";
            this.labelAsignatura.Size = new System.Drawing.Size(87, 18);
            this.labelAsignatura.TabIndex = 8;
            this.labelAsignatura.Text = "Asignatura";
            this.labelAsignatura.Click += new System.EventHandler(this.labelAsignatura_Click);
            // 
            // labelHoraFin
            // 
            this.labelHoraFin.AutoSize = true;
            this.labelHoraFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHoraFin.ForeColor = System.Drawing.Color.Black;
            this.labelHoraFin.Location = new System.Drawing.Point(729, 133);
            this.labelHoraFin.Name = "labelHoraFin";
            this.labelHoraFin.Size = new System.Drawing.Size(86, 18);
            this.labelHoraFin.TabIndex = 7;
            this.labelHoraFin.Text = "Hora Final";
            this.labelHoraFin.Click += new System.EventHandler(this.labelHoraFin_Click);
            // 
            // labelHoraInicio
            // 
            this.labelHoraInicio.AutoSize = true;
            this.labelHoraInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHoraInicio.ForeColor = System.Drawing.Color.Black;
            this.labelHoraInicio.Location = new System.Drawing.Point(729, 90);
            this.labelHoraInicio.Name = "labelHoraInicio";
            this.labelHoraInicio.Size = new System.Drawing.Size(113, 18);
            this.labelHoraInicio.TabIndex = 6;
            this.labelHoraInicio.Text = "Hora de inicio";
            this.labelHoraInicio.Click += new System.EventHandler(this.labelHoraInicio_Click);
            // 
            // labelFechaUso
            // 
            this.labelFechaUso.AutoSize = true;
            this.labelFechaUso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaUso.ForeColor = System.Drawing.Color.Black;
            this.labelFechaUso.Location = new System.Drawing.Point(75, 247);
            this.labelFechaUso.Name = "labelFechaUso";
            this.labelFechaUso.Size = new System.Drawing.Size(110, 18);
            this.labelFechaUso.TabIndex = 5;
            this.labelFechaUso.Text = "Fecha de uso";
            this.labelFechaUso.Click += new System.EventHandler(this.labelFechaUso_Click);
            // 
            // labelFechaSolicitud
            // 
            this.labelFechaSolicitud.AutoSize = true;
            this.labelFechaSolicitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaSolicitud.ForeColor = System.Drawing.Color.Black;
            this.labelFechaSolicitud.Location = new System.Drawing.Point(75, 205);
            this.labelFechaSolicitud.Name = "labelFechaSolicitud";
            this.labelFechaSolicitud.Size = new System.Drawing.Size(124, 18);
            this.labelFechaSolicitud.TabIndex = 4;
            this.labelFechaSolicitud.Text = "Fecha Solicitud";
            this.labelFechaSolicitud.Click += new System.EventHandler(this.labelFechaSolicitud_Click);
            // 
            // labelNivel
            // 
            this.labelNivel.AutoSize = true;
            this.labelNivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNivel.ForeColor = System.Drawing.Color.Black;
            this.labelNivel.Location = new System.Drawing.Point(75, 164);
            this.labelNivel.Name = "labelNivel";
            this.labelNivel.Size = new System.Drawing.Size(45, 18);
            this.labelNivel.TabIndex = 3;
            this.labelNivel.Text = "Nivel";
            this.labelNivel.Click += new System.EventHandler(this.labelNivel_Click);
            // 
            // labelAula
            // 
            this.labelAula.AutoSize = true;
            this.labelAula.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAula.ForeColor = System.Drawing.Color.Black;
            this.labelAula.Location = new System.Drawing.Point(75, 124);
            this.labelAula.Name = "labelAula";
            this.labelAula.Size = new System.Drawing.Size(40, 18);
            this.labelAula.TabIndex = 2;
            this.labelAula.Text = "Aula";
            this.labelAula.Click += new System.EventHandler(this.labelAula_Click);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.ForeColor = System.Drawing.Color.Black;
            this.labelID.Location = new System.Drawing.Point(75, 90);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(24, 18);
            this.labelID.TabIndex = 1;
            this.labelID.Text = "ID";
            this.labelID.Click += new System.EventHandler(this.labelID_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(544, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Solicitud";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewSolicitud);
            this.tabPage2.Controls.Add(this.buttonBuscar);
            this.tabPage2.Controls.Add(this.buttonEditar);
            this.tabPage2.Controls.Add(this.buttonEliminar);
            this.tabPage2.Controls.Add(this.textBoxBuscar);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1247, 547);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detalles";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // dataGridViewSolicitud
            // 
            this.dataGridViewSolicitud.AllowUserToOrderColumns = true;
            this.dataGridViewSolicitud.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSolicitud.Location = new System.Drawing.Point(81, 91);
            this.dataGridViewSolicitud.Name = "dataGridViewSolicitud";
            this.dataGridViewSolicitud.Size = new System.Drawing.Size(1093, 306);
            this.dataGridViewSolicitud.TabIndex = 11;
            this.dataGridViewSolicitud.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSolicitud_CellContentClick);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(748, 18);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.TabIndex = 10;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(934, 17);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(75, 23);
            this.buttonEditar.TabIndex = 9;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(843, 17);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminar.TabIndex = 8;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Location = new System.Drawing.Point(276, 20);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(438, 20);
            this.textBoxBuscar.TabIndex = 7;
            this.textBoxBuscar.TextChanged += new System.EventHandler(this.textBoxBuscar_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(203, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Buscar";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // programacionBaseDeDatosDataSet
            // 
            this.programacionBaseDeDatosDataSet.DataSetName = "programacionBaseDeDatosDataSet";
            this.programacionBaseDeDatosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // recursosBindingSource
            // 
            this.recursosBindingSource.DataMember = "recursos";
            this.recursosBindingSource.DataSource = this.programacionBaseDeDatosDataSet;
            this.recursosBindingSource.CurrentChanged += new System.EventHandler(this.recursosBindingSource_CurrentChanged);
            // 
            // recursosTableAdapter
            // 
            this.recursosTableAdapter.ClearBeforeFill = true;
            // 
            // FSolicitud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 567);
            this.Controls.Add(this.tabSolicitud);
            this.Name = "FSolicitud";
            this.Text = "FSolicitud";
            this.Load += new System.EventHandler(this.FSolicitud_Load);
            this.tabSolicitud.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIdUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIdrecursos)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSolicitud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programacionBaseDeDatosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recursosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.TextBox textBoxIdRecurso;
        public System.Windows.Forms.TextBox textBoxIdUsuario;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TabControl tabSolicitud;
        public System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.Label labelID;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label labelAsignatura;
        public System.Windows.Forms.Label labelHoraFin;
        public System.Windows.Forms.Label labelHoraInicio;
        public System.Windows.Forms.Label labelFechaUso;
        public System.Windows.Forms.Label labelFechaSolicitud;
        public System.Windows.Forms.Label labelNivel;
        public System.Windows.Forms.Label labelAula;
        public System.Windows.Forms.Button buttonGuardar;
        public System.Windows.Forms.TextBox textBoxCarrera;
        public System.Windows.Forms.TextBox textBoxAsignatura;
        public System.Windows.Forms.TextBox textBoxHoraFin;
        public System.Windows.Forms.TextBox textBoxHoraInicio;
        public System.Windows.Forms.TextBox textBoxNivel;
        public System.Windows.Forms.TextBox textBoxAula;
        public System.Windows.Forms.TextBox textBoxID;
        public System.Windows.Forms.Label labelCarrera;
        public System.Windows.Forms.DataGridView dataGridViewSolicitud;
        public System.Windows.Forms.Button buttonBuscar;
        public System.Windows.Forms.Button buttonEditar;
        public System.Windows.Forms.Button buttonEliminar;
        public System.Windows.Forms.TextBox textBoxBuscar;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label3;
        public programacionBaseDeDatosDataSet programacionBaseDeDatosDataSet;
        public System.Windows.Forms.BindingSource recursosBindingSource;
        public programacionBaseDeDatosDataSetTableAdapters.recursosTableAdapter recursosTableAdapter;
        private System.Windows.Forms.DataGridView dataGridViewIdUsuario;
        private System.Windows.Forms.DataGridView dataGridViewIdrecursos;
        private System.Windows.Forms.Button buttonagregarusuario;
        private System.Windows.Forms.Button buttonagregarrecurso;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechasolicitud;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechauso;
    }
}