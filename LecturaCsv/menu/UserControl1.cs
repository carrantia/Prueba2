using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace menu
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* string[] CsvFile = System.IO.File.ReadAllLines(@"C:\Users\isma\Desktop\Datos.csv");

             var comerciales = new List<Comercial>();

             for (int i = 0; i < CsvFile.Length; i++)
             {
                 Comercial cm = new Comercial(CsvFile[i]);
                 comerciales.Add(cm);

             }*/

            String fichero = @"..\..\..\..\LecturaCsv\BD\1_datos_comerciales.csv";

            try
            {
                using (StreamReader lector = new StreamReader(fichero))
                {
                    while (lector.Peek() > -1)
                    {
                        string linea = lector.ReadLine();
                        
                        textBox1.Text = linea;
                        
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            
            
        }
    }
}
