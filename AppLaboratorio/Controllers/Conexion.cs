using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLaboratorio.Controllers
{
    public class Conexion
    {
        public string connectionString = "Server=localhost;Database=lab_herramientas; Uid=root;Pwd=root;";
        public string stringToDb(string word)
        {
            int lenght = 50 - word.Length;
            string StringDb = word;
            for (int i = 0; i < lenght; i++)
            {
                StringDb = StringDb + " ";
            }
            return StringDb;
        }
    }
   
}
