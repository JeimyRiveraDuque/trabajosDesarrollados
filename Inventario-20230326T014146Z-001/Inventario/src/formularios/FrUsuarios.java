/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package formularios;

import clases.ConexionBD;
import clases.Usuario;
import javax.swing.JButton;
import javax.swing.JOptionPane;

/**
 *
 * @author Usuario
 */
public class FrUsuarios extends javax.swing.JInternalFrame {

    /**
     * Creates new form FrUsuarios
     */
    
    ConexionBD cnx = new ConexionBD();
    
    public FrUsuarios() {
        initComponents();
    }

    /**
     * This method is called from within the constructor to initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is always
     * regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        cbxRol = new javax.swing.JComboBox<>();
        jLabel1 = new javax.swing.JLabel();
        jLabel2 = new javax.swing.JLabel();
        jLabel3 = new javax.swing.JLabel();
        jLabel4 = new javax.swing.JLabel();
        jLabel5 = new javax.swing.JLabel();
        txtIdUsuario = new javax.swing.JTextField();
        txtNombres = new javax.swing.JTextField();
        txtApellidos = new javax.swing.JTextField();
        txtPass = new javax.swing.JPasswordField();
        jLabel6 = new javax.swing.JLabel();
        txtPassw = new javax.swing.JPasswordField();
        btnNuevo = new javax.swing.JButton();
        btnLimpiar = new javax.swing.JButton();
        btnEliminar = new javax.swing.JButton();
        btnModificar = new javax.swing.JButton();
        btnSalir = new javax.swing.JButton();
        btnConsultar = new javax.swing.JButton();

        setTitle("Usuarios");

        cbxRol.setModel(new javax.swing.DefaultComboBoxModel<>(new String[] { "Administrador", "Empleado" }));

        jLabel1.setFont(new java.awt.Font("Tahoma", 1, 12)); // NOI18N
        jLabel1.setText("Rol");

        jLabel2.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel2.setText("Id");

        jLabel3.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel3.setText("Nombres");

        jLabel4.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel4.setText("Apellidos");

        jLabel5.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel5.setText("Contraseña");

        jLabel6.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jLabel6.setText("Confirmar Contraseña");

        btnNuevo.setFont(new java.awt.Font("Arial", 1, 14)); // NOI18N
        btnNuevo.setText("Nuevo");
        btnNuevo.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnNuevoActionPerformed(evt);
            }
        });

        btnLimpiar.setFont(new java.awt.Font("Arial", 1, 14)); // NOI18N
        btnLimpiar.setText("Limpiar");
        btnLimpiar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnLimpiarActionPerformed(evt);
            }
        });

        btnEliminar.setFont(new java.awt.Font("Arial", 1, 14)); // NOI18N
        btnEliminar.setText("Eliminar");
        btnEliminar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnEliminarActionPerformed(evt);
            }
        });

        btnModificar.setFont(new java.awt.Font("Arial", 1, 14)); // NOI18N
        btnModificar.setText("Modificar");
        btnModificar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnModificarActionPerformed(evt);
            }
        });

        btnSalir.setFont(new java.awt.Font("Arial", 1, 14)); // NOI18N
        btnSalir.setText("Salir");

        btnConsultar.setFont(new java.awt.Font("Arial", 1, 14)); // NOI18N
        btnConsultar.setText("Consultar");
        btnConsultar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnConsultarActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING, false)
                    .addGroup(layout.createSequentialGroup()
                        .addGap(42, 42, 42)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING, false)
                            .addGroup(layout.createSequentialGroup()
                                .addComponent(jLabel2, javax.swing.GroupLayout.PREFERRED_SIZE, 27, javax.swing.GroupLayout.PREFERRED_SIZE)
                                .addGap(52, 52, 52)
                                .addComponent(txtIdUsuario, javax.swing.GroupLayout.PREFERRED_SIZE, 185, javax.swing.GroupLayout.PREFERRED_SIZE))
                            .addGroup(javax.swing.GroupLayout.Alignment.LEADING, layout.createSequentialGroup()
                                .addComponent(jLabel5)
                                .addGap(18, 18, 18)
                                .addComponent(txtPass))
                            .addGroup(javax.swing.GroupLayout.Alignment.LEADING, layout.createSequentialGroup()
                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                    .addComponent(jLabel3)
                                    .addComponent(jLabel4))
                                .addGap(18, 18, 18)
                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                    .addGroup(layout.createSequentialGroup()
                                        .addComponent(txtApellidos, javax.swing.GroupLayout.PREFERRED_SIZE, 166, javax.swing.GroupLayout.PREFERRED_SIZE)
                                        .addGap(0, 0, Short.MAX_VALUE))
                                    .addComponent(txtNombres)))))
                    .addGroup(layout.createSequentialGroup()
                        .addGap(24, 24, 24)
                        .addComponent(btnConsultar)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                        .addComponent(btnNuevo)
                        .addGap(27, 27, 27)
                        .addComponent(btnLimpiar)))
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                        .addComponent(jLabel1, javax.swing.GroupLayout.PREFERRED_SIZE, 45, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(18, 18, 18)
                        .addComponent(cbxRol, javax.swing.GroupLayout.PREFERRED_SIZE, 130, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(42, 42, 42))
                    .addGroup(layout.createSequentialGroup()
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                            .addGroup(layout.createSequentialGroup()
                                .addGap(5, 5, 5)
                                .addComponent(jLabel6)
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                                .addComponent(txtPassw, javax.swing.GroupLayout.PREFERRED_SIZE, 183, javax.swing.GroupLayout.PREFERRED_SIZE))
                            .addGroup(javax.swing.GroupLayout.Alignment.LEADING, layout.createSequentialGroup()
                                .addGap(18, 18, 18)
                                .addComponent(btnEliminar)
                                .addGap(18, 18, 18)
                                .addComponent(btnModificar)
                                .addGap(31, 31, 31)
                                .addComponent(btnSalir)))
                        .addContainerGap(31, Short.MAX_VALUE))))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGap(24, 24, 24)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel2)
                    .addComponent(txtIdUsuario, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jLabel1)
                    .addComponent(cbxRol, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(37, 37, 37)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel3)
                    .addComponent(txtNombres, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(39, 39, 39)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel4)
                    .addComponent(txtApellidos, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(31, 31, 31)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel5)
                    .addComponent(txtPass, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jLabel6)
                    .addComponent(txtPassw, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 92, Short.MAX_VALUE)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(btnNuevo)
                    .addComponent(btnLimpiar)
                    .addComponent(btnEliminar)
                    .addComponent(btnModificar)
                    .addComponent(btnSalir)
                    .addComponent(btnConsultar))
                .addGap(55, 55, 55))
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void btnConsultarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnConsultarActionPerformed
            
        String idUsuario = txtIdUsuario.getText();
        
        if(idUsuario.equals(""))
        {
            JOptionPane.showInputDialog(this, "debe de ingresar un id de usuario");
            return;
        }

        
        
        //instanciar los metos get y set del Usuario
        
        Usuario miUsuario = cnx.getUsuario(idUsuario);
        
        //si devuelve nulo
        if(miUsuario == null)
        {
            JOptionPane.showConfirmDialog(this, "no existe usuario");
            return;
        }
        
        //si existe
        
        txtNombres.setText(miUsuario.getNombres());
        txtApellidos.setText(miUsuario.getApellidos());
        txtPass.setText(miUsuario.getClave());
        txtPassw.setText(miUsuario.getClave());

    }//GEN-LAST:event_btnConsultarActionPerformed

    private void btnNuevoActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnNuevoActionPerformed
          String idUsuario = txtIdUsuario.getText();
        
        if(idUsuario.equals(""))
        {
            JOptionPane.showMessageDialog(this, "debe de ingresar un id de usuario");
            txtIdUsuario.requestFocus();
            return;
        }
         Usuario miUsuario = cnx.getUsuario(idUsuario);
        
        //si es distinto de nulo
        if(miUsuario != null)
        {
            JOptionPane.showMessageDialog(this, "Usuario ya existe");
            
            return;
        }
        
        String nombres = txtNombres.getText();
        if(nombres.equals(""))
        {
            JOptionPane.showInputDialog(this, "debe de ingresar nombres");
            txtNombres.requestFocus();
            return;
        }
        
        String apellidos = txtApellidos.getText();
        if(apellidos.equals(""))
        {
            JOptionPane.showInputDialog(this, "debe de ingresar apellidos");
            txtApellidos.requestFocus();
            return;
        }
        //creamos el objeto pass y validamos que no este vacio
        
        String pass = new String(txtPass.getPassword());
        
        if(pass.equals(""))
        {
            JOptionPane.showInputDialog(this, "debe de ingresar clave");
            txtPass.requestFocus();
            return;
        }
        
        String confirPass = new String(txtPass.getPassword());
        
        if(confirPass.equals(""))
        {
            JOptionPane.showInputDialog(this, "debe de ingresar clave");
            txtPassw.requestFocus();
            return;
        }
        
        if(!pass.equals(confirPass))
        {
            JOptionPane.showInputDialog(this, "las contraseñas no son iguales");
            return;
            
        }
        
        int idRol;
        
        if(cbxRol.getSelectedIndex() == 0)
        {
            idRol = 1;
        }
        else
        {
            idRol = 2;
        }
    //enviamos las variables a clase

    miUsuario = new Usuario(idUsuario,
            nombres,
            apellidos,
            pass, 
            idRol);
    
    if(cnx.nuevoUsuario(miUsuario))
    {
        JOptionPane.showConfirmDialog(this, "Usuario Guardado");
    }
    else
        JOptionPane.showInputDialog(this, "no se pudo guardar");
        
    }//GEN-LAST:event_btnNuevoActionPerformed

    private void btnModificarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnModificarActionPerformed
        
        
         String idUsuario = txtIdUsuario.getText();
        
        if(idUsuario.equals(""))
        {
            JOptionPane.showMessageDialog(this, "debe de ingresar un id de usuario");
            txtIdUsuario.requestFocus();
            return;
        }
         Usuario miUsuario = cnx.getUsuario(idUsuario);
        
        //si es distinto de nulo
        if(miUsuario == null)
        {
            JOptionPane.showMessageDialog(this, "No existe Usuario ya existe");
            
            return;
        }
        
        String nombres = txtNombres.getText();
        if(nombres.equals(""))
        {
            JOptionPane.showInputDialog(this, "debe de ingresar nombres");
            txtNombres.requestFocus();
            return;
        }
        
        String apellidos = txtApellidos.getText();
        if(apellidos.equals(""))
        {
            JOptionPane.showInputDialog(this, "debe de ingresar apellidos");
            txtApellidos.requestFocus();
            return;
        }
        //creamos el objeto pass y validamos que no este vacio
        
        String pass = new String(txtPass.getPassword());
        
        if(pass.equals(""))
        {
            JOptionPane.showInputDialog(this, "debe de ingresar clave");
            txtPass.requestFocus();
            return;
        }
        
        String confirPass = new String(txtPass.getPassword());
        
        if(confirPass.equals(""))
        {
            JOptionPane.showInputDialog(this, "debe de ingresar clave");
            txtPassw.requestFocus();
            return;
        }
        
        if(!pass.equals(confirPass))
        {
            JOptionPane.showInputDialog(this, "las contraseñas no son iguales");
            return;
            
        }
        
        int idRol;
        
        if(cbxRol.getSelectedIndex() == 0)
        {
            idRol = 1;
        }
        else
        {
            idRol = 2;
        }
    //enviamos las variables a clase

    miUsuario = new Usuario(idUsuario,
            nombres,
            apellidos,
            pass, 
            idRol);
    
    if(cnx.modificarUsuario(miUsuario))
    {
        JOptionPane.showConfirmDialog(this, "Usuario Guardado");
    }
    else
        JOptionPane.showInputDialog(this, "no se pudo guardar");
        
        
    }//GEN-LAST:event_btnModificarActionPerformed

    private void btnEliminarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnEliminarActionPerformed
          String idUsuario = txtIdUsuario.getText();
        
        if(idUsuario.equals(""))
        {
            JOptionPane.showMessageDialog(this, "debe de ingresar un id de usuario");
            txtIdUsuario.requestFocus();
            return;
        }
         Usuario miUsuario = cnx.getUsuario(idUsuario);
        
        //si es distinto de nulo
        if(miUsuario == null)
        {
            JOptionPane.showMessageDialog(this, "No existe Usuario");
            
            return;
        }
        int confirmacion = JOptionPane.showConfirmDialog(rootPane, "esta seguro que desea eliminar?");
        
        if(confirmacion != 0)
        {
           return;
        }
        if(cnx.borrarUsuario(miUsuario))
        {
             JOptionPane.showMessageDialog(this, "Usuario eliminado correctamente");
            btnLimpiarActionPerformed(evt);
        }
        else
        {
            JOptionPane.showConfirmDialog(this, "no se pudo eliminar usuario");
        }

   
    }//GEN-LAST:event_btnEliminarActionPerformed

    private void btnLimpiarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnLimpiarActionPerformed
        txtIdUsuario.setText("");
        txtNombres.setText("");
        txtApellidos.setText("");
        txtPass.setText("");
        txtPassw.setText("");
    }//GEN-LAST:event_btnLimpiarActionPerformed

    
   
    

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton btnConsultar;
    private javax.swing.JButton btnEliminar;
    private javax.swing.JButton btnLimpiar;
    private javax.swing.JButton btnModificar;
    private javax.swing.JButton btnNuevo;
    private javax.swing.JButton btnSalir;
    private javax.swing.JComboBox<String> cbxRol;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JLabel jLabel3;
    private javax.swing.JLabel jLabel4;
    private javax.swing.JLabel jLabel5;
    private javax.swing.JLabel jLabel6;
    private javax.swing.JTextField txtApellidos;
    private javax.swing.JTextField txtIdUsuario;
    private javax.swing.JTextField txtNombres;
    private javax.swing.JPasswordField txtPass;
    private javax.swing.JPasswordField txtPassw;
    // End of variables declaration//GEN-END:variables
}