/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.lp2soft.mysql;

import java.util.ArrayList;
import pe.edu.pucp.lp2soft.dao.EmpleadoDAO;
import pe.edu.pucp.lp2soft.model.Empleado;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.Statement;
import java.sql.ResultSet;
import pe.edu.pucp.lp2soft.config.DBManager;
import java.sql.CallableStatement;
import static pe.edu.pucp.lp2soft.config.DBManager.url;
/**
 *
 * @author Miguel
 */
public class EmpleadoMySQL implements EmpleadoDAO{

    @Override
    public int insertar(Empleado empleado) {
        int rpta = 0;
        try{
            //REGISTRAR EL JAR DE LA CONEXION
            Class.forName("com.mysql.cj.jdbc.Driver");
            //ESTABLECER CONEXION A BASE DE DATOS
            Connection con = DriverManager.
                    getConnection(DBManager.url,DBManager.usuario,
                            DBManager.password);
            
            //EJECUTAR SENTENCIA
            String sentencia = "{call insertar_empleado(?,?,?,?,?)}";
            CallableStatement cs = con.prepareCall(sentencia);
            cs.registerOutParameter(1, java.sql.Types.INTEGER);
            cs.setString(2,empleado.getNombreCompleto());
            cs.setString(3,empleado.getCargo());
            cs.setFloat(4,empleado.getSueldo());
            cs.setString(5,empleado.getDni());
            //ExcecuteQuery-> PARA SELET
            //ExecuteUpdate-> PARA INSERT;DELETE;UPDATE
            cs.executeUpdate();
            rpta = cs.getInt("_id_empleado");
            //CERRAMOS CONEXCION
            con.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return rpta;
    }

    @Override
    public int actualizar(Empleado empleado) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public int borrar(int idEmpleado) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public ArrayList<Empleado> listar() {
        ArrayList<Empleado> empleados = new ArrayList<Empleado>();
        try{
            //REGISTRAR EL JAR DE LA CONEXION
            Class.forName("com.mysql.cj.jdbc.Driver");
            //ESTABLECER CONEXION A BASE DE DATOS
            Connection con = DriverManager.
                    getConnection(DBManager.url,DBManager.usuario,
                            DBManager.password);
            
            //EJECUTAR SENTENCIA
            String sentencia = "Select * from PERSONA INNER JOIN EMPLEADO"
                    + " ON PERSONA.ID_PERSONA = EMPLEADO.ID_EMPLEADO";
            Statement st = con.createStatement();
            //ExcecuteQuery-> PARA SELET
            //ExecuteUpdate-> PARA INSERT;DELETE;UPDATE
            ResultSet rs =st.executeQuery(sentencia);
            while(rs.next()) {
                Empleado empleado = new Empleado();
               empleado.setIdPersona(rs.getInt("ID_EMPLEADO"));
               empleado.setNombreCompleto(rs.getString("NOMBRE_COMPLETO"));
               empleado.setSueldo(rs.getFloat("SUELDO"));
               empleado.setCargo(rs.getString("CARGO"));
               empleado.setDni(rs.getString("DNI"));
               empleados.add(empleado);
            }
            //CERRAMOS CONEXCION
            con.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return empleados;
    }
    
}
