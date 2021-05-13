using System;
using System.Collections.Generic;
using System.Text;

namespace LecturaCsv
{
    public class Ventas
    {
        public int comercial, empresa, mes;

        public Ventas(string RowData)
        {
            string[] data = RowData.Split(',');
            this.comercial = Convert.ToInt32(data[0]);
            this.empresa = Convert.ToInt32(data[1]);
            this.mes = Convert.ToInt32(data[2]);
            this.mes = Convert.ToInt32(data[3]);
            this.mes = Convert.ToInt32(data[4]);
            this.mes = Convert.ToInt32(data[5]);
            this.mes = Convert.ToInt32(data[6]);
            this.mes = Convert.ToInt32(data[7]);
            this.mes = Convert.ToInt32(data[8]);
            this.mes = Convert.ToInt32(data[9]);
            this.mes = Convert.ToInt32(data[10]);
            this.mes = Convert.ToInt32(data[11]);
            this.mes = Convert.ToInt32(data[12]);


        }

        public override string ToString()
        {
            string str = $"Comercial: {comercial}" + $" Para la empresa: {empresa}" + $" los meses {mes}";
            return base.ToString();
        }
    }
}
