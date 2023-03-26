/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package clases;

/**
 *
 * @author Usuario
 */
public class Usuario {

    public String getIDusuario() {
        return IDusuario;
    }

    public void setIDusuario(String IDusuario) {
        this.IDusuario = IDusuario;
    }

    public String getNombres() {
        return nombres;
    }

    public void setNombres(String nombres) {
        this.nombres = nombres;
    }

    public String getApellidos() {
        return apellidos;
    }

    public void setApellidos(String apellidos) {
        this.apellidos = apellidos;
    }

    public String getClave() {
        return clave;
    }

    public void setClave(String clave) {
        this.clave = clave;
    }

    public int getiDRol() {
        return iDRol;
    }

    //definimos variables publicas de clase
    public void setiDRol(int iDRol) {
        this.iDRol = iDRol;
    }

    public Usuario(String IDusuario, String nombres, String apellidos, String clave, int iDRol) {
        this.IDusuario = IDusuario;
        this.nombres = nombres;
        this.apellidos = apellidos;
        this.clave = clave;
        this.iDRol = iDRol;
    }
    private String IDusuario;
    private String nombres;
    private String apellidos;
    private String clave;
    int iDRol;
    
    //se crean los get y los set
}
