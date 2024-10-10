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

namespace DirectoryUsing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

            //Verificar el tiempo y fecha de creacion de la carpeta  con propiedades de DirectoryInfo
            DirectoryInfo dr = new DirectoryInfo("folder2");
            string accesstime = dr.CreationTime.ToString();
            MessageBox.Show(accesstime);


            // Crear una carpeta con condicional 
            /*if(Directory.Exists("folder2"))
            {
                Directory.CreateDirectory("folder2");


            }*/
            //Crea una carpeta en el directorio 
            //Directory.CreateDirectory("temp");

            //Crea una carpeta  en tu unidad de almacenamiento a elegir 
            //DirectoryInfo dr = new DirectoryInfo(@"E:\temp2");

            //Crea una carpeta en tu directorio usando el metodo DirectoryInfo
            //DirectoryInfo dr = new DirectoryInfo("temp2");
            /*dr.Create();
            MessageBox.Show("Folder was created");*/
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            //Mover del directorio a una carpeta en especifico 
            Directory.Move("temp", @"E:\newfolder\temp");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Directory.Delete("temp");
        }
    }
}
