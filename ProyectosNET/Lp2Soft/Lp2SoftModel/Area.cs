using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lp2SoftModel
{
	public class Area
	{
		private int _idArea;
		private string _nombre;

		public Area(int idArea, string nombre)
		{
			IdArea = idArea;
			Nombre = nombre;
		}

		public Area(string nombre)
		{
			Nombre = nombre;
		}

		public Area()
		{
		}

		public int IdArea { get => _idArea; set => _idArea = value; }
		public string Nombre { get => _nombre; set => _nombre = value; }
	}
}
