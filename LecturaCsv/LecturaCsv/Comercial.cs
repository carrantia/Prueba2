using System;
using System.Collections.Generic;
using System.Text;

namespace LecturaCsv
{
   public class Comercial
    {

       public int Id, Edad;
       public  String Nombre, Apellido, Ciudad;

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

        /** 
             public int Id { get; set; }
             public string Nombre { get; set; }
             public string Apellido { get; set; }
             public string Ciudad { get; set; }
             public int Edad { get; set; }
         
         **/
    }
}
