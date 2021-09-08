using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Forma_de_captura_de_datos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (listPersonas.Items.Count != 0)
            {
                SaveFileDialog dlg = new SaveFileDialog();

                dlg.Filter = "Archivos.txt|.txt|Otro archivo|.rty";

                DialogResult res = dlg.ShowDialog();
                if (res == DialogResult.OK)
                {
                    foreach (string s in listPersonas.Items)
                    {
                        File.AppendAllText(dlg.FileName, s + "\n");
                    }
                }
            }
        }

        private void buttonInsertar_Click(object sender, EventArgs e)
        {
            if (formaCompleta())
            {
                Persona person = new Persona();
                person.setNombre(nombre.Text);
                person.setEdad(int.Parse(edad.Text));
                person.setCiudad(ciudad.Text);
                person.setFechaNacimiento(fechaDeNacimiento.Value.Date);
                listPersonas.Items.Add(person.getData());
                clearTextBox();
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            listPersonas.Items.Remove(listPersonas.SelectedItem);
        }

        private bool formaCompleta()
        {
            return (nombre.Text != "" && edad.Text != "" && ciudad.Text != "");
        }
        private void clearTextBox()
        {
            nombre.Text = "";
            edad.Text = "";
            ciudad.Text = "";
        }

        private void buttonSiguiente_Click(object sender, EventArgs e)
        {
            if (listPersonas.Items.Count > 0)
            {
                try
                {
                    listPersonas.SelectedIndex++;
                }
                catch (Exception) { }
            }
        }

        private void buttonAnterior_Click(object sender, EventArgs e)
        {
            if (listPersonas.Items.Count > 0)
            {
                try
                {
                    listPersonas.SelectedIndex--;
                }
                catch (Exception) { }
            }
        }

        private void listPersonas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listPersonas.SelectedIndex != -1)
            {
                clearTextBox();
                updateCurrentPerson();
            }
        }

        private void updateCurrentPerson()
        {
            string[] campos = ((string)listPersonas.SelectedItem).Split(" | ");

            nombre.Text = campos[0];
            edad.Text = campos[1];
            ciudad.Text = campos[2];
            fechaDeNacimiento.Value = DateTime.Parse(campos[3]);

        }

        private void nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.nombreLetrasEspacios(e);
        }

        private void edad_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.edadEntre0y120(e);
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Archvos txt|*.txt";
            DialogResult res = dlg.ShowDialog();

            if (res == DialogResult.OK)
            {
                listPersonas.Items.Clear();
                using (StreamReader lector = new StreamReader(dlg.FileName))
                {
                    string linea;
                    while ((linea = lector.ReadLine()) != null)
                    {
                        listPersonas.Items.Add(linea);
                    }
                }
            }
        }
    }

    public class Persona
    {
        private String nombre;
        private String ciudad;
        private int edad;
        private DateTime fechaNacimiento;

        public void setNombre(String nombre)
        {
            this.nombre = nombre;
        }

        public void setCiudad(String ciudad)
        {
            this.ciudad = ciudad;
        }

        public void setEdad(int edad)
        {
            this.edad = edad;
        }

        public void setFechaNacimiento(DateTime fechaNacimiento)
        {
            this.fechaNacimiento = fechaNacimiento;
        }

        public String getData()
        {
            return (nombre + " | " + edad.ToString() + " | " + ciudad + " | " + fechaNacimiento.ToString("MM/dd/yyyy"));
        }
    }

    public class validacion 
    {
        

        public static void nombreLetrasEspacios(KeyPressEventArgs pE)
        {
            if (char.IsLetter(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else if (char.IsControl(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else if (char.IsSeparator(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else
            {
                pE.Handled = true;
            }
        }

        public static void edadEntre0y120(KeyPressEventArgs pE)
        {
            if (char.IsDigit(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else if (char.IsControl(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else
            {
                pE.Handled = true;
            }
        }

    }
}
