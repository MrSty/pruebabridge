using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebabridge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var datosDocente = new List<string> { "Nombre: Marcelo ", "Apellido: Rivera", "Titulo: Ingeniero en sistemas" };
            var visualizador = new VisualizadorTextoPlano();
            var expediente = new Expediente(visualizador);
            var expedienteV = expediente.Visualizar(datosDocente);
            Console.WriteLine(expedienteV);

            var visualizador2 = new VisualizadorHTML();
            var expediente2 = new Expediente(visualizador2);
            expedienteV = expediente2.Visualizar(datosDocente);
            string htmlContent = expedienteV;
            string filePath = "D:/Dev/Projects/C#/pruebabridge";
            string nombreArchivo = "visual.html";
            string rutaCompleta = Path.Combine(filePath, nombreArchivo);
            using(StreamWriter writer = new StreamWriter(rutaCompleta))
            {
                writer.Write(htmlContent);
            }
            
            var visualizador3 = new VisualizadorPDF();
            var expediente3 = new Expediente(visualizador3);
            expedienteV = expediente3.Visualizar(datosDocente);
            Console.WriteLine(expedienteV);

            var visualizador4 = new VisualizadorExcel();
            var expediente4 = new Expediente(visualizador4);
            expedienteV = expediente4.Visualizar(datosDocente);
            Console.WriteLine(expedienteV);
        }
    }
}
