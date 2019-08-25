/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package projeto_java.dao;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;
import projeto_java.ConnectionFactory;
import projeto_java.modelo.Cliente;
/**
 *
 * @author lab
 */
public class ClienteDAO {
    private Connection connection;
    
    public ClienteDAO(){
        this.connection = new ConnectionFactory().getConnection();
    }
    //Adiciona Cliente
    public void adiciona(Cliente cliente){
        String sql = "insert into cliente"
                     +"(nome,telefone,endereco,email,idade,salario)"
                     +"values(?,?,?,?,?,?)";
        try {
            //Prepared Statement para inserção.
            PreparedStatement stmt = connection.prepareStatement(sql);
            stmt.setString(1, cliente.getNome());
            stmt.setString(2, cliente.getTelefone());
            stmt.setString(3, cliente.getEndereco());
            stmt.setString(4, cliente.getEmail());
            stmt.setInt(5, cliente.getIdade());
            stmt.setDouble(6, cliente.getSalario());
            //Executar
            stmt.execute();
            stmt.close();
            
        } catch (SQLException e) {
            throw new RuntimeException();
        }
    }
}
