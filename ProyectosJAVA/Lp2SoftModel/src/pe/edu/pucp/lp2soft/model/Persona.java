/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.lp2soft.model;

/**
 *
 * @author Miguel
 */
public class Persona {
    private int idPersona;
    private String nombreCompleto;
    private String dni;

    public Persona(){
        
    }
    
    public Persona(int idPersona, String nombreCompleto, String dni) {
        this.idPersona = idPersona;
        this.nombreCompleto = nombreCompleto;
        this.dni = dni;
    }

    public Persona(String nombreCompleto, String dni) {
        this.nombreCompleto = nombreCompleto;
        this.dni = dni;
    }
    
    
    
    
    public int getIdPersona() {
        return idPersona;
    }

    public void setIdPersona(int idPersona) {
        this.idPersona = idPersona;
    }

    public String getNombreCompleto() {
        return nombreCompleto;
    }

    public void setNombreCompleto(String nombreCompleto) {
        this.nombreCompleto = nombreCompleto;
    }

    public String getDni() {
        return dni;
    }

    public void setDni(String dni) {
        this.dni = dni;
    }
    
    
}
