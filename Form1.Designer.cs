﻿
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonInsertar = new System.Windows.Forms.Button();
            this.buttonAnterior = new System.Windows.Forms.Button();
            this.buttonSiguiente = new System.Windows.Forms.Button();
            this.listPersonas = new System.Windows.Forms.ListBox();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(21, 27);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(335, 27);
            this.nombre.TabIndex = 0;
            this.nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nombre_KeyPress);
            // 
            // cuadroDeAyudaNombre
            // 
            this.cuadroDeAyudaNombre.Location = new System.Drawing.Point(21, 59);
            this.cuadroDeAyudaNombre.Name = "cuadroDeAyudaNombre";
            this.cuadroDeAyudaNombre.ReadOnly = true;
            this.cuadroDeAyudaNombre.Size = new System.Drawing.Size(335, 27);
            this.cuadroDeAyudaNombre.TabIndex = 1;
            this.cuadroDeAyudaNombre.Text = "Nombre";
            // 
            // edad
            // 
            this.edad.Location = new System.Drawing.Point(21, 116);
            this.edad.Name = "edad";
            this.edad.Size = new System.Drawing.Size(335, 27);
            this.edad.TabIndex = 2;
            this.edad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edad_KeyPress);
            // 
            // cuadroDeAyudaEdad
            // 
            this.cuadroDeAyudaEdad.Location = new System.Drawing.Point(21, 149);
            this.cuadroDeAyudaEdad.Name = "cuadroDeAyudaEdad";
            this.cuadroDeAyudaEdad.ReadOnly = true;
            this.cuadroDeAyudaEdad.Size = new System.Drawing.Size(335, 27);
            this.cuadroDeAyudaEdad.TabIndex = 3;
            this.cuadroDeAyudaEdad.Text = "Edad";
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
            this.ciudad.Location = new System.Drawing.Point(21, 211);
            this.ciudad.Name = "ciudad";
            this.ciudad.Size = new System.Drawing.Size(335, 28);
            this.ciudad.TabIndex = 4;
            // 
            // fechaDeNacimiento
            // 
            this.fechaDeNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaDeNacimiento.Location = new System.Drawing.Point(21, 307);
            this.fechaDeNacimiento.MaxDate = new System.DateTime(2021, 9, 7, 15, 7, 58, 0);
            this.fechaDeNacimiento.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.fechaDeNacimiento.Name = "fechaDeNacimiento";
            this.fechaDeNacimiento.Size = new System.Drawing.Size(335, 27);
            this.fechaDeNacimiento.TabIndex = 5;
            this.fechaDeNacimiento.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // cuadroDeAyudaCiudad
            // 
            this.cuadroDeAyudaCiudad.Location = new System.Drawing.Point(21, 244);
            this.cuadroDeAyudaCiudad.Name = "cuadroDeAyudaCiudad";
            this.cuadroDeAyudaCiudad.ReadOnly = true;
            this.cuadroDeAyudaCiudad.Size = new System.Drawing.Size(335, 27);
            this.cuadroDeAyudaCiudad.TabIndex = 6;
            this.cuadroDeAyudaCiudad.Text = "Ciudad";
            // 
            // cuadroDeAyudaFechaDeNac
            // 
            this.cuadroDeAyudaFechaDeNac.Location = new System.Drawing.Point(21, 340);
            this.cuadroDeAyudaFechaDeNac.Name = "cuadroDeAyudaFechaDeNac";
            this.cuadroDeAyudaFechaDeNac.ReadOnly = true;
            this.cuadroDeAyudaFechaDeNac.Size = new System.Drawing.Size(335, 27);
            this.cuadroDeAyudaFechaDeNac.TabIndex = 7;
            this.cuadroDeAyudaFechaDeNac.Text = "Fecha de Nacimiento";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(730, 297);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(94, 29);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Guardar";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonEliminar);
            this.groupBox1.Controls.Add(this.buttonInsertar);
            this.groupBox1.Controls.Add(this.nombre);
            this.groupBox1.Controls.Add(this.cuadroDeAyudaNombre);
            this.groupBox1.Controls.Add(this.edad);
            this.groupBox1.Controls.Add(this.cuadroDeAyudaFechaDeNac);
            this.groupBox1.Controls.Add(this.cuadroDeAyudaEdad);
            this.groupBox1.Controls.Add(this.fechaDeNacimiento);
            this.groupBox1.Controls.Add(this.cuadroDeAyudaCiudad);
            this.groupBox1.Controls.Add(this.ciudad);
            this.groupBox1.Location = new System.Drawing.Point(22, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 427);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(21, 392);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(94, 29);
            this.buttonEliminar.TabIndex = 18;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonInsertar
            // 
            this.buttonInsertar.Location = new System.Drawing.Point(263, 392);
            this.buttonInsertar.Name = "buttonInsertar";
            this.buttonInsertar.Size = new System.Drawing.Size(94, 29);
            this.buttonInsertar.TabIndex = 8;
            this.buttonInsertar.Text = "Insertar";
            this.buttonInsertar.UseVisualStyleBackColor = true;
            this.buttonInsertar.Click += new System.EventHandler(this.buttonInsertar_Click);
            // 
            // buttonAnterior
            // 
            this.buttonAnterior.Location = new System.Drawing.Point(426, 297);
            this.buttonAnterior.Name = "buttonAnterior";
            this.buttonAnterior.Size = new System.Drawing.Size(94, 29);
            this.buttonAnterior.TabIndex = 12;
            this.buttonAnterior.Text = "Anterior";
            this.buttonAnterior.UseVisualStyleBackColor = true;
            this.buttonAnterior.Click += new System.EventHandler(this.buttonAnterior_Click);
            // 
            // buttonSiguiente
            // 
            this.buttonSiguiente.Location = new System.Drawing.Point(891, 297);
            this.buttonSiguiente.Name = "buttonSiguiente";
            this.buttonSiguiente.Size = new System.Drawing.Size(94, 29);
            this.buttonSiguiente.TabIndex = 13;
            this.buttonSiguiente.Text = "Siguiente";
            this.buttonSiguiente.UseVisualStyleBackColor = true;
            this.buttonSiguiente.Click += new System.EventHandler(this.buttonSiguiente_Click);
            // 
            // listPersonas
            // 
            this.listPersonas.FormattingEnabled = true;
            this.listPersonas.ItemHeight = 20;
            this.listPersonas.Location = new System.Drawing.Point(426, 24);
            this.listPersonas.Name = "listPersonas";
            this.listPersonas.Size = new System.Drawing.Size(558, 244);
            this.listPersonas.TabIndex = 17;
            this.listPersonas.SelectedIndexChanged += new System.EventHandler(this.listPersonas_SelectedIndexChanged);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(571, 297);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(94, 29);
            this.buttonOpen.TabIndex = 18;
            this.buttonOpen.Text = "Abrir";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 451);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.listPersonas);
            this.Controls.Add(this.buttonSiguiente);
            this.Controls.Add(this.buttonAnterior);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Captura de Datos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonAnterior;
        private System.Windows.Forms.Button buttonSiguiente;
        private System.Windows.Forms.ListBox listPersonas;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonInsertar;
    }
}

