using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace menu
{
    public partial class UserControl3 : UserControl
    {
        public UserControl3()
        {
            InitializeComponent();
            String[] series = { "enero", "febrero", "marzo", "abril", "mayo", "junio", "julio", "agosto", "septiembre", "octubre", "noviembre", "diciembre" };
            int[] cantidades = { 45, 23, 34, 67, 89, 76, 90,178,200,90,67,90 };

            chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            chart1.Titles.Add("Resumen Ventas anuales");

            for (int i = 0; i < series.Length; i++)
            {
                Series serie = chart1.Series.Add(series[i]);
                serie.Label = cantidades[i].ToString();
                serie.Points.Add(cantidades[i]);

            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
