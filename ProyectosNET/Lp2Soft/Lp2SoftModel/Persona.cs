using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lp2SoftModel
{
	public class Persona
	{
		private int _idPersona;
		private string _nombreCompleto;
		private string _dni;

		public Persona(int idPersona, string nombreCompleto, string dni)
		{
			IdPersona = idPersona;
			NombreCompleto = nombreCompleto;
			Dni = dni;
		}

		public Persona()
		{
		}

		public int IdPersona { get => _idPersona; set => _idPersona = value; }
		public string NombreCompleto { get => _nombreCompleto; set => _nombreCompleto = value; }
		public string Dni { get => _dni; set => _dni = value; }
	}
}
