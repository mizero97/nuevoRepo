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
	public class AreaMySQL : AreaDAO
	{
		public int actualizar(Area area)
		{
			throw new NotImplementedException();
		}

		public int eliminar(int idArea)
		{
			throw new NotImplementedException();
		}

		public int insertar(Area area)
		{
			int rpta = 0;
			MySqlConnection con = new MySqlConnection(DBManager.CadenaConexion);
			//ABRIMOS CONEXION
			con.Open();
			//COMANDO DE SQL
			MySqlCommand comando = new MySqlCommand();
			comando.Connection = con;
			comando.CommandText = "INSERT INTO AREA(NOMBRE,ACTIVO) VALUES('" +area.Nombre+ "',1)";
			//SENTENCIA TIPO NO SELECT
			rpta = comando.ExecuteNonQuery();
			//CERRAMOS CONEXION
			con.Close();
			return rpta;
		}

		public BindingList<Area> listar()
		{
			BindingList<Area> areas = new BindingList<Area>();
			MySqlConnection con = new MySqlConnection(DBManager.CadenaConexion);
            con.Open(); //ABRIMOS CONEXCION
			MySqlCommand comando = new MySqlCommand();
			comando.Connection = con;
			comando.CommandText = "select_area";
			comando.CommandType = System.Data.CommandType.StoredProcedure;
			//EXECUTE READER PARA SELET
			//EXECUTENONQUERY PARA LOS DEMAS
			MySqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
				Area area = new Area();
				area.IdArea = lector.GetInt32("ID_AREA");
				area.Nombre = lector.GetString("NOMBRE");
				areas.Add(area);
            }
			lector.Close();
			con.Close();
			return areas;
		}
	}
}
