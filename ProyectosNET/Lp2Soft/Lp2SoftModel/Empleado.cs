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
		private string _cargo;
		private float _sueldo;
		private bool _activo;
		private DateTime _fechaNacimiento;
		public Empleado(Area area)
		{
			Area = area;
		}

        public Empleado(Area area, string cargo, float sueldo, bool activo) : this(area)
        {
            Cargo = cargo;
            Sueldo = sueldo;
            Activo = activo;
        }

        public Empleado()
		{
		}

		
        public string Cargo { get => _cargo; set => _cargo = value; }
        public float Sueldo { get => _sueldo; set => _sueldo = value; }
        public bool Activo { get => _activo; set => _activo = value; }
        public Area Area { get => _area; set => _area = value; }
        public DateTime FechaNacimiento { get => _fechaNacimiento; set => _fechaNacimiento = value; }
    }
}
