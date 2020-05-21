using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lp2SoftController.Lp2SoftConfig;
using Lp2SoftController.Lp2SoftDAO;
using Lp2SoftModel;
using MySql.Data.MySqlClient;

namespace Lp2SoftController.Lp2MySQL
{
    public class EmpleadoMySQL : EmpleadoDAO
    {
        public int actualizar(Empleado empleado)
        {
            throw new NotImplementedException();
        }

        public int eliminar(int idEmpleado)
        {
            throw new NotImplementedException();
        }

        public int insertar(Empleado empleado)
        {
            int rpta = 0;
            MySqlConnection con = new MySqlConnection(DBManager.CadenaConexion);
            con.Open(); //ABRIMOS CONEXCION
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = con;

            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "insertar_empleado";
            //PARAMETROS DE ENTRADA
            comando.Parameters.AddWithValue("_nombre_completo", empleado.NombreCompleto);
            comando.Parameters.AddWithValue("_cargo", empleado.Cargo);
            comando.Parameters.AddWithValue("_sueldo", empleado.Sueldo);
            comando.Parameters.AddWithValue("_dni", empleado.Dni);
            comando.Parameters.AddWithValue("_fid_area", empleado.Area.IdArea);
            comando.Parameters.AddWithValue("_fecha_nacimiento", empleado.FechaNacimiento);
            //PARAMETROS DE SALIDA
            comando.Parameters.Add("_id_empleado", MySqlDbType.Int32).Direction =
                System.Data.ParameterDirection.Output;

            //EJEUTAMOS EL NONQUERY pAR AUPDATE
            //EXECUTE READER PARA SELECT
            comando.ExecuteNonQuery();
            //SACAR EL OUTPUT
            rpta = Int32.Parse(comando.Parameters["_id_empleado"].Value.ToString());
            con.Close();
            return rpta;
        }

        public BindingList<Empleado> listar()
        {
            throw new NotImplementedException();
        }
    }
}
