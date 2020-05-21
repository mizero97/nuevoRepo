using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lp2SoftModel;

namespace Lp2SoftController.Lp2SoftDAO
{
    public interface EmpleadoDAO
    {
        int insertar(Empleado empleado);
        int actualizar(Empleado empleado);
        int eliminar(int idEmpleado);
        BindingList<Empleado> listar();
    }
}
