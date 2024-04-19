using System.Data.SqlClient;

namespace ProyectoFisica.Clases
{
    internal class BD
    { 
        public SqlConnection CrearConexion()
        {
            return new SqlConnection("Data Source=localhost;Initial Catalog=proyecto_fisica;Integrated Security=True;");
        }
    }
}
