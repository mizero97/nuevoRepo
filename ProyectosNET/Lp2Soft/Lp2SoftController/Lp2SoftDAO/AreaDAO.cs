using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lp2SoftModel;

namespace Lp2SoftController.Lp2SoftDAO
{
	public interface AreaDAO
	{
		int insertar(Area area);
		int actualizar(Area area);
		int eliminar(int idArea);
		BindingList<Area> listar();
	}
}
