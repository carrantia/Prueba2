using System;
using System.Collections.Generic;
using System.Windows.Forms;



namespace menu { 


    
    public partial class Form1 : Form
    {
                

        public Form1()
        {
            InitializeComponent();
           
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            UserControl1 prueba = new UserControl1();
            tableLayoutPanel1.Controls.Add(prueba, 1, 1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LecturaCsv.Ventas nuevo = new LecturaCsv.Ventas();   
            UserControl2 totalVentas = new UserControl2(ventas);
            tableLayoutPanel1.Controls.Add(totalVentas, 1, 1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            UserControl3 grafica = new UserControl3();
            tableLayoutPanel1.Controls.Add(grafica, 1, 1);
        }
    }
}
