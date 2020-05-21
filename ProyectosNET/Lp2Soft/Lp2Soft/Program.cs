using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lp2SoftController.Lp2MySQL;
using Lp2SoftController.Lp2SoftDAO;
using Lp2SoftModel;

namespace Lp2Soft
{
	class Program
	{
		static void Main(string[] args)
		{
			/*Area area = new Area("LOGISTICA");
			AreaDAO daoArea= new AreaMySQL();
			int resultado = daoArea.insertar(area);
			if (resultado == 1) System.Console.WriteLine("SE HA INSERTADO CORRECTAMENTE");
			else System.Console.WriteLine("HA HABIDO UN ERROR...");
			System.Console.ReadLine();*/
			Application.Run(new frmGestionarEmpleados());

		}
	}
}
