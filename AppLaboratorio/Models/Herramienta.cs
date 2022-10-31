using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLaboratorio.Models
{
    public class Herramienta
    {
        public int IdHerramienta { get; set; }
        public string herramienta { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public string numero_serie { get; set; }
        public string cantidad { get; set; }
        public string descripcion { get; set; }
        public string laboratorio { get; set; }
    }
}
