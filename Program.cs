using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramandoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime fecha = new DateTime(2004, 2, 10);
            DateTime fechaConHora = new DateTime(2021, 10, 18, 16, 40, 50);
            

            Console.WriteLine("Fecha en que entre a mi primer trabajo formal de Informática: " + fecha.ToString());
            Console.WriteLine(fecha.ToString("dd/MM/yyyy"));
            Console.WriteLine(fecha.ToString("dd/MM/yy"));
            Console.WriteLine("Fecha con Hora: " + fechaConHora.ToString("dd/MM/yyyy hh:mm:ss"));

            

            Console.ReadLine();
        }

        

    }
}
