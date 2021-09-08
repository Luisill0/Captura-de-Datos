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
            SaveFileDialog dlg = new SaveFileDialog();

            dlg.Filter = "Archivos.txt|.txt|Otro archivo|.rty";

            DialogResult res = dlg.ShowDialog();
            if (res == DialogResult.OK)
            {
                File.AppendAllText(dlg.FileName, nombre.Text + " ; " + Int32.Parse(edad.Text) + " ; " + ciudad.Text + " ; " + fechaDeNacimiento.Text + "\n");
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if(textSearch.Text == "")
            {
                listPersonas.Items.Clear();
                string ruta;

                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "Archvos txt|*.txt";
                DialogResult res = dlg.ShowDialog();
                ruta = dlg.FileName;

                if (res == DialogResult.OK)
                {
                    using (StreamReader lector = new StreamReader(ruta))
                    {
                        string linea;
                        while ((linea = lector.ReadLine()) != null)
                        {
                            listPersonas.Items.Add(linea);
                        }
                    }
                }
            }
            else
            {
                listPersonas.Items.Clear();
                string ruta;

                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "Archvos txt|*.txt";
                DialogResult res = dlg.ShowDialog();
                ruta = dlg.FileName;

                var wordSearch = textSearch.Text;
                if (res == DialogResult.OK)
                {
                    using (StreamReader lector = new StreamReader(ruta))
                    {
                        string linea;
                        while((linea = lector.ReadLine()) != null)
                        {
                            if(linea.Contains(wordSearch))
                                listPersonas.Items.Add(linea);
                        }
                    }
                }
            }
        }
    }
}
