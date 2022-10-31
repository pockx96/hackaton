using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLaboratorio.Models
{
    public class PrestamosAlumno
    {
        public string matricula { get;set;}
        public string nombre { get;set;}
        public string materia { get; set; }
        public string Herramienta { get; set; }
        public string cantidad { get; set; }
        public string fecha_salida { get; set; }
       public string fecha_regreso { get; set; }

    }
}
