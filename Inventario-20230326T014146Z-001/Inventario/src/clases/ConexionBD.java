/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package clases;

import com.mysql.jdbc.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.logging.Level;
import java.util.logging.Logger;



/**
 *
 * @author Usuario
 */
public class ConexionBD {
    
    private Connection con;
    
    public ConexionBD() 
    {
        try {
            //se carga el driver
            Class.forName("com.mysql.jdbc.Driver");
            //creamos objeto con la ruta de la base de datos
            String db = "jdbc:mysql://localhost/inventario";
            //hacemos la conexio a la BD
            con = (Connection) DriverManager.getConnection(db,"root","");
        } catch (SQLException ex) {
            Logger.getLogger(ConexionBD.class.getName()).log(Level.SEVERE, null, ex);
        } catch (ClassNotFoundException ex) {
            Logger.getLogger(ConexionBD.class.getName()).log(Level.SEVERE, null, ex);
        }
    }
    
    public void cerrarConexion()
    {
        try {
            con.close();
        } catch (SQLException ex) {
            Logger.getLogger(ConexionBD.class.getName()).log(Level.SEVERE, null, ex);
        }
    }
    
    //Metodo de validación
    
    public boolean validarUsuario(String usuario, String contrasena)
    {
        String sql = "SELECT 1 FROM usuarios WHERE IDusuario = '"
                + usuario + "' AND clave = '" + contrasena + "'";
        
        try {
            //cremos sentencia
            Statement st = con.createStatement();
            
            //ejecutamos la sentencia
            ResultSet  rs = st.executeQuery(sql);
            
            return rs.next();
            
        } catch (SQLException ex) {
            Logger.getLogger(ConexionBD.class.getName()).log(Level.SEVERE, null, ex);
            return false;
        }
    }
    
    public Usuario getUsuario(String idUsuario)
    {
             String sql = "SELECT * FROM usuarios WHERE IDusuario = '"
                + idUsuario + "'";
        
        try {
            //cremos sentencia
            Statement st = con.createStatement();
            
            //ejecutamos la sentencia
            ResultSet  rs = st.executeQuery(sql);
            
           if(rs.next())
           {
               Usuario miUsuario = new Usuario(rs.getString("IDusuario"),
               rs.getString("nombres"),
               rs.getString("apellidos"),
               rs.getString("clave"),
               rs.getInt("iDRol")
               );
               return miUsuario;
           }
           else
           {
               return null;
           }
            
        } catch (SQLException ex) {
            Logger.getLogger(ConexionBD.class.getName()).log(Level.SEVERE, null, ex);
            return null;
        }
    }
    
    public boolean nuevoUsuario(Usuario miUsuario)
    {
        String sql = "insert into usuarios values('"
                + miUsuario.getIDusuario() + "', '"
                + miUsuario.getNombres() + "', '" 
                + miUsuario.getApellidos() + "', '" 
                + miUsuario.getClave() + "', " 
                + miUsuario.getiDRol() + ")" ;
                
                 try {
            //cremos sentencia
            Statement st = con.createStatement();
            
            //ejecutamos la sentencia
            st.executeUpdate(sql);
            
           return true;
            
        } catch (SQLException ex) {
            Logger.getLogger(ConexionBD.class.getName()).log(Level.SEVERE, null, ex);
            return false;
        }
    }
    
    //modificar usuario
    
    public boolean modificarUsuario(Usuario miUsuario)
    {
       try {
           String sql = "UPDATE usuarios SET "
                   + "nombres = '" + miUsuario.getNombres() + "', "
                   + "apellidos = '" + miUsuario.getApellidos() + "', "
                   + "clave = '" + miUsuario.getClave() + "', "
                   + "iDRol = " + miUsuario.getiDRol() + " "
                   + "WHERE IDusuario = '" + miUsuario.getIDusuario() + "'";
                
                
            //cremos sentencia
            Statement st = con.createStatement();
            
            //ejecutamos la sentencia
            st.executeUpdate(sql);
            
           return true;
            
        } catch (SQLException ex) {
            Logger.getLogger(ConexionBD.class.getName()).log(Level.SEVERE, null, ex);
            return false;
        }
    }
    
    //eliminar usuario
    
    public boolean borrarUsuario(Usuario miUsuario) throws SQLException
    {
      
         String sql = "DELETE FROM usuarios WHERE IDusuario = '" + miUsuario.getIDusuario() +"'";
                
              
            //cremos sentencia
            Statement st = con.createStatement();
            
            //ejecutamos la sentencia
            st.executeUpdate(sql);
            
           return true;
 
    }
    
     
     public boolean ModificarUsuraio (Usuario miUsuario){
         String sql = "UPDATE usuarios SET nombres ='"+ miUsuario.getNombres() +"', apellidos = '"+ miUsuario.getApellidos() +"'"
                + ", clave = '"+ miUsuario.getClave() +"', IDRol ='"+ miUsuario.getiDRol()+"' WHERE IDusuario = '"+ miUsuario.getIDusuario() +"'";
                 try {
            //cremos sentencia
            Statement st = con.createStatement();
            
            //ejecutamos la sentencia
            st.executeUpdate(sql);
            
           return true;
            
        } catch (SQLException ex) {
            Logger.getLogger(ConexionBD.class.getName()).log(Level.SEVERE, null, ex);
            return false;
        }
                
              
     }
}
