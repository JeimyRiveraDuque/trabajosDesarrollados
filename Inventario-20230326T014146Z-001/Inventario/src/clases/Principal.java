/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package clases;

import formularios.Login;

/**
 *
 * @author Usuario
 */
public class Principal {
    public static void main(String[] args) {
        
    //creamos la instancia    
    Login miLogin = new Login();
    //centramos el objeto
    miLogin.setLocationRelativeTo(null);
    //mostramos el objeto
    miLogin.setVisible(true);
  }
}
