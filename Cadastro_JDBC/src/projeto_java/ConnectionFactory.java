/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package projeto_java;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;

/**
 *
 * @author lab
 */
public class ConnectionFactory {
    public Connection getConnection(){
        System.out.println("Conectando ao Banco de Dados");
        try{
            return 
             DriverManager.getConnection("jdbc:mysql://localhost/projeto_java",
                                             "teste","123");
        }catch(SQLException e){
            throw new RuntimeException(e);
        }
    }
    public static void main (String[]args){
        new ConnectionFactory().getConnection();
        System.out.println("Conexão criada com sucesso");
    }
}
