
namespace Forma_de_captura_de_datos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nombre = new System.Windows.Forms.TextBox();
            this.cuadroDeAyudaNombre = new System.Windows.Forms.TextBox();
            this.edad = new System.Windows.Forms.TextBox();
            this.cuadroDeAyudaEdad = new System.Windows.Forms.TextBox();
            this.ciudad = new System.Windows.Forms.ComboBox();
            this.fechaDeNacimiento = new System.Windows.Forms.DateTimePicker();
            this.cuadroDeAyudaCiudad = new System.Windows.Forms.TextBox();
            this.cuadroDeAyudaFechaDeNac = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonAnterior = new System.Windows.Forms.Button();
            this.buttonSiguiente = new System.Windows.Forms.Button();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.cuadroDeAyudaBusqueda = new System.Windows.Forms.TextBox();
            this.listPersonas = new System.Windows.Forms.ListBox();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(21, 26);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(336, 27);
            this.nombre.TabIndex = 0;
            // 
            // cuadroDeAyudaNombre
            // 
            this.cuadroDeAyudaNombre.Location = new System.Drawing.Point(21, 59);
            this.cuadroDeAyudaNombre.Name = "cuadroDeAyudaNombre";
            this.cuadroDeAyudaNombre.ReadOnly = true;
            this.cuadroDeAyudaNombre.Size = new System.Drawing.Size(336, 27);
            this.cuadroDeAyudaNombre.TabIndex = 1;
            // 
            // edad
            // 
            this.edad.Location = new System.Drawing.Point(21, 116);
            this.edad.Name = "edad";
            this.edad.Size = new System.Drawing.Size(336, 27);
            this.edad.TabIndex = 2;
            // 
            // cuadroDeAyudaEdad
            // 
            this.cuadroDeAyudaEdad.Location = new System.Drawing.Point(21, 149);
            this.cuadroDeAyudaEdad.Name = "cuadroDeAyudaEdad";
            this.cuadroDeAyudaEdad.ReadOnly = true;
            this.cuadroDeAyudaEdad.Size = new System.Drawing.Size(336, 27);
            this.cuadroDeAyudaEdad.TabIndex = 3;
            // 
            // ciudad
            // 
            this.ciudad.FormattingEnabled = true;
            this.ciudad.Items.AddRange(new object[] {
            "Aguascalientes",
            "Baja California",
            "Baja California Sur",
            "Campeche",
            "Chiapas",
            "Chihuahua",
            "Ciudad de México",
            "Coahuila",
            "Colima",
            "Durango",
            "Estado de México",
            "Guanajuato",
            "Guerrero",
            "Hidalgo",
            "Jalisco",
            "Michoacán",
            "Morelos",
            "Nayarit",
            "Nuevo León",
            "Oaxaca",
            "Puebla",
            "Querétaro",
            "Quintana Roo",
            "San Luis Potosí",
            "Sinaloa",
            "Sonora",
            "Tabasco",
            "Tamaulipas",
            "Tlaxcala",
            "Veracruz",
            "Yucatán",
            "Zacatecas"});
            this.ciudad.Location = new System.Drawing.Point(21, 210);
            this.ciudad.Name = "ciudad";
            this.ciudad.Size = new System.Drawing.Size(336, 28);
            this.ciudad.TabIndex = 4;
            // 
            // fechaDeNacimiento
            // 
            this.fechaDeNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaDeNacimiento.Location = new System.Drawing.Point(21, 307);
            this.fechaDeNacimiento.MaxDate = new System.DateTime(2018, 12, 31, 0, 0, 0, 0);
            this.fechaDeNacimiento.MinDate = new System.DateTime(1898, 1, 1, 0, 0, 0, 0);
            this.fechaDeNacimiento.Name = "fechaDeNacimiento";
            this.fechaDeNacimiento.Size = new System.Drawing.Size(336, 27);
            this.fechaDeNacimiento.TabIndex = 5;
            this.fechaDeNacimiento.Value = new System.DateTime(2018, 12, 31, 0, 0, 0, 0);
            
            // 
            // cuadroDeAyudaCiudad
            // 
            this.cuadroDeAyudaCiudad.Location = new System.Drawing.Point(21, 244);
            this.cuadroDeAyudaCiudad.Name = "cuadroDeAyudaCiudad";
            this.cuadroDeAyudaCiudad.ReadOnly = true;
            this.cuadroDeAyudaCiudad.Size = new System.Drawing.Size(336, 27);
            this.cuadroDeAyudaCiudad.TabIndex = 6;
            // 
            // cuadroDeAyudaFechaDeNac
            // 
            this.cuadroDeAyudaFechaDeNac.Location = new System.Drawing.Point(21, 340);
            this.cuadroDeAyudaFechaDeNac.Name = "cuadroDeAyudaFechaDeNac";
            this.cuadroDeAyudaFechaDeNac.ReadOnly = true;
            this.cuadroDeAyudaFechaDeNac.Size = new System.Drawing.Size(336, 27);
            this.cuadroDeAyudaFechaDeNac.TabIndex = 7;
            
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(21, 382);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(94, 29);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Guardar";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(900, 274);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(94, 29);
            this.buttonSearch.TabIndex = 9;
            this.buttonSearch.Text = "Buscar";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nombre);
            this.groupBox1.Controls.Add(this.buttonSave);
            this.groupBox1.Controls.Add(this.cuadroDeAyudaNombre);
            this.groupBox1.Controls.Add(this.edad);
            this.groupBox1.Controls.Add(this.cuadroDeAyudaFechaDeNac);
            this.groupBox1.Controls.Add(this.cuadroDeAyudaEdad);
            this.groupBox1.Controls.Add(this.fechaDeNacimiento);
            this.groupBox1.Controls.Add(this.cuadroDeAyudaCiudad);
            this.groupBox1.Controls.Add(this.ciudad);
            this.groupBox1.Location = new System.Drawing.Point(22, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 426);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            
            // 
            // buttonAnterior
            // 
            this.buttonAnterior.Location = new System.Drawing.Point(523, 381);
            this.buttonAnterior.Name = "buttonAnterior";
            this.buttonAnterior.Size = new System.Drawing.Size(94, 29);
            this.buttonAnterior.TabIndex = 12;
            this.buttonAnterior.Text = "Anterior";
            this.buttonAnterior.UseVisualStyleBackColor = true;
            // 
            // buttonSiguiente
            // 
            this.buttonSiguiente.Location = new System.Drawing.Point(900, 381);
            this.buttonSiguiente.Name = "buttonSiguiente";
            this.buttonSiguiente.Size = new System.Drawing.Size(94, 29);
            this.buttonSiguiente.TabIndex = 13;
            this.buttonSiguiente.Text = "Siguiente";
            this.buttonSiguiente.UseVisualStyleBackColor = true;
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(523, 275);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(347, 27);
            this.textSearch.TabIndex = 15;
            // 
            // cuadroDeAyudaBusqueda
            // 
            this.cuadroDeAyudaBusqueda.Location = new System.Drawing.Point(523, 308);
            this.cuadroDeAyudaBusqueda.Name = "cuadroDeAyudaBusqueda";
            this.cuadroDeAyudaBusqueda.ReadOnly = true;
            this.cuadroDeAyudaBusqueda.Size = new System.Drawing.Size(347, 27);
            this.cuadroDeAyudaBusqueda.TabIndex = 16;
            // 
            // listPersonas
            // 
            this.listPersonas.FormattingEnabled = true;
            this.listPersonas.ItemHeight = 20;
            this.listPersonas.Location = new System.Drawing.Point(426, 24);
            this.listPersonas.Name = "listPersonas";
            this.listPersonas.Size = new System.Drawing.Size(740, 244);
            this.listPersonas.TabIndex = 17;
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(708, 381);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(94, 29);
            this.buttonOpen.TabIndex = 18;
            this.buttonOpen.Text = "Abrir";
            this.buttonOpen.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 450);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.listPersonas);
            this.Controls.Add(this.cuadroDeAyudaBusqueda);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.buttonSiguiente);
            this.Controls.Add(this.buttonAnterior);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonSearch);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox cuadroDeAyudaNombre;
        private System.Windows.Forms.TextBox edad;
        private System.Windows.Forms.TextBox cuadroDeAyudaEdad;
        private System.Windows.Forms.ComboBox ciudad;
        private System.Windows.Forms.DateTimePicker fechaDeNacimiento;
        private System.Windows.Forms.TextBox cuadroDeAyudaCiudad;
        private System.Windows.Forms.TextBox cuadroDeAyudaFechaDeNac;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonAnterior;
        private System.Windows.Forms.Button buttonSiguiente;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.TextBox cuadroDeAyudaBusqueda;
        private System.Windows.Forms.ListBox listPersonas;
        private System.Windows.Forms.Button buttonOpen;
    }
}

