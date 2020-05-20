/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.lp2soft.main;

import java.util.ArrayList;
import pe.edu.pucp.lp2soft.dao.EmpleadoDAO;
import pe.edu.pucp.lp2soft.model.Empleado;
import pe.edu.pucp.lp2soft.mysql.EmpleadoMySQL;

/**
 *
 * @author Miguel
 */
public class Principal {
    public static void main(String [] args) {
        ArrayList<Empleado> empleados = new ArrayList<Empleado>(); 
        
        EmpleadoDAO daoEmpleado = new EmpleadoMySQL();
        Empleado mizero = new Empleado("IDOL3",191.7f,"gaaaaaa","54634564");
        
        
        
        
        //int resultado = daoEmpleado.insertar(mizero);
        //if (resultado==0) System.out.println("ALGO ESTA MAL");
        //else System.out.println("EL NUEVO ID INSERTADO ES: " + resultado);
        
        empleados = daoEmpleado.listar();
        for (Empleado i: empleados) {
            System.out.println(i.mostrarDatos());
        }
        
    }
}
