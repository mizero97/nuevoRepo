using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lp2SoftController.Lp2MySQL;
using Lp2SoftController.Lp2SoftDAO;
using Lp2SoftModel;

namespace Lp2Soft
{
    public partial class frmGestionarEmpleados : Form
    {
        public frmGestionarEmpleados()
        {
            //INICIALIZA COMPONENTES GRAFICOS
            InitializeComponent();
            //INICIALIZAR COMPONENTES DE FORMLARIO
            estadoComponentes(Estado.Inicial);
            //CARGAMOS LAS AREAS EN EL COMBOBOX
            AreaDAO daoArea = new AreaMySQL();
            cboArea.DataSource = daoArea.listar();
            cboArea.DisplayMember = "Nombre";
        }

        public void estadoComponentes(Estado estado)
        {
            switch (estado)
            {
                case Estado.Inicial:
                    txtCargo.Enabled = false;
                    txtDNI.Enabled = false;
                    txtIDEmpleado.Enabled = false;
                    txtNombreCompleto.Enabled = false;
                    txtSueldo.Enabled = false;
                    cboArea.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnGuardar.Enabled = false;
                    dtpFechaNac.Enabled = false;
                    break;

                case Estado.Nuevo:
                    txtCargo.Enabled = true;
                    txtDNI.Enabled = true;
                    txtIDEmpleado.Enabled = true;
                    txtNombreCompleto.Enabled = true;
                    txtSueldo.Enabled = true;
                    cboArea.Enabled = true;
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    dtpFechaNac.Enabled = true;
                    break;

            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            estadoComponentes(Estado.Nuevo);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Empleado emp = new Empleado();
            emp.NombreCompleto = txtNombreCompleto.Text;
            emp.Dni = txtDNI.Text;
            emp.Cargo = txtCargo.Text;
            emp.Sueldo = float.Parse(txtSueldo.Text);
            emp.Area = (Area)cboArea.SelectedItem;
            emp.FechaNacimiento = dtpFechaNac.Value;
            EmpleadoDAO daoEmpleado = new EmpleadoMySQL();
            int idGenerado = daoEmpleado.insertar(emp);

            if (idGenerado != 0)
            {
                MessageBox.Show("SE HA REGISTRADO CON EXITO","Mensaje",
                    MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

            txtIDEmpleado.Text = idGenerado.ToString();
        }
    }
}
