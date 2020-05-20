/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.lp2soft.dao;

import java.util.ArrayList;
import pe.edu.pucp.lp2soft.model.Empleado;

/**
 *
 * @author Miguel
 */
public interface EmpleadoDAO {
    int insertar(Empleado empleado);
    int actualizar(Empleado empleado);
    int borrar(int idEmpleado);
    ArrayList<Empleado> listar();
}
