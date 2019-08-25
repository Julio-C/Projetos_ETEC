package Locadora.dao;

import Conection.Conexao;
import Locadora.modelo.Locacao;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;
import javax.swing.JOptionPane;

public class LocacaoDao {
     private Connection conection;

    public LocacaoDao(){
        this.conection =  new Conexao().getConexao();
    }
   public void Consulta(String campo, String inf, Locacao l) throws SQLException {
        
        try {
            PreparedStatement stmt = this.conection.prepareStatement(
            "select * from Locacao where "+ campo +" like '"+ inf + "';");
            ResultSet rs = stmt.executeQuery();
            while(rs.next()){
                
                l.setData_dev(rs.getString("Data_Devolucao"));
                l.setValor(rs.getDouble("valor"));
                
            }
            rs.close();
            stmt.close(); 
             
            
        } catch (Exception e) {
            JOptionPane.showMessageDialog(null, "Erro SQL " + e);
            throw new RuntimeException(e);   
                }
   }
    public void Adiciona(Locacao l){
        String SQL = "insert into Locacao (Data_locacao, Data_Devolucao,id_filme1_pk,id_filme2_pk,id_filme3_pk,id_filme4_pk,id_cliente_pk,valor,statuss)"
                      + " values ( ? , ? , ? , ? , ? , ? , ? , ? , ?);" ;
     
        try {
            PreparedStatement stmt = conection.prepareStatement(SQL);
            stmt.setString(1,l.getData_loc());
            stmt.setString(2,l.getData_dev());
            stmt.setInt(3,l.getId_filme1_pk());
            stmt.setInt(4,l.getId_filme2_pk());
            stmt.setInt(5,l.getId_filme3_pk());
            stmt.setInt(6,l.getId_filme4_pk());
            stmt.setInt(7,l.getId_cliente_pk());
            stmt.setDouble(8,l.getValor());
            stmt.setString(9,l.getStatus());
            
            
            stmt.execute();
            
            stmt.close();
        } catch (SQLException e) {

            throw new RuntimeException(e);
            
        }
    }
    
     public List<Locacao> getLista(String campo, String inf) {
        try {
            List<Locacao> locacao = new ArrayList<Locacao>();
            PreparedStatement stmt = this.conection.prepareStatement(
"       select * from Locacao" +
"	inner join Filme on filme.id_filme = Locacao.id_filme1_pk or Locacao.id_filme2_pk"+
"       or Locacao.id_filme3_pk or Locacao.id_filme4_pk\n" +
"       inner join Cliente on Cliente.id_cliente = Locacao.id_cliente_pk" +
"       where " + campo + " like '%" + inf + "%'");
            
            ResultSet rs = stmt.executeQuery();
            while (rs.next()) {
                Locacao l = new Locacao();
                
                l.setData_dev(rs.getString("Data_Devolucao"));
                l.setData_loc(rs.getString("Data_locacao"));
                l.setTitulo(rs.getString("Filme.Titulo"));
                l.setNome(rs.getString("Cliente.nome"));
                l.setCpf(rs.getString("Cliente.cpf"));
                l.setStatus(rs.getString("statuss"));
                l.setId_loc(rs.getInt("id_loc"));
                locacao.add(l);
            }
            rs.close();
            stmt.close();
            return locacao;
        } catch (SQLException e) {
            JOptionPane.showMessageDialog(null, "Erro SQL " + e);
            throw new RuntimeException(e);
        }
    }
         public void Alterar(Locacao c) {

        String sql = "update Locacao set statuss = ? where id_loc=?;" ;
        try {
            PreparedStatement stmt = conection.prepareStatement(sql);
            stmt.setString(1, c.getStatus());
            stmt.setInt(2, c.getId_loc());
            
            
            stmt.execute();
            stmt.close();
        } catch (SQLException e) {
            JOptionPane.showMessageDialog(null, "Erro SQL " + e);
            throw new RuntimeException(e);
        }
      }
}
