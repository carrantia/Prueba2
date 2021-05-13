using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace LecturaCsv
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] CsvFile = System.IO.File.ReadAllLines(@"..\..\..\..\..\BD\1_datos_comerciales.csv");

            var comerciales = new List<Comercial>();

            for (int i = 0; i < CsvFile.Length; i++)
            {
                Comercial cm = new Comercial(CsvFile[i]);
                comerciales.Add(cm);
                //Console.WriteLine(CsvFile[i
                Console.WriteLine(cm.ToString());

            }
            Console.WriteLine(comerciales.ToString());

            foreach (Comercial customer in comerciales)
            {
                Console.WriteLine("    {0}", customer.Nombre);
            }



        }
    }

}


