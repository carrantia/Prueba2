using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menu
{
    public class Comercial
    {

        public int Id, Edad;
        public String Nombre, Apellido, Ciudad;

        public Comercial(string RowData)
        {
            string[] data = RowData.Split(',');

            this.Id = Convert.ToInt32(data[0]);
            this.Nombre = data[1];
            this.Apellido = data[2];
            this.Ciudad = data[3];
            this.Edad = Convert.ToInt32(data[4]);
        }

        public override string ToString()
        {
            string str = $"{Id}: " + $"{Nombre}-{Apellido}-{Ciudad}-{Edad}";

            return str;
        }
    }
}