package Locadora.dao;

import Conection.Conexao;
import Locadora.modelo.Filme;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import javax.swing.JOptionPane;

public class FilmeDao {
     private Connection conection;

    public FilmeDao(){
        this.conection =  new Conexao().getConexao();
    }
    public void Adiciona(Filme c){
         String SQL = "insert into Filme (Duracao,Titulo,Genero,produtora, preco, Quant) values ( ? , ? , ? , ? , ? , ?);" ;
     
        try {
            PreparedStatement stmt = conection.prepareStatement(SQL);
            stmt.setString(1, c.getDuracao());
            stmt.setString(2, c.getTitulo());
            stmt.setString(3, c.getGenero());
            stmt.setString(4, c.getProdutora());
            stmt.setDouble(5, c.getPreco());
            stmt.setInt(6, c.getQtd());
            
            stmt.execute();
            
            stmt.close();
        } catch (SQLException e) {

            throw new RuntimeException(e);
            
        }
    }
    public void Consulta(String campo, String inf, Filme c) throws SQLException {
        
        try {
            PreparedStatement stmt = this.conection.prepareStatement(
            "select * from Filme where "+ campo +" like '"+ inf + "';");
            ResultSet rs = stmt.executeQuery();
            while(rs.next()){
                c.setDuracao(rs.getString("Duracao"));
                c.setGenero(rs.getString("Genero"));
                c.setId_filme(rs.getInt("id_Filme"));
                c.setPreco(rs.getDouble("preco"));
                c.setProdutora(rs.getString("produtora"));
                c.setQtd(rs.getInt("Quant"));
                c.setTitulo(rs.getString("Titulo"));
            }
            rs.close();
            stmt.close(); 
             
            
        } catch (Exception e) {
            JOptionPane.showMessageDialog(null, "Erro SQL " + e);
            throw new RuntimeException(e);   
                }
    }
    public void remove(Filme c) {
        try {
            PreparedStatement stmt = conection
            .prepareStatement("delete from Filme where id_Filme=?;");
            stmt.setInt(1, c.getId_filme());
            stmt.execute();
            stmt.close();

        } catch (SQLException e) {
            JOptionPane.showMessageDialog(null, "Erro SQL " + e);
            throw new RuntimeException(e);
        }
    }
    public void Alterar(Filme c) {

        String sql = "update Filme set Duracao = ?,Titulo = ?,Genero = ?,produtora=?, Quant = ?, preco = ?;" ;
        try {
            PreparedStatement stmt = conection.prepareStatement(sql);
            stmt.setString(1, c.getDuracao());
            stmt.setString(2, c.getTitulo());
            stmt.setString(3, c.getGenero());
            stmt.setString(4, c.getProdutora());
            stmt.setInt(5, c.getQtd());
            stmt.setDouble(6, c.getPreco());
            
            
            stmt.execute();
            stmt.close();
        } catch (SQLException e) {
            JOptionPane.showMessageDialog(null, "Erro SQL " + e);
            throw new RuntimeException(e);
        }
      }
}
