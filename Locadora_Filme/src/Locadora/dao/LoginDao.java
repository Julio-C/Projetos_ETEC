/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Locadora.dao;

import Locadora.modelo.Login;
import Conection.Conexao;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;
import javalocadora.FRM_Login;
import javalocadora.Menu;
import javax.swing.JOptionPane;

/**
 *
 * @author julio
 */
public class LoginDao {

public LoginDao() {

    }
 Conexao con;
       public Login checkLogin (String nome , String senha) throws SQLException
        {
            Login objCadL  = null;
            String SQL = " select * from Login where Usuario = ? and senha = ?";
            try{
                 con = new Conexao();
                 
                  PreparedStatement ps = con.getConexao().prepareStatement(SQL);
                  
                  ps.setString(1,nome);
                  ps.setString(2,senha);
                  ResultSet rs =  ps.executeQuery();
                  if(rs.next())
                  {
                      objCadL = new Login();
                      objCadL.setUsuario(rs.getString("Usuario"));
                      objCadL.setSenha(rs.getString("senha"));
                     
                  }
            }catch(Exception ex){
                JOptionPane.showMessageDialog(null," Erro : " +ex.getMessage());
                
            }
       return objCadL;
        }
}
    

