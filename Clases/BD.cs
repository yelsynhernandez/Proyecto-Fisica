using System.Data.SqlClient;
using System.IO;
using System.Linq;

namespace ProyectoFisica.Clases
{
    internal class BD
    {
        public static string server()
        {
            string archivo = @"C:\proyecto\config\bd.txt";
            if (File.Exists(archivo))
            { 
                string primeraLinea = File.ReadLines(archivo).FirstOrDefault();
                return primeraLinea;
            }
            else
            {
                return string.Empty;
            }
        }
        public SqlConnection CrearConexion()
        {
            return new SqlConnection($"Data Source={server()};Initial Catalog=proyecto_fisica;Integrated Security=True;");
        }
    }
}
