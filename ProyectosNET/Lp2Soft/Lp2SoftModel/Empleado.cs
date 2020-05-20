using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lp2SoftModel
{
	public class Empleado : Persona
	{
		private Area _area;

		public Empleado(Area area)
		{
			Area = area;
		}

		public Empleado()
		{
		}

		internal Area Area { get => _area; set => _area = value; }
	}
}
