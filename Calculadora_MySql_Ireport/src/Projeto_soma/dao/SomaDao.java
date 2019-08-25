package Projeto_soma.dao;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;
import Projeto_soma.ConnectionFactory;
import Projeto_soma.modelo.Soma;
import java.io.File;
import java.util.HashMap;
import javax.swing.JOptionPane;
import net.sf.jasperreports.engine.JRResultSetDataSource;
import net.sf.jasperreports.engine.JasperCompileManager;
import net.sf.jasperreports.engine.JasperExportManager;
import net.sf.jasperreports.engine.JasperFillManager;
import net.sf.jasperreports.engine.JasperPrint;
import net.sf.jasperreports.engine.JasperReport;
import net.sf.jasperreports.view.JasperViewer;




public class SomaDao {
        private Connection connection;
    
    public SomaDao(){
        this.connection = new ConnectionFactory().getConnection();
    }
    
 
    public void Adicionar( Soma soma){
        
            
                   String sql = "insert into Soma"
                           +"( valor1 , valor2 , total)"
                           + "values (?,?,?)";
          
               
                try {
            PreparedStatement stmt = this.connection.prepareStatement(sql);
            stmt.setDouble(1, soma.getValor1());
             stmt.setDouble(2, soma.getValor2());
             stmt.setDouble(3, soma.getTotal());
                
             stmt.execute();
             stmt.close();
        } catch (Exception e) {
            throw new RuntimeException(e);
    }
                
}
    
    public List<Soma> getLista (String campo, String inf){
        try {
            List <Soma> soma = new ArrayList<Soma>();
            PreparedStatement stmt = this.connection.prepareStatement
        ("select * from Soma where "+campo+" like '%"+inf+"%'");
        ResultSet rs = stmt.executeQuery();
        
        while (rs.next()){
            
            Soma s = new Soma();
            s.setCod_soma((rs.getInt("cod_soma")));
            s.setValor1(rs.getDouble("valor1"));
            s.setValor2(rs.getDouble("valor2"));
            s.setTotal(rs.getDouble("total"));
            soma.add(s);
        }
        rs.close();
        stmt.close();
        return soma;
        
        } catch (Exception e) {
        throw new RuntimeException(e);        
        
        }  
    }
//Pesquisar
    public void pesquisar(String campo,String inf,Soma c){
        try {
            PreparedStatement stmt = this.connection.prepareStatement
                    ("select * from Soma where " +campo+ " like '%" +inf+ "%'");
            ResultSet rs= stmt.executeQuery();
            while (rs.next()){
                //criando o objeto Soma
                    //Soma c = new Soma();
                
                c.setCod_soma(rs.getInt("cod_soma"));
                c.setValor1((rs.getDouble("valor1")));
                c.setValor2(rs.getDouble("valor2"));
                c.setTotal(rs.getDouble("total"));
           
                
            }
            rs.close();
            stmt.close();
        } catch(SQLException e){
            throw new RuntimeException(e);
        }
    }    
    
    public void remover ( Soma c) {
        try {
            PreparedStatement stmt = connection.prepareStatement("delete from Soma where cod_soma=?") ;
            
            stmt.setInt(1,c.getCod_soma());
            stmt.execute();
            stmt.close();
        } catch (Exception e) {
        throw new RuntimeException(e);
        }
    }
    
    //relatorios
    public void Rel() {
        
        try {
  JasperReport report = JasperCompileManager.compileReport("src/Projeto_soma/Relatorios/Relsoma.jrxml");
  JasperPrint print = JasperFillManager.fillReport(report, null, connection);
  JasperExportManager.exportReportToPdfFile(print,"src/Projeto_soma/Relatorios/Relsoma.pdf");
            System.out.println("Relatório gerado com Sucesso");
        } catch (Exception e) {
        throw new RuntimeException(e);
        }
    }
    public void GerarRel (){
        try {
            String sql = "select * from Soma";
            try (PreparedStatement smtp = connection.prepareStatement(sql)) {
                ResultSet rs = smtp.executeQuery();
                JRResultSetDataSource jrRs = new JRResultSetDataSource(rs);
                JasperPrint print = JasperFillManager.fillReport
        ("src/Projeto_soma/Relatorios/RelSom.jasper",new HashMap(),jrRs);
                JasperViewer jv = new JasperViewer(print,false);
                jv.setVisible(true);
                jv.toFront();
                smtp.close();
            }
        } catch (SQLException e) {
            JOptionPane.showMessageDialog(null,"Erro SQL "+e);
        
        }
        }
    
            
    public void ChamaRel (){
        
        try {
            java.awt.Desktop.getDesktop().open(new File("src/Projeto_soma/Relatorios/Relsoma.pdf"));
        } catch (Exception e) {
            
        }
    }
    
  public void altera(Soma c){
        String sql = "update Soma set valor1=?, valor2=?, total=? where cod_soma=?";
        try{
            PreparedStatement stmt = connection.prepareStatement(sql);
          
            stmt.setDouble(1, c.getValor1());
            stmt.setDouble(2, c.getValor2());
            stmt.setDouble(3, c.getTotal());
            stmt.setInt(4, c.getCod_soma());
        
            stmt.execute();
            stmt.close();
        } catch (SQLException e){
            throw  new RuntimeException(e);
        }
    }

}
