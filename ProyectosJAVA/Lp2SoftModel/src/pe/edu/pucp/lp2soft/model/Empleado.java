/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.lp2soft.model;

import java.util.ArrayList;

/**
 *
 * @author Miguel
 */
public class Empleado extends Persona{
    private String cargo;
    private float sueldo;
    private ArrayList<Pedido>pedidos;

    
    
    public Empleado(){   
    }

    public Empleado(String cargo, float sueldo) {
        this.cargo = cargo;
        this.sueldo = sueldo;
    }

    public Empleado(String cargo, float sueldo, int idPersona, String nombreCompleto, String dni) {
        super(idPersona, nombreCompleto, dni);
        this.cargo = cargo;
        this.sueldo = sueldo;
    }

    public Empleado(String cargo, float sueldo, String nombreCompleto, String dni) {
        super(nombreCompleto, dni);
        this.cargo = cargo;
        this.sueldo = sueldo;
    }
    
    

  
    
   


    /**
     * @return the cargo
     */
    public String getCargo() {
        return cargo;
    }

    /**
     * @param cargo the cargo to set
     */
    public void setCargo(String cargo) {
        this.cargo = cargo;
    }

    /**
     * @return the sueldo
     */
    public float getSueldo() {
        return sueldo;
    }

    /**
     * @param sueldo the sueldo to set
     */
    public void setSueldo(float sueldo) {
        this.sueldo = sueldo;
    }

    /**
     * @return the pedidos
     */
    public ArrayList<Pedido> getPedidos() {
        return pedidos;
    }

    /**
     * @param pedidos the pedidos to set
     */
    public void setPedidos(ArrayList<Pedido> pedidos) {
        this.pedidos = pedidos;
    }
    
    public String mostrarDatos(){
        return getIdPersona() + " - " + getNombreCompleto() +
                " - " + cargo + " - " + sueldo + " - " + getDni();
    }
}
